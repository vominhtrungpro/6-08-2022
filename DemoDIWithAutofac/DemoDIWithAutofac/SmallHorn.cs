using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDIWithAutofac
{
    public class SmallHorn : IHorn
    {
        public void Beep()
        {
            Console.WriteLine("Beep beep beep");
        }
    }
}
