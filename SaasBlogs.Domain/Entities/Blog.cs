using SaasBlogs.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Domain.Entities
{
    public class Blog : BaseAuditableEntity
    {
        public string BlogTitle { get; set; }

        public string BlogContent { get; set; }

        public string? BlogImageUrl { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Vote> Votes { get; set; }

        public virtual ICollection<Notification> Notifications { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
