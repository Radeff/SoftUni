using Microsoft.Owin;
using Owin;
using BlogCSharp.Migrations;
using BlogCSharp.Models;
using System.Data.Entity;

[assembly: OwinStartupAttribute(typeof(BlogCSharp.Startup))]
namespace BlogCSharp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BlogDbContext, Configuration>());
            ConfigureAuth(app);
        }
    }
}
