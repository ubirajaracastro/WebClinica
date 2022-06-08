using System;
using System.Collections.Generic;

namespace WebClinica.Dominio.Entidades
{
    public class Profissional
    {
        public Profissional()
        {
            this.Convenios = new List<Convenio>();
        }
        public int ProfissionalId { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }      
        public string Registro { get; set; }
        public string CodigoConselhoProfissional { get; set; }
        public string CodigoUFConselhoProfisional { get; set; }       
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int EstadoId { get; set; }
        public int CidadeId { get; set; }       
        public string Login { get; set; }
        public string Senha { get; set; }
        public string CNPJClinica { get; set; }
        public string CodigoCBOOcupacao { get; set; }
        public ICollection<Convenio> Convenios { get; set; }
    }
}
