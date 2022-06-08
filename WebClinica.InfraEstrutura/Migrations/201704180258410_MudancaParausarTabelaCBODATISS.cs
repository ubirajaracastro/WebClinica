namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MudancaParausarTabelaCBODATISS : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TblProcedimento", "EspecialidadeId", "dbo.TblEspecialidade");
            DropForeignKey("dbo.TblEscalaAtendimentoProfissional", "Profissional_ProfissaoId", "dbo.TblProfissao");
            DropIndex("dbo.TblProcedimento", new[] { "EspecialidadeId" });
            DropIndex("dbo.TblEscalaAtendimentoProfissional", new[] { "Profissional_ProfissaoId" });
            AddColumn("dbo.TblProfissional", "CodigoConselhoProfissional", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AddColumn("dbo.TblProfissional", "CodigoUFConselhoProfisional", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AddColumn("dbo.TblProfissional", "CodigoCBOOcupacao", c => c.String(nullable: false, maxLength: 200, unicode: false));
            DropColumn("dbo.TblProfissional", "ProfissaoId");
            DropColumn("dbo.TblProfissional", "EspecialidadeID");
            DropColumn("dbo.TblEscalaAtendimentoProfissional", "Profissional_ProfissaoId");
            DropTable("dbo.TblEspecialidade");
            DropTable("dbo.TblProfissao");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TblProfissao",
                c => new
                    {
                        ProfissaoId = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 200, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProfissaoId);
            
            CreateTable(
                "dbo.TblEspecialidade",
                c => new
                    {
                        EspecialidadeId = c.Int(nullable: false, identity: true),
                        DescricaoEspecialidade = c.String(maxLength: 200, unicode: false),
                        Ativo = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.EspecialidadeId);
            
            AddColumn("dbo.TblEscalaAtendimentoProfissional", "Profissional_ProfissaoId", c => c.Int(nullable: false));
            AddColumn("dbo.TblProfissional", "EspecialidadeID", c => c.Int(nullable: false));
            AddColumn("dbo.TblProfissional", "ProfissaoId", c => c.Int(nullable: false));
            DropColumn("dbo.TblProfissional", "CodigoCBOOcupacao");
            DropColumn("dbo.TblProfissional", "CodigoUFConselhoProfisional");
            DropColumn("dbo.TblProfissional", "CodigoConselhoProfissional");
            CreateIndex("dbo.TblEscalaAtendimentoProfissional", "Profissional_ProfissaoId");
            CreateIndex("dbo.TblProcedimento", "EspecialidadeId");
            AddForeignKey("dbo.TblEscalaAtendimentoProfissional", "Profissional_ProfissaoId", "dbo.TblProfissao", "ProfissaoId");
            AddForeignKey("dbo.TblProcedimento", "EspecialidadeId", "dbo.TblEspecialidade", "EspecialidadeId");
        }
    }
}
