using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class Usuario
    {       
        public int UsuarioId { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public bool Ativo { get; set; }
        public bool Bloqueado { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Senha { get; set; }
        public int PerfilId { get; set; }
        public string CNPJClinica { get; set; }
        public bool PrimeiroAcesso { get; set; }
        public Perfil Perfil { get; set; }
    }
}
