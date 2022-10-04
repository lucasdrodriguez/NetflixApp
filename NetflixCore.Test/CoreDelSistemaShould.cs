using NetflixCore.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCore.Test
{
    [TestClass]
    public class CoreDelSistemaShould
    {

        [TestMethod]
        public void DevolverNuloEnUserNoValido() 
        {
            //GIVEN           ARRANGE
            string userPrueba = "error";
            string contraPrueba = "errorito";
            Usuario usuarioEsperado;

            //WHEN            ACT

            usuarioEsperado = CoreDelSistema.LogearUsuario(userPrueba, contraPrueba);

            //THEN            ASSERT

            Assert.IsNull(usuarioEsperado);

        }

        [TestMethod]
        public void DevolverUserValido() 
        {
            //GIVEN           ARRANGE
            string userPrueba = "LUCAS@lucas.com";
            string contraPrueba = "megustaelte123";
            Usuario usuarioEsperado;

            //WHEN            ACT

            usuarioEsperado = CoreDelSistema.LogearUsuario(userPrueba, contraPrueba);

            //THEN            ASSERT

            Assert.IsNotNull(usuarioEsperado);
            Assert.AreEqual(usuarioEsperado.Email, userPrueba);
        }

    }
}
