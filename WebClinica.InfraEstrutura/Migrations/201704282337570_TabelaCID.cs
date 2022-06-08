namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaCID : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCID",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodigoCID = c.String(maxLength: 200, unicode: false),
                        DescricaoCID = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AlterColumn("dbo.TblAtendimento", "ModeloAnamneseID", c => c.Int());
            AlterColumn("dbo.TblAtendimento", "ModeloAnamneseId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TblAtendimento", "ModeloAnamneseId", c => c.Int());
            AlterColumn("dbo.TblAtendimento", "ModeloAnamneseID", c => c.Int(nullable: false));
            DropTable("dbo.tblCID");
        }
    }
}
