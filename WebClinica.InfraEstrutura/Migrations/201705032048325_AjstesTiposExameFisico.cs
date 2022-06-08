namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AjstesTiposExameFisico : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TblExameFisico", "Peso", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.TblExameFisico", "FrequenciaRespiratoria", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.TblExameFisico", "Altura", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.TblExameFisico", "FrequenciaCardiaca", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.TblExameFisico", "PressãoArterialsistotica", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.TblExameFisico", "Temperatura", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.TblExameFisico", "PressãoArterialdiastolica", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.TblExameFisico", "Hemoglucoteste", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TblExameFisico", "Hemoglucoteste", c => c.Double(nullable: false));
            AlterColumn("dbo.TblExameFisico", "PressãoArterialdiastolica", c => c.Double(nullable: false));
            AlterColumn("dbo.TblExameFisico", "Temperatura", c => c.Double(nullable: false));
            AlterColumn("dbo.TblExameFisico", "PressãoArterialsistotica", c => c.Double(nullable: false));
            AlterColumn("dbo.TblExameFisico", "FrequenciaCardiaca", c => c.Double(nullable: false));
            AlterColumn("dbo.TblExameFisico", "Altura", c => c.Double(nullable: false));
            AlterColumn("dbo.TblExameFisico", "FrequenciaRespiratoria", c => c.Double(nullable: false));
            AlterColumn("dbo.TblExameFisico", "Peso", c => c.Double(nullable: false));
        }
    }
}
