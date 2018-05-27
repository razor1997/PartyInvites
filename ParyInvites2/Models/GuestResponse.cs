using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ParyInvites2.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Proszę podać swoje imię i nazwisko.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę podać adres e-mail.")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage ="Proszę podać prawidłowy e-mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Proszę podać numer telefonu.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Proszę określić się czy weźmiesz udział.")]
        public bool? WillAttend { get; set; }
    }
}