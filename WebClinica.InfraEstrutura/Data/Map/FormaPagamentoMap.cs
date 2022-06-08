using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class FormaPagamentoMap:EntityTypeConfiguration<FormaPagamento>
    {
        public FormaPagamentoMap()
        {
            ToTable("TblFormaPagamento");

            Property(x => x.FormaId)
              .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasKey(x => x.FormaId);

            Property(x => x.Ativo);
            Property(x => x.Descricao);



        }
    }
}
