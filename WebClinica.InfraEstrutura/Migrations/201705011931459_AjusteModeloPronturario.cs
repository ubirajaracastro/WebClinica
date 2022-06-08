namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjusteModeloPronturario : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TblAtendimento", "ModeloAnamneseID", c => c.Int());
            AlterColumn("dbo.TblAtendimento", "ModeloAnamneseId", c => c.Int(nullable: false));
            DropColumn("dbo.TblAtendimento", "tipoConsultaCodigo");
            DropColumn("dbo.TblAtendimento", "CodigoProcedimento");
            DropColumn("dbo.TblAtendimento", "ValorProcedimento");
            DropColumn("dbo.TblAtendimento", "RecemNascido");
            DropColumn("dbo.TblProntuarioProcedimento", "Valor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblProntuarioProcedimento", "Valor", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.TblAtendimento", "RecemNascido", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblAtendimento", "ValorProcedimento", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.TblAtendimento", "CodigoProcedimento", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.TblAtendimento", "tipoConsultaCodigo", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.TblAtendimento", "ModeloAnamneseId", c => c.Int());
            AlterColumn("dbo.TblAtendimento", "ModeloAnamneseID", c => c.Int(nullable: false));
        }
    }
}
