namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoModelagemProntuario : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblAtestado", "Atendimento_AtendimentoId", "dbo.TblAtendimento");
            DropForeignKey("dbo.TblExameFisico", "Atendimento_AtendimentoId", "dbo.TblAtendimento");
            DropIndex("dbo.TblAtestado", new[] { "Atendimento_AtendimentoId" });
            DropIndex("dbo.TblExameFisico", new[] { "Atendimento_AtendimentoId" });
            AddColumn("dbo.TblAtestado", "AtendimentoID", c => c.Int(nullable: false));
            AddColumn("dbo.TblAtendimento", "Atestado_AtestadoId", c => c.Int());
            AddColumn("dbo.TblAtendimento", "ExameFisico_ExameId", c => c.Int());
            AddColumn("dbo.TblExameFisico", "AtendimentoID", c => c.Int(nullable: false));
            CreateIndex("dbo.TblAtendimento", "Atestado_AtestadoId");
            CreateIndex("dbo.TblAtendimento", "ExameFisico_ExameId");
            AddForeignKey("dbo.TblAtendimento", "Atestado_AtestadoId", "dbo.TblAtestado", "AtestadoId");
            AddForeignKey("dbo.TblAtendimento", "ExameFisico_ExameId", "dbo.TblExameFisico", "ExameId");
            DropColumn("dbo.TblAtestado", "Atendimento_AtendimentoId");
            DropColumn("dbo.TblExameFisico", "Atendimento_AtendimentoId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblExameFisico", "Atendimento_AtendimentoId", c => c.Int(nullable: false));
            AddColumn("dbo.TblAtestado", "Atendimento_AtendimentoId", c => c.Int(nullable: false));
            DropForeignKey("dbo.TblAtendimento", "ExameFisico_ExameId", "dbo.TblExameFisico");
            DropForeignKey("dbo.TblAtendimento", "Atestado_AtestadoId", "dbo.TblAtestado");
            DropIndex("dbo.TblAtendimento", new[] { "ExameFisico_ExameId" });
            DropIndex("dbo.TblAtendimento", new[] { "Atestado_AtestadoId" });
            DropColumn("dbo.TblExameFisico", "AtendimentoID");
            DropColumn("dbo.TblAtendimento", "ExameFisico_ExameId");
            DropColumn("dbo.TblAtendimento", "Atestado_AtestadoId");
            DropColumn("dbo.TblAtestado", "AtendimentoID");
            CreateIndex("dbo.TblExameFisico", "Atendimento_AtendimentoId");
            CreateIndex("dbo.TblAtestado", "Atendimento_AtendimentoId");
            AddForeignKey("dbo.TblExameFisico", "Atendimento_AtendimentoId", "dbo.TblAtendimento", "AtendimentoId");
            AddForeignKey("dbo.TblAtestado", "Atendimento_AtendimentoId", "dbo.TblAtendimento", "AtendimentoId");
        }
    }
}
