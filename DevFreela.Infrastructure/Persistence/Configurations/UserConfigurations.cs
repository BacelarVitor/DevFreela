using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(u => u.Id);

            builder
                .Property(u => u.Active)
                .HasDefaultValue(true);

            builder
                .Property(u => u.FistName)
                .IsRequired()
                .HasMaxLength(150);

            builder
                .Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(500);

            builder
                .Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(400);


            builder
                .Property(u => u.CreatedAt)
                .HasDefaultValue(DateTime.UtcNow);

            builder
               .Property(u => u.UpdatedAt)
               .HasDefaultValue(DateTime.UtcNow);

            builder
                .HasMany(u => u.Skills)
                .WithOne()
                .HasForeignKey(u => u.IdSkill)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
