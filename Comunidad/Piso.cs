using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Piso : Propiedad
    {
        private string tipo_vivienda;
        private int numero_dormitorios;

        public string Tipo_vivienda
        {
            get
            {
                return tipo_vivienda;
            }

            set
            {
                tipo_vivienda = value;
            }
        }

        public int Numero_dormitorios
        {
            get
            {
                return numero_dormitorios;
            }

            set
            {
                numero_dormitorios = value;
            }
        }
    }
}
