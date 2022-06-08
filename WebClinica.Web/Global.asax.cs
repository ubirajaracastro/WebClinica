using AutoMapper;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebClinica.Web.Mapeamento;


namespace WebClinica.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AutoMapperConfig.RegisterMappings();  
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ModelBinders.Binders.Add(
               typeof(decimal), new DecimalModelBinder());
            ModelBinders.Binders.Add(
                typeof(decimal?), new DecimalModelBinder());

        }


    }
    public class AutoMapperConfiguration

    {
        public static void Configure()

        {
            Mapper.Initialize(x =>

            {
                x.AddProfile<DominioParaModelo>();
                x.AddProfile<ModeloParaDominio>();

            });

        }

    }

    public class Bootstrapper

    {

        public static void Run()

        {                                 
            //Configure Automapper

            AutoMapperConfiguration.Configure();

        }

    }



}
