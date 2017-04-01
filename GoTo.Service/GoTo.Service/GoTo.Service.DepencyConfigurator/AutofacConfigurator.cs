using Autofac;
using Autofac.Core;
using GoTo.Service.Storage.Managers;
using GoTo.Service.Storage.Intergace.Managers;
using GoTo.Service.Configurations;
using GoTo.Service.Provider.Interface.Managers;
using GoTo.Service.Provider.Managers;

namespace GoTo.Service.DepencyConfigurator
{
    public sealed class DepencyConfigurator
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<OffersDataManager>().As<IOffersDataManager>().WithParameter("goToDbConnectionString", GoToServiceConfig.GoToDbConnectionString);

            builder.RegisterType<OfferManager>().As<IOfferManager>();

            var container = builder.Build();
        }
    }
}
