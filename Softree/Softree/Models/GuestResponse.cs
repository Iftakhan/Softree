using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Softree.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Please enter enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage ="please enter your mail")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage ="Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please enter phone number")]
        public string  Phone { get; set; }
        [Required(ErrorMessage ="Please specify whether you wil attend or not")]
        public bool?WillAttend { get; set; }
        

    }
}