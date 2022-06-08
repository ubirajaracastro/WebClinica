﻿using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class CentroCustoMap:EntityTypeConfiguration<CentroCusto>
    {
        public CentroCustoMap()
        {
            ToTable("TblCentroCusto");
            HasKey(x => x.CentroCustoId);

            Property(x => x.CentroCustoId)
           .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.DescricaoConta)
             .IsRequired();

            Property(x => x.Ativo);
            Property(x => x.CNPJClinica)
                .IsRequired()
                 .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));


        }

    }
}
