using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NetflixCore;
using NetflixCore.Catalogo;
using System.Collections.Generic;

namespace UnitTestNetflixApp
{
    [TestClass]
    public class Test_CoreDelSistema
    {

        private static List<Show> listaShows;
        private const string  passCorrecta = "megustaelte123";

        [TestInitialize]
        public void Initialize()
        {
            listaShows = new List<Show>();
        }



        [TestMethod]
        public void LogearUsuarioValido()
        {
            //ARRANGE -> emular la informacion para ejecutar el metodo 

            bool response;
            string user = "lucas@lucas.com";
            string pass = "megustaelte123";

            //ACT  -> llamar al metodo con la info que emule 

            response = CoreDelSistema.LogearUsuario(user, pass);

            //ASSERT -> comprobar el resultado obtenido con lo que espero 

            Assert.IsTrue(response);

        }

        [TestMethod]
        [DataRow("Luca", "megustaelte123")]
        [DataRow("Luca", "megustaelte123")]
        [DataRow("Luca", passCorrecta)]
        public void LogearUsuarioInvalido(string user, string pass)
        {


            bool response;

            response = CoreDelSistema.LogearUsuario(user, pass);

            Assert.IsFalse(response);

        }



        [TestMethod]
        [DataRow(null, "megustaelte123")]
        [DataRow("Lucas@lucas.com", null)] // user valido y conrta null 
        [DataRow("Lucas", null)]
        [DataRow(null, null)]
        [ExpectedException(typeof(NullReferenceException))]
        public void LogearUsuarioNull(string user, string pass)
        {
            CoreDelSistema.LogearUsuario(user, pass);
        }

    }
}
