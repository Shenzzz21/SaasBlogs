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
    internal class VoteConfiguration : IEntityTypeConfiguration<Vote>
    {
        public void Configure(EntityTypeBuilder<Vote> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.IsUpvote).IsRequired();

            builder.Property(v => v.CreatedDate)
                .IsRequired();

            builder.Property(v => v.ModifiedDate)
                .IsRequired(false);

            builder.HasOne(v => v.User)
           .WithMany(u => u.Votes)
           .HasForeignKey(v => v.UserId)
           .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(v => v.Blog)
            .WithMany(b => b.Votes)
            .HasForeignKey(v => v.BlogId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
