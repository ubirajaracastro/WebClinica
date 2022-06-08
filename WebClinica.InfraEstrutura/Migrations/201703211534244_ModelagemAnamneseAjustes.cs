namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelagemAnamneseAjustes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblModeloPerguntaAnamneses", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese");
            DropForeignKey("dbo.TblModeloPerguntaAnamneses", "PerguntasAnamnese_PerguntaId", "dbo.TblPerguntaAnamnese");
            DropIndex("dbo.TblModeloPerguntaAnamneses", new[] { "ModeloAnamnese_ModeloId" });
            DropIndex("dbo.TblModeloPerguntaAnamneses", new[] { "PerguntasAnamnese_PerguntaId" });
            CreateTable(
                "dbo.tblPerguntaModelo",
                c => new
                    {
                        ModeloPerguntaId = c.Int(nullable: false, identity: true),
                        ModeloId = c.Int(nullable: false),
                        PerguntaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModeloPerguntaId)
                .Index(t => t.ModeloId, unique: true, name: "IX_MODELOID")
                .Index(t => t.PerguntaId, unique: true, name: "IX_PERGUNTAID");
            
            //AddColumn("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId", c => c.Int());
            //CreateIndex("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId");
            //AddForeignKey("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese", "ModeloId");
            DropTable("dbo.TblModeloPerguntaAnamneses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TblModeloPerguntaAnamneses",
                c => new
                    {
                        ModeloAnamnese_ModeloId = c.Int(nullable: false),
                        PerguntasAnamnese_PerguntaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ModeloAnamnese_ModeloId, t.PerguntasAnamnese_PerguntaId });
            
            DropForeignKey("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese");
            DropIndex("dbo.tblPerguntaModelo", "IX_PERGUNTAID");
            DropIndex("dbo.tblPerguntaModelo", "IX_MODELOID");
            DropIndex("dbo.TblPerguntaAnamnese", new[] { "ModeloAnamnese_ModeloId" });
            DropColumn("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId");
            DropTable("dbo.tblPerguntaModelo");
            CreateIndex("dbo.TblModeloPerguntaAnamneses", "PerguntasAnamnese_PerguntaId");
            CreateIndex("dbo.TblModeloPerguntaAnamneses", "ModeloAnamnese_ModeloId");
            AddForeignKey("dbo.TblModeloPerguntaAnamneses", "PerguntasAnamnese_PerguntaId", "dbo.TblPerguntaAnamnese", "PerguntaId", cascadeDelete: true);
            AddForeignKey("dbo.TblModeloPerguntaAnamneses", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese", "ModeloId", cascadeDelete: true);
        }
    }
}
