using System.Collections.Generic;
using NetflixCore.Personas;
using NetflixCore.Catalogo;

namespace NetflixCore.Catalogo
{
    public class Peliculas : Show
    {
        int duracionMin;

        public Peliculas(string nomb, string descripcion, int duracion, List<Celebridad> elencoShow, List<EGenero> generos) : base(nomb, descripcion, elencoShow, generos)
        {
            this.duracionMin = duracion;
        }

        public override string Descripcion
        {
            get { return "Este film trata sobre " + this.descripcion; }
        }

        public string Duracion
        {
            get { return FuncionesAyuda.FormatearMinAHoras(this.duracionMin); }
        }

        public bool ModificarDuracion(int duracion)
        {
            if (duracion < 10)
                return false;

            this.duracionMin = duracion;
            return true;
        }



    }
}