using AutoMapper;

namespace WebClinica.Web.Mapeamento
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {

            Mapper.Initialize(x =>

            {
                x.AddProfile<DominioParaModelo>();
                x.AddProfile<ModeloParaDominio>();

            });

        }
    }
}