namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MudancaNomeColunas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblModeloPerguntaAnamnese", "ModeloCodigo", c => c.Int(nullable: false));
            AddColumn("dbo.TblModeloPerguntaAnamnese", "PerguntaCodigo", c => c.Int(nullable: false));
            DropColumn("dbo.TblModeloPerguntaAnamnese", "ModeloId");
            DropColumn("dbo.TblModeloPerguntaAnamnese", "PerguntaId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblModeloPerguntaAnamnese", "PerguntaId", c => c.Int(nullable: false));
            AddColumn("dbo.TblModeloPerguntaAnamnese", "ModeloId", c => c.Int(nullable: false));
            DropColumn("dbo.TblModeloPerguntaAnamnese", "PerguntaCodigo");
            DropColumn("dbo.TblModeloPerguntaAnamnese", "ModeloCodigo");
        }
    }
}
