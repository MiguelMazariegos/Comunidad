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
            string archivo_comunidad = "C:\\Users\\Miguel Mazariegos\\Documents\\Visual Studio 2015\\Projects\\Programacion III\\Comunidad\\Comunidad\\comunidad.txt";
            FileStream stream1 = new FileStream(archivo_comunidad, FileMode.Open, FileAccess.Read);
            StreamReader lectura1 = new StreamReader(stream1);
            while (lectura1.Peek() > -1)
            {
                Comunidad comunidadtemp = new Comunidad();
                comunidadtemp.Identificacion = lectura1.ReadLine();
                comunidadtemp.Nombre = lectura1.ReadLine();
                comunidadtemp.Poblacion = lectura1.ReadLine();
                comunidades.Add(comunidadtemp);
            }
            lectura1.Close();
            string archivo_gastos = "C:\\Users\\Miguel Mazariegos\\Documents\\Visual Studio 2015\\Projects\\Programacion III\\Comunidad\\Comunidad\\gastos.txt";
            FileStream stream2 = new FileStream(archivo_gastos, FileMode.Open, FileAccess.Read);
            StreamReader lectura2 = new StreamReader(stream2);
            while (lectura2.Peek() > -1)
            {
                Gastos gastostemp = new Gastos();
                string[] dividida = lectura2.ReadLine().Split(';');
                for (int i = 0; i < dividida.Count(); i++)
                {
                    if (i == 0)
                        gastostemp.Identificacion = Convert.ToChar(dividida[i]);
                    else if (i == 1)
                        gastostemp.Nombre = dividida[i];
                    else gastostemp.Tipo_reparto = Convert.ToChar(dividida[i]);
                }
                gastos.Add(gastostemp);
            }
            lectura2.Close();
            string archivo_propiedades = "C:\\Users\\Miguel Mazariegos\\Documents\\Visual Studio 2015\\Projects\\Programacion III\\Comunidad\\Comunidad\\propiedades.txt";
            FileStream stream3 = new FileStream(archivo_propiedades, FileMode.Open, FileAccess.Read);
            StreamReader lectura3 = new StreamReader(stream3);
            while (lectura3.Peek() > -1)
            {
                Local localtemp = new Local();
                Piso pisotemp = new Piso();
                Garaje garajetemp = new Garaje();
                string[] dividida = lectura3.ReadLine().Split(';');
                for (int k = 0; k < 6; k++)
                {
                   if(dividida[k]=="L")
                    {
                        for (int i = 0; i < dividida.Count(); i++)
                        {
                            if (i == 0)
                                localtemp.Tipo = Convert.ToChar(dividida[i]);
                            else if (i == 1)
                                localtemp.Codigo = dividida[i];
                            else if (i == 2)
                                localtemp.Metros_cuadrados = Convert.ToInt32(dividida[i]);
                            else if (i == 3)
                                localtemp.Codigo_propietario = dividida[i];
                            else if (i == 4)
                            {
                                List<string> temp = new List<string>();
                                string[] temps = dividida[i].Split(',');
                                foreach (string n in temps)
                                {
                                    temp.Add(n);
                                }
                                localtemp.Lista_gastos = temp;
                            }
                            else if (i == 5)
                                localtemp.Nombre_comercio = dividida[i];
                            else if (i == 6)
                                localtemp.Actividad = dividida[i];
                        }
                        locales.Add(localtemp);
                    }
                   else if(dividida[k]=="P")
                    {
                        for (int i = 0; i < dividida.Count(); i++)
                        {
                            if (i == 0)
                                pisotemp.Tipo = Convert.ToChar(dividida[i]);
                            else if (i == 1)
                                pisotemp.Codigo = dividida[i];
                            else if (i == 2)
                                pisotemp.Metros_cuadrados = Convert.ToInt32(dividida[i]);
                            else if (i == 3)
                                pisotemp.Codigo_propietario = dividida[i];
                            else if (i == 4)
                            {
                                List<string> temp = new List<string>();
                                string[] temps = dividida[i].Split(',');
                                foreach (string n in temps)
                                {
                                    temp.Add(n);
                                }
                                pisotemp.Lista_gastos = temp;
                            }
                            else if (i == 5)
                                pisotemp.Tipo_vivienda = dividida[i];
                            else if (i == 6)
                                pisotemp.Numero_dormitorios = Convert.ToInt32(dividida[i]);
                        }
                        pisos.Add(pisotemp);
                    }
                   else if(dividida[k]=="G")
                    {
                        for (int i = 0; i < dividida.Count(); i++)
                        {
                            if (i == 0)
                                garajetemp.Tipo = Convert.ToChar(dividida[i]);
                            else if (i == 1)
                                garajetemp.Codigo = dividida[i];
                            else if (i == 2)
                                garajetemp.Metros_cuadrados = Convert.ToInt32(dividida[i]);
                            else if (i == 3)
                                garajetemp.Codigo_propietario = dividida[i];
                            else if (i == 4)
                            {
                                List<string> temp = new List<string>();
                                string[] temps = dividida[i].Split(',');
                                foreach (string n in temps)
                                {
                                    temp.Add(n);
                                }
                                garajetemp.Lista_gastos = temp;
                            }
                            else if (i == 5)
                                garajetemp.Estado = Convert.ToChar(dividida[i]);
                            else if (i == 6)
                                garajetemp.Bodega = Convert.ToChar(dividida[i]);
                        }
                        garajes.Add(garajetemp);
                    }
                }              
            }
            lectura3.Close();
            string archivo_propietarios = "C:\\Users\\Miguel Mazariegos\\Documents\\Visual Studio 2015\\Projects\\Programacion III\\Comunidad\\Comunidad\\propietarios.txt";
            FileStream stream4 = new FileStream(archivo_propietarios, FileMode.Open, FileAccess.Read);
            StreamReader lectura4 = new StreamReader(stream4);
            while (lectura4.Peek() > -1)
            {
                Propietario propietariotemp = new Propietario();
                string[] dividida = lectura4.ReadLine().Split(';');
                for (int i = 0; i < dividida.Count(); i++)
                {
                    if (i == 0)
                        propietariotemp.Nombre = dividida[i];
                    else if (i == 1)
                        propietariotemp.Nit = dividida[i];
                    else propietariotemp.Correo_electronico = dividida[i];
                }
                propietarios.Add(propietariotemp);
            }
            lectura4.Close();
            string archivo_gastospropietarios = "C:\\Users\\Miguel Mazariegos\\Documents\\Visual Studio 2015\\Projects\\Programacion III\\Comunidad\\Comunidad\\gastos_propietarios.txt";
            FileStream stream5 = new FileStream(archivo_gastospropietarios, FileMode.Open, FileAccess.Read);
            StreamReader lectura5 = new StreamReader(stream5);
            while (lectura5.Peek() > -1)
            {
                GastosPropietario gastosptemp = new GastosPropietario();
                string[] dividida = lectura5.ReadLine().Split(';');
                for (int i = 0; i < dividida.Count(); i++)
                {
                    if (i == 0)
                        gastosptemp.Id_gasto = dividida[i];
                    else if (i == 1)
                        gastosptemp.Descripcion = dividida[i];
                    else if (i==2)
                        gastosptemp.Importe = Convert.ToDecimal(dividida[i]);
                    else gastosptemp.Tipo_gasto = Convert.ToChar(dividida[i]);
                }
                gastos_propietario.Add(gastosptemp);
            }
            lectura5.Close();
        }
    }
}
