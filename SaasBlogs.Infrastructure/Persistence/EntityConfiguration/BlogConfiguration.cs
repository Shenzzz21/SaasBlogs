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
    internal class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.BlogTitle)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(b => b.BlogContent)
                .IsRequired();

            builder.Property(b => b.BlogImageUrl)
                .HasMaxLength(255);

            builder.Property(b => b.CreatedDate).IsRequired();

            builder.Property(b => b.ModifiedDate).IsRequired(false);

            builder.HasOne(b => b.User)
                .WithMany(u => u.Blogs)
                .HasForeignKey(b => b.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(b => b.Comments)
                .WithOne(c => c.Blog)
                .HasForeignKey(c => c.BlogId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(b => b.Notifications)
                .WithOne(n => n.Blog)
                .HasForeignKey(n => n.BlogId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
