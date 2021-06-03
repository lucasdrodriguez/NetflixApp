using System.Collections.Generic;
using NetflixCore.Catalogo;

namespace NetflixCore.Personas
{
    public class Celebridad : Persona
    {
        EGenero generoPrincipal;
        List<Show> listaShowDondeTrabajo;

        public Celebridad(string nombre, string apellido, EPais paisOrigen) : base(nombre, apellido, paisOrigen)
        {
            listaShowDondeTrabajo = new List<Show>();
        }

        public Celebridad(string nombre, string apellido, EPais paisOrigen, EGenero generoPrincipal) : this(nombre, apellido, paisOrigen)
        {
            this.generoPrincipal = generoPrincipal;
        }


    }
}
