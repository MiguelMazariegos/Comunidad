using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class Propiedad
    {
        private char tipo;
        private string codigo;
        private int metros_cuadrados;
        private string codigo_propietario;
        private List<string> lista_gastos;

        public char Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public string Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public int Metros_cuadrados
        {
            get
            {
                return metros_cuadrados;
            }

            set
            {
                metros_cuadrados = value;
            }
        }

        public string Codigo_propietario
        {
            get
            {
                return codigo_propietario;
            }

            set
            {
                codigo_propietario = value;
            }
        }

        public List<string> Lista_gastos
        {
            get
            {
                return lista_gastos;
            }

            set
            {
                lista_gastos = value;
            }
        }
    }
}
