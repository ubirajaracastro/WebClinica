using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ProcedimentoCobrancaMap : EntityTypeConfiguration<ProcedimentoCobranca>
    {
        public ProcedimentoCobrancaMap()
        {
            ToTable("TblProcedimentoCobranca");
            HasKey(x => x.ProcedimentoCobrancaId);

            Property(x => x.ProcedimentoId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.ConvenioId);

            Property(x => x.ValorConvenio);
            Property(x => x.ValorPaciente);

        }


    }
}
