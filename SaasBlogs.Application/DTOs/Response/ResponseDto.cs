﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Application.DTOs.Response
{
    public class ResponseDto
    {
        public string? Status { get; set; }

        public string? Message { get; set; }
    }

    public class ErrorMessageResponse
    {
        public string? Message { get; set; }

        public string? ContentType { get; set; }

        public int StatusCode { get; set; }
    }
}
