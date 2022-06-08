using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;


namespace WebClinica.InfraEstrutura.Data.Map
{
    public class CidadeMap:EntityTypeConfiguration<WCidade>
    {
        public CidadeMap()
        {
            ToTable("Cidade");

            Property(x => x.Id);
            HasKey(x => x.Id);

            Property(x => x.CidadeId)
                .HasColumnName("cod_cidade")
                  .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.EstadoId)
                .HasColumnName("cod_estado");

            Property(x => x.Nome    )   
               .HasColumnName("nom_cidade");


        }

    }
}
