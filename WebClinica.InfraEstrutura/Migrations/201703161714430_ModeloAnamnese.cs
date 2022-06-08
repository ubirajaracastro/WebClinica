namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloAnamnese : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.TblPerguntaAnamnese", new[] { "ModeloAnamnese_ModeloId" });
            AddColumn("dbo.TblPerguntaAnamnese", "ModeloAnamneseId", c => c.Int(nullable: false));
            AlterColumn("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId", c => c.Int(nullable: false));
            CreateIndex("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.TblPerguntaAnamnese", new[] { "ModeloAnamnese_ModeloId" });
            AlterColumn("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId", c => c.Int());
            DropColumn("dbo.TblPerguntaAnamnese", "ModeloAnamneseId");
            CreateIndex("dbo.TblPerguntaAnamnese", "ModeloAnamnese_ModeloId");
        }
    }
}
