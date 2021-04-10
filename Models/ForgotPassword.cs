using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Step_8_PawTracks.Models
{
    public class ForgotPassword
    {
        [Required(ErrorMessage = "Name Is Required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email Is Required")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
