using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Propietario
    {
        private string nombre;
        private string nit;
        private string correo_electronico;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Nit
        {
            get
            {
                return nit;
            }

            set
            {
                nit = value;
            }
        }

        public string Correo_electronico
        {
            get
            {
                return correo_electronico;
            }

            set
            {
                correo_electronico = value;
            }
        }
    }
}
