namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoModelagemAnamnese : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblModeloPergunta", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese");
            DropForeignKey("dbo.TblModeloPergunta", "PerguntasAnamnese_PerguntaId", "dbo.TblPerguntaAnamnese");
            DropIndex("dbo.TblModeloPergunta", new[] { "ModeloAnamnese_ModeloId" });
            DropIndex("dbo.TblModeloPergunta", new[] { "PerguntasAnamnese_PerguntaId" });
            CreateTable(
                "dbo.TblModeloPerguntaAnamnese",
                c => new
                    {
                        ModeloPerguntaAnamneseId = c.Int(nullable: false, identity: true),
                        ModeloId = c.Int(nullable: false),
                        PerguntaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ModeloPerguntaAnamneseId);
            
           
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TblModeloPergunta",
                c => new
                    {
                        ModeloAnamnese_ModeloId = c.Int(nullable: false),
                        PerguntasAnamnese_PerguntaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ModeloAnamnese_ModeloId, t.PerguntasAnamnese_PerguntaId });
            
            DropForeignKey("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese");
            DropIndex("dbo.TblPerguntaAnamnese", new[] { "ModeloAnamnese_ModeloId" });
            DropColumn("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId");
            DropTable("dbo.TblModeloPerguntaAnamnese");
            CreateIndex("dbo.TblModeloPergunta", "PerguntasAnamnese_PerguntaId");
            CreateIndex("dbo.TblModeloPergunta", "ModeloAnamnese_ModeloId");
            AddForeignKey("dbo.TblModeloPergunta", "PerguntasAnamnese_PerguntaId", "dbo.TblPerguntaAnamnese", "PerguntaId", cascadeDelete: true);
            AddForeignKey("dbo.TblModeloPergunta", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese", "ModeloId", cascadeDelete: true);
        }
    }
}
