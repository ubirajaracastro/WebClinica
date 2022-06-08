namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjusteModeloOffProntuario2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TblAtendimento", "AtestadoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblAtendimento", "AtestadoId", c => c.Int());
        }
    }
}
