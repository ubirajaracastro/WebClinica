using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ProntuarioProcedimentoMap:EntityTypeConfiguration<ProntuarioProcedimento>
    {
        public ProntuarioProcedimentoMap()
        {
            ToTable("TblProntuarioProcedimento");
            HasKey(x => x.ProntuarioProcedimentoID);

            Property(x => x.ProntuarioProcedimentoID)
            .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.AtendimentoID);
            Property(x => x.CodigoProcedimento);         
            
        }

    }
}
