using Autofac;
using Autofac.Integration.WebApi;
using GoTo.Service.Configurations;
using GoTo.Service.Provider.Interface.Managers;
using GoTo.Service.Provider.Managers;
using GoTo.Service.Storage.Intergace.Managers;
using GoTo.Service.Storage.Managers;
using GoTo.Service.UserManager;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Reflection;
using System.Web.Http;

[assembly: OwinStartup(typeof(GoTo.Service.App_srart.Startup))]
namespace GoTo.Service.App_srart
{
    public sealed class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            ConfigureOAuth(app);
            WebApiConfig.Register(config);
            RegisterDepency(config);
            app.UseWebApi(config);
        }
        private void RegisterDepency(HttpConfiguration config)
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());



            builder.RegisterType<OfferManager>().As<IOfferManager>().InstancePerRequest();
            builder.RegisterType<AuthRepository>().AsSelf().InstancePerRequest().WithParameter("authConnectionString", GoToServiceConfig.GoToDbConnectionString);

            builder.RegisterType<OffersDataManager>().As<IOffersDataManager>().WithParameter("goToDbConnectionString", GoToServiceConfig.GoToDbConnectionString).InstancePerRequest();

            var container = builder.Build();
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
    }
}