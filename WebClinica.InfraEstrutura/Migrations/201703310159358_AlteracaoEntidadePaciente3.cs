namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracaoEntidadePaciente3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblPacienteDadoComplementar", "EscolaridadeId", "dbo.TblEscolaridade");
            DropForeignKey("dbo.TblPacienteDadoComplementar", "ProfissaoId", "dbo.TblProfissao");
            DropIndex("dbo.TblPacienteDadoComplementar", new[] { "EscolaridadeId" });
            DropIndex("dbo.TblPacienteDadoComplementar", new[] { "ProfissaoId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.TblPacienteDadoComplementar", "ProfissaoId");
            CreateIndex("dbo.TblPacienteDadoComplementar", "EscolaridadeId");
            AddForeignKey("dbo.TblPacienteDadoComplementar", "ProfissaoId", "dbo.TblProfissao", "ProfissaoId");
            AddForeignKey("dbo.TblPacienteDadoComplementar", "EscolaridadeId", "dbo.TblEscolaridade", "EscolaridadeId");
        }
    }
}
