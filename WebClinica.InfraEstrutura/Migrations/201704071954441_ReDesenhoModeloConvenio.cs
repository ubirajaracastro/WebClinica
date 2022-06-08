namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReDesenhoModeloConvenio : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.TblConvenio", "IX_CNPJ");
            CreateTable(
                "dbo.TblConvenioPlano",
                c => new
                    {
                        ConvenioPlanoID = c.Int(nullable: false, identity: true),
                        ConvenioID = c.Int(nullable: false),
                        DescricaoPlano = c.String(nullable: false, maxLength: 200, unicode: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ConvenioPlanoID)
                .ForeignKey("dbo.TblConvenio", t => t.ConvenioID)
                .Index(t => t.ConvenioID);
            
            AddColumn("dbo.TblConvenio", "CGC", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.TblConvenio", "Telefone", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.TblConvenio", "Email", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.TblConvenio", "Contato", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AddColumn("dbo.TblConvenio", "CNPJClinica", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AddColumn("dbo.TblConvenio", "Site", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.TblConvenio", "Observacao", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.TblConvenio", "TabelaId", c => c.Int(nullable: false));
            AddColumn("dbo.TblConvenio", "NumeroContrato", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.TblConvenio", "CalcularExtraCirurgia", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblConvenio", "HorarioSemanalHoraExtra", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.TblConvenio", "HorarioFinalSemanaHoraExtra", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.TblConvenio", "AtendeRadiologia", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblConvenio", "ValorFilme", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.TblConvenio", "PagamentoAdicionalMedico", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblConvenio", "PercentualSobConsulta", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.TblConvenio", "PercentualSobProcedimento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.TblConvenio", "NroDigitosCarteira", c => c.Int(nullable: false));
            AddColumn("dbo.TblConvenio", "QteDiasFaturamento", c => c.Int(nullable: false));
            AddColumn("dbo.TblConvenio", "NumeroRegistroANS", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AddColumn("dbo.TblConvenio", "NumeroJuntoaoConvenio", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.TblConvenio", "DataCadastro", c => c.DateTime(nullable: false));
            CreateIndex("dbo.TblConvenio", "CNPJClinica", name: "IX_CNPJ");
            DropColumn("dbo.TblConvenio", "NumeroRegistro");
            DropColumn("dbo.TblConvenio", "Validade");
            DropColumn("dbo.TblConvenio", "Faturar");
            DropColumn("dbo.TblConvenio", "CNPClinica");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblConvenio", "CNPClinica", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AddColumn("dbo.TblConvenio", "Faturar", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblConvenio", "Validade", c => c.DateTime(nullable: false));
            AddColumn("dbo.TblConvenio", "NumeroRegistro", c => c.String(nullable: false, maxLength: 200, unicode: false));
            DropForeignKey("dbo.TblConvenioPlano", "ConvenioID", "dbo.TblConvenio");
            DropIndex("dbo.TblConvenioPlano", new[] { "ConvenioID" });
            DropIndex("dbo.TblConvenio", "IX_CNPJ");
            DropColumn("dbo.TblConvenio", "DataCadastro");
            DropColumn("dbo.TblConvenio", "NumeroJuntoaoConvenio");
            DropColumn("dbo.TblConvenio", "NumeroRegistroANS");
            DropColumn("dbo.TblConvenio", "QteDiasFaturamento");
            DropColumn("dbo.TblConvenio", "NroDigitosCarteira");
            DropColumn("dbo.TblConvenio", "PercentualSobProcedimento");
            DropColumn("dbo.TblConvenio", "PercentualSobConsulta");
            DropColumn("dbo.TblConvenio", "PagamentoAdicionalMedico");
            DropColumn("dbo.TblConvenio", "ValorFilme");
            DropColumn("dbo.TblConvenio", "AtendeRadiologia");
            DropColumn("dbo.TblConvenio", "HorarioFinalSemanaHoraExtra");
            DropColumn("dbo.TblConvenio", "HorarioSemanalHoraExtra");
            DropColumn("dbo.TblConvenio", "CalcularExtraCirurgia");
            DropColumn("dbo.TblConvenio", "NumeroContrato");
            DropColumn("dbo.TblConvenio", "TabelaId");
            DropColumn("dbo.TblConvenio", "Observacao");
            DropColumn("dbo.TblConvenio", "Site");
            DropColumn("dbo.TblConvenio", "CNPJClinica");
            DropColumn("dbo.TblConvenio", "Contato");
            DropColumn("dbo.TblConvenio", "Email");
            DropColumn("dbo.TblConvenio", "Telefone");
            DropColumn("dbo.TblConvenio", "CGC");
            DropTable("dbo.TblConvenioPlano");
            CreateIndex("dbo.TblConvenio", "CNPClinica", name: "IX_CNPJ");
        }
    }
}
