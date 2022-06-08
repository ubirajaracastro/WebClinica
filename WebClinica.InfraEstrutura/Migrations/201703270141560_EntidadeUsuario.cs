namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntidadeUsuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblUsuario", "PrimeiroAcesso", c => c.Boolean(nullable: false));
            AlterColumn("dbo.TblUsuario", "Senha", c => c.String(nullable: false, maxLength: 200, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TblUsuario", "Senha", c => c.String(maxLength: 200, unicode: false));
            DropColumn("dbo.TblUsuario", "PrimeiroAcesso");
        }
    }
}
