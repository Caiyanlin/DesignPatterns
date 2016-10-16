using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class Facade
    {
        private InsideClassA insideClassA= null;
        private InsideClassB insideClassB= null;
        private InsideClassC insideClassC= null;
        private InsideClassD insideClassD = null;

        public Facade()
        {
            insideClassA = new InsideClassA();
            insideClassB = new InsideClassB();
            insideClassC = new InsideClassC();
            insideClassD = new InsideClassD();
        }

        public void open()
        {
            insideClassA.Open();
            insideClassB.Open();
            insideClassC.Open();
            insideClassD.Open();
        }

        public void Close()
        {
            insideClassA.Close();
            insideClassB.Close();
            insideClassC.Close();
            insideClassD.Close();
        }

    }
}
