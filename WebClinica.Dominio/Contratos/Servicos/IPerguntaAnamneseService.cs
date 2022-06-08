using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface IPerguntaAnamneseService
    {
        //IEnumerable<PerguntasAnamnese> obter(int ModeloID);
        IEnumerable<PerguntasAnamnese> obter();       
        void Salvar(PerguntasAnamnese pergunta, List<RespostaPerguntaAnamnese> listaRespostas);
        void Excluir(int id);
        
    }

}
