using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace GoTo.Service.Configurations
{
    public sealed class GoToServiceConfig
    {
        public static string GoToDbConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["goToDbConnectionString"].ConnectionString;
            }
        }
    }
}
