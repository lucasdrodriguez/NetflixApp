using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixCore.Personas;
using NetflixCore;

namespace UnitTestNetflixApp
{
    [TestClass]
    public class Test_Usuario
    {


        [TestMethod]
        public void InstanciarUsuario()
        {

            Usuario miusuario = new Usuario("lucas@lucas", "ASD123",
                "lucas",
                "R", EPais.Argentina);

            Assert.IsNotNull(miusuario);
            Assert.AreEqual("lucas@lucas", miusuario.Email);




        }



    }
}
