﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Application.DTOs.User
{
    public class UserUpdateRequestDto
    {
        public string? UserName { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}
