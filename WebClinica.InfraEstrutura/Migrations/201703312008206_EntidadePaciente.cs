namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntidadePaciente : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblPaciente", "DadosComplementares_Id", "dbo.TblPacienteDadoComplementar");
            DropIndex("dbo.TblPaciente", new[] { "DadosComplementares_Id" });
            DropPrimaryKey("dbo.TblPacienteDadoComplementar");
            AddPrimaryKey("dbo.TblPacienteDadoComplementar", "PacienteId");
            //DropColumn("dbo.TblPaciente", "DadosComplementares_Id");
            DropColumn("dbo.TblPacienteDadoComplementar", "Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblPacienteDadoComplementar", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.TblPaciente", "DadosComplementares_Id", c => c.Int());
            DropPrimaryKey("dbo.TblPacienteDadoComplementar");
            AddPrimaryKey("dbo.TblPacienteDadoComplementar", "Id");
            CreateIndex("dbo.TblPaciente", "DadosComplementares_Id");
            AddForeignKey("dbo.TblPaciente", "DadosComplementares_Id", "dbo.TblPacienteDadoComplementar", "Id");
        }
    }
}
