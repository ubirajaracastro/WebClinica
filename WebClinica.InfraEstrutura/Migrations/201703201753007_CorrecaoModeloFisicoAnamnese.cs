namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoModeloFisicoAnamnese : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese");
            DropIndex("dbo.TblPerguntaAnamnese", new[] { "ModeloAnamnese_ModeloId" });
            CreateTable(
                "dbo.TblModeloPerguntaAnamneses",
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
            
            DropColumn("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId");
            DropTable("dbo.TblModeloPerguntaAnamnese");
            DropTable("dbo.TblModeloPergunta");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TblModeloPerguntaAnamnese",
                c => new
                    {
                        ModeloPerguntaAnamneseId = c.Int(nullable: false, identity: true),
                        ModeloCodigo = c.Int(nullable: false),
                        PerguntaCodigo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModeloPerguntaAnamneseId);
            
            AddColumn("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId", c => c.Int());
            DropForeignKey("dbo.TblModeloPergunta", "PerguntasAnamnese_PerguntaId", "dbo.TblPerguntaAnamnese");
            DropForeignKey("dbo.TblModeloPergunta", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese");
            DropIndex("dbo.TblModeloPergunta", new[] { "PerguntasAnamnese_PerguntaId" });
            DropIndex("dbo.TblModeloPergunta", new[] { "ModeloAnamnese_ModeloId" });
            DropTable("dbo.TblModeloPergunta");
            CreateIndex("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId");
            AddForeignKey("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese", "ModeloId");
        }
    }
}
