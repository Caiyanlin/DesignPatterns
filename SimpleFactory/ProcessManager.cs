using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public class ProcessManager
    {
        public static Process GetProcess(String Team)
        {
            Process process = null;
            switch (Team.ToUpper())
            {
                case "PSG":
                    process = new PSGProcess();
                    break;
                case "IPG":
                    process = new PSGProcess();
                    break;
                default:
                    throw new Exception("Unkown Team Name");
            }

            return process;
        }


    }
}
