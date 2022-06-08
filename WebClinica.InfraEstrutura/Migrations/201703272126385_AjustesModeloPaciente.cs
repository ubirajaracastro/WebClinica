namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjustesModeloPaciente : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblPaciente", "DadosComplementares_Id", "dbo.TblPacienteDadoComplementar");
            DropIndex("dbo.TblPaciente", new[] { "DadosComplementares_Id" });
            //DropIndex("dbo.TblASO", new[] { "PacienteId" });
            //DropIndex("dbo.TblASOFichaClinica", new[] { "PacienteId" });
            //DropColumn("dbo.TblASO", "ASOId");
            //DropColumn("dbo.TblASOFichaClinica", "AsoFichaClinicaId");
           /* DropColumn("dbo.TblPacienteDadoComplementar", "Id")*/;
            //RenameColumn(table: "dbo.TblASOFichaClinica", name: "PacienteId", newName: "AsoFichaClinicaId");
            //RenameColumn(table: "dbo.TblPacienteDadoComplementar", name: "DadosComplementares_Id", newName: "Id");
            //RenameColumn(table: "dbo.TblASO", name: "PacienteId", newName: "ASOId");
            //DropPrimaryKey("dbo.TblASO");
            //DropPrimaryKey("dbo.TblASOFichaClinica");
            //DropPrimaryKey("dbo.TblPacienteDadoComplementar");
            AddColumn("dbo.TblPaciente", "ConvenioID", c => c.Int(nullable: false));
            AddColumn("dbo.TblPaciente", "Convenio_ConvenioID", c => c.Int(nullable: false));
            AlterColumn("dbo.TblASO", "ASOId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.TblASOFichaClinica", "AsoFichaClinicaId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.TblPacienteDadoComplementar", "Id", c => c.Int(nullable: false));
            //AddPrimaryKey("dbo.TblASO", "ASOId");
            //AddPrimaryKey("dbo.TblASOFichaClinica", "AsoFichaClinicaId");
            //AddPrimaryKey("dbo.TblPacienteDadoComplementar", "Id");
            CreateIndex("dbo.TblPaciente", "Convenio_ConvenioID");
            CreateIndex("dbo.TblASO", "ASOId");
            CreateIndex("dbo.TblASOFichaClinica", "AsoFichaClinicaId");
            CreateIndex("dbo.TblPacienteDadoComplementar", "Id");
            AddForeignKey("dbo.TblPaciente", "Convenio_ConvenioID", "dbo.TblConvenio", "ConvenioID");
            DropColumn("dbo.TblPaciente", "DadosComplementares_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblPaciente", "DadosComplementares_Id", c => c.Int());
            DropForeignKey("dbo.TblPaciente", "Convenio_ConvenioID", "dbo.TblConvenio");
            DropIndex("dbo.TblPacienteDadoComplementar", new[] { "Id" });
            DropIndex("dbo.TblASOFichaClinica", new[] { "AsoFichaClinicaId" });
            DropIndex("dbo.TblASO", new[] { "ASOId" });
            DropIndex("dbo.TblPaciente", new[] { "Convenio_ConvenioID" });
            DropPrimaryKey("dbo.TblPacienteDadoComplementar");
            DropPrimaryKey("dbo.TblASOFichaClinica");
            DropPrimaryKey("dbo.TblASO");
            AlterColumn("dbo.TblPacienteDadoComplementar", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.TblASOFichaClinica", "AsoFichaClinicaId", c => c.Int(nullable: false));
            AlterColumn("dbo.TblASO", "ASOId", c => c.Int(nullable: false));
            DropColumn("dbo.TblPaciente", "Convenio_ConvenioID");
            DropColumn("dbo.TblPaciente", "ConvenioID");
            AddPrimaryKey("dbo.TblPacienteDadoComplementar", "Id");
            AddPrimaryKey("dbo.TblASOFichaClinica", "AsoFichaClinicaId");
            AddPrimaryKey("dbo.TblASO", "ASOId");
            RenameColumn(table: "dbo.TblASO", name: "ASOId", newName: "PacienteId");
            RenameColumn(table: "dbo.TblPacienteDadoComplementar", name: "Id", newName: "DadosComplementares_Id");
            RenameColumn(table: "dbo.TblASOFichaClinica", name: "AsoFichaClinicaId", newName: "PacienteId");
            AddColumn("dbo.TblPacienteDadoComplementar", "Id", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.TblASOFichaClinica", "AsoFichaClinicaId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.TblASO", "ASOId", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.TblASOFichaClinica", "PacienteId");
            CreateIndex("dbo.TblASO", "PacienteId");
            CreateIndex("dbo.TblPaciente", "DadosComplementares_Id");
            AddForeignKey("dbo.TblPaciente", "DadosComplementares_Id", "dbo.TblPacienteDadoComplementar", "Id");
        }
    }
}
