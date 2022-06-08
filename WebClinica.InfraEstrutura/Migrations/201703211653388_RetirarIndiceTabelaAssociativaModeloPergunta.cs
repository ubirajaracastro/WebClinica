namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RetirarIndiceTabelaAssociativaModeloPergunta : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.tblPerguntaModelo", "IX_MODELOID");
            DropIndex("dbo.tblPerguntaModelo", "IX_PERGUNTAID");
        }
        
        public override void Down()
        {
            CreateIndex("dbo.tblPerguntaModelo", "PerguntaId", unique: true, name: "IX_PERGUNTAID");
            CreateIndex("dbo.tblPerguntaModelo", "ModeloId", unique: true, name: "IX_MODELOID");
        }
    }
}
