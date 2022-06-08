using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;


namespace WebClinica.InfraEstrutura.Data.Map
{
    public class CIDMap:EntityTypeConfiguration<Cid>
    {
        public CIDMap()
        {
            ToTable("tblCID");

            Property(x => x.ID);
            HasKey(x => x.ID);

            Property(x => x.ID)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CodigoCID);
            Property(x => x.DescricaoCID);
        }

    }
}
