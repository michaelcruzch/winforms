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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe esta ventana abierta, termine de trabajar alli");
                    return;
                }
                    
            }



            Form1 ventana = new Form1(); //creo la ventana
            ventana.MdiParent = this;  
            //ventana.ShowDialog();         // le pido a la ventana que se muestre . se le agrego "dialog" para que no se abran multiples ventanas.
            ventana.Show();
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.ShowDialog();
        }
    }
}
