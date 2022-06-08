namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblPerguntaModelo", "ModeloCodigo", c => c.Int(nullable: false));
            AddColumn("dbo.tblPerguntaModelo", "PerguntaCodigo", c => c.Int(nullable: false));
            DropColumn("dbo.tblPerguntaModelo", "ModeloId");
            DropColumn("dbo.tblPerguntaModelo", "PerguntaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblPerguntaModelo", "PerguntaId", c => c.Int(nullable: false));
            AddColumn("dbo.tblPerguntaModelo", "ModeloId", c => c.Int(nullable: false));
            DropColumn("dbo.tblPerguntaModelo", "PerguntaCodigo");
            DropColumn("dbo.tblPerguntaModelo", "ModeloCodigo");
        }
    }
}
