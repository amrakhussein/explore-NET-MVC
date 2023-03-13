using System.ComponentModel.DataAnnotations;

namespace SimpleSchoolSystem.ViewModel.AccountViewModels;

public class RoleViewModel
{
    [Required, StringLength(256)]
    public string Name { get; set; } = null!;
}


