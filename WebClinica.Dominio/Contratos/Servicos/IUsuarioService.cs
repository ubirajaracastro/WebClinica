using System.Collections.Generic;
using WebClinica.Dominio.Entidades;

namespace WebClinica.Dominio.Contratos.Servicos
{
    public interface IUsuarioService
    {
        string criarUsuario(Usuario usuario,int idPerfilID);
        void alterarSenha(Usuario usuario);
        void desbloquearUsuario(Usuario usuario);
        bool autenticarUsuario(Usuario usuario);
        void inativarUsuario(Usuario usuario);
        Usuario obterUsuario(string login);
        IEnumerable<Usuario> obterUsuarios();
    }
}
