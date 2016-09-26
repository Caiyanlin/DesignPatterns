using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
    public class BlueLight : Light
    {
        public override void TurnOn()
        {
            Console.WriteLine("Turn On BlueLight ");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Turn Off BlueLight ");
        }
    }
}
