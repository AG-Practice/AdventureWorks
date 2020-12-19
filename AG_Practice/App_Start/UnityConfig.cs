using System.Web.Mvc;
using AG_Practice.Repository;
using AG_Practice.Service;
using AG_Practice.Service.Implementations;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace AG_Practice
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<IProductRepository, ProductRepository>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}