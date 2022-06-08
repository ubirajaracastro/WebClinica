namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteracoesModelo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TblAtendimento", "ModeloAnamneseID", c => c.Int());
            CreateIndex("dbo.TblAtendimento", "AtestadoId");
            CreateIndex("dbo.TblProntuarioProcedimento", "AtendimentoID");
            AddForeignKey("dbo.TblAtendimento", "AtestadoId", "dbo.TblAtestado", "AtestadoId");
            AddForeignKey("dbo.TblProntuarioProcedimento", "AtendimentoID", "dbo.TblAtendimento", "AtendimentoId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TblProntuarioProcedimento", "AtendimentoID", "dbo.TblAtendimento");
            DropForeignKey("dbo.TblAtendimento", "AtestadoId", "dbo.TblAtestado");
            DropIndex("dbo.TblProntuarioProcedimento", new[] { "AtendimentoID" });
            DropIndex("dbo.TblAtendimento", new[] { "AtestadoId" });
            AlterColumn("dbo.TblAtendimento", "ModeloAnamneseID", c => c.Int(nullable: false));
        }
    }
}
