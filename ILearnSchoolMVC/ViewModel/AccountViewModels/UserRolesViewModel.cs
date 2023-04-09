namespace ILearnSchoolMVC.ViewModel.AccountViewModels;

public class UserWithRolesViewModel
{
    public string UserId { get; set; } = null!;
    public string Username { get; set; } = null!;

    public List<RolesAssignedToUsersViewModel> UserRoles { get; set; } = null!;
}


