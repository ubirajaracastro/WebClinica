using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ConvenioPlanoMap: EntityTypeConfiguration<ConvenioPlano>
    {
        public ConvenioPlanoMap()
        {
            ToTable("TblConvenioPlano");
            HasKey(x => x.ConvenioPlanoID);

            Property(x => x.ConvenioPlanoID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //Property(x => x.ConvenioID);
            Property(x => x.DescricaoPlano)
                    .IsRequired();

            Property(x => x.DataCadastro);
            Property(x => x.TabelaID)
                    .IsOptional();


            HasRequired(x => x.Convenio);

        }
    }
}
