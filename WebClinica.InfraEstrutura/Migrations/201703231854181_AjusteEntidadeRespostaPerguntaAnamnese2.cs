namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjusteEntidadeRespostaPerguntaAnamnese2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblRespostaPerguntaAnamnese", "TipoPerguntaID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TblRespostaPerguntaAnamnese", "TipoPerguntaID");
        }
    }
}
