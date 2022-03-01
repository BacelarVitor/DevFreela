﻿
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
    public class UserSkillConfigurations : IEntityTypeConfiguration<UserSkill>
    {
        public void Configure(EntityTypeBuilder<UserSkill> builder)
        {
            builder
                .HasKey(u => u.Id);

            builder
                .Property(u => u.CreatedAt)
                .HasDefaultValue(DateTime.UtcNow);

            builder
               .Property(u => u.UpdatedAt)
               .HasDefaultValue(DateTime.UtcNow);
        }
    }
}
