using Autofac;
using Autofac.Integration.Mvc;
using Condorcet.Eshop.Interfaces;
using Condorcet.Eshop.Services;
using System.Web.Mvc;

namespace Condorcet.Eshop.App_Start
{
    public class InjectionConfig
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<EmailService>()
                   .As<IEmailService>();

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}