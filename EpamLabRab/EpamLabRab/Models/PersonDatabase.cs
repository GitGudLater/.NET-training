using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EpamLabRab.Models
{
    public class PersonDatabase
    {
        [Required]
        public string Name { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+.[A-Za-z]", ErrorMessage = "Falce email")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Long must be more than 6 symbols and less than 20")]
        //[RegularExpression(@"[A-Za-z0-9]", ErrorMessage = "Uncorrect password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Different passwords")]
        [DataType(DataType.Password)]
        public string ReEnterPassword { get; set; }

        [Required]
        [Range(18, 99, ErrorMessage = "Uncorrect age")]
        public int Age { get; set; }

        [Required]
        //[RegularExpression(@"[+]+(+[0-9]+[0-9]+[0-9]+)+-[0-9]+[0-9]+-[0-9]+[0-9]+[0-9]+-[0-9]+[0-9]+-[0-9]+[0-9]", ErrorMessage = "Number must be +(nnn)-nn-nnn-nn-nn")]
        public string Phone { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 20, ErrorMessage = "Short adress")]
        public string Adress { get; set; }

        public int ID { get; set; }
    }
}