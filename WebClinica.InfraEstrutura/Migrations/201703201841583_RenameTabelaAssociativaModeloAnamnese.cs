namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTabelaAssociativaModeloAnamnese : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TblModeloPergunta", newName: "TblModeloPerguntaAnamneses");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TblModeloPerguntaAnamneses", newName: "TblModeloPergunta");
        }
    }
}
