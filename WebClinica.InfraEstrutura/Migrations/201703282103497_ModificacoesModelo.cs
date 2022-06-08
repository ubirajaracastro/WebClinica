namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificacoesModelo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TblPaciente", "ValidadeCarteira", c => c.DateTime(nullable: false));
            AddColumn("dbo.TblPaciente", "NumeroCarteira", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.TblRiscoOcupacional", "Ruido", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "Calor", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "RadiacaoNaoIonizante", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "Poeira", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "Nevoas", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "Fumo", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "Infeccoes", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "Gripe", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "Fungos", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "Bacilos", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "Virus", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "Bacterias", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "Postural", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "MovimentacaoContinua", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "LevtoTranspManualdePeso", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "TrabalhoNoturno", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "AcidentePostural", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "QuedadeMaterial", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "ManuseioPerfuroCortantes", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "AtaqueAnimaisPeconhentos", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "EsmagamentoLuxacao", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "EquipFerramentaUsoManual", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "Outros", c => c.Boolean(nullable: false));
            AddColumn("dbo.TblRiscoOcupacional", "PacienteId", c => c.Int(nullable: false));
            AddColumn("dbo.TblPacienteDadoComplementar", "RG", c => c.String(maxLength: 200, unicode: false));
            DropColumn("dbo.TblPaciente", "Password");
            DropColumn("dbo.TblPaciente", "TelefoneComercialRamal");
            DropColumn("dbo.TblRiscoOcupacional", "Descricao");
            DropTable("dbo.TblLaudoNR07");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TblLaudoNR07",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.TblRiscoOcupacional", "Descricao", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AddColumn("dbo.TblPaciente", "TelefoneComercialRamal", c => c.String(maxLength: 200, unicode: false));
            AddColumn("dbo.TblPaciente", "Password", c => c.String(nullable: false, maxLength: 200, unicode: false));
            DropColumn("dbo.TblPacienteDadoComplementar", "RG");
            DropColumn("dbo.TblRiscoOcupacional", "PacienteId");
            DropColumn("dbo.TblRiscoOcupacional", "Outros");
            DropColumn("dbo.TblRiscoOcupacional", "EquipFerramentaUsoManual");
            DropColumn("dbo.TblRiscoOcupacional", "EsmagamentoLuxacao");
            DropColumn("dbo.TblRiscoOcupacional", "AtaqueAnimaisPeconhentos");
            DropColumn("dbo.TblRiscoOcupacional", "ManuseioPerfuroCortantes");
            DropColumn("dbo.TblRiscoOcupacional", "QuedadeMaterial");
            DropColumn("dbo.TblRiscoOcupacional", "AcidentePostural");
            DropColumn("dbo.TblRiscoOcupacional", "TrabalhoNoturno");
            DropColumn("dbo.TblRiscoOcupacional", "LevtoTranspManualdePeso");
            DropColumn("dbo.TblRiscoOcupacional", "MovimentacaoContinua");
            DropColumn("dbo.TblRiscoOcupacional", "Postural");
            DropColumn("dbo.TblRiscoOcupacional", "Bacterias");
            DropColumn("dbo.TblRiscoOcupacional", "Virus");
            DropColumn("dbo.TblRiscoOcupacional", "Bacilos");
            DropColumn("dbo.TblRiscoOcupacional", "Fungos");
            DropColumn("dbo.TblRiscoOcupacional", "Gripe");
            DropColumn("dbo.TblRiscoOcupacional", "Infeccoes");
            DropColumn("dbo.TblRiscoOcupacional", "Fumo");
            DropColumn("dbo.TblRiscoOcupacional", "Nevoas");
            DropColumn("dbo.TblRiscoOcupacional", "Poeira");
            DropColumn("dbo.TblRiscoOcupacional", "RadiacaoNaoIonizante");
            DropColumn("dbo.TblRiscoOcupacional", "Calor");
            DropColumn("dbo.TblRiscoOcupacional", "Ruido");
            DropColumn("dbo.TblPaciente", "NumeroCarteira");
            DropColumn("dbo.TblPaciente", "ValidadeCarteira");
        }
    }
}
