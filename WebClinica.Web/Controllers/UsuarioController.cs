using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Web.Mvc;
using WebClinica.Dominio.Contratos.Servicos;
using WebClinica.Dominio.Entidades;
using WebClinica.Web.Models;

namespace WebClinica.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _servicoUsuario;
        private readonly IPerfilService _servicoPerfil;
        const string cnpj = "45543915003954";

        public UsuarioController(IUsuarioService servicoUsuario,IPerfilService servicoPerfil)
        {
            _servicoPerfil = servicoPerfil;
            _servicoUsuario = servicoUsuario;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Novo()
        {
            carregarComboTela();
            UsuarioViewModel usuario = new UsuarioViewModel();
            usuario.Ativo = true;

            return View(usuario);

        }
        public JsonResult Salvar(UsuarioViewModel model)
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<UsuarioViewModel, Usuario>();
            });

            if (ModelState.IsValid)
            {
                Usuario usuarioDominio =
                    Mapper.Map<UsuarioViewModel, Usuario>(model);
                usuarioDominio.CNPJClinica = cnpj;

                var result = _servicoUsuario.criarUsuario(usuarioDominio, model.PerfilId);

                if (!String.IsNullOrWhiteSpace(result))
                {
                    return Json(new
                    {
                        msg = result
                    }, JsonRequestBehavior.AllowGet);

                }

            }
            return Json(new
            {
                msg = "Usuário cadastrado com sucesso. O usuário deverá alterar a senha no primeiro acesso ao sistema."
            }, JsonRequestBehavior.AllowGet);
        }



        private void carregarComboTela()
        {
            var listaPerfil = _servicoPerfil.obterPerfil();
            ViewBag.Perfis = new SelectList(listaPerfil, "PerfilId", "Descricao");
            
        }

        public JsonResult Listar(string searchPhrase)
        {
            IEnumerable<Usuario> listaUsuario = _servicoUsuario.obterUsuarios();
            var lista = listaUsuario.AsQueryable();
          

            if (!String.IsNullOrWhiteSpace(searchPhrase))
            {
                lista = lista.Where("login.Contains(@0)", searchPhrase);
            }


            int totalUsuarios = lista.Count();

            return Json(new
            {
                current = 1,
                rowCount = totalUsuarios,
                rows = lista,
                total = listaUsuario.Count(),
            }, JsonRequestBehavior.AllowGet);
        }

    }
}