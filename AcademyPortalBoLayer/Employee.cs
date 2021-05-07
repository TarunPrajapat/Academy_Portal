using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPortalBoLayer
{
        public class Employee
        {
            [Required(ErrorMessage = "Please Enter First Name")]
            public string First_name { get; set; }

            [Required(ErrorMessage = "Please Enter Last Name")]
            public string Last_name { get; set; }

            [Required]
            [Display(Name = "Date of Birth")]
            [DataType(DataType.Date)]
            public DateTime DOB { get; set; }

            [Required]

            public Gender gender { get; set; }

            [Required(ErrorMessage = "Contact should not be more or less than 10 digit")]
            [Display(Name = "Contact Number")]
            [DataType(DataType.PhoneNumber)]
            public long Contact { get; set; }

            [Required(ErrorMessage = "Please Enter Email Address")]
            [Display(Name = "Email")]
            [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }

            [Required(ErrorMessage = "Please Enter User Id")]
            [Key]
            public int UserId { get; set; }


            [Required(ErrorMessage = "Please Enter Password")]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Required]
            public UserCategory userCategory { get; set; }

            [Required]
           public bool IsDeleted { get; set; }

           [Required]
           public DateTime CreatedDate { get; set; }

           [Required]
           public DateTime? ModifiedDate { get; set; }

            [Required]
            public string RegistrationStatus { get; set; }
        }
}
