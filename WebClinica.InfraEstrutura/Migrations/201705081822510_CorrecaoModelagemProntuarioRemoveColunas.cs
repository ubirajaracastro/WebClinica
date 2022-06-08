namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CorrecaoModelagemProntuarioRemoveColunas : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.TblAtestado", "AtendimentoID");
            DropColumn("dbo.TblExameFisico", "AtendimentoID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TblExameFisico", "AtendimentoID", c => c.Int(nullable: false));
            AddColumn("dbo.TblAtestado", "AtendimentoID", c => c.Int(nullable: false));
        }
    }
}
