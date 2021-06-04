using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using NetflixCore;

namespace Test_NetflixCore
{
    [TestClass]
    public class FuncionesAyuda_Test
    {
      
        [TestMethod]
        public void TestMethod1()
        {
            FuncionesAyuda.FormatearMinAHoras(22);

        }
    }
}
