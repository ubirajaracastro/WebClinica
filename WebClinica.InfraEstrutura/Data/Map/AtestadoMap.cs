using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebClinica.InfraEstrutura.Data.Map
{
    public class AtestadoMap:EntityTypeConfiguration<Atestado>
    {
       
        public AtestadoMap()
        {
            ToTable("TblAtestado");
            HasKey(x => x.AtestadoId);

            Property(x => x.AtestadoId)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
          
            Property(x => x.TituloImpressao);
            Property(x => x.Texto);
            Property(x => x.CNPJClinica);         


        }
    }
}
