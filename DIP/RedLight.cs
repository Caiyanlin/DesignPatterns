using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
    public class RedLight : Light
    {
        public override void TurnOn()
        {
            Console.WriteLine("Turn On RedLight ");
        }

        public override void TurnOff()
        {
            Console.WriteLine("Turn Off RedLight ");
        }
    }
}
