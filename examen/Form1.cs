using examen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Windows.Forms;

namespace examen
{
    public partial class Form1 : Form
    {
        Stack<string> PilaDatos = new Stack<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearTriangulo_Click(object sender, EventArgs e)
        {
            Triangulo triangulo01 = new Triangulo();

            try
            {
                double area = triangulo01.Area(double.Parse(txtBaseTriangulo.Text), double.Parse(txtAlturaTriangulo.Text));
                triangulo01.Nombre("Triangulo");

                lblAreaNombreTriangulo.Text = "Area = " + area + "\n\r" + triangulo01.ToString();
                PilaDatos.Push(txtBaseTriangulo.Text);
                PilaDatos.Push(txtAlturaTriangulo.Text);
            }
            catch
            {
                MessageBox.Show("Error al ingresar datos");
            }
        }

        private void btnCrearRectangulo_Click(object sender, EventArgs e)
        {
            Rectangulo rectangulo01 = new Rectangulo();
            try
            {
                double area = rectangulo01.Area(double.Parse(txtBaseRectangulo.Text), double.Parse(txtAlturaRectangulo.Text));
                rectangulo01.Nombre("Rectangulo");

                lblAreaNombreRectangulo.Text = "Area = " + area + "\n\r" + rectangulo01.ToString();
                PilaDatos.Push(txtBaseRectangulo.Text);
                PilaDatos.Push(txtAlturaRectangulo.Text);
            }
            catch
            {
                MessageBox.Show("Error al ingresar datos");
            }
        }

        private void btnCrearParalelogramo_Click(object sender, EventArgs e)
        {
            Paralelogramo paralelogramo01 = new Paralelogramo();
            try
            {
                double area = paralelogramo01.Area(double.Parse(txtBaseParalelogramo.Text), double.Parse(txtAlturaParalelogramo.Text));
                paralelogramo01.Nombre("Paralelogramo");

                lblAreaNombreParalelogramo.Text = "Area = " + area + "\n\r" + paralelogramo01.ToString();
                PilaDatos.Push(txtBaseParalelogramo.Text);
                PilaDatos.Push(txtAlturaParalelogramo.Text);
            }
            catch
            {
                MessageBox.Show("Error al ingresar datos");
            }
            
        }

        private void btmMostrarPila_Click(object sender, EventArgs e)
        {
            lblPila.Text = null;
            foreach(string elementos in PilaDatos)
            {
                lblPila.Text += elementos + "\r\n";
            }
        }
    }
}
