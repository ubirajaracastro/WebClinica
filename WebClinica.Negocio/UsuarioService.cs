using System;
using System.Collections.Generic;
using System.Linq;
using WebClinica.Dominio.Contratos.Repositorios;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;
using WebClinica.Dominio.Entidades.Fluxo;

namespace WebClinica.Negocio
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepositoryBase<Usuario> _repositorio;
        private readonly IRepositoryBase<Perfil> _perfilrepositorio;

        public UsuarioService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repositorio = _unitOfWork.UsuarioRepositorio;
            _perfilrepositorio = _unitOfWork.PerfilRepositorio;

        }
        public void alterarSenha(Usuario usuario)
        {
            var registro = _repositorio.GetById(usuario.UsuarioId);

            if (registro != null)
            {
                FluxoUsuario workFlowPassword = new FluxoUsuario();
                string senha = workFlowPassword.setHash(usuario.Senha);
                usuario.DataCadastro = DateTime.Now;
                registro.Senha = senha;
                registro.PrimeiroAcesso = false;

                _repositorio.Update(registro, usuario);
                _unitOfWork.Save();
            }
        }

        public bool autenticarUsuario(Usuario usuario)
        {
            return _repositorio.GetById(usuario.UsuarioId) != null
                ? true : false;
        }

        public string criarUsuario(Usuario usuario, int PerfilID)
        {
            string msg = string.Empty;

            try
            {
                var usuarioExisteLogin = _repositorio.GetWhere(u => u.Login == usuario.Login).FirstOrDefault();

                if (usuarioExisteLogin != null)
                {
                    msg = "Login já cadastrado!";

                }

                if (usuarioExisteLogin == null)
                {
                    var usuarioExisteEmail = _repositorio.GetWhere(u => u.Email == usuario.Email).FirstOrDefault();
                    if (usuarioExisteEmail != null)
                        msg = "Email já cadastrado!";
                }

                if (String.IsNullOrEmpty(msg))
                {

                    FluxoUsuario workFlowPassword = new FluxoUsuario();
                    string senha = workFlowPassword.setHash(usuario.Senha);
                    usuario.DataCadastro = DateTime.Now;

                    Perfil perfil = _perfilrepositorio.GetById(PerfilID);
                    usuario.Perfil = perfil;
                    usuario.Senha = senha;
                    usuario.PrimeiroAcesso = true;

                    _repositorio.Add(usuario);
                    _unitOfWork.Save();

                }


            }

            catch (Exception erro)
            {


            }

            return msg;
        }

        public void desbloquearUsuario(Usuario usuario)
        {
            var registro = _repositorio.GetById(usuario.UsuarioId);

            if (registro != null)
                registro.Bloqueado = false;

            _repositorio.Update(registro, usuario);
        }

        public void inativarUsuario(Usuario usuario)
        {
            var registro = _repositorio.GetById(usuario.UsuarioId);

            if (registro != null)
                registro.Ativo = false;

            _repositorio.Update(registro, usuario);
        }

        public Usuario obterUsuario(string email)
        {
            return _repositorio.GetWhere(em => em.Email == email).FirstOrDefault();
        }

        public IEnumerable<Usuario> obterUsuarios()
        {
            return _repositorio.GetWhere(u => u.Ativo = true);
        }
    }
}
