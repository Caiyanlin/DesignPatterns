using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP
{
    public class Swhitch
    {
        public ISwitchable swhithable;
    
        public void Toggle()
        {
            swhithable.TurnOff();
            swhithable.TurnOn();
        }
    }
}
