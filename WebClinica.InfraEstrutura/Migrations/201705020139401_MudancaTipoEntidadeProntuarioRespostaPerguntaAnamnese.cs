namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MudancaTipoEntidadeProntuarioRespostaPerguntaAnamnese : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblProntuarioRespostaAnamnese", "RespostaID", c => c.Int(nullable: false));
            DropColumn("dbo.TblProntuarioRespostaAnamnese", "Resposta");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblProntuarioRespostaAnamnese", "Resposta", c => c.Boolean(nullable: false));
            DropColumn("dbo.TblProntuarioRespostaAnamnese", "RespostaID");
        }
    }
}
