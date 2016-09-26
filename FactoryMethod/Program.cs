using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessManager processManager = new IPGProcessManager();
            Process process = processManager.Create();
            process.Start();
            Console.ReadKey();
        }
    }
}
