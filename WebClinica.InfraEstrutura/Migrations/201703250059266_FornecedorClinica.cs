namespace WebClinica.InfraEstrutura.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FornecedorClinica : DbMigration
    {
        public override void Up()
        {
            //RenameTable(name: "dbo.TblFornecedor", newName: "Fornecedor");
            CreateTable(
                "dbo.TblFornecedorClinica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CNPJ = c.String(nullable: false, maxLength: 200, unicode: false),
                        Nome = c.String(nullable: false, maxLength: 200, unicode: false),
                        RazaoSocial = c.String(nullable: false, maxLength: 200, unicode: false),
                        NomeContato = c.String(nullable: false, maxLength: 200, unicode: false),
                        Email = c.String(nullable: false, maxLength: 200, unicode: false),
                        Telefone = c.String(nullable: false, maxLength: 200, unicode: false),
                        Endereco = c.String(maxLength: 200, unicode: false),
                        Numero = c.String(maxLength: 200, unicode: false),
                        Bairro = c.String(maxLength: 200, unicode: false),
                        Cep = c.String(maxLength: 200, unicode: false),
                        EstadoId = c.Int(nullable: false),
                        CidadeId = c.Int(nullable: false),
                        Ativo = c.Boolean(nullable: false),
                        CNPJClinica = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cidade", t => t.CidadeId)
                .ForeignKey("dbo.Estado", t => t.EstadoId)
                .Index(t => t.EstadoId)
                .Index(t => t.CidadeId);
            
            //AlterColumn("dbo.Fornecedor", "CNPJ", c => c.String(maxLength: 200, unicode: false));
            //AlterColumn("dbo.Fornecedor", "Nome", c => c.String(maxLength: 200, unicode: false));
            //AlterColumn("dbo.Fornecedor", "RazaoSocial", c => c.String(maxLength: 200, unicode: false));
            //AlterColumn("dbo.Fornecedor", "NomeContato", c => c.String(maxLength: 200, unicode: false));
            //AlterColumn("dbo.Fornecedor", "Email", c => c.String(maxLength: 200, unicode: false));
            //AlterColumn("dbo.Fornecedor", "Telefone", c => c.String(maxLength: 200, unicode: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TblFornecedorClinica", "EstadoId", "dbo.Estado");
            DropForeignKey("dbo.TblFornecedorClinica", "CidadeId", "dbo.Cidade");
            DropIndex("dbo.TblFornecedorClinica", new[] { "CidadeId" });
            DropIndex("dbo.TblFornecedorClinica", new[] { "EstadoId" });
            AlterColumn("dbo.Fornecedor", "Telefone", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.Fornecedor", "Email", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.Fornecedor", "NomeContato", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.Fornecedor", "RazaoSocial", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.Fornecedor", "Nome", c => c.String(nullable: false, maxLength: 200, unicode: false));
            AlterColumn("dbo.Fornecedor", "CNPJ", c => c.String(nullable: false, maxLength: 200, unicode: false));
            DropTable("dbo.TblFornecedorClinica");
            RenameTable(name: "dbo.Fornecedor", newName: "TblFornecedor");
        }
    }
}
