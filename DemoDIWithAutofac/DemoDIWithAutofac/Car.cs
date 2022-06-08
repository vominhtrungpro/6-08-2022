using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDIWithAutofac
{
    public class Car : ICar
    {
        private readonly IHorn _horn;

        public Car(IHorn horn)
        {
            _horn = horn;
        }

        public void Press()
        {
            Console.WriteLine("Pressing the horn");
            _horn.Beep();
            Console.WriteLine("Horn pressed");
        }
    }
}
