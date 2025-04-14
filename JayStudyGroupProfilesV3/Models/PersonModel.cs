using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JayStudyGroupProfilesV3.Models
{
    public class PersonModel
    { 
 
        [Display(Name = "Student Number")]
        [Required(ErrorMessage = "Student Number is required")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "Student Number must be 8 digits")]
        public string stuNum { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, ErrorMessage = "First Name cannot be longer than 50 characters")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "First Name must only contain letters")]
        public string fName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Surname is required")]
        [RegularExpression(@"^[A-Za-z]+$", ErrorMessage = "First Name must only contain letters")]
        [StringLength(50, ErrorMessage = "Surname cannot be longer than 50 characters")]
        public string lName { get; set; }

        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email format")]
        public string email { get; set; }

        [Display(Name = "Delete")]
        public string delete { get; set; }
    }
}