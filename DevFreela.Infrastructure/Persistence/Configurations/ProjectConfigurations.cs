using DevFreela.Core.Entities;
using DevFreela.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.Persistence.Configurations
{
    public class ProjectConfigurations : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                .HasKey(p => p.Id);

            builder
                .Property(p => p.TotalCost)
                .HasColumnType("decimal(18,2)");

            builder
                .Property(p => p.Title)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(p => p.Description)
                .IsRequired();

            builder
               .Property(p => p.Status)
               .IsRequired()
               .HasMaxLength(100);

            builder
                .Property(p => p.CreatedAt)
                .HasDefaultValue(DateTime.UtcNow);

            builder
               .Property(p => p.UpdatedAt)
               .HasDefaultValue(DateTime.UtcNow);

            builder
                .HasOne(p => p.Client)
                .WithMany(c => c.OwnedProjects)
                .HasForeignKey(p => p.IdClient)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(p => p.Freelancer)
                .WithMany(f => f.FreelanceProjects)
                .HasForeignKey(p => p.IdFreelancer)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
