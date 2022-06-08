using System;
using System.Linq;
using System.Web.Mvc;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Web.Models;
using AutoMapper;
using WebClinica.Dominio.Entidades;
using System.Collections;
using System.Linq.Dynamic;
using System.Xml.Linq;

namespace WebClinica.Web.Controllers
{
    public class PacienteController : BaseController
    {
        #region membros
        private readonly IFatorSanguineoService _servicoFatorSanguineo;
        private readonly IEscolaridadeService _servicoEscolaridade;
        private readonly IEspecialidadeService _servicoProfissao;
        private readonly IConvenioService _servicoConvenio;
        private readonly IProfissionalService _servicoProfissional;
        private readonly IEstadoService _servicoUf;
        private readonly IPacienteService _servicoPaciente;
        private readonly ICidadeService _serviceCidade;
       
       
        #endregion

        #region Construtor
        public PacienteController(IFatorSanguineoService servicoFatorSanguineo, IEscolaridadeService servicoEscolaridade,
            IConvenioService servicoConvenio,
            IProfissionalService servicoProfissonal, IEstadoService servicoUf,IPacienteService servicoPaciente,
            ICidadeService serviceCidade)

        {
            _servicoFatorSanguineo = servicoFatorSanguineo;
            _servicoEscolaridade = servicoEscolaridade;            
            _servicoConvenio = servicoConvenio;
            _servicoProfissional = servicoProfissonal;
            _servicoUf = servicoUf;
            _servicoPaciente = servicoPaciente;
            _serviceCidade = serviceCidade;

        }
        #endregion

        #region Action
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ManterPaciente()
        {
            CarregaComboTela();
            return View();

        }

        public ActionResult Alterar(int id)
        {
            PacienteViewModel pacienteviewModel=null;
            PacienteDadosComplementaresViewModel pacienteDadoComplementarviewModel=null;

            Mapper.Initialize(config =>
            {
                config.CreateMap<Paciente, PacienteViewModel>();
                config.CreateMap<PacienteDadosComplementares, PacienteDadosComplementaresViewModel>();
            });

            CarregaComboTela();
            Paciente paciente = _servicoPaciente.obterPaciente(id);
            if(paciente!=null)
            {
                PacienteDadosComplementares dadoComplementar = 
                    _servicoPaciente.obterDadoComplementar(id);

                var nomeCidadeAtual = _serviceCidade.obterCidade(paciente.CidadeID);
                ViewBag.CidadeAtual = nomeCidadeAtual.Nome;
                ViewBag.CodigoCidadeAtual = nomeCidadeAtual.Id;
                ViewBag.CodigoPlano = paciente.ConvenioPlanoId;

                pacienteviewModel = Mapper.Map<Paciente, PacienteViewModel>(paciente);
                pacienteDadoComplementarviewModel = Mapper.Map<PacienteDadosComplementares, 
                    PacienteDadosComplementaresViewModel>(dadoComplementar);

            }

            //bind enums
            if (pacienteDadoComplementarviewModel != null)
            {
                if (pacienteDadoComplementarviewModel.EstadoCivilId > 0)
                    pacienteDadoComplementarviewModel.EstadoCivil =
                         (EstadoCivil)pacienteDadoComplementarviewModel.EstadoCivilId;

                if (pacienteDadoComplementarviewModel.EtniaId > 0)
                    pacienteDadoComplementarviewModel.Etnia =
                       (Etnia)pacienteDadoComplementarviewModel.EtniaId;

                if (pacienteviewModel.TipoConvenioId > 0)
                    pacienteDadoComplementarviewModel.TipoConvenio =
                       (TipoConvenio)pacienteviewModel.TipoConvenioId;
                //bind enums

            }

            pacienteviewModel.DadosComplementares = pacienteDadoComplementarviewModel;
            pacienteviewModel.PacienteId = paciente.PacienteId;
            
            return View("ManterPaciente",pacienteviewModel);

        }

        public JsonResult Listar(string searchPhrase)
        {
            var listaPacientes = _servicoPaciente.obter().AsQueryable();
           
            if (!String.IsNullOrWhiteSpace(searchPhrase))
            {
                listaPacientes = listaPacientes.Where("CPF.Contains(@0) or NomeCompleto.Contains(@0) or Sexo.Contains(@0) or TelefoneCelular.Contains(@0) or NomeConvenio.Contains(@0)", searchPhrase);
                //listaPacientes = listaPacientes.Where("NomeCompleto.Contains(@0)", searchPhrase);
            }
            
            int totalPacientes = listaPacientes.Count();

            return Json(new
            {
                current = 1,
                rowCount = totalPacientes,
                rows = listaPacientes,
                total = totalPacientes
            }, JsonRequestBehavior.AllowGet);
        }       
      

        public JsonResult buscarPacientePorNome(string nome)
        {
            var listaPacientes = _servicoPaciente.obterPaciente(nome);
            return Json(listaPacientes, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Salvar(PacienteViewModel model)
        {
            string msg = string.Empty;
            Paciente entidadePaciente = new Paciente();
            try
            {

                Mapper.Initialize(config =>
                {
                    config.CreateMap<PacienteViewModel, Paciente>();
                    config.CreateMap<PacienteDadosComplementaresViewModel, PacienteDadosComplementares>();

                });
               
                if (!ModelState.IsValid)
                {

                    var resultado = new
                    {
                        msg = "Ocorreu um erro no preenchimento do cadastro. Verifique os campos obrigatórios."
                    };

                    return Json(resultado, JsonRequestBehavior.AllowGet);

                }

               
                PacienteDadosComplementares dadoComplementar = new PacienteDadosComplementares();                            
                              
                entidadePaciente = Mapper.Map<PacienteViewModel, Paciente>(model);
                dadoComplementar = Mapper.Map<PacienteDadosComplementaresViewModel, PacienteDadosComplementares>(model.DadosComplementares);

                dadoComplementar.EtniaId = (int)model.DadosComplementares.Etnia;
                dadoComplementar.EstadoCivilId = (int)model.DadosComplementares.EstadoCivil;

                if(model.PacienteId>0)
                   dadoComplementar.PacienteId = model.PacienteId.Value;

                entidadePaciente.TipoConvenioId = (int)model.DadosComplementares.TipoConvenio;             
                entidadePaciente.CNPJClinica = CNPJClinica;
                entidadePaciente.CidadeID = Int32.Parse(Request.Form["Cidade"].ToString());

                if (Request.Form["ddlPlano"] != null)
                    entidadePaciente.ConvenioPlanoId = Int32.Parse(Request.Form["ddlPlano"].ToString());
                
                _servicoPaciente.Salvar(entidadePaciente,dadoComplementar);

                var result = new
                {
                    msg = "Paciente cadastrado com sucesso."
                };

                return Json(result, JsonRequestBehavior.AllowGet);
            }

            catch
            {
                var result = new
                {
                    msg = "Ocorreu um erro no cadastro do paciente. Contacte o suporte."
                };

                return Json(result, JsonRequestBehavior.AllowGet);
                
            }

        }

        private void CarregaComboTela()
        {
            var listaFatorSanguineo = _servicoFatorSanguineo.obter();
            ViewBag.GrupoSanguineo = new SelectList(listaFatorSanguineo, "FatorId", "Descricao");

            var listaEscolaridade = _servicoEscolaridade.obter();
            ViewBag.Escolaridade = new SelectList(listaEscolaridade, "EscolaridadeId", "Descricao");

            //var listaProfissao = _servicoProfissao.obter();
            //ViewBag.Profissao = new SelectList(listaProfissao, "codTermo", "Termo");

            var listaConvenio = _servicoConvenio.Obter();
            ViewBag.Convenio = new SelectList(listaConvenio, "ConvenioID", "NomeConvenio");

            var listaProfissional = _servicoProfissional.listarProfissional();
            ViewBag.Profissional = new SelectList(listaProfissional, "ProfissionalId", "Nome");

            var listaUf = _servicoUf.obterEstados(1);
            ViewBag.UF = new SelectList(listaUf, "EstadoId", "Nome");
           
        }
       
        #endregion

    }
}