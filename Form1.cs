using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador_V4._0
{
    public partial class Form1 : Form
    {
        List<Ordenar> Lista = new List<Ordenar>();

        public Form1()
        {
            InitializeComponent();
        }

        void Guardar_Datos()
        {
            FileStream stream = new FileStream("DatosBusqueda.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            foreach (var p in Lista)
            {
                writer.WriteLine(p.URL1);
                writer.WriteLine(p.Fecha);
            }

            writer.Close();

        }

        void Cargar_Datos()
        {
            FileStream stream = new FileStream("DatosBusqueda.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Ordenar data = new Ordenar();
                data.URL1 = reader.ReadLine();
                data.Fecha = DateTime.Parse(reader.ReadLine());
                
                Lista.Add(data);
            }
            reader.Close();
        }

        void Cargar_Datos_Combobox()
        {
            comboBox1.Items.Clear();
        foreach(var url in Lista)
            {
                comboBox1.Items.Add(url.URL1);
            }
            comboBox1.Focus();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ventanaGoogle.Navigate("https://www.google.com/");
            Cargar_Datos();
            Cargar_Datos_Combobox();
        }

        private void butAtras_Click(object sender, EventArgs e)
        {
            ventanaGoogle.GoBack();
        }

        private void butAdelante_Click(object sender, EventArgs e)
        {
            ventanaGoogle.GoForward();
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            Ordenar orden = new Ordenar();
            Regex isSearch = new Regex("^¿?([\\wáéíóú]+\\s?)+\\??$");
            if (isSearch.IsMatch(comboBox1.Text))
            {
                ventanaGoogle.Navigate($" http://www.google.com/search?q={comboBox1.Text}");
                orden.URL1 = comboBox1.Text;
                orden.Fecha = DateTime.Now;
            }
            else
            {
                comboBox1.Text = NormalizarURL.NormalizeUrl(comboBox1.Text);
                ventanaGoogle.Navigate(comboBox1.Text);
                orden.URL1 = comboBox1.Text;
                orden.Fecha = DateTime.Now;
            }

            Lista.Add(orden);
            Guardar_Datos();
            Cargar_Datos_Combobox();
           
        }

        private void ordenarPorFechadesdeMasRecienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Lista = Lista.OrderBy(p => p.Fecha).ToList();
            Cargar_Datos_Combobox();

        }

        private void ordenarPorFechadesdeMasAntiguoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista = Lista.OrderByDescending(p => p.Fecha).ToList();
            Cargar_Datos_Combobox();
        }
    }
}
