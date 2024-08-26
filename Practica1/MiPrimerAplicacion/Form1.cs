using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class frmMiPrimerAplicacion : Form
    {
        public frmMiPrimerAplicacion()
        {
            InitializeComponent();
        }

        private void frmMiPrimerAplicacion_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a C#");
        }

        private void frmMiPrimerAplicacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("nos vemos pronto");
        }

        private void btnBoton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se disparo el evento CLICK", "ATENCION");
            //this.BackColor = Color.Blue;

            if (txtApellido.Text == "")
                txtApellido.BackColor = Color.Red;
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;
                    
        }

        private void frmMiPrimerAplicacion_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el boton izquierdo", "ATENCION");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el boton derecho", "atencion");
            else if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el boton del medio", "atencion");

        }

        private void lblEtiqueta_MouseMove(object sender, MouseEventArgs e)
        {
            lblEtiqueta.BackColor = Color.Cyan;
            lblEtiqueta.Cursor = Cursors.Hand;

           
        }

        private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
        {
            lblEtiqueta.BackColor = System.Drawing.SystemColors.Control;
            lblEtiqueta.Cursor = Cursors.Arrow;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void txtNuevo_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtNuevo.Text.Length + "Carateres");
        }
    }
}
