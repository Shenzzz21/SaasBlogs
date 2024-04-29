using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Application.DTOs.Comment
{
    public class CommentUpdateRequestDto
    {
        public string? CommentBody { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
