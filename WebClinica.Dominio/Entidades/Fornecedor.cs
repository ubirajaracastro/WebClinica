using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClinica.Dominio.Entidades
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeContato { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public int EstadoId { get; set; }
        public int CidadeId { get; set; }
        public bool Ativo { get; set; }
        public string CNPJClinica { get; set; }
        public WEstado Estado { get; set; }
        public WCidade Cidade { get; set; }


    }
}
