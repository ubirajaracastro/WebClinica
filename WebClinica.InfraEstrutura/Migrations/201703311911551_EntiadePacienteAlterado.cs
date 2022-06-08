namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntiadePacienteAlterado : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblConvenio", "Paciente_PacienteId", "dbo.TblPaciente");
            DropIndex("dbo.TblConvenio", new[] { "Paciente_PacienteId" });
            DropColumn("dbo.TblConvenio", "Paciente_PacienteId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblConvenio", "Paciente_PacienteId", c => c.Int());
            CreateIndex("dbo.TblConvenio", "Paciente_PacienteId");
            AddForeignKey("dbo.TblConvenio", "Paciente_PacienteId", "dbo.TblPaciente", "PacienteId");
        }
    }
}
