namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfigComissao : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TblComissao", "PercentualDesconto");
            DropColumn("dbo.TblComissao", "Paga");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblComissao", "Paga", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblComissao", "PercentualDesconto", c => c.Double(nullable: false));
        }
    }
}
