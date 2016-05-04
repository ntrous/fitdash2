using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Web.Http;
using Template.Core.Models;
using Template.Web.Providers;

[assembly: OwinStartupAttribute(typeof(Template.Web.Startup))]		
namespace Template.Web
{		
    public partial class Startup
    {		
        public void Configuration(IAppBuilder app)
        {		
            HttpConfiguration config = new HttpConfiguration();		
		
            ConfigureOAuth(app);		
		
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);		
        }		
		
        public void ConfigureOAuth(IAppBuilder app)
        {
            // Configure the db context and user manager to use a single instance per request
            app.CreatePerOwinContext(ApplicationDbContext.Create);
            app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);

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