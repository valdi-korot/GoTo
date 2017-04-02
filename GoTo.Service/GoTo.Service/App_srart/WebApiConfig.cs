using System.Web.Http;

namespace GoTo.Service.App_srart
{
    public sealed class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();
        }
    }
}