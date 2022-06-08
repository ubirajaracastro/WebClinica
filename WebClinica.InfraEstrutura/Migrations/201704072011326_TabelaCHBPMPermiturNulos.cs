namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaCHBPMPermiturNulos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TblTabelaCBHPM", "ValorPorte", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.TblTabelaCBHPM", "Auxiliares", c => c.Int());
            AlterColumn("dbo.TblTabelaCBHPM", "ValorUCO", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.TblTabelaCBHPM", "PorteAnestesico", c => c.Int());
            AlterColumn("dbo.TblTabelaCBHPM", "QtdeFilme", c => c.Int());
            AlterColumn("dbo.TblTabelaCBHPM", "Incidencia", c => c.Int());
            AlterColumn("dbo.TblTabelaCBHPM", "ValorTotal", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TblTabelaCBHPM", "ValorTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TblTabelaCBHPM", "Incidencia", c => c.Int(nullable: false));
            AlterColumn("dbo.TblTabelaCBHPM", "QtdeFilme", c => c.Int(nullable: false));
            AlterColumn("dbo.TblTabelaCBHPM", "PorteAnestesico", c => c.Int(nullable: false));
            AlterColumn("dbo.TblTabelaCBHPM", "ValorUCO", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.TblTabelaCBHPM", "Auxiliares", c => c.Int(nullable: false));
            AlterColumn("dbo.TblTabelaCBHPM", "ValorPorte", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
