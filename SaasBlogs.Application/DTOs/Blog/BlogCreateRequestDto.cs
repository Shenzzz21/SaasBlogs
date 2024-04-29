using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Application.DTOs.Blog
{
    public class BlogCreateRequestDto
    {
        [Required(ErrorMessage = "Blog title is required")]
        public string BlogTitle { get; set; }

        [Required(ErrorMessage = "Blog content is required")]
        public string BlogContent { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? BlogImageUrl { get; set; }

        public string? UserId { get; set; }
    }
}
