﻿using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class CreatePersonViewModel
    {
        [Required]
        [Display(Name = "First Name")]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [StringLength(25)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(25)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Range(1, 120)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Confirm Email")]
        [Compare("Email")]
        public string ConfirmEmail { get; set; }

        [Url]
        [MinLength(7)]
        public string Website { get; set; }

        public string School { get; set; }
    }
}
