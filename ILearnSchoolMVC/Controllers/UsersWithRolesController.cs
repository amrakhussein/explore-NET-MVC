using ILearnSchoolMVC.Constants;
using ILearnSchoolMVC.Models;
using ILearnSchoolMVC.ViewModel.AccountViewModels;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ILearnSchoolMVC.Controllers;

[Authorize(Roles = RoleConstants.Admin)]
public class UsersWithRolesController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public UsersWithRolesController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task<IActionResult> Index()
    {
        var users = await _userManager.Users.ToListAsync();
        var userViewModels = new List<UserViewModel>();

        foreach (var user in users)
        {
            var roles = await _userManager.GetRolesAsync(user);
            var userViewModel = new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Username = user.UserName,
                Roles = roles
            };
            userViewModels.Add(userViewModel);
        }

        return View(userViewModels);
    }



    // has a list of roles
    public IActionResult RolesManager()
    {
        var roles = _roleManager.Roles.ToListAsync();

        return View(roles);
    }

    public async Task<IActionResult> ManageRoles(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user is null) return NotFound();


        var roles = await _roleManager.Roles.ToListAsync();

        var viewModel = new UserWithRolesViewModel
        {
            UserId = user.Id,
            Username = user.UserName,
            UserRoles = roles.Select(role => new RolesAssignedToUsersViewModel
            {
                Name = role.Name,
                HasAssigned = _userManager.IsInRoleAsync(user, role.Name).Result

            }).ToList(),
        };

        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> ManageRoles(UserWithRolesViewModel model)
    {
        var user = await _userManager.FindByIdAsync(model.UserId);
        if (user is null) return NotFound();


        var userRoles = await _userManager.GetRolesAsync(user);

        // loop all roles in the database
        foreach (var role in model.UserRoles)
        {
            if (userRoles.Any(r => r == role.Name) && !role.HasAssigned)
                await _userManager.RemoveFromRoleAsync(user, role.Name);

            //if (userRoles.Any(r => r == role.Name) && role.HasAssigned)
            //    await _userManager.AddToRoleAsync(user, role.Name);

            if (userRoles.All(r => r != role.Name) && role.HasAssigned)
                await _userManager.AddToRoleAsync(user, role.Name);
        }

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Add(RoleViewModel model)
    {
        var roles = await _roleManager.Roles.ToListAsync();
        if (!ModelState.IsValid)
        {
            return View("Index", roles);
        }

        var roleIsExist = await _roleManager.RoleExistsAsync(model.Name);

        if (roleIsExist)
        {
            ModelState.AddModelError("Name", "Role Exists");
            return View("Index", roles);
        }

        await _roleManager.CreateAsync(new IdentityRole { Name = model.Name.Trim() });

        return RedirectToAction(nameof(Index));
    }
}
