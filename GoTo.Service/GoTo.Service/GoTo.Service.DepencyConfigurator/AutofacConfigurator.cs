using Autofac;
using Autofac.Integration.WebApi;
using System.Web.Http;
using GoTo.Service.Storage.Managers;
using GoTo.Service.Storage.Intergace.Managers;
using GoTo.Service.Configurations;
using GoTo.Service.Provider.Interface.Managers;
using GoTo.Service.Provider.Managers;
using System.Reflection;

namespace GoTo.Service.DepencyConfigurator
{
    public sealed class AutofacConfigurator
    {
        public static void ConfigureContainer(HttpConfiguration config)
        {
            
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());

            

            builder.RegisterType<OfferManager>().As<IOfferManager>().InstancePerRequest();

           // builder.RegisterType<OffersDataManager>().As<IOffersDataManager>().WithParameter("goToDbConnectionString", GoToServiceConfig.GoToDbConnectionString).InstancePerRequest();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container); 
        }
    }
}
