namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoEntidadePaiTabelaDerivacao : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TblTabelaDerivadaCobrancaProcedimento", newName: "TblTabelaDerivadaProcedimento");
            AddColumn("dbo.TblTabelaDerivadaProcedimento", "DtCadastro", c => c.DateTime(nullable: false));
            DropColumn("dbo.TblTabelaDerivadaProcedimento", "CodigoProcedimento");
            DropColumn("dbo.TblTabelaDerivadaProcedimento", "ValorUCO");
            DropColumn("dbo.TblTabelaDerivadaProcedimento", "Ativo");
            DropColumn("dbo.TblTabelaDerivadaProcedimento", "NovoValorAcordado");
            DropColumn("dbo.TblTabelaDerivadaProcedimento", "DataCadastro");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblTabelaDerivadaProcedimento", "DataCadastro", c => c.DateTime(nullable: false));
            AddColumn("dbo.TblTabelaDerivadaProcedimento", "NovoValorAcordado", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.TblTabelaDerivadaProcedimento", "Ativo", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblTabelaDerivadaProcedimento", "ValorUCO", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.TblTabelaDerivadaProcedimento", "CodigoProcedimento", c => c.Int(nullable: false));
            DropColumn("dbo.TblTabelaDerivadaProcedimento", "DtCadastro");
            RenameTable(name: "dbo.TblTabelaDerivadaProcedimento", newName: "TblTabelaDerivadaCobrancaProcedimento");
        }
    }
}
