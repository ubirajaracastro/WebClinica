using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ModeloPerguntaMap:EntityTypeConfiguration<ModeloPergunta>
    {
        public ModeloPerguntaMap()
        {
            ToTable("tblPerguntaModelo");
            HasKey(x => x.ModeloPerguntaId);

            Property(x => x.ModeloCodigo)
               .IsRequired();


            Property(x => x.PerguntaCodigo)
                .IsRequired();
                 

        }
    }
}
