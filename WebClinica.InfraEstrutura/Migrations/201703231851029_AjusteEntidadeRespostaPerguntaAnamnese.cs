namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjusteEntidadeRespostaPerguntaAnamnese : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TblRespostaPerguntaAnamnese", "PerguntaAnamneseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblRespostaPerguntaAnamnese", "PerguntaAnamneseId", c => c.Int(nullable: false));
        }
    }
}
