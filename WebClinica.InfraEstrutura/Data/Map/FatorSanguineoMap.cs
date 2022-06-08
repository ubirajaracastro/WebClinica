using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;


namespace WebClinica.InfraEstrutura.Data.Map
{
    public class FatorSanguineoMap:EntityTypeConfiguration<FatorSanguineo>
    {
        public FatorSanguineoMap()
        {
            ToTable("TblFatorSanguineo");

            Property(x => x.FatorId)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasKey(x => x.FatorId);

            Property(x => x.Descricao);

        }

    }
}
