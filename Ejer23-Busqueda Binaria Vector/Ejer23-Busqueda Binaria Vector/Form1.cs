using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer23_Busqueda_Binaria_Vector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Vector vector=new Vector();
        private void btnCrearVector_Click(object sender, EventArgs e)
        {
            txtInformación.Text = "";
            if (txtTamaño.Text != "")
                vector.crearVector(Convert.ToInt32(txtTamaño.Text));
            else
                txtInformación.Text = "Falta información";
        }

        private void btnLlenarVector_Click(object sender, EventArgs e)
        {
            txtInformación.Text = "";
            if (txtLímite.Text != "")
                vector.llenarVector(Convert.ToInt32(txtLímite.Text));
            else
                txtInformación.Text = "Falta información";
        }

        private void btnOrdenarVector_Click(object sender, EventArgs e)
        {
            vector.ordenarVector();
        }

        private void btnMostrarVector_Click(object sender, EventArgs e)
        {
            txtInformación.Text = vector.mostrar();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (txtNumeroBusqueda.Text != ""){
                int posicion = vector.busquedaBinaria(Convert.ToInt32(txtNumeroBusqueda.Text));
                if (posicion != -1)
                    txtInformación.Text = "El número " + txtNumeroBusqueda.Text + " se encuentra en la posición: " + posicion + ".";
                else
                    txtInformación.Text = "El número " + txtNumeroBusqueda.Text + " no se encuentra en el vector.";
                txtInformación.Text += Environment.NewLine + "Después de las siguientes comparaciones: " + vector.comparaciones + ".";
            }
            else
                MessageBox.Show("Falta información de número a buscar");
            
        }
    }
}
