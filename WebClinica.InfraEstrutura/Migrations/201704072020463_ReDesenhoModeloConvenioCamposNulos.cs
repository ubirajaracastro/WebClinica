namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReDesenhoModeloConvenioCamposNulos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TblConvenio", "ValorFilme", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.TblConvenio", "PagamentoAdicionalMedico", c => c.Boolean());
            AlterColumn("dbo.TblConvenio", "PercentualSobConsulta", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.TblConvenio", "PercentualSobProcedimento", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.TblConvenioPlanoNegociacao", "NovoValorAcordado", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TblConvenioPlanoNegociacao", "NovoValorAcordado", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TblConvenio", "PercentualSobProcedimento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TblConvenio", "PercentualSobConsulta", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TblConvenio", "PagamentoAdicionalMedico", c => c.Boolean(nullable: false));
            AlterColumn("dbo.TblConvenio", "ValorFilme", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
