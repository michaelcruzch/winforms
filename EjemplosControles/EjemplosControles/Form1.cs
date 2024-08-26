using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboColorFavorito.Items.Add("Rojo");
            cboColorFavorito.Items.Add("verde");
            cboColorFavorito.Items.Add("azul");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            //OPERADOR TERNARIO (es como un IF en una sola linea)
            //"si el checkbox está chequeado- si esto es verdadero, si es TRUE le pondra , si es FALSE es
            string chocolate = ckbChocolate.Checked == true ? "le gusta el chocolate" : "odia el chocolate";

            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";


            string colorFavorito = cboColorFavorito.SelectedItem.ToString();

            string numeroFavorito = numNumeroFavorito.Value.ToString();

            string mensaje = chocolate + " ,es  " + tipo + " su color es: " + colorFavorito + " su numero es: " + numeroFavorito;
            MessageBox.Show("Nombre: " + nombre + " Fecha: " + fecha + mensaje);
        }
    }
}
