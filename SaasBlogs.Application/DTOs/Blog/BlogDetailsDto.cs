using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Application.DTOs.Blog
{
    public class BlogDetailsDto
    {
        public string Id { get; set; }
        public string BlogTitle { get; set; }

        public string BlogContent { get; set; }

        public string? BlogImageUrl { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string AuthorName { get; set; }

        public string UserId { get; set; }

        public virtual ICollection<CommentDetailsDto> Comments { get; set; }

        public virtual ICollection<VoteDetailsDto> Votes { get; set; }
    }
}
