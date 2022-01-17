using Autofac;
using Autofac.Integration.Mvc;
using MvcFrameworkEmpleadosReto.Data;
using MvcFrameworkEmpleadosReto.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MvcFrameworkEmpleadosReto.App_Start
{
    public class IoCConfigurationAutofac
    {
        public static void ConfigureDependencies()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.Register(z => new EmpleadosContext()).InstancePerRequest();
            builder.RegisterType<RepositoryEmpleados>().InstancePerRequest();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            IContainer container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}