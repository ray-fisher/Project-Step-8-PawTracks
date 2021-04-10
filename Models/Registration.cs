using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Project_Step_8_PawTracks.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Name Is Required")]
        public string Username { get; set; } // Property

        [Required(ErrorMessage = "Email Is Required")]
        [EmailAddress]
        public string Email { get; set; } // Property

        [Required(ErrorMessage = "Password Is Required")]
        public string Password { get; set; } // Property
    }
}
