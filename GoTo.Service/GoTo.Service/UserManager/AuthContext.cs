using GoTo.Service.Configurations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GoTo.Service.UserManager
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext():
            base(GoToServiceConfig.GoToDbConnectionString)
        { }
    }
}