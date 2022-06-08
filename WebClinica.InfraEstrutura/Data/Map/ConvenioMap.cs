using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ConvenioMap : EntityTypeConfiguration<Convenio>
    {
        public ConvenioMap()
        {
            ToTable("TblConvenio");
            HasKey(x => x.ConvenioID);

            Property(x => x.ConvenioID)
             .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CNPJClinica)
              .IsRequired()
               .HasColumnAnnotation(
                   IndexAnnotation.AnnotationName,
                   new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));


            Property(x => x.NomeConvenio)
              .IsRequired();

            Property(x => x.NumeroRegistroANS)
             .IsRequired();

            Property(x => x.Contato)
                .IsRequired();

            Property(x => x.CGC);        
            Property(x => x.Telefone);
            Property(x => x.Email);          
            Property(x => x.Ativo);
            Property(x => x.CNPJClinica);
            Property(x => x.Site);
            Property(x => x.Observacao);
            Property(x => x.NumeroContrato);
            Property(x => x.CalcularExtraCirurgia);
            Property(x => x.HorarioSemanalHoraExtra);
            Property(x => x.HorarioFinalSemanaHoraExtra);
            Property(x => x.AtendeRadiologia);

            Property(x => x.ValorFilme)
                .IsOptional();

            Property(x => x.PagamentoAdicionalMedico)
                .IsOptional();

            Property(x => x.PercentualSobConsulta)
                .IsOptional();

            Property(x => x.PercentualSobProcedimento)
                .IsOptional();

            Property(x => x.NroDigitosCarteira);
            Property(x => x.QteDiasFaturamento);
            Property(x => x.NumeroJuntoaoConvenio);
            Property(x => x.DataCadastro);
            Property(x => x.TabelaId);
            

            //HasMany(x => x.ProfissionaisQueAceitam);
            //HasMany(x => x.Procedimentos);


        }

    }
}
