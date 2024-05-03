using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Application.DTOs.Response
{
    public class ResponseWithJwtDto
    {
        public string? Status { get; set; }

        public string? Message { get; set; }

        public string? JWTToken { get; set; }

        public IList<string>? Roles { get; set; } = new List<string>();
    }
}
