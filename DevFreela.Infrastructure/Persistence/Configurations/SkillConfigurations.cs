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
    public class SkillConfigurations : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder
                .HasKey(s => s.Id);

            builder
                .Property(s => s.Description)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(s => s.CreatedAt)
                .HasDefaultValue(DateTime.UtcNow);

            builder
               .Property(s => s.UpdatedAt)
               .HasDefaultValue(DateTime.UtcNow);
        }
    }
}
