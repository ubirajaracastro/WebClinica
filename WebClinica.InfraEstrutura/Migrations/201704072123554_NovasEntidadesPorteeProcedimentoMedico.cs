namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NovasEntidadesPorteeProcedimentoMedico : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TblPorteAnestesico",
                c => new
                    {
                        Codigo = c.String(nullable: false, maxLength: 200, unicode: false),
                        Descricao = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.TblPorteProcedimentoMedico",
                c => new
                    {
                        PorteProcedimentoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(maxLength: 200, unicode: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PorteProcedimentoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TblPorteProcedimentoMedico");
            DropTable("dbo.TblPorteAnestesico");
        }
    }
}
