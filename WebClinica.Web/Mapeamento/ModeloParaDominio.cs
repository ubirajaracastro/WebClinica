using AutoMapper;
using WebClinica.Dominio.Entidades;
using WebClinica.Web.Models;

namespace WebClinica.Web.Mapeamento
{
    public class ModeloParaDominio:Profile
    {

        public override string ProfileName

        {
            get { return "DomainToViewModelMappings"; }

        }

        public ModeloParaDominio()
        {
            Mapper.Initialize(cfg => {

                cfg.CreateMap<ClinicaViewModel, Clinica>();
                cfg.CreateMap<PacienteViewModel,Paciente>();
                cfg.CreateMap<PacienteDadosComplementaresViewModel, PacienteDadosComplementares>();
            });
        }
        
        
    }
}