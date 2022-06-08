namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjusteEntidadeTabelaProcedimentoDerivada : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblConvenioPlanoNegociacao", "ConvenioPlanoID", "dbo.TblConvenioPlano");
            DropIndex("dbo.TblConvenioPlanoNegociacao", new[] { "ConvenioPlanoID" });
            CreateTable(
                "dbo.TabelaDerivadaCobrancaProcedimento",
                c => new
                    {
                        TabelaDerivadaCobrancaProcedimentoID = c.Int(nullable: false, identity: true),
                        CodigoProcedimento = c.Int(nullable: false),
                        NovoValorAcordado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TabelaBaseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TabelaDerivadaCobrancaProcedimentoID);
            
            DropTable("dbo.TblConvenioPlanoNegociacao");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TblConvenioPlanoNegociacao",
                c => new
                    {
                        ConvenioPlanoNegociacaoID = c.Int(nullable: false, identity: true),
                        CodigoProcedimento = c.String(maxLength: 200, unicode: false),
                        NovoValorAcordado = c.Decimal(precision: 18, scale: 2),
                        ConvenioPlanoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ConvenioPlanoNegociacaoID);
            
            DropTable("dbo.TabelaDerivadaCobrancaProcedimento");
            CreateIndex("dbo.TblConvenioPlanoNegociacao", "ConvenioPlanoID");
            AddForeignKey("dbo.TblConvenioPlanoNegociacao", "ConvenioPlanoID", "dbo.TblConvenioPlano", "ConvenioPlanoID");
        }
    }
}
