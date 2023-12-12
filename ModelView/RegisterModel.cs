﻿using System.ComponentModel.DataAnnotations;

namespace TestApiJWT.Models
{
    public class RegisterModel
    {
        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, StringLength(100),Phone]
        public string PhoneNumber  { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; }

        [Required, StringLength(128)]
        public string Email { get; set; }

        [Required, StringLength(256)]
        public string Password { get; set; }
    }
}