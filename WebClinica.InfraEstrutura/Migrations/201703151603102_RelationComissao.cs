namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RelationComissao : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ComissaoProcedimento", "Comissao_ComissaoId", "dbo.TblComissao");
            DropForeignKey("dbo.ComissaoProcedimento", "Procedimento_ProcedimentoId", "dbo.TblProcedimento");
            DropIndex("dbo.ComissaoProcedimento", new[] { "Comissao_ComissaoId" });
            DropIndex("dbo.ComissaoProcedimento", new[] { "Procedimento_ProcedimentoId" });
            CreateIndex("dbo.TblComissao", "ProcedimentoId");
            AddForeignKey("dbo.TblComissao", "ProcedimentoId", "dbo.TblProcedimento", "ProcedimentoId");
            DropTable("dbo.ComissaoProcedimento");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ComissaoProcedimento",
                c => new
                    {
                        Comissao_ComissaoId = c.Int(nullable: false),
                        Procedimento_ProcedimentoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Comissao_ComissaoId, t.Procedimento_ProcedimentoId });
            
            DropForeignKey("dbo.TblComissao", "ProcedimentoId", "dbo.TblProcedimento");
            DropIndex("dbo.TblComissao", new[] { "ProcedimentoId" });
            CreateIndex("dbo.ComissaoProcedimento", "Procedimento_ProcedimentoId");
            CreateIndex("dbo.ComissaoProcedimento", "Comissao_ComissaoId");
            AddForeignKey("dbo.ComissaoProcedimento", "Procedimento_ProcedimentoId", "dbo.TblProcedimento", "ProcedimentoId", cascadeDelete: true);
            AddForeignKey("dbo.ComissaoProcedimento", "Comissao_ComissaoId", "dbo.TblComissao", "ComissaoId", cascadeDelete: true);
        }
    }
}
