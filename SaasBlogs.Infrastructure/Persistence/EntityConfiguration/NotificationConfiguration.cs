using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SaasBlogs.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Infrastructure.Persistence.EntityConfiguration
{
    internal class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasKey(n => n.Id);

            builder.Property(n => n.NotificationContent)
                .IsRequired();

            builder.Property(n => n.CreatedDate)
                .IsRequired();

            builder.Property(n => n.ModifiedDate)
                .IsRequired(false);

            builder.HasOne(n => n.User)
                .WithMany(u => u.Notifications)
                .HasForeignKey(n => n.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(n => n.Blog)
                .WithMany(b => b.Notifications)
                .HasForeignKey(n => n.BlogId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
