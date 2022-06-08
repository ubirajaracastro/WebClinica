using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Web.Models;
using WebClinica.Comum.dto;
using System.Xml.Linq;

namespace WebClinica.Web.Controllers
{
    public class ProntuarioController : BaseController
    {
        #region membros
        private readonly IPacienteService _servicoPaciente;
        private readonly IAtendimentoService _servicoProntuario;
        public readonly IModeloAnamneseService _servicoModeloAnamnese;       
        private static int CodigoModeloAnamnesePadrao;

        #endregion

        #region Construtor
        public ProntuarioController(IPacienteService servicoPaciente, IAtendimentoService servicoProntuario,
            IModeloAnamneseService servicoModeloAnamnese)
        {
            _servicoPaciente = servicoPaciente;
            _servicoProntuario = servicoProntuario;
            _servicoModeloAnamnese = servicoModeloAnamnese;
        }

        #endregion

        #region actions
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BuscaPaciente()
        {
            return View();
        }

        public ActionResult obterProntuario(int id)
        {
            Atendimento prontuario = _servicoProntuario.obterAtendimento(id);           
            IEnumerable<ProntuarioRespostaAnamnese> respostas = null;          
            List<PerguntasAnamneseViewModel> PerguntasAnamnese = new List<PerguntasAnamneseViewModel>();
            List<ProntuarioProcedimentoViewModel> Procedimentos = new List<ProntuarioProcedimentoViewModel>();

            if (prontuario!=null){               
                respostas = _servicoProntuario.ObterRespostasAnamnese(prontuario.AtendimentoId);             
            }        

            ProntuarioViewModel model = new ProntuarioViewModel();
            model.DescricaoCID = prontuario.DescricaoCID;
            model.Conduta = prontuario.Conduta;
            model.Data = prontuario.Data;
            model.PrescricaoMedica = prontuario.PrescricaoMedica;
            model.QueixaPrincipal = prontuario.QueixaPrincipal;

            model.Atestado = new AtestadoViewModel() { Texto = prontuario.Atestado!=null? prontuario.Atestado.Texto:string.Empty};

            if (prontuario.ExameFisico != null)
            {
                ExameFisicoViewModel exameModel = new ExameFisicoViewModel()
                {
                    Altura = prontuario.ExameFisico.Altura,
                    FrequenciaCardiaca = prontuario.ExameFisico.FrequenciaCardiaca,
                    FrequenciaRespiratoria = prontuario.ExameFisico.FrequenciaRespiratoria,
                    Hemoglucoteste = prontuario.ExameFisico.Hemoglucoteste,
                    Peso = prontuario.ExameFisico.Peso,
                    PressãoArterialdiastolica = prontuario.ExameFisico.PressãoArterialdiastolica,
                    PressãoArterialsistotica = prontuario.ExameFisico.PressãoArterialsistotica,
                    Temperatura = prontuario.ExameFisico.Temperatura
                   
                };
                model.ExameFisico = exameModel;
            }
                       
            foreach (ProntuarioRespostaAnamnese item in respostas)
            {
                PerguntasAnamneseViewModel pergunta = new PerguntasAnamneseViewModel();
                pergunta.PerguntaId = item.PerguntaID;
                pergunta.Selecionada = item.RespostaID > 0 ? true : false;
                pergunta.RespostaId = item.RespostaID;
                pergunta.Descricao = _servicoModeloAnamnese.obterDescricaoPergunta(item.PerguntaID);
                PerguntasAnamnese.Add(pergunta);
                
            }

            foreach (ProntuarioProcedimento item in prontuario.ProcedimentosProntuario)
            { 
                ProntuarioProcedimentoViewModel procedimento = new ProntuarioProcedimentoViewModel();
                procedimento.CodigoProcedimento = item.CodigoProcedimento;

                Procedimentos.Add(procedimento);
            }
            
            model.Perguntas = PerguntasAnamnese;
            model.Procedimentos = Procedimentos;           
            ViewBag.AtendimentoID = prontuario.AtendimentoId.ToString();


            return View("IniciarAtendimento",model);
        }

        private List<PerguntasAnamneseViewModel> ObterPerguntasdoModelo(int modeloID)
        {
            IEnumerable<PerguntasAnamnese> listaPerguntas = _servicoModeloAnamnese.obterPerguntas(modeloID);
            List<PerguntasAnamneseViewModel> lista = new List<PerguntasAnamneseViewModel>();

            foreach (var item in listaPerguntas)
            {
                PerguntasAnamneseViewModel pergunta = new PerguntasAnamneseViewModel();
                pergunta.Descricao = item.Descricao;
                pergunta.PerguntaId = item.PerguntaId;
                pergunta.RespostaId = 0;

                lista.Add(pergunta);

            }

            return lista;
        }

        [HttpPost]
        public JsonResult IniciarAtendimento(ProntuarioViewModel model)
        {
            string msg = string.Empty;
            ExameFisico exame = null;
            Atestado atestado = null;
            int atendimentoID = 0;

            if (ModelState.IsValid)
            {
                if (Request.Form["CodigoPaciente"] == null)
                {
                    msg = "Paciente não localizado!";
                }
                else
                {
                    Atendimento modelo = new Atendimento();
                    modelo.CNPJClinica = CNPJClinica;
                    modelo.PacienteID = Int32.Parse(Request.Form["CodigoPaciente"].ToString());
                    modelo.QueixaPrincipal = model.QueixaPrincipal;
                    modelo.Conduta = model.Conduta;
                    modelo.Data = DateTime.Now;
                    modelo.CID = model.DescricaoCID.Substring(0, 4);                   
                    modelo.DescricaoCID = model.DescricaoCID.Remove(4);
                    modelo.PrescricaoMedica = model.PrescricaoMedica;
                    modelo.ModeloAnamneseID = CodigoModeloAnamnesePadrao;                   

                    if (model.ExameFisico.Altura > 0 || model.ExameFisico.FrequenciaCardiaca > 0 || model.ExameFisico.FrequenciaRespiratoria > 0
                        || model.ExameFisico.Hemoglucoteste > 0 || model.ExameFisico.Peso > 0 || model.ExameFisico.PressãoArterialdiastolica > 0 ||
                        model.ExameFisico.PressãoArterialsistotica > 0 || model.ExameFisico.Temperatura > 0
                       )
                    {
                        exame = new ExameFisico();
                        exame.Altura = model.ExameFisico.Altura.Value;
                        exame.FrequenciaCardiaca = model.ExameFisico.FrequenciaCardiaca.Value;
                        exame.FrequenciaRespiratoria = model.ExameFisico.FrequenciaRespiratoria.Value;
                        exame.Hemoglucoteste = model.ExameFisico.Hemoglucoteste.Value;
                        exame.Peso = model.ExameFisico.Peso.Value;
                        exame.PressãoArterialdiastolica = model.ExameFisico.PressãoArterialdiastolica.Value;
                        exame.PressãoArterialsistotica = model.ExameFisico.PressãoArterialsistotica.Value;
                        exame.Temperatura = model.ExameFisico.Temperatura.Value;
                        exame.CNPJClinica = CNPJClinica;

                        modelo.ExameFisico = exame;

                    }                    

                    List<ProntuarioRespostaAnamnese> listaRespostas = new List<ProntuarioRespostaAnamnese>();
                    //respostas Anamnese
                    foreach (PerguntasAnamneseViewModel item in model.Perguntas)
                    {
                        ProntuarioRespostaAnamnese resposta = new ProntuarioRespostaAnamnese();
                        resposta.PerguntaID = item.PerguntaId.Value;
                        resposta.RespostaID = item.RespostaId.Value;
                        
                        listaRespostas.Add(resposta);
                    }
                    // fim //respostas Anamnese


                    //procedimentos do prontuario
                    List<ProntuarioProcedimento> listaProcedimentos = new List<ProntuarioProcedimento>();

                    foreach (var item in model.Procedimentos)
                    {
                        if (item.CodigoProcedimento != null)
                        {
                            ProntuarioProcedimento procedimento = new ProntuarioProcedimento();
                            procedimento.CodigoProcedimento = item.CodigoProcedimento;

                            listaProcedimentos.Add(procedimento);
                        }
                    }
                    // fim procedimentos do prontuario

                    modelo.ProcedimentosProntuario = listaProcedimentos;

                    if (!String.IsNullOrEmpty(model.Atestado.Texto))
                    {
                        atestado = new Atestado();
                        atestado.Texto = model.Atestado.Texto;
                        atestado.CNPJClinica = CNPJClinica;
                        atestado.TituloImpressao = "Atestado Médico";

                        modelo.Atestado = atestado;
                    }

                    atendimentoID = _servicoProntuario.Salvar(modelo, listaRespostas);
                    msg = "OK";

                }

            }

            else
            {
                foreach (ModelState modelState in ViewData.ModelState.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        msg = "Ocorreu um erro no preenchimento do cadastro. Verifique os campos obrigatórios.<br> ";
                        msg += "Err(o)s: " + error.ErrorMessage;
                    }
                }

                throw new Exception();
            }

            var resultado = new
            {
                msg = msg,
                AtendimentoID = atendimentoID
            };

            return Json(resultado, JsonRequestBehavior.AllowGet);

        }

        public ActionResult IniciarAtendimento(FormCollection form)
        {
            //var itens = form[0].Split('-');
            string[] itens = null;
            ModeloAnamnese modelo = null;
            ProntuarioViewModel model = new ProntuarioViewModel();

            if (Request.Params[0] != null)
            {
                itens = Convert.ToString(Request.Params[0]).Split('-');
                int PacienteID = Int32.Parse(itens[0]);

                ResumoPaciente resumo = _servicoPaciente.obterResumodoPaciente(PacienteID);

                if (resumo != null)
                {
                    ViewBag.CPF = resumo.CPF;
                    ViewBag.Paciente = resumo.NomePaciente;
                    ViewBag.Sexo = resumo.Sexo;
                    ViewBag.DataNascimento = resumo.DataNascimento.ToShortDateString();
                    ViewBag.Telefone = resumo.Telefone;
                    ViewBag.Email = resumo.Email;
                    ViewBag.Responsavel = resumo.Responsável;
                    ViewBag.Indicacao = resumo.Indicacao;
                    ViewBag.Convenio = resumo.Convenio;
                    ViewBag.QtdeAtendimentos = resumo.QtdeAtendimentosRealizados;
                    ViewBag.PacienteID = PacienteID.ToString();

                }

                modelo = _servicoModeloAnamnese.obterModeloPadraoClinica();
                CodigoModeloAnamnesePadrao = modelo.ModeloId;

                if (modelo != null)
                {
                    var listaPerguntasModelo = ObterPerguntasdoModelo(CodigoModeloAnamnesePadrao);
                    model.Perguntas = listaPerguntasModelo;
                }

            }
                      

            return View(model);
        }

        public JsonResult buscarDoencaCID(string codigo)
        {
            var listaCids = _servicoPaciente.obterCID(codigo);
            return Json(listaCids, JsonRequestBehavior.AllowGet);

        }

        public PartialViewResult Add()
        {
            var model = new ProntuarioProcedimentoViewModel();
            return PartialView("_NovoProcedimento", model);
        }
        #endregion

    }
}