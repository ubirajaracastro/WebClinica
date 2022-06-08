using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ConvenioProfissionalMap : EntityTypeConfiguration<ConvenioProfissional>
    {
        public ConvenioProfissionalMap()
        {
            ToTable("TblConvenioProfissional");
            HasKey(x => x.ConvenioProfissionalId);

            Property(x => x.ConvenioId);
            Property(x => x.ProfissionalId);
            
       }


    }
}
