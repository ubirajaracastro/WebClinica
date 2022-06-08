using System.Collections;
using System.Collections.Generic;
using WebClinica.Dominio.Entidades;


namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface IModeloAnamneseService
    {
        IEnumerable<ModeloAnamnese> obter();
        int obterModeloPadrao();
        ModeloAnamnese obterModeloPadraoClinica();
        void ExcluirModeloAnamnese(int id);
        ModeloAnamnese obterPorId(int id);
        void Salvar(ModeloAnamnese modelo,List<PerguntasAnamnese>Perguntas);
        void ExcluirModeloPergunta(int ModeloId);
        IEnumerable<ModeloPergunta> obterPerguntasModelo(int ModeloId);
        IEnumerable<PerguntasAnamnese> obterPerguntas(int ModeloId);
        string obterDescricaoPergunta(int PerguntaID);



    }
}
