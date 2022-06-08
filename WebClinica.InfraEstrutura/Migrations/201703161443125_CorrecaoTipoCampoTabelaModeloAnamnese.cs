namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoTipoCampoTabelaModeloAnamnese : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TblModeloAnamnese", "Nome", c => c.String(nullable: false, maxLength: 200, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TblModeloAnamnese", "Nome", c => c.Int(nullable: false));
        }
    }
}
