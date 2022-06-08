namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoColunaIdentityPacienteDadoComplementar : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.TblPacienteDadoComplementar", new[] { "Id" });
            DropPrimaryKey("dbo.TblPacienteDadoComplementar");
            AlterColumn("dbo.TblPacienteDadoComplementar", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.TblPacienteDadoComplementar", "Id");
            CreateIndex("dbo.TblPacienteDadoComplementar", "Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.TblPacienteDadoComplementar", new[] { "Id" });
            DropPrimaryKey("dbo.TblPacienteDadoComplementar");
            AlterColumn("dbo.TblPacienteDadoComplementar", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.TblPacienteDadoComplementar", "Id");
            CreateIndex("dbo.TblPacienteDadoComplementar", "Id");
        }
    }
}
