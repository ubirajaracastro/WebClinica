using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using WebClinica.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;


namespace WebClinica.InfraEstrutura.Data.Map
{
    public class TabelaNormativaUSSMap:EntityTypeConfiguration<TabelaNormativaUSS>
    {
        public TabelaNormativaUSSMap()
        {

            ToTable("TblNormativaUSS");
            HasKey(x => x.TUSSId);
            

            Property(x => x.CodigoTUSS);
            Property(x => x.GrupoSubGrupoTUSS);
            Property(x => x.ProcedimentoTUSS);




        }


    }
}
