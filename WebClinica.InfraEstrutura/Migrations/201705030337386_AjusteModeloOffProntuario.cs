namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjusteModeloOffProntuario : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblAtendimento", "AtestadoId", "dbo.TblAtestado");
            DropForeignKey("dbo.TblAtendimento", "ExameFisico_ExameId", "dbo.TblExameFisico");
            DropIndex("dbo.TblAtendimento", new[] { "AtestadoId" });
            DropIndex("dbo.TblAtendimento", new[] { "ExameFisico_ExameId" });
            AddColumn("dbo.TblAtestado", "Atendimento_AtendimentoId", c => c.Int(nullable: false));
            AddColumn("dbo.TblExameFisico", "Atendimento_AtendimentoId", c => c.Int(nullable: false));
            CreateIndex("dbo.TblAtestado", "Atendimento_AtendimentoId");
            CreateIndex("dbo.TblExameFisico", "Atendimento_AtendimentoId");
            AddForeignKey("dbo.TblAtestado", "Atendimento_AtendimentoId", "dbo.TblAtendimento", "AtendimentoId");
            AddForeignKey("dbo.TblExameFisico", "Atendimento_AtendimentoId", "dbo.TblAtendimento", "AtendimentoId");
            DropColumn("dbo.TblAtestado", "AtendimentoId");
            DropColumn("dbo.TblAtendimento", "ExameFisico_ExameId");
            DropColumn("dbo.TblExameFisico", "AtendimentoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblExameFisico", "AtendimentoId", c => c.Int(nullable: false));
            AddColumn("dbo.TblAtendimento", "ExameFisico_ExameId", c => c.Int());
            AddColumn("dbo.TblAtestado", "AtendimentoId", c => c.Int(nullable: false));
            DropForeignKey("dbo.TblExameFisico", "Atendimento_AtendimentoId", "dbo.TblAtendimento");
            DropForeignKey("dbo.TblAtestado", "Atendimento_AtendimentoId", "dbo.TblAtendimento");
            DropIndex("dbo.TblExameFisico", new[] { "Atendimento_AtendimentoId" });
            DropIndex("dbo.TblAtestado", new[] { "Atendimento_AtendimentoId" });
            DropColumn("dbo.TblExameFisico", "Atendimento_AtendimentoId");
            DropColumn("dbo.TblAtestado", "Atendimento_AtendimentoId");
            CreateIndex("dbo.TblAtendimento", "ExameFisico_ExameId");
            CreateIndex("dbo.TblAtendimento", "AtestadoId");
            AddForeignKey("dbo.TblAtendimento", "ExameFisico_ExameId", "dbo.TblExameFisico", "ExameId");
            AddForeignKey("dbo.TblAtendimento", "AtestadoId", "dbo.TblAtestado", "AtestadoId");
        }
    }
}
