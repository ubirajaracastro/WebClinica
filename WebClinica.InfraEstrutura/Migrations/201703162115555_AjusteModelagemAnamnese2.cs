namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjusteModelagemAnamnese2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ModeloPergunta", newName: "TblModeloPergunta");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TblModeloPergunta", newName: "ModeloPergunta");
        }
    }
}
