using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPortalBoLayer
{
    public enum Gender { Male, Female };
    public enum SkillFamily { Technical, NonTechnical };
    public enum ProficiencyType { Beginner, Intermediate, Advance };
    public enum UserCategory { Admin, Faculty, Employee };
    public class Faculty
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please Enter First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Date of Birth")]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public DateTime Dob { get; set; }

        [Required]
        public Gender gender { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Contact Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public long Contact { get; set; }

        [Required(ErrorMessage = "Please Enter Email Address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Security Question")]
        public string SecurityQuestion { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "User Category")]
        public UserCategory UserCatagory { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Skill Family")]
        public SkillFamily skillFamily { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Module Name")]
        public string ModuleName { get; set; }

        [Required(ErrorMessage = "*")]
        public ProficiencyType Proficiency { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Teaching Hours")]
        public int TeachingHours { get; set; }
        [Required]
        public bool IsDeleted { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        [Required]
        public string RegistrationStatus { get; set; }
    }
}
