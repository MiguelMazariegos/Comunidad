using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Local : Propiedad
    {
        private string nombre_comercio;
        private string actividad;

        public string Nombre_comercio
        {
            get
            {
                return nombre_comercio;
            }

            set
            {
                nombre_comercio = value;
            }
        }

        public string Actividad
        {
            get
            {
                return actividad;
            }

            set
            {
                actividad = value;
            }
        }
    }
}
