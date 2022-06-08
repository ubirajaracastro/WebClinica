namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntidadePacienteAlteracaoObrigatoriedade : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TblPacienteDadoComplementar", "EscolaridadeId", c => c.Int());
            AlterColumn("dbo.TblPacienteDadoComplementar", "ProfissaoId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TblPacienteDadoComplementar", "ProfissaoId", c => c.Int(nullable: false));
            AlterColumn("dbo.TblPacienteDadoComplementar", "EscolaridadeId", c => c.Int(nullable: false));
        }
    }
}
