using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace User_Managment.ViewModels
{
    public class AddUserViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        [StringLength(100, ErrorMessage = "The {0} must be al least{1} and at max{2} between "), MinLength(3)]
        public string UserName { get; set; }

        [Required]
        [Display(Name ="Fitrst Name")]
        [StringLength( 100,ErrorMessage ="The {0} must be al least{1} and at max{2} between "),MinLength(3)]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [StringLength(100, ErrorMessage = "The {0} must be al least{1} and at max{2} between "), MinLength(3)]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Email")]
        [StringLength(100, ErrorMessage = "The {0} must be al least{1} and at max{2} between "), MinLength(3)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Password")]
        [StringLength(100, ErrorMessage = "The {0} must be al least{1} and at max{2} between "), MinLength(3)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "The Pasword and confirm must be match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public List<RoleViewModel> Roles { get; set; }

    }
}
