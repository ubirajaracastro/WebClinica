namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveEntidade : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblProntuario", "PacienteId", "dbo.TblPaciente");
            DropIndex("dbo.TblProntuario", new[] { "PacienteId" });
            AlterColumn("dbo.TblAtendimento", "ModeloAnamneseID", c => c.Int());
            AlterColumn("dbo.TblAtendimento", "ModeloAnamneseId", c => c.Int(nullable: false));
            DropTable("dbo.TblProntuario");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TblProntuario",
                c => new
                    {
                        ProntuarioId = c.Int(nullable: false, identity: true),
                        PacienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProntuarioId);
            
            AlterColumn("dbo.TblAtendimento", "ModeloAnamneseId", c => c.Int());
            AlterColumn("dbo.TblAtendimento", "ModeloAnamneseID", c => c.Int(nullable: false));
            CreateIndex("dbo.TblProntuario", "PacienteId");
            AddForeignKey("dbo.TblProntuario", "PacienteId", "dbo.TblPaciente", "PacienteId");
        }
    }
}
