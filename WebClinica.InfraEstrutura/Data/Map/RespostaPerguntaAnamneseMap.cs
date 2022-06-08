using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class RespostaPerguntaAnamneseMap:EntityTypeConfiguration<RespostaPerguntaAnamnese>
    {
        public RespostaPerguntaAnamneseMap()
        {
            ToTable("TblRespostaPerguntaAnamnese");
            HasKey(x => x.RespostaId);         
          
            Property(x => x.DescricaoResposta);
            Property(x => x.TipoPerguntaID);

            HasRequired(x => x.PerguntasAnamnese)
                .WithMany()                
                .WillCascadeOnDelete(true);
              
        }

    }
}
