﻿using Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.EntitiesConfiguration
{
    public class PagamentoConfiguration : IEntityTypeConfiguration<PagamentoEntity>
    {
        public void Configure(EntityTypeBuilder<PagamentoEntity> builder)
        {
            builder.ToTable("TB_PAGAMENTO");

            builder.HasKey(p => p.PkId);

            builder.Property(p => p.PagamentoStatus)
                .HasConversion<string>();

            builder.Property(p => p.TipoPagamento)
                .HasConversion<string>();

            builder.Property(p => p.Valor)
                .HasPrecision(10, 2);
        }
    }
}
