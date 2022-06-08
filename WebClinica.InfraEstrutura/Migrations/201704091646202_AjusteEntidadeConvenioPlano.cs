namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjusteEntidadeConvenioPlano : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TabelaDerivadaCobrancaProcedimento", newName: "TblTabelaDerivadaCobrancaProcedimento");
            AddColumn("dbo.TblConvenioPlano", "TabelaID", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.TblConvenioPlano", "TabelaID");
            RenameTable(name: "dbo.TblTabelaDerivadaCobrancaProcedimento", newName: "TabelaDerivadaCobrancaProcedimento");
        }
    }
}
