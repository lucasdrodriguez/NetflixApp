using NetflixCore.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCore.Test
{
    [TestClass]
    public class CoreDelSistemaShould
    {
        [DataRow("error", "errorito")]
        [DataRow("asdasd", "dasdsa")]
        [TestMethod]
        public void DevolverNuloEnUserNoValido(string usuario, string pass)
        {
            Usuario usuarioEsperado;

            usuarioEsperado = CoreDelSistema.LogearUsuario(usuario, pass);

            Assert.IsNull(usuarioEsperado);

        }


        [ExpectedException(typeof(ArgumentNullException))]
        [TestMethod]
        public void DevolverExcepcionCuandoMailEsNull()
        {
            CoreDelSistema.LogearUsuario("asd", "asd123");
        }


        [DataRow("Lucas@lucas.com", "megustaelte123")]
        [DataRow("LUCAS@lucas.COM", "megustaelte123")]
        [TestMethod]
        public void DevolverUserValido(string usuario, string pass)
        {
            Usuario usuarioEsperado;

            usuarioEsperado = CoreDelSistema.LogearUsuario(usuario, pass);

            Assert.IsNotNull(usuarioEsperado);
            Assert.AreEqual(usuarioEsperado.Email.ToLower(), usuario.ToLower());
        }


    }
}
