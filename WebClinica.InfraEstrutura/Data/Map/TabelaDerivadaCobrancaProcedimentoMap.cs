using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class TabelaDerivadaCobrancaProcedimentoMap:EntityTypeConfiguration<TabelaDerivadaCobrancaProcedimento>
    {
        public TabelaDerivadaCobrancaProcedimentoMap()
        {
            ToTable("TblTabelaDerivadaProcedimento");

            HasKey(x => x.TabelaDerivadaCobrancaProcedimentoID);

            Property(x => x.TabelaDerivadaCobrancaProcedimentoID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.NomeTabela)
                .IsRequired();

            Property(x => x.TabelaBaseID)
                .IsRequired();

            Property(x => x.DtCadastro)
               .IsRequired();


        }
    }
}
