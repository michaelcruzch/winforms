namespace MiPrimerAplicacion
{
    partial class frmMiPrimerAplicacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMiPrimerAplicacion));
            this.btnBoton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBoton
            // 
            this.btnBoton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBoton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBoton.Image = ((System.Drawing.Image)(resources.GetObject("btnBoton.Image")));
            this.btnBoton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBoton.Location = new System.Drawing.Point(247, 258);
            this.btnBoton.Name = "btnBoton";
            this.btnBoton.Size = new System.Drawing.Size(272, 160);
            this.btnBoton.TabIndex = 0;
            this.btnBoton.Text = "Boton";
            this.btnBoton.UseVisualStyleBackColor = false;
            this.btnBoton.Click += new System.EventHandler(this.btnBoton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEtiqueta.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEtiqueta.Location = new System.Drawing.Point(271, 43);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(120, 30);
            this.lblEtiqueta.TabIndex = 2;
            this.lblEtiqueta.Text = "nombre:";
            this.lblEtiqueta.MouseLeave += new System.EventHandler(this.lblEtiqueta_MouseLeave);
            this.lblEtiqueta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblEtiqueta_MouseMove);
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(271, 112);
            this.txtApellido.MaxLength = 90;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 22);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(271, 185);
            this.txtNuevo.Multiline = true;
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNuevo.Size = new System.Drawing.Size(100, 22);
            this.txtNuevo.TabIndex = 4;
            this.txtNuevo.Leave += new System.EventHandler(this.txtNuevo_Leave);
            // 
            // frmMiPrimerAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBoton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMiPrimerAplicacion";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiPrimerAplicacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMiPrimerAplicacion_FormClosed);
            this.Load += new System.EventHandler(this.frmMiPrimerAplicacion_Load);
            this.Click += new System.EventHandler(this.frmMiPrimerAplicacion_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEtiqueta;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNuevo;
    }
}

