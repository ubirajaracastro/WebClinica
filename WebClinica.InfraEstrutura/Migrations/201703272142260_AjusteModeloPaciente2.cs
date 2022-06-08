namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjusteModeloPaciente2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TblPaciente", "ConvenioID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblPaciente", "ConvenioID", c => c.Int(nullable: false));
        }
    }
}
