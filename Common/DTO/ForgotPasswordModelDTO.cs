﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTO
{
    public class ForgotPasswordModelDTO
    {
        public string OTP { get; set; } = string.Empty;
        
        public string Password { get; set; } = string.Empty;

        public string ConfirmPassword { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
    }
}

