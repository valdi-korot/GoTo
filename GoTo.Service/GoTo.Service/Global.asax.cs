using Autofac;
using Autofac.Integration.WebApi;
using GoTo.Service.App_srart;
using GoTo.Service.Configurations;
using GoTo.Service.Provider.Interface.Managers;
using GoTo.Service.Provider.Managers;
using GoTo.Service.Storage.Intergace.Managers;
using GoTo.Service.Storage.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Security;
using System.Web.SessionState;

namespace GoTo.Service
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RegisterDepency();
        }

        private void RegisterDepency()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterAssemblyModules(Assembly.GetExecutingAssembly());



            builder.RegisterType<OfferManager>().As<IOfferManager>().InstancePerRequest();

            builder.RegisterType<OffersDataManager>().As<IOffersDataManager>().WithParameter("goToDbConnectionString", GoToServiceConfig.GoToDbConnectionString).InstancePerRequest();

            var container = builder.Build();
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}