using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datos_Personales
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;

            if (txtNombre.Text == "")
                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.ControlDark;

            if (txtEdad.Text == "")
                txtEdad.BackColor = Color.Red;
            else
                txtNombre.BackColor = System.Drawing.SystemColors.ControlDark;

            if (txtDireccion.Text == "")
                txtDireccion.BackColor = Color.Red;
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.ControlDark;


            string textoApellido = txtApellido.Text;
            string textoNombre = txtNombre.Text;
            string textoEdad = txtEdad.Text;
            string textoDireccion = txtDireccion.Text;


            txtResultado.Text = "Apellido y Nombre: " + textoApellido + " " + textoNombre + " Edad: " + textoEdad + " Direccion: " + textoDireccion;
          
        }

        private void frmDatosPersonales_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("hasta pronto");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
