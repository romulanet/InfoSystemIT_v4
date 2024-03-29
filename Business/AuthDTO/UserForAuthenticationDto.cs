﻿using System.ComponentModel.DataAnnotations;

namespace Business.AuthDTO
{
    public class UserForAuthenticationDto
    {
        [Required(ErrorMessage = "First Name is required.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string? Password { get; set; }
    }
}
