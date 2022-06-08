namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CampoAtivoModeloAnamnese : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblModeloAnamnese", "Ativo", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TblModeloAnamnese", "Ativo");
        }
    }
}
