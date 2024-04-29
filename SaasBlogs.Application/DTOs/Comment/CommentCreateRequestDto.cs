using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Application.DTOs.Comment
{
    public class CommentCreateRequestDto
    {
        public string? CommentBody { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string BlogId { get; set; }

        public string UserId { get; set; }
    }
}
