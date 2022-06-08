namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjusteModelagemAnamnese : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblModeloAnamnese", "Pergunta_PerguntaId", "dbo.TblPerguntaAnamnese");
            DropForeignKey("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId1", "dbo.TblModeloAnamnese");
            DropIndex("dbo.TblModeloAnamnese", new[] { "Pergunta_PerguntaId" });
            DropIndex("dbo.TblPerguntaAnamnese", new[] { "ModeloAnamnese_ModeloId1" });
            CreateTable(
                "dbo.ModeloPergunta",
                c => new
                    {
                        ModeloAnamnese_ModeloId = c.Int(nullable: false),
                        PerguntasAnamnese_PerguntaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ModeloAnamnese_ModeloId, t.PerguntasAnamnese_PerguntaId })
                .ForeignKey("dbo.TblModeloAnamnese", t => t.ModeloAnamnese_ModeloId, cascadeDelete: true)
                .ForeignKey("dbo.TblPerguntaAnamnese", t => t.PerguntasAnamnese_PerguntaId, cascadeDelete: true)
                .Index(t => t.ModeloAnamnese_ModeloId)
                .Index(t => t.PerguntasAnamnese_PerguntaId);
            
            DropColumn("dbo.TblModeloAnamnese", "Pergunta_PerguntaId");
            DropColumn("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId1", c => c.Int());
            AddColumn("dbo.TblModeloAnamnese", "Pergunta_PerguntaId", c => c.Int());
            DropForeignKey("dbo.ModeloPergunta", "PerguntasAnamnese_PerguntaId", "dbo.TblPerguntaAnamnese");
            DropForeignKey("dbo.ModeloPergunta", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese");
            DropIndex("dbo.ModeloPergunta", new[] { "PerguntasAnamnese_PerguntaId" });
            DropIndex("dbo.ModeloPergunta", new[] { "ModeloAnamnese_ModeloId" });
            DropTable("dbo.ModeloPergunta");
            CreateIndex("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId1");
            CreateIndex("dbo.TblModeloAnamnese", "Pergunta_PerguntaId");
            AddForeignKey("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId1", "dbo.TblModeloAnamnese", "ModeloId");
            AddForeignKey("dbo.TblModeloAnamnese", "Pergunta_PerguntaId", "dbo.TblPerguntaAnamnese", "PerguntaId");
        }
    }
}
