using System.Collections;
using System.Collections.Generic;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface IAtendimentoService
    {
        IEnumerable obterModeloAnamnese(string CNPJClinica);
        IEnumerable obterPerguntasModelo(int ModeloID);        
        int Salvar(Atendimento atendimento,List<ProntuarioRespostaAnamnese> prontuarioRespostas);
        Atendimento obterAtendimento(int ID);
        ExameFisico obterExameFisico(int atendimentoID);
        IEnumerable<ProntuarioRespostaAnamnese> ObterRespostasAnamnese(int atendimentoID);
        Atestado obterAtestado(int atendimentoID);
      
    }
}
