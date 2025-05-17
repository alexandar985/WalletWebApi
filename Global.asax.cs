using Autofac;
using Autofac.Integration.WebApi;
using System.Diagnostics;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using WalletWebApi.Controllers;
using WalletWebApi.Domain.Exceptions;
using WalletWebApi.Infrastructure;
using WalletWebApi.Interfaces;
using WalletWebApi.Services;

namespace WalletWebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            //autofac

            var builder = new ContainerBuilder();

            // Get your HttpConfiguration.
            var config = GlobalConfiguration.Configuration;


            config.Services.Add(typeof(IExceptionLogger),
     new GlobalExceptionLogger(new
     TraceSource("MyTraceSource", SourceLevels.All)));

            // Register DbContext (instance per request)
            builder.RegisterType<WalletDbContext>()
                   .AsSelf()
                   .InstancePerRequest();  // or .InstancePerLifetimeScope()

            // Register your repositories
            builder.RegisterType<WalletRepository>().As<IWalletRepository>().InstancePerRequest();
            builder.RegisterType<WalletEventRepository>().As<IWalletEventRepository>().InstancePerRequest();

            builder.RegisterType<WalletService>().As<IWalletService>();

            // Register your Web API controllers.
            //builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<WalletController>().InstancePerRequest();


            // OPTIONAL: Register the Autofac filter provider.
            builder.RegisterWebApiFilterProvider(config);

            // OPTIONAL: Register the Autofac model binder provider.
            builder.RegisterWebApiModelBinderProvider();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);




            /*
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
             */
        }
    }
}
