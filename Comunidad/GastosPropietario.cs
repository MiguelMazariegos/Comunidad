using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comunidad
{
    class GastosPropietario
    {
        private string id_gasto;
        private string descripcion;
        private int importe;
        private char tipo_gasto;

        public string Id_gasto
        {
            get
            {
                return id_gasto;
            }

            set
            {
                id_gasto = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int Importe
        {
            get
            {
                return importe;
            }

            set
            {
                importe = value;
            }
        }

        public char Tipo_gasto
        {
            get
            {
                return tipo_gasto;
            }

            set
            {
                tipo_gasto = value;
            }
        }
    }
}
