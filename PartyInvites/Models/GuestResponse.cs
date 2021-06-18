using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault.Models;

namespace PartyInvites.Models
{ 

    public class GuestResponse
    {
        [Required(ErrorMessage = "Enter your Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter your Email")]
        [RegularExpression(".+\\@.+\\..+.", ErrorMessage = "Please enter validate your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter your Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "You will attend party")]
        public bool ? WillAttend { get; set; }
    }
}
