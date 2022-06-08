using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class PerguntasAnamneseMap:EntityTypeConfiguration<PerguntasAnamnese>
    {
        public PerguntasAnamneseMap()
        {
            ToTable("TblPerguntaAnamnese");

            Property(x => x.PerguntaId)
               .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasKey(x => x.PerguntaId);

            Property(x => x.Descricao);
            Property(x => x.TipoPergunta);
            
            HasMany(x => x.Respostas);                        
                
                 
                
        }

    }
}
