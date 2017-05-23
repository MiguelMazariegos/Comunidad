using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Comunidad
{
    public partial class Form1 : Form
    {
        List<Comunidad> comunidades = new List<Comunidad>();
        List<Gastos> gastos = new List<Gastos>();
        List<Piso> pisos = new List<Piso>();
        List<Local> locales = new List<Local>();
        List<Garaje> garajes = new List<Garaje>();
        List<Propietario> propietarios = new List<Propietario>();
        List<GastosPropietario> gastos_propietario = new List<GastosPropietario>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string nombreA = "C:\\Users\\Miguel Mazariegos\\Documents\\Visual Studio 2015\\Projects\\Programacion III\\Comunidad\\Comunidad\\comunidad.txt";
            FileStream stream = new FileStream(nombreA, FileMode.Open, FileAccess.Read);
            StreamReader lectura = new StreamReader(stream);
            while (lectura.Peek() > -1)
            {
                Comunidad comunidadtemp = new Comunidad();
                comunidadtemp.Identificacion = lectura.ReadLine();
                comunidadtemp.Nombre = lectura.ReadLine();
                comunidadtemp.Poblacion = lectura.ReadLine();
                comunidades.Add(comunidadtemp);
            }
            lectura.Close();
            dataGridView1.DataSource = comunidades;
            dataGridView1.Refresh();
        }
    }
}
