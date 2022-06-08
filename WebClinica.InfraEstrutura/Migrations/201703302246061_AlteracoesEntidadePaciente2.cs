namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracoesEntidadePaciente2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblPaciente", "CidadeID", "dbo.Cidade");
            DropForeignKey("dbo.TblPaciente", "EstadoID", "dbo.Estado");
            DropIndex("dbo.TblPaciente", new[] { "EstadoID" });
            DropIndex("dbo.TblPaciente", new[] { "CidadeID" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.TblPaciente", "CidadeID");
            CreateIndex("dbo.TblPaciente", "EstadoID");
            AddForeignKey("dbo.TblPaciente", "EstadoID", "dbo.Estado", "Id");
            AddForeignKey("dbo.TblPaciente", "CidadeID", "dbo.Cidade", "Id");
        }
    }
}
