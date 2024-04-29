using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Application.DTOs.Blog
{
    public class BlogUpdateRequestDto
    {
        public string BlogTitle { get; set; }

        public string BlogContent { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
