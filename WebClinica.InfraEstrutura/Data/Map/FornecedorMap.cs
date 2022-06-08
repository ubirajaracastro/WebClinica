using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class FornecedorMap:EntityTypeConfiguration<FornecedorClinica>
    {
        public FornecedorMap()
        {
            ToTable("TblFornecedorClinica");
            HasKey(x => x.Id);

            Property(x => x.Id)
                 .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CNPJ)
            .IsRequired();

            Property(x => x.Nome)
             .IsRequired();

            Property(x => x.RazaoSocial)
                .IsRequired();
            
            Property(x => x.NomeContato)
            .IsRequired();

            Property(x => x.CNPJClinica);        
         
            Property(x => x.Email)
             .IsRequired();

            Property(x => x.Telefone)
             .IsRequired();

            Property(x => x.Endereco);             
            Property(x => x.Numero);
            Property(x => x.Bairro);
            Property(x => x.Cep);
            Property(x => x.Ativo);

            HasRequired(x => x.Estado);
            HasRequired(x => x.Cidade);



        }

    }
}
