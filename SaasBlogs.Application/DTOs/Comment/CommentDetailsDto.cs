using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Application.DTOs.Comment
{
    public class CommentDetailsDto
    {
        public string? CommentBody { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string UserName { get; set; }
    }
}
