namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveColunaUFRegistroProfissional : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TblProfissional", "UFRegistro");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblProfissional", "UFRegistro", c => c.String(nullable: false, maxLength: 200, unicode: false));
        }
    }
}
