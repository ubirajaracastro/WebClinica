using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;


namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ExameComplementarPCMSOMap:EntityTypeConfiguration<ExameComplementarPCMSO>
    {
        public ExameComplementarPCMSOMap()
        {
            ToTable("TblExameComplementarPCMSO");
            Property(x => x.Id);
            HasKey(x => x.Id);

            Property(x => x.PacienteId);
            Property(x => x.Descricao);
            Property(x => x.ExameClinico);
            Property(x => x.TGOTGP);
            Property(x => x.AudiometriaTonal);
            Property(x => x.AcuidadeVisual);
            Property(x => x.Oftalmologico);
            Property(x => x.ECG);
            Property(x => x.Espirometria);
            Property(x => x.EEG);
            Property(x => x.RXColunaLombar);
            Property(x => x.AvaliacooPsicologica);
            Property(x => x.RXColunaCervical);
            Property(x => x.Otoneurológico);
            Property(x => x.RXColunaDorsal);
            Property(x => x.Parecerodontológico);
            Property(x => x.Ureia);
            Property(x => x.Glicose);
            Property(x => x.Creatinina);
            Property(x => x.Reticulocitos);
            Property(x => x.RXdasMaos);
            Property(x => x.GamaGT);
            Property(x => x.VDRL);
            Property(x => x.Observacao);

           
        }
    }
}
