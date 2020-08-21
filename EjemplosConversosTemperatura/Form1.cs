using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EjemplosConversosTemperatura.clases;

namespace EjemplosConversosTemperatura
{
    public partial class Form1 : Form
    {
        //Instancia de la clase: Creación del objeto de la clase
        Temperatura temperatura = new Temperatura();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            lbltotal.Visible = true;
            double valorGrado;
            valorGrado = double.Parse(txtvalor.Text);
            temperatura.setGrados(valorGrado);
            lbltotal.Text = Convert.ToString(temperatura.convertirAFahrenheit());
        }

        private void btnconvertirkelvin_Click(object sender, EventArgs e)
        {
            lbltotal.Visible = true;
            double valorGrado;
            valorGrado = double.Parse(txtvalor.Text);
            temperatura.setGrados(valorGrado);
            lbltotal.Text = Convert.ToString(temperatura.convertirAKelvin());

        }
    }
}
