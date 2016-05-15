using Microsoft.Practices.Unity;
using System.Data.Entity;
using System.Web.Http;
using Template.Core.Models;
using Unity.WebApi;

namespace Template.Web
{
    public static class UnityConfig
    {
        public static IUnityContainer RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<DbContext, ApplicationDbContext>();

            return container;
        }
    }
}