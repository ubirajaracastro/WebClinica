using System.Collections;
using WebClinica.Dominio.Entidades;
using WebClinica.Comum.dto;

namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface IPacienteService
    {
        void Salvar(Paciente paciente,PacienteDadosComplementares dadoComplementar);
        Paciente obterPaciente(int pacienteID);
        IEnumerable obter();
        PacienteDadosComplementares obterDadoComplementar(int pacienteID);
        IEnumerable obterPaciente(string nome);
        IEnumerable obterCID(string nome);
        ResumoPaciente obterResumodoPaciente(int pacienteID);

    }
}
