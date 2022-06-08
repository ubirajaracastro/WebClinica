using System;
using System.Collections;
using System.Linq;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;
using WebClinica.Comum.dto;

namespace WebClinica.Negocio
{
    public class PacienteService : IPacienteService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<Paciente> _repositorio;
        private readonly IRepositoryBase<PacienteDadosComplementares> _repositorioPacienteDadoComplementar;
        private readonly IRepositoryBase<Convenio> _repositorioConvenio;
        private readonly IRepositoryBase<Atendimento> _repositorioAtendimento;
        private readonly IRepositoryBase<Cid> _repositorioCid;

        public PacienteService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.PacienteRepositorio;
            _repositorioPacienteDadoComplementar = _unitOfWork.PacienteDadoComplementarRepositorio;
            _repositorioConvenio = _unitOfWork.ConvenioRepositorio;
            _repositorioAtendimento = _unitOfWork.ProntuarioRepositorio;
            _repositorioCid = _unitOfWork.CidRepositorio;
           
        }
        public IEnumerable obter()
        {
            IEnumerable listaPacientes = null;
            try
            {
                listaPacientes = from p in _repositorio.GetAll()
                                 join cv in _repositorioConvenio.GetAll() on p.ConvenioId equals cv.ConvenioID

                                 select new
                                 {
                                     p.PacienteId,
                                     p.CPF,
                                     p.DataNascimento,
                                     p.NomeCompleto,
                                     p.Sexo,
                                     p.TelefoneCelular,
                                     cv.NomeConvenio

                                 };

            }

            catch (Exception ex)
            {


            }

            return listaPacientes;

        }
        public Paciente obterPaciente(int pacienteID)
        {
            Paciente paciente = _repositorio.GetById(pacienteID);
            return paciente;
        }

        public void Salvar(Paciente paciente, PacienteDadosComplementares dadoComplementar)
        {
            try
            {
                var registro = _repositorio.GetById(paciente.PacienteId);

                if (registro == null)
                {
                    _repositorio.Add(paciente);
                    _unitOfWork.Save();

                    if (checarseTemValor(dadoComplementar))
                    {
                        dadoComplementar.PacienteId = paciente.PacienteId;
                        _repositorioPacienteDadoComplementar.Add(dadoComplementar);
                        _unitOfWork.Save();
                    }

                }
                else
                {
                    int IDPaciente = paciente.PacienteId;
                    _repositorio.Update(registro, paciente);

                    var registroExistente = _repositorioPacienteDadoComplementar.
                        GetById(dadoComplementar.PacienteId);

                    if ((registroExistente != null) && checarseTemValor(dadoComplementar))
                    {
                        _repositorioPacienteDadoComplementar.Update(registroExistente, dadoComplementar);
                    }
                    else
                        _repositorioPacienteDadoComplementar.Add(dadoComplementar);

                    _unitOfWork.Save();
                }


            }

            catch (Exception err)
            {


            }
        }


        private bool checarseTemValor(PacienteDadosComplementares objeto)
        {
            bool temvalor = false;

            if (!string.IsNullOrEmpty(objeto.CNSSUS) || (!string.IsNullOrEmpty(objeto.FatorSanguineo)) ||
                (!string.IsNullOrEmpty(objeto.Hobby) || (!string.IsNullOrEmpty(objeto.Indicacao) ||
                (!string.IsNullOrEmpty(objeto.NomeConjugue) || (!string.IsNullOrEmpty(objeto.NomeMae)
                || (!string.IsNullOrEmpty(objeto.NomePai) || (!string.IsNullOrEmpty(objeto.Responsavel)
                || (!string.IsNullOrEmpty(objeto.RG)))))))))
                temvalor = true;


            if ((objeto.ProfissaoId > 0) || (objeto.EscolaridadeId > 0) || (objeto.EstadoCivilId > 0) ||
                (objeto.EtniaId > 0))
                temvalor = true;



            return temvalor;


        }

        public PacienteDadosComplementares obterDadoComplementar(int pacienteID)
        {
            return _repositorioPacienteDadoComplementar.GetById(pacienteID);
        }

        public IEnumerable obterCID(string codigo)
        {
            IEnumerable listaCIDS = null;

            listaCIDS = from cid in _repositorioCid.TWhere(cid => cid.DescricaoCID.Contains(codigo))
                        orderby cid.DescricaoCID

                        select new
                        {
                            cid.CodigoCID,
                            cid.DescricaoCID

                        };

            return listaCIDS;
        }

        public IEnumerable obterPaciente(string nome)
        {
            IEnumerable listaPacientes = null;
            try
            {
                listaPacientes = from p in
                                    _repositorio.TWhere(c => c.NomeCompleto.Contains(nome))

                                 select new
                                 {
                                     p.PacienteId,
                                     p.NomeCompleto

                                 };

            }

            catch (Exception err)
            {

            }

            return listaPacientes;
        }

        public ResumoPaciente obterResumodoPaciente(int pacienteID)
        {
            ResumoPaciente resumo = null;
            int countAtendimento = _repositorioAtendimento.TWhere(p => p.PacienteID == pacienteID).Count();
            

            try
            {
                resumo = (from p in _repositorio.GetAll()
                                        join cv in _repositorioConvenio.GetAll() on p.ConvenioId equals cv.ConvenioID
                                        join dc in _repositorioPacienteDadoComplementar.GetAll()
                                           on p.PacienteId equals dc.PacienteId
                                        where p.PacienteId == pacienteID

                                        select new ResumoPaciente()
                                        {
                                            CPF = p.CPF,
                                            NomePaciente = p.NomeCompleto,
                                            DataNascimento = p.DataNascimento,
                                            Sexo = p.Sexo,
                                            Telefone = p.TelefoneCelular,
                                            Email = p.Email,
                                            Responsável = dc.Responsavel,
                                            Indicacao = dc.Indicacao,
                                            Convenio = cv.NomeConvenio,
                                            QtdeAtendimentosRealizados = countAtendimento

                                        }).FirstOrDefault();               

            }

            catch (Exception ex)
            {


            }

            return resumo;

        }

        
    }
}
