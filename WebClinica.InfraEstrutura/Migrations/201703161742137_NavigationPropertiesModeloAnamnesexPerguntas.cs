namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NavigationPropertiesModeloAnamnesexPerguntas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese");
            AddColumn("dbo.TblModeloAnamnese", "Pergunta_PerguntaId", c => c.Int());
            AddColumn("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId1", c => c.Int());
            CreateIndex("dbo.TblModeloAnamnese", "Pergunta_PerguntaId");
            CreateIndex("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId1");
            AddForeignKey("dbo.TblModeloAnamnese", "Pergunta_PerguntaId", "dbo.TblPerguntaAnamnese", "PerguntaId");
            AddForeignKey("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId1", "dbo.TblModeloAnamnese", "ModeloId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId1", "dbo.TblModeloAnamnese");
            DropForeignKey("dbo.TblModeloAnamnese", "Pergunta_PerguntaId", "dbo.TblPerguntaAnamnese");
            DropIndex("dbo.TblPerguntaAnamnese", new[] { "ModeloAnamnese_ModeloId1" });
            DropIndex("dbo.TblModeloAnamnese", new[] { "Pergunta_PerguntaId" });
            DropColumn("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId1");
            DropColumn("dbo.TblModeloAnamnese", "Pergunta_PerguntaId");
            AddForeignKey("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese", "ModeloId");
        }
    }
}
