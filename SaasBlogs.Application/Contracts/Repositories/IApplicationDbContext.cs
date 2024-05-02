using Microsoft.EntityFrameworkCore;
using SaasBlogs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Application.Contracts.Repositories
{
    public interface IApplicationDbContext
    {
        DbSet<Blog> Blogs { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Notification> Notifications { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Vote> Votes { get; set; }
    }
}
