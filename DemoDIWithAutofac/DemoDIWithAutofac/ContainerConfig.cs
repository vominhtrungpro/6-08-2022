﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace DemoDIWithAutofac
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<Car>().As<ICar>();
            builder.RegisterType<SmallHorn>().As<IHorn>();

            return builder.Build();
        }
    }
}
