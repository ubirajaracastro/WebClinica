using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class PaisMap:EntityTypeConfiguration<Pais>
    {
        public PaisMap()
        {
            ToTable("tblPais");

            Property(x => x.PaisId)
                .HasColumnName("cod_pais")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.Sigla).
                HasColumnName("sgl_pais");

            Property(x => x.Nome).
               HasColumnName("nom_pais");

        }

    }
}
