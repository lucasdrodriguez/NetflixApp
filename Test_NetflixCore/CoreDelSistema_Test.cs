using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NetflixCore;

namespace Test_NetflixCore
{
    [TestClass]
    public class CoreDelSistema_Test
    {
        [TestMethod]
        public void LogearUsuario_True()
        {

            ///ARRANGE  -> establecer los parametros de inicio 
            string usuario = "lucas@lucas.com";
            string password = "megustaelte123";
            bool resultado;
            ///ACT  ->>> llamada al metodo a testear

            resultado = CoreDelSistema.LogearUsuario(usuario, password);

            /// ASSERT  -> lo que esperamos 
            Assert.IsTrue(resultado);

            usuario = "pepe@pepe.com";
            password = "RUFruf123";

            ///ACT  ->>> llamada al metodo a testear

            resultado = CoreDelSistema.LogearUsuario(usuario, password);

            /// ASSERT  -> lo que esperamos 
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        //[DataRow("lucas@lucas.com", "megustaelte123")]
        //[DataRow("pepe@pepe.com", "RUFruf123")]
        [DataRow("lucas@lucas.com", null)]
        public void LogearUsuario_True_V2(string usuario, string password)
        {
            bool resultado = CoreDelSistema.LogearUsuario(usuario, password);

            Assert.IsTrue(resultado);

        }


    }
}
