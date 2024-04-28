using SaasBlogs.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Domain.Entities
{
    public class Vote : BaseAuditableEntity
    {
        public bool IsUpvote { get; set; }

        public string BlogId { get; set; }
        public virtual Blog Blog { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
