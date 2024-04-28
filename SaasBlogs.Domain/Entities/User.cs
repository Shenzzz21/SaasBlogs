using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public bool IsAdmin { get; set; }

        // Navigation properties
        public virtual ICollection<Blog>? Blogs { get; set; }

        public virtual ICollection<Comment>? Comments { get; set; }

        public virtual ICollection<Vote>? Votes { get; set; }

        public virtual ICollection<Notification>? Notifications { get; set; }
    }
}
