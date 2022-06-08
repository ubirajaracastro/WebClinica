namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelagemTerminologiaTISS_TabelaDescricao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DescricaoTabelas",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                        DescricaoTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DescricaoTabelas");
        }
    }
}
