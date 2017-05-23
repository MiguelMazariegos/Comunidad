using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Gastos
    {
        char identificacion;
        string nombre;
        char tipo_reparto;

        public char Identificacion
        {
            get
            {
                return identificacion;
            }

            set
            {
                identificacion = value;
            }
        }

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

        public char Tipo_reparto
        {
            get
            {
                return tipo_reparto;
            }

            set
            {
                tipo_reparto = value;
            }
        }
    }
}
