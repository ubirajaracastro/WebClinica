namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracosEntidadePaciente : DbMigration
    {
        public override void Up()
        {
           
            //DropColumn("dbo.TblASO", "PacienteId");
            //DropColumn("dbo.TblASOFichaClinica", "PacienteId");          
            AddColumn("dbo.TblPaciente", "TipoConvenioId", c => c.Int(nullable: false));
            //AlterColumn("dbo.TblASO", "PacienteId", c => c.Int(nullable: false));
            //AlterColumn("dbo.TblASOFichaClinica", "PacienteId", c => c.Int(nullable: false));         
         
            DropColumn("dbo.TblPaciente", "AtestadoID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblPaciente", "AtestadoID", c => c.Int(nullable: false));
            DropIndex("dbo.TblASOFichaClinica", new[] { "PacienteId" });
            DropIndex("dbo.TblASO", new[] { "PacienteId" });
            AlterColumn("dbo.TblASOFichaClinica", "PacienteId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.TblASO", "PacienteId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.TblPaciente", "TipoConvenioId");
            RenameColumn(table: "dbo.TblASOFichaClinica", name: "PacienteId", newName: "AsoFichaClinicaId");
            RenameColumn(table: "dbo.TblASO", name: "PacienteId", newName: "ASOId");
            AddColumn("dbo.TblASOFichaClinica", "PacienteId", c => c.Int(nullable: false));
            AddColumn("dbo.TblASO", "PacienteId", c => c.Int(nullable: false));
            CreateIndex("dbo.TblASOFichaClinica", "AsoFichaClinicaId");
            CreateIndex("dbo.TblASO", "ASOId");
        }
    }
}
