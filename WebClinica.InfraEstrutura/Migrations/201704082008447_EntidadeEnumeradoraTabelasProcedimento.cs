namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntidadeEnumeradoraTabelasProcedimento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblTabelasProcedimento",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblTabelasProcedimento");
        }
    }
}
