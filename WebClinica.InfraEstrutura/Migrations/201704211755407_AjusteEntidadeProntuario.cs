namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjusteEntidadeProntuario : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblAtestado", "ClinicaId", "dbo.TblClinica");
            DropForeignKey("dbo.TblAtendimento", "AtestadoId", "dbo.TblAtestado");
            DropForeignKey("dbo.TblAtendimento", "ClinicaId", "dbo.TblClinica");
            DropForeignKey("dbo.TblAtendimento", "ConvenioId", "dbo.TblConvenio");
            DropForeignKey("dbo.TblAtendimento", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese");
            DropForeignKey("dbo.TblPrescricao", "ProfissionalId", "dbo.TblProfissional");
            DropForeignKey("dbo.TblAtendimento", "PrescricaoId", "dbo.TblPrescricao");
            DropForeignKey("dbo.TblSolicitacaoExame", "Atendimento_AtendimentoId", "dbo.TblAtendimento");
            DropIndex("dbo.TblAtestado", new[] { "PacienteId" });
            DropIndex("dbo.TblAtestado", new[] { "ClinicaId" });
            DropIndex("dbo.TblSolicitacaoExame", new[] { "Atendimento_AtendimentoId" });
            DropIndex("dbo.TblAtendimento", new[] { "ConvenioId" });
            DropIndex("dbo.TblAtendimento", new[] { "ClinicaId" });
            DropIndex("dbo.TblAtendimento", new[] { "AtestadoId" });
            DropIndex("dbo.TblAtendimento", new[] { "PrescricaoId" });
            DropIndex("dbo.TblAtendimento", new[] { "ExameFisico_ExameId" });
            DropIndex("dbo.TblAtendimento", new[] { "ModeloAnamnese_ModeloId" });
            DropIndex("dbo.TblPrescricao", new[] { "ProfissionalId" });
            RenameColumn(table: "dbo.TblAtestado", name: "PacienteId", newName: "Paciente_PacienteId");
            CreateTable(
                "dbo.TblProntuarioProcedimento",
                c => new
                    {
                        ProntuarioProcedimentoID = c.Int(nullable: false, identity: true),
                        AtendimentoID = c.Int(nullable: false),
                        CodigoProcedimento = c.String(maxLength: 200, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProntuarioProcedimentoID);
            
            CreateTable(
                "dbo.TblProntuarioRespostaAnamnese",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AtendimentoID = c.Int(nullable: false),
                        PerguntaID = c.Int(nullable: false),
                        Resposta = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.TblPaciente", "ConvenioPlanoId", c => c.Int());
            AddColumn("dbo.TblAtestado", "CNPJClinica", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.TblAtendimento", "tipoConsultaCodigo", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AddColumn("dbo.TblAtendimento", "PrescricaoMedica", c => c.String(maxLength: 400, unicode: false));
            AddColumn("dbo.TblAtendimento", "CodigoProcedimento", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.TblAtendimento", "ValorProcedimento", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.TblAtendimento", "RecemNascido", c => c.Boolean(nullable: false));
            AlterColumn("dbo.TblAtestado", "Paciente_PacienteId", c => c.Int());
            AlterColumn("dbo.TblAtendimento", "AtestadoId", c => c.Int());
            AlterColumn("dbo.TblAtendimento", "ExameFisico_ExameId", c => c.Int());
            CreateIndex("dbo.TblAtestado", "Paciente_PacienteId");
            CreateIndex("dbo.TblAtendimento", "ExameFisico_ExameId");
            DropColumn("dbo.TblAtestado", "ClinicaId");
            DropColumn("dbo.TblSolicitacaoExame", "Atendimento_AtendimentoId");
            DropColumn("dbo.TblAtendimento", "ConvenioId");
            DropColumn("dbo.TblAtendimento", "TipoAtendimentoId");
            DropColumn("dbo.TblAtendimento", "ClinicaId");
            DropColumn("dbo.TblAtendimento", "ModeloAnamnese_ModeloId");
            DropTable("dbo.TblPrescricao");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TblPrescricao",
                c => new
                    {
                        PrescricaoId = c.Int(nullable: false, identity: true),
                        ProfissionalId = c.Int(nullable: false),
                        TextoPrescricao = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.PrescricaoId);
            
            AddColumn("dbo.TblAtendimento", "ModeloAnamnese_ModeloId", c => c.Int(nullable: false));
            AddColumn("dbo.TblAtendimento", "ClinicaId", c => c.Int(nullable: false));
            AddColumn("dbo.TblAtendimento", "TipoAtendimentoId", c => c.Int(nullable: false));
            AddColumn("dbo.TblAtendimento", "ConvenioId", c => c.Int(nullable: false));
            AddColumn("dbo.TblSolicitacaoExame", "Atendimento_AtendimentoId", c => c.Int());
            AddColumn("dbo.TblAtestado", "ClinicaId", c => c.Int(nullable: false));
            DropIndex("dbo.TblAtendimento", new[] { "ExameFisico_ExameId" });
            DropIndex("dbo.TblAtestado", new[] { "Paciente_PacienteId" });
            AlterColumn("dbo.TblAtendimento", "ExameFisico_ExameId", c => c.Int(nullable: false));
            AlterColumn("dbo.TblAtendimento", "AtestadoId", c => c.Int(nullable: false));
            AlterColumn("dbo.TblAtestado", "Paciente_PacienteId", c => c.Int(nullable: false));
            DropColumn("dbo.TblAtendimento", "RecemNascido");
            DropColumn("dbo.TblAtendimento", "ValorProcedimento");
            DropColumn("dbo.TblAtendimento", "CodigoProcedimento");
            DropColumn("dbo.TblAtendimento", "PrescricaoMedica");
            DropColumn("dbo.TblAtendimento", "tipoConsultaCodigo");
            DropColumn("dbo.TblAtestado", "CNPJClinica");
            DropColumn("dbo.TblPaciente", "ConvenioPlanoId");
            DropTable("dbo.TblProntuarioRespostaAnamnese");
            DropTable("dbo.TblProntuarioProcedimento");
            RenameColumn(table: "dbo.TblAtestado", name: "Paciente_PacienteId", newName: "PacienteId");
            CreateIndex("dbo.TblPrescricao", "ProfissionalId");
            CreateIndex("dbo.TblAtendimento", "ModeloAnamnese_ModeloId");
            CreateIndex("dbo.TblAtendimento", "ExameFisico_ExameId");
            CreateIndex("dbo.TblAtendimento", "PrescricaoId");
            CreateIndex("dbo.TblAtendimento", "AtestadoId");
            CreateIndex("dbo.TblAtendimento", "ClinicaId");
            CreateIndex("dbo.TblAtendimento", "ConvenioId");
            CreateIndex("dbo.TblSolicitacaoExame", "Atendimento_AtendimentoId");
            CreateIndex("dbo.TblAtestado", "ClinicaId");
            CreateIndex("dbo.TblAtestado", "PacienteId");
            AddForeignKey("dbo.TblSolicitacaoExame", "Atendimento_AtendimentoId", "dbo.TblAtendimento", "AtendimentoId");
            AddForeignKey("dbo.TblAtendimento", "PrescricaoId", "dbo.TblPrescricao", "PrescricaoId");
            AddForeignKey("dbo.TblPrescricao", "ProfissionalId", "dbo.TblProfissional", "ProfissionalId");
            AddForeignKey("dbo.TblAtendimento", "ModeloAnamnese_ModeloId", "dbo.TblModeloAnamnese", "ModeloId");
            AddForeignKey("dbo.TblAtendimento", "ConvenioId", "dbo.TblConvenio", "ConvenioID");
            AddForeignKey("dbo.TblAtendimento", "ClinicaId", "dbo.TblClinica", "ClinicaId");
            AddForeignKey("dbo.TblAtendimento", "AtestadoId", "dbo.TblAtestado", "AtestadoId");
            AddForeignKey("dbo.TblAtestado", "ClinicaId", "dbo.TblClinica", "ClinicaId");
        }
    }
}
