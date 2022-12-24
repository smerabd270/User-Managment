using System.ComponentModel.DataAnnotations;

namespace User_Managment.ViewModels
{
    public class ProfileFormViewModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        [Display(Name = "User Name")]
        [StringLength(100, ErrorMessage = "The {0} must be al least{1} and at max{2} between "), MinLength(3)]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Fitrst Name")]
        [StringLength(100, ErrorMessage = "The {0} must be al least{1} and at max{2} between "), MinLength(3)]
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
    }
}
