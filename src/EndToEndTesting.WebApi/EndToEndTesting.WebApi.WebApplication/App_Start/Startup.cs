using System.Reflection;
using System.Web.Http;
using Microsoft.Owin;
using Ninject;
using Owin;
using Ninject.Web.WebApi.OwinHost;
using Ninject.Web.Common.OwinHost;
using Ninject.Web.WebApi;

[assembly: OwinStartup(typeof(EndToEndTesting.WebApi.WebApplication.Startup))]
namespace EndToEndTesting.WebApi.WebApplication
{
    public class Startup
    {
        public static IKernel Kernel { get; set; }

        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();

            config.DependencyResolver = new NinjectDependencyResolver(CreateKernel());

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            app.UseNinjectMiddleware(CreateKernel);
            app.UseNinjectWebApi(config);
        }

        private IKernel CreateKernel()
        {
            Kernel = new StandardKernel();
            //Kernel.Bind(x => x.FromThisAssembly().SelectAllClasses().BindAllInterfaces());
            Kernel.Load(Assembly.GetExecutingAssembly());
            return Kernel;
        }
    }
}