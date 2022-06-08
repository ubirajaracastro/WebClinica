namespace WebClinica.InfraEstrutura.Migrations
{
    using Dominio.Entidades;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebClinica.InfraEstrutura.Data.WebClinicaDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            
        }

        protected override void Seed(WebClinica.InfraEstrutura.Data.WebClinicaDataContext context)
        {
            /*
            #region TipoConsulta
            IList<TipodeConsulta> listaTiposConsulta = new List<TipodeConsulta>();

            listaTiposConsulta.Add(new TipodeConsulta()
            { Descricao = "Consulta", Ativo = true, Faturar = true, CNPJClinica = "45543915003954" });

            listaTiposConsulta.Add(new TipodeConsulta()
            { Descricao = "Cirurgia", Ativo = true, Faturar = true, CNPJClinica = "45543915003954" });

            listaTiposConsulta.Add(new TipodeConsulta()
            { Descricao = "Encaixe", Ativo = true, Faturar = true, CNPJClinica = "45543915003954" });

            listaTiposConsulta.Add(new TipodeConsulta()
            { Descricao = "Encaminhamento", Ativo = true, Faturar = true, CNPJClinica = "45543915003954" });

            listaTiposConsulta.Add(new TipodeConsulta()
            { Descricao = "Exame", Ativo = true, Faturar = true, CNPJClinica = "45543915003954" });

            listaTiposConsulta.Add(new TipodeConsulta()
            { Descricao = "Pré-Natal", Ativo = true, Faturar = true, CNPJClinica = "45543915003954" });

            listaTiposConsulta.Add(new TipodeConsulta()
            { Descricao = "Revisão", Ativo = true, Faturar = true, CNPJClinica = "45543915003954" });


            foreach (TipodeConsulta item in listaTiposConsulta)
            {
                context.TblTipodeConsulta.AddOrUpdate(item);
            }
            #endregion

            #region Banco
            IList<Banco> listaBanco = new List<Banco>();

            listaBanco.Add(new Banco()
            { Nome = "BANCO DO BRASIL S.A", Numero = "001", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO DA AMAZONIA S.A", Numero = "003", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO DO NORDESTE DO BRASIL S.A", Numero = "004", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANESTES S.A BANCO DO ESTADO DO ESPIRITO SANTO", Numero = "021", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO DE PERNAMBUCO S.A.-BANDEPE", Numero = "024", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO ALFA S/A", Numero = "025", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO DO ESTADO DE SANTA CATARINA S.A", Numero = "027", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO BANERJ S.A", Numero = "029", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO BEG S.A", Numero = "031", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO SANTANDER S.A", Numero = "033", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO DO ESTADO DO AMAZONAS S.A", Numero = "034", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO BRADESCO BBI S.A", Numero = "036", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO DO ESTADO DO PARA S.A", Numero = "037", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO BANESTADO S.A", Numero = "038", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO DO ESTADO DO PIAUI S.A. - BEP", Numero = "039", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO CARGILL S.A", Numero = "040", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO DO ESTADO DO RIO GRANDE DO SUL S.A", Numero = "041", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO BVA SA", Numero = "044", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO OPPORTUNITY S.A", Numero = "045", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO DO ESTADO DE SERGIPE S.A", Numero = "047", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "HIPERCARD BANCO MÚLTIPLO S.A", Numero = "062", CNPJClinica = "45543915003954" });


            listaBanco.Add(new Banco()
            { Nome = "BANCO IBI S.A - BANCO MULTIPLO", Numero = "063", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "LEMON BANK BANCO MÚLTIPLO S..A", Numero = "065", CNPJClinica = "45543915003954" });


            listaBanco.Add(new Banco()
            { Nome = "BANCO MORGAN STANLEY S.A", Numero = "066", CNPJClinica = "45543915003954" });


            listaBanco.Add(new Banco()
            { Nome = "BPN BRASIL BANCO MÚLTIPLO S.A", Numero = "069", CNPJClinica = "45543915003954" });


            listaBanco.Add(new Banco()
            { Nome = "BRB - BANCO DE BRASILIA S.A", Numero = "070", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO RURAL MAIS S.A", Numero = "072", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BB BANCO POPULAR DO BRASL S.A", Numero = "073", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO J.SAFRA S.A", Numero = "074", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO CR2 S.A", Numero = "075", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO KDB DO BRASIL S.A", Numero = "076", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO BM&F DE SERVIÇOS DE LIQUIDAÇÃO E CUSTÓDIA S.A", Numero = "096", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "CAIXA ECONÔMICA FEDERAL", Numero = "104", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO ÚNICO S.A", Numero = "116", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO NOSSA CAIXA S.A", Numero = "151", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO FINASA S.A", Numero = "175", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO ITAÚ - BBA S.A", Numero = "184", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO UBS PACTUAL S.A", Numero = "208", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO MATONE S.A", Numero = "212", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO ARBI S.A", Numero = "213", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO DIBENS S.A", Numero = "214", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO ACOMERCIAL E DE INVESTIMENTO SUDAMERIS S.A", Numero = "215", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO JOHN DEERE S.A", Numero = "217", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO BONSUCESSO S.A", Numero = "218", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO CLAYON BRASIL S/A", Numero = "222", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO FIBRA S.A", Numero = "224", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO BRASCAN S.A", Numero = "225", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO CRUZEIRO DO SUL S.A", Numero = "229", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "UNICARD BANCO MÚLTIPLO S.A", Numero = "230", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO GE CAPITAL S.A", Numero = "233", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO BRADESCO S.A", Numero = "237", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO CLASSICO S.A", Numero = "241", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO MAXIMA S.A", Numero = "243", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO ABC-BRASIL S.A", Numero = "246", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO BOAVISTA INTERATLANTICO S.A", Numero = "248", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO INVESTCRED UNIBANCO S.A", Numero = "249", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = " BANCO SCHAHIN", Numero = "250", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO FININVEST S.A", Numero = "252", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "PARANÁ BANCO S.A", Numero = "254", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO CACIQUE S.A", Numero = "263", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO FATOR S.A", Numero = "265", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO CEDULA S.A", Numero = "266", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO DE LA NACION ARGENTINA", Numero = "300", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO INDUSTRIAL E COMERCIAL S.A", Numero = "320", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO ITAU S.A", Numero = "341", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO SOCIETE GENERALE BRASIL S.A", Numero = "366", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO WESTLB DO BRASIL S.A", Numero = "370", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO J.P. MORGAN S.A", Numero = "376", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO MERCANTIL DO BRASIL S.A", Numero = "389", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO BMC S.A", Numero = "394", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "HSBC BANK BRASIL S.A.-BANCO MULTIPLO", Numero = "399", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO CAPITAL S.A", Numero = "412", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO SAFRA S.A", Numero = "422", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO RURAL S.A", Numero = "453", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO DE TOKYO-MITSUBISHI UFJ BRASIL S.A", Numero = "456", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO SUMITOMO MITSUI BRASILEIRO S.A", Numero = "464", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "CITIBANK N.A", Numero = "477", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO ITAUBANK S.A", Numero = "479", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "DEUTSCHE BANK S. A. - BANCO ALEMAO", Numero = "487", CNPJClinica = "45543915003954" });


            listaBanco.Add(new Banco()
            { Nome = "JPMORGAN CHASE BANK, NATIONAL ASSOCIATION", Numero = "488", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO CREDIT SUISSE (BRASIL) S.A", Numero = "505", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO CREDIT SUISSE (BRASIL) S.A", Numero = "600", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO INDUSTRIAL DO BRASIL S. A", Numero = "604", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO PAULISTA S.A", Numero = "611", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO PANAMERICANO S.A", Numero = "623", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO SOFISA S.A", Numero = "637", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO ITAÚ HOLDING FINANCEIRA S.A", Numero = "652", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO VOTORANTIM S.A", Numero = "655", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO DAYCOVAL S.A", Numero = "707", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO GERDAU S.A", Numero = "734", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO BARCLAYS S.A", Numero = "740", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO RIBEIRAO PRETO S.A", Numero = "741", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANKBOSTON N.A", Numero = "741", CNPJClinica = "45543915003954" });

            listaBanco.Add(new Banco()
            { Nome = "BANCO CITIBANK S.A", Numero = "745", CNPJClinica = "45543915003954" });


            foreach (Banco item in listaBanco)
            {
                context.TblBanco.AddOrUpdate(item);
            }
            #endregion

            #region StatusAgendamento
            IList<StatusAgendamento> listStatus = new List<StatusAgendamento>();

            listStatus.Add(new StatusAgendamento()
            { Ativo = true, Descricao = "Agendado"});

            listStatus.Add(new StatusAgendamento()
            { Ativo = true, Descricao = "Confirmado" });

            listStatus.Add(new StatusAgendamento()
            { Ativo = true, Descricao = "Cancelado pelo Profissional" });

            listStatus.Add(new StatusAgendamento()
            { Ativo = true, Descricao = "Cancelado pelo Profissional" });

            listStatus.Add(new StatusAgendamento()
            { Ativo = true, Descricao = "Em Eespera" });

            listStatus.Add(new StatusAgendamento()
            { Ativo = true, Descricao = "Em Andamento" });

            listStatus.Add(new StatusAgendamento()
            { Ativo = true, Descricao = "Finalizado" });

            listStatus.Add(new StatusAgendamento()
            { Ativo = true, Descricao = "Paciente Faltou" });

            listStatus.Add(new StatusAgendamento()
            { Ativo = true, Descricao = "Remarcou" });

            foreach (StatusAgendamento item in listStatus)
            {
                context.TblStatusAgendamento.AddOrUpdate(item);
            }

            #endregion

            #region CentrodeCusto
            IList<CentroCusto> listaCentroCusto = new List<CentroCusto>();

            #region Receitas

            CentroCusto cc = new CentroCusto();
            cc.CentroCustoId = 1;
            cc.Ativo = true;
            cc.DescricaoConta = "Receitas";
            cc.CNPJClinica = "45543915003954";

            IList<CategoriaCentroCusto> listaCat = new List<CategoriaCentroCusto>();

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc, Descricao = "Consultas", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc, Descricao = "Procedimentoss", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc, Descricao = "Dividendos Recebidos", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc, Descricao = "Juros de Aplicações", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc, Descricao = "Empréstimos Bancários", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc, Descricao = "Vendas de Ativo/Veículos", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc, Descricao = "Outras Receitas", CNPJ = "45543915003954" });

            #endregion

            #region Despesa Vendas          
            CentroCusto cc2 = new CentroCusto();
            cc2.CentroCustoId = 2;
            cc2.Ativo = true;
            cc2.DescricaoConta = "Despesas de Vendas e Marketing";
            cc2.CNPJClinica = "45543915003954";


            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc2, Descricao = "Comissões", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc2, Descricao = "Propaganda e Publicidade", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc2, Descricao = "Despesas de Viagens", CNPJ = "45543915003954" });

            #endregion

            #region Despesas Pessoal           
            CentroCusto cc3 = new CentroCusto();
            cc3.CentroCustoId = 3;
            cc3.Ativo = true;
            cc3.DescricaoConta = "Despesas com Pessoal";
            cc3.CNPJClinica = "45543915003954";

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc3, Descricao = "Salários", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc3, Descricao = "Adiantamentos", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc3, Descricao = "Férias", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc3, Descricao = "Rescisões", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc3, Descricao = "Décimo Terceiro Salário", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc3, Descricao = "FGTS", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc3, Descricao = "INSS", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc3, Descricao = "IRRP", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc3, Descricao = "Pensão Alimentícia", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc3, Descricao = "Assistência Médica", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc3, Descricao = "Vale Transporte", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc3, Descricao = "Vale Refeição", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc3, Descricao = "Seguro de Vida", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc3, Descricao = "Outros Benefícios", CNPJ = "45543915003954" });
            #endregion

            #region DespesaAdministrativa            
            CentroCusto cc4 = new CentroCusto();
            cc4.CentroCustoId = 4;
            cc4.Ativo = true;
            cc4.DescricaoConta = "Despesas Administrativas";
            cc4.CNPJClinica = "45543915003954";

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Aluguel", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Condomínio", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Água e Esgoto", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Energia Elétrica", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Telefonia", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Material de Escritório", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Manutenção de Imobilizado", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Seguros", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "IPTU", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Contabilidade", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Advogados", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Segurança", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Limpeza", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Internet", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Correios", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc4, Descricao = "Frete", CNPJ = "45543915003954" });
            #endregion

            #region DespesasFinanceiras

            CentroCusto cc5 = new CentroCusto();
            cc5.CentroCustoId = 5;
            cc5.Ativo = true;
            cc5.DescricaoConta = "Despesas Financeiras";
            cc5.CNPJClinica = "45543915003954";

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc5, Descricao = "Tarifas Bancárias", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc5, Descricao = "Tarifas de Cobrança", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc5, Descricao = "Juros Conta Corrente", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc5, Descricao = "Juros de Empréstimos", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc5, Descricao = "Pagamentos de Empréstimos", CNPJ = "45543915003954" });
            #endregion

            #region ImpostosTaxas          

            CentroCusto cc6 = new CentroCusto();
            cc6.CentroCustoId = 6;
            cc6.Ativo = true;
            cc6.DescricaoConta = "Impostos e Taxas";
            cc6.CNPJClinica = "45543915003954";

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc6, Descricao = "IR", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc6, Descricao = "Simples", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc6, Descricao = "Contribuição Social", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc6, Descricao = "PIS", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc6, Descricao = "ISS", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc6, Descricao = "COFINS", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc6, Descricao = "FGTS", CNPJ = "45543915003954" });
            #endregion

            #region Investimentos
            CentroCusto cc7 = new CentroCusto();
            cc7.CentroCustoId = 7;
            cc7.Ativo = true;
            cc7.DescricaoConta = "Investimentos";
            cc7.CNPJClinica = "45543915003954";

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc7, Descricao = "Máquinas e Equipamentos", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc7, Descricao = "Veículos", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc7, Descricao = "Instalações", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc7, Descricao = "Equipamentos de Informática", CNPJ = "45543915003954" });

            listaCat.Add(new CategoriaCentroCusto()
            { CentroCusto = cc7, Descricao = "Móveis e Utensílios", CNPJ = "45543915003954" });
            #endregion

            #region Save
            context.TblCentroCusto.AddOrUpdate(cc);
            context.TblCentroCusto.AddOrUpdate(cc2);
            context.TblCentroCusto.AddOrUpdate(cc3);
            context.TblCentroCusto.AddOrUpdate(cc4);
            context.TblCentroCusto.AddOrUpdate(cc5);
            context.TblCentroCusto.AddOrUpdate(cc6);
            context.TblCentroCusto.AddOrUpdate(cc7);
            #endregion
            foreach (CategoriaCentroCusto item in listaCat)
            {
                context.TblCategoriaCentroCusto.AddOrUpdate(item);
            }

            #endregion  

            #region ExameComplementarPCMSO

            //Estado estado = new Estado();
            //estado.Nome = "São Paulo";

            //Cidade cidade = new Cidade();
            //cidade.Estado = estado;
            //cidade.Nome = "Cotia";
          

            IList<ExameComplementarPCMSO> listaEx = new List<ExameComplementarPCMSO>();
            listaEx.Add(new ExameComplementarPCMSO()
            {
                ExameClinico = false,
                TGOTGP = false,
                AudiometriaTonal = false,
                AcuidadeVisual = false,
                Oftalmologico = false,
                ECG = false,
                Espirometria = false,
                EEG = false,
                RXColunaLombar = false,
                AvaliacooPsicologica = false,
                RXColunaCervical = false,
                Otoneurológico = false,
                RXColunaDorsal = false,
                Parecerodontológico = false,
                Ureia = false,
                Glicose = false,
                Creatinina = false,
                Reticulocitos = false,
                RXdasMaos = false,
                GamaGT = false,
                VDRL = false
                
               
            });

            foreach (ExameComplementarPCMSO item in listaEx)
            {
                 context.TblExameComplementarPCMSO.AddOrUpdate(item);

            }

            #endregion

            #region RiscoOcupacional
            IList<RiscoOcupacional> listaRisco = new List<RiscoOcupacional>();
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Ruído", Descricao = "Ruído" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Ruído", Descricao = "Calor" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Ruído", Descricao = "Radiação não-ionizante" });

            listaRisco.Add(new RiscoOcupacional() { Tipo = "Químicos", Descricao = "Peiras" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Químicos", Descricao = "Névoas" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Químicos", Descricao = "Fumo" });

            listaRisco.Add(new RiscoOcupacional() { Tipo = "Biológicos", Descricao = "Infecções" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Biológicos", Descricao = "Gripe" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Biológicos", Descricao = "Fungos" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Biológicos", Descricao = "Bacilos" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Biológicos", Descricao = "Vírus" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Biológicos", Descricao = "Bactérias" });

            listaRisco.Add(new RiscoOcupacional() { Tipo = "Ergonômicos", Descricao = "Postural" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Ergonômicos", Descricao = "Movimentação Contínua" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Ergonômicos", Descricao = "Levantamento e transporte de Peso." });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Ergonômicos", Descricao = "Trabalho Noturno" });

            listaRisco.Add(new RiscoOcupacional() { Tipo = "Acidente", Descricao = "Postural" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Acidente", Descricao = "Queda de Material" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Acidente", Descricao = "Manuseio de Peças Perfurocortantes" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Acidente", Descricao = "Ataque de animais peçonhentos" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Acidente", Descricao = "Esmagamento/Luxações" });
            listaRisco.Add(new RiscoOcupacional() { Tipo = "Acidente", Descricao = "Equip e Ferramenta de uso manual" });

            listaRisco.Add(new RiscoOcupacional() { Tipo = "Outros", Descricao = "Outros" });

            foreach (RiscoOcupacional item in listaRisco)
            {
                 context.TblRiscoOcupacional.AddOrUpdate(item);
            }

            #endregion

            #region Especialidade
            IList<Especialidade> listaEsp = new List<Especialidade>();

            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Acupuntura" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Alergia e Imunologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Anestesiologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Angiologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Cancerologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Cirurgia Cardiovascular" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Cirurgia da Mão" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Cirurgia de cabeça e pescoço" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Cirurgia do Aparelho Digestivo" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Cirurgia Pediátrica" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Cirurgia Plástica" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Cirurgia Torácica" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Cirurgia Vascular" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Clínica Médica" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Coloproctologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Canal Anal" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Clínica Médica" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Dermatologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Endocrinologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Endoscopia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Gastroenterologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Genética médica" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Geriatria" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Ginecologia e Obstetrícia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Mastologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Medicina do Tráfego" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Medicina Esportiva" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Medicina Física e Reabilitação" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Medicina Intensiva" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Medicina Legal e Perícia Médica" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Medicina Nuclear" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Medicina Preventiva e Social" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Neurologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Obstetrícia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Oftalmologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Patologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Medicina laboratorial" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Pediatria" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Pneumologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Psiquiatria" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Radiologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Radioterapia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Reumatologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Radiologia" });
            listaEsp.Add(new Especialidade() { Ativo = true, DescricaoEspecialidade = "Urologia" });

            foreach (Especialidade item in listaEsp)
            {
                 context.TblEspecialidade.AddOrUpdate(item);
            }
            #endregion

            #region Profissao
            IList<Profissao> listaProfissao = new List<Profissao>();

            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Acompanhante terapêutico " });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Administrador" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Assistente social" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Atendente" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Cozinheira" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Dentista" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Atendente" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Caixa" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Educador Fisíco" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Enfermeira (o)" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Esteticista" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Estimuladora visual" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Financeiro" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Fisioterapeuta" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Fonoaudiólogo" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Massoterapeuta" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Médico" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Motorista" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Musicoterapeuta" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Nutricionista" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Oftalmologista" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Optometrista" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Parceria/Apoio" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Pedagoga" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Podólogo" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Profissional assistente" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Psicanalista" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Psicólogo" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Psicopedagogo   " });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Psiquiatra" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Secretária" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Serviços gerais" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Técnico (a) de Enfermagem" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Técnico em Dependência Quimíca" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Técnico em Laboratório" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Técnico em podologia" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Técnico em Raio-x" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Técnico em Reabilitação de Dependentes Químicos" });
            listaProfissao.Add(new Profissao() { Ativo = true, Descricao = "Terapeuta ocupacional" });

            foreach (Profissao item in listaProfissao)
            {
                 context.TblProfissao.AddOrUpdate(item);
            }
            #endregion

            #region FatorSanguineo
            IList<FatorSanguineo> listaFator = new List<FatorSanguineo>();
            listaFator.Add(new FatorSanguineo() { Descricao = "O-" });
            listaFator.Add(new FatorSanguineo() { Descricao = "O+" });
            listaFator.Add(new FatorSanguineo() { Descricao = "A-" });
            listaFator.Add(new FatorSanguineo() { Descricao = "A+" });
            listaFator.Add(new FatorSanguineo() { Descricao = "B-" });
            listaFator.Add(new FatorSanguineo() { Descricao = "B+" });
            listaFator.Add(new FatorSanguineo() { Descricao = "AB-" });
            listaFator.Add(new FatorSanguineo() { Descricao = "AB+" });

            foreach (FatorSanguineo item in listaFator)
            {
                context.TblFatorSanguineo.AddOrUpdate(item);
            }
            #endregion

            #region Escolaridade
            IList<Escolaridade> listaEsc = new List<Escolaridade>();
            listaEsc.Add(new Escolaridade() { Ativo = true, Descricao = "Pré-escola" });
            listaEsc.Add(new Escolaridade() { Ativo = true, Descricao = "Analfabeto" });
            listaEsc.Add(new Escolaridade() { Ativo = true, Descricao = "Fundamental incompleto" });
            listaEsc.Add(new Escolaridade() { Ativo = true, Descricao = "Fundamental completo" });
            listaEsc.Add(new Escolaridade() { Ativo = true, Descricao = "Médio completo" });
            listaEsc.Add(new Escolaridade() { Ativo = true, Descricao = "Superior incompleto" });
            listaEsc.Add(new Escolaridade() { Ativo = true, Descricao = "Superior completo" });
            listaEsc.Add(new Escolaridade() { Ativo = true, Descricao = "Mestrado" });
            listaEsc.Add(new Escolaridade() { Ativo = true, Descricao = "Doutorado" });
            listaEsc.Add(new Escolaridade() { Ativo = true, Descricao = " Pós doutorado" });

            foreach (Escolaridade item in listaEsc)
            {
                 context.TblEscolaridade.AddOrUpdate(item);
            }
            #endregion

            #region Laudo
            IList<LaudoNR07> listaLaudo = new List<LaudoNR07>();

            listaLaudo.Add(new LaudoNR07() { Descricao = "Não se aplica" });
            listaLaudo.Add(new LaudoNR07() { Descricao = "Apto para o trabalho" });
            listaLaudo.Add(new LaudoNR07() { Descricao = "Inapto para o trabalho" });

            foreach (LaudoNR07 item in listaLaudo)
            {
                 context.TblLaudoNR07.AddOrUpdate(item);
            }
            #endregion

            #region FormaPagamento
            IList<FormaPagamento> listaFormaPag = new List<FormaPagamento>();
            listaFormaPag.Add(new FormaPagamento() { Ativo = true, Descricao = "Cartão de Crédito" });
            listaFormaPag.Add(new FormaPagamento() { Ativo = true, Descricao = "Cartão de Débito" });
            listaFormaPag.Add(new FormaPagamento() { Ativo = true, Descricao = "Cheque" });
            listaFormaPag.Add(new FormaPagamento() { Ativo = true, Descricao = "Convênio" });
            listaFormaPag.Add(new FormaPagamento() { Ativo = true, Descricao = "Crediário" });
            listaFormaPag.Add(new FormaPagamento() { Ativo = true, Descricao = "Débito em Conta Corrente" });
            listaFormaPag.Add(new FormaPagamento() { Ativo = true, Descricao = "Dinheiro" });
            listaFormaPag.Add(new FormaPagamento() { Ativo = true, Descricao = "DOC" });
            listaFormaPag.Add(new FormaPagamento() { Ativo = true, Descricao = "Duplicata" });
            listaFormaPag.Add(new FormaPagamento() { Ativo = true, Descricao = "TED" });

            foreach (FormaPagamento item in listaFormaPag)
            {
                 context.TblFormaPagamento.AddOrUpdate(item);
            }
            #endregion

            */
            
        }
    }
}
