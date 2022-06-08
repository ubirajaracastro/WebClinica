using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace WebClinica.InfraEstrutura.Data.Map
{
    public class PacienteMap : EntityTypeConfiguration<Paciente>
    {
        public PacienteMap()
        {
            ToTable("TblPaciente");
            HasKey(x => x.PacienteId);

            Property(x => x.PacienteId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.CNPJClinica)
            .IsRequired()
             .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                    new IndexAnnotation(new IndexAttribute("IX_CNPJ", 1) { IsUnique = false }));

            Property(x => x.NomeCompleto)
            .IsRequired();

            Property(x => x.DataNascimento)
           .IsRequired();

            Property(x => x.Sexo)
           .IsRequired();

            Property(x => x.CPF)
           .IsRequired();

            Property(x => x.ConvenioId)
          .IsRequired();

            Property(x => x.RG);
            Property(x => x.NumeroCarteira);
            Property(x => x.ValidadeCarteira);
            Property(x => x.Cep);
            Property(x => x.UrlFoto);
            Property(x => x.Endereco);
            Property(x => x.Numero);
            Property(x => x.Bairro);
            Property(x => x.Complemento);
            Property(x => x.CidadeID);
            Property(x => x.EstadoID);

            Property(x => x.TipoConvenioId)
                .IsRequired();

            Property(x => x.ConvenioPlanoId)
                .IsOptional();

            Property(x => x.Email)
                .IsRequired();

            Property(x => x.TelefoneCelular)
                .IsRequired();

            Property(x => x.TelefoneResidencial);
            Property(x => x.TelefoneComercial);
            Property(x => x.UrlImagemCartaoSaudePaciente);
            Property(x => x.Skype);

            HasMany(x => x.Agendamentos);
            HasMany(x => x.Procedimentos);
            HasMany(x => x.Orcamentos);           
            HasMany(x => x.Atestados);
            HasMany(x => x.SolicitacoesExame);

        }

    }
}
