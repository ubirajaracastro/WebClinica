namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjustesModeloAnamnese : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese");
            DropIndex("dbo.TblPerguntaAnamnese", new[] { "ModeloAnamnese_ModeloId" });
            DropColumn("dbo.TblPerguntaAnamnese", "ModeloAnamneseId");
            DropColumn("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId", c => c.Int(nullable: false));
            AddColumn("dbo.TblPerguntaAnamnese", "ModeloAnamneseId", c => c.Int(nullable: false));
            CreateIndex("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId");
            AddForeignKey("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese", "ModeloId");
        }
    }
}
