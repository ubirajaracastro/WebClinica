using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ProntuarioRespostaAnamneseMap:EntityTypeConfiguration<ProntuarioRespostaAnamnese>
    {
        public ProntuarioRespostaAnamneseMap()
        {
            ToTable("TblProntuarioRespostaAnamnese");
            HasKey(x => x.ID);

            Property(x => x.ID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.AtendimentoID);
            Property(x => x.PerguntaID);
            Property(x => x.RespostaID);

        }
    }
}
