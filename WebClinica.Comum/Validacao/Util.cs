using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WebClinica.Comum.dto;

namespace WebClinica.Comum.Validacao
{
    public class Util
    {
        private static string RemoveNaoNumericos(string text)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"[^0-9]");
            string ret = reg.Replace(text, string.Empty);
            return ret;
        }

        public static bool ValidaCPF(string cpf)
        {
            //Remove formatação do número, ex: "123.456.789-01" vira: "12345678901"
            cpf = Util.RemoveNaoNumericos(cpf);

            if (cpf.Length > 11)
                return false;

            while (cpf.Length != 11)
                cpf = '0' + cpf;

            bool igual = true;
            for (int i = 1; i < 11 && igual; i++)
                if (cpf[i] != cpf[0])
                    igual = false;

            if (igual || cpf == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(cpf[i].ToString());

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];

            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[9] != 0)
                    return false;
            }
            else if (numeros[9] != 11 - resultado)
                return false;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {
                if (numeros[10] != 0)
                    return false;
            }
            else
                if (numeros[10] != 11 - resultado)
                return false;

            return true;
        }

        public static bool ValidaCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            tempCnpj = cnpj.Substring(0, 12);

            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public static List<DoencaCID>obterDadosTabelaCID()
        {
            //Cria uma instância de um documento XML
            XmlDocument oXML = new XmlDocument();
            List<DoencaCID> listaCid = new List<DoencaCID>();
            string caminho = "@C:\\WebClinica\\WebClinica\\lista-cid-10.xml";

            //Define o caminho do arquivo XML 
            string ArquivoXML = caminho;
            //carrega o arquivo XML
            oXML.Load(ArquivoXML);
            string codigoDoenca = string.Empty;
            string Nome = string.Empty;

            int i = 0;
            foreach (XmlNodeList item in oXML.SelectSingleNode("doencasCid10").ChildNodes)
            {
                codigoDoenca = item[i].SelectSingleNode("doenca").ChildNodes[0].InnerText;
                Nome = item[i].SelectSingleNode("nome").ChildNodes[1].InnerText;

                DoencaCID cid = new DoencaCID();
                cid.CodigoCID = codigoDoenca;
                cid.Nome = Nome;

                listaCid.Add(cid);
                i += 1;

            }

            //Lê o filho de um Nó Pai específico 
            //string nomeAluno = oXML.SelectSingleNode("Alunos").ChildNodes[0].InnerText;
            //string idadeAluno = oXML.SelectSingleNode("Alunos").ChildNodes[1].InnerText;
            //string emailAluno = oXML.SelectSingleNode("Alunos").ChildNodes[2].InnerText;

            //*** Exibe Dados do aluno
            //lstXML.Items.Add(nomeAluno);
            //lstXML.Items.Add(idadeAluno);
            //lstXML.Items.Add(emailAluno);

            //endereco do aluno
            //for (int i = 0; i <= 4; i++)
            //{
            //    lstXML.Items.Add(oXML.SelectSingleNode("Alunos").ChildNodes[3].ChildNodes[i].InnerText);
            //}

            return listaCid;

        }

        

        
    }
}
