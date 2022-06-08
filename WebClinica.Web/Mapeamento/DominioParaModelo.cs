using AutoMapper;
using System;
using WebClinica.Dominio.Entidades;
using WebClinica.Web.Models;

namespace WebClinica.Web.Mapeamento
{
    public class DominioParaModelo : Profile
    {
        public override string ProfileName

        {
            get { return "DomainToViewModelMappings"; }

        }

        public DominioParaModelo()
        {
            CreateMap<Clinica, ClinicaViewModel>();
            CreateMap<Paciente, PacienteViewModel>();
            CreateMap<PacienteDadosComplementares, PacienteDadosComplementaresViewModel>();
        }
       
    }
}