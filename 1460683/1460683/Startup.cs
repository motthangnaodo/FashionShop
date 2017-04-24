using Microsoft.Owin;
using Owin;
using System;
[assembly: OwinStartupAttribute(typeof(_1460683.Startup))]
namespace _1460683
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
