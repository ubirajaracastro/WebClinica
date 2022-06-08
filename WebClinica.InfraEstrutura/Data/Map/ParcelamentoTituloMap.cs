using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebClinica.InfraEstrutura.Data.Map
{
    public class ParcelamentoTituloMap:EntityTypeConfiguration<Parcelamento>
    {
        public ParcelamentoTituloMap()
        {
            ToTable("TblParcelamentoTitulo");

            Property(x => x.TituloId);
            Property(x => x.Parcela);
            Property(x => x.Valor);
            Property(x => x.Vencto);
           

        }
    }
}
