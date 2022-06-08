using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class EscolaridadeMap:EntityTypeConfiguration<Escolaridade>
    {
        public EscolaridadeMap()
        {
            ToTable("TblEscolaridade");

            Property(x => x.EscolaridadeId)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasKey(x => x.EscolaridadeId);

            Property(x => x.Ativo);
            Property(x => x.Descricao);



        }

    }
}
