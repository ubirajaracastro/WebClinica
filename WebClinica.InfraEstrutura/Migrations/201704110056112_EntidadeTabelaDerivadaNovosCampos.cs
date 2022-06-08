namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntidadeTabelaDerivadaNovosCampos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblTabelaDerivadaCobrancaProcedimento", "NomeTabela", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AddColumn("dbo.TblTabelaDerivadaCobrancaProcedimento", "ValorUCO", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.TblTabelaDerivadaCobrancaProcedimento", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblTabelaDerivadaCobrancaProcedimento", "DataCadastro", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TblTabelaDerivadaCobrancaProcedimento", "DataCadastro");
            DropColumn("dbo.TblTabelaDerivadaCobrancaProcedimento", "Ativo");
            DropColumn("dbo.TblTabelaDerivadaCobrancaProcedimento", "ValorUCO");
            DropColumn("dbo.TblTabelaDerivadaCobrancaProcedimento", "NomeTabela");
        }
    }
}
