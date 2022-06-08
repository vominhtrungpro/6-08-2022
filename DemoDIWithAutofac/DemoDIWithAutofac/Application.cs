using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoDIWithAutofac;

namespace DemoDIWithAutofac
{
    public class Application : IApplication
    {
        private readonly ICar _car;

        public Application(ICar car)
        {
            _car = car;
        }

        public void Run()
        {
            _car.Press();
        }
    }
}
