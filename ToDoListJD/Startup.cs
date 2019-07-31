using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ToDoListJD.Startup))]
namespace ToDoListJD
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
