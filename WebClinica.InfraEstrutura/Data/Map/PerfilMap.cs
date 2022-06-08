using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;


namespace WebClinica.InfraEstrutura.Data.Map
{
    public class PerfilMap:EntityTypeConfiguration<Perfil>
    {
        public PerfilMap()
        {
            ToTable("TblPerfil");
            HasKey(x => x.PerfilId);

            Property(x => x.PerfilId);
            Property(x => x.Descricao);
            Property(x => x.Ativo);
        }
    }
}
