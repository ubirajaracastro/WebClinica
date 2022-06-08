namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelagemTerminologiaTISS : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TAB_18",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_19",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        RefFabricante = c.String(maxLength: 200, unicode: false),
                        Fabricante = c.String(maxLength: 200, unicode: false),
                        RegistroAnvisa = c.String(maxLength: 200, unicode: false),
                        ClasseRisco = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_20",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        Apresentacao = c.String(maxLength: 200, unicode: false),
                        Laboratorio = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_22",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_23",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_24",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_25",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_26",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_27",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_28",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_29",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_30",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_31",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_32",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_33",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_34",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_35",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_36",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_37",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_38",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_39",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_40",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_41",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_42",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_43",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_44",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_45",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_46",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_47",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_48",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_49",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_50",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_51",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_52",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_53",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_54",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_55",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_56",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_57",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_58",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_59",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        Sigla = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_60",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        DescricaoDetalhada = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_61",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_62",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Termo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_63",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CodTermo = c.String(maxLength: 200, unicode: false),
                        Grupo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TAB_64",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Terminologia = c.String(maxLength: 200, unicode: false),
                        CodigoTUSS = c.String(maxLength: 200, unicode: false),
                        FormaEnvio = c.String(maxLength: 200, unicode: false),
                        CodigoGrupo = c.String(maxLength: 200, unicode: false),
                        DescricaoGrupo = c.String(maxLength: 200, unicode: false),
                        NumeroTabela = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TAB_64");
            DropTable("dbo.TAB_63");
            DropTable("dbo.TAB_62");
            DropTable("dbo.TAB_61");
            DropTable("dbo.TAB_60");
            DropTable("dbo.TAB_59");
            DropTable("dbo.TAB_58");
            DropTable("dbo.TAB_57");
            DropTable("dbo.TAB_56");
            DropTable("dbo.TAB_55");
            DropTable("dbo.TAB_54");
            DropTable("dbo.TAB_53");
            DropTable("dbo.TAB_52");
            DropTable("dbo.TAB_51");
            DropTable("dbo.TAB_50");
            DropTable("dbo.TAB_49");
            DropTable("dbo.TAB_48");
            DropTable("dbo.TAB_47");
            DropTable("dbo.TAB_46");
            DropTable("dbo.TAB_45");
            DropTable("dbo.TAB_44");
            DropTable("dbo.TAB_43");
            DropTable("dbo.TAB_42");
            DropTable("dbo.TAB_41");
            DropTable("dbo.TAB_40");
            DropTable("dbo.TAB_39");
            DropTable("dbo.TAB_38");
            DropTable("dbo.TAB_37");
            DropTable("dbo.TAB_36");
            DropTable("dbo.TAB_35");
            DropTable("dbo.TAB_34");
            DropTable("dbo.TAB_33");
            DropTable("dbo.TAB_32");
            DropTable("dbo.TAB_31");
            DropTable("dbo.TAB_30");
            DropTable("dbo.TAB_29");
            DropTable("dbo.TAB_28");
            DropTable("dbo.TAB_27");
            DropTable("dbo.TAB_26");
            DropTable("dbo.TAB_25");
            DropTable("dbo.TAB_24");
            DropTable("dbo.TAB_23");
            DropTable("dbo.TAB_22");
            DropTable("dbo.TAB_20");
            DropTable("dbo.TAB_19");
            DropTable("dbo.TAB_18");
        }
    }
}
