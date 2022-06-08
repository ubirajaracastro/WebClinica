namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConvencaoDeleteCascateRespostas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblRespostaPerguntaAnamnese", "PerguntasAnamnese_PerguntaId", "dbo.TblPerguntaAnamnese");
            AddColumn("dbo.TblRespostaPerguntaAnamnese", "PerguntasAnamnese_PerguntaId1", c => c.Int());
            CreateIndex("dbo.TblRespostaPerguntaAnamnese", "PerguntasAnamnese_PerguntaId1");
            AddForeignKey("dbo.TblRespostaPerguntaAnamnese", "PerguntasAnamnese_PerguntaId1", "dbo.TblPerguntaAnamnese", "PerguntaId");
            AddForeignKey("dbo.TblRespostaPerguntaAnamnese", "PerguntasAnamnese_PerguntaId", "dbo.TblPerguntaAnamnese", "PerguntaId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TblRespostaPerguntaAnamnese", "PerguntasAnamnese_PerguntaId", "dbo.TblPerguntaAnamnese");
            DropForeignKey("dbo.TblRespostaPerguntaAnamnese", "PerguntasAnamnese_PerguntaId1", "dbo.TblPerguntaAnamnese");
            DropIndex("dbo.TblRespostaPerguntaAnamnese", new[] { "PerguntasAnamnese_PerguntaId1" });
            DropColumn("dbo.TblRespostaPerguntaAnamnese", "PerguntasAnamnese_PerguntaId1");
            AddForeignKey("dbo.TblRespostaPerguntaAnamnese", "PerguntasAnamnese_PerguntaId", "dbo.TblPerguntaAnamnese", "PerguntaId");
        }
    }
}
