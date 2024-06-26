﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SaudeIntegrada.Domain.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeIntegrada.Domain
{
    public class ExercicioFichaMapping : IEntityTypeConfiguration<ExercicioFicha>
    {
        public void Configure(EntityTypeBuilder<ExercicioFicha> builder)
        {
            builder.ToTable("ExercicioFicha");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Sets).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Repeticoes).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Observacoes).IsRequired().HasMaxLength(200);
            builder.Property(x => x.Carga).IsRequired().HasMaxLength(200);

            builder.HasOne(x => x.ExercicioBase).WithMany(); 
        }
    }
}