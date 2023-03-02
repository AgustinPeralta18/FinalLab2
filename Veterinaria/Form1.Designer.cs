
namespace Veterinaria
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelTituloPanelIzquierdo = new System.Windows.Forms.Label();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.picturePrincipalHija = new System.Windows.Forms.PictureBox();
            this.panelMenuLateral.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePrincipalHija)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(139)))), ((int)(((byte)(0)))));
            this.panelMenuLateral.Controls.Add(this.btnLista);
            this.panelMenuLateral.Controls.Add(this.btnRegistrar);
            this.panelMenuLateral.Controls.Add(this.panelLogo);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(326, 420);
            this.panelMenuLateral.TabIndex = 0;
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.White;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Location = new System.Drawing.Point(3, 223);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(313, 51);
            this.btnLista.TabIndex = 2;
            this.btnLista.Text = "Lista de Mascotas";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Location = new System.Drawing.Point(3, 143);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(313, 51);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar Mascota";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelTituloPanelIzquierdo);
            this.panelLogo.Controls.Add(this.logoBox);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(326, 97);
            this.panelLogo.TabIndex = 0;
            // 
            // labelTituloPanelIzquierdo
            // 
            this.labelTituloPanelIzquierdo.AutoSize = true;
            this.labelTituloPanelIzquierdo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPanelIzquierdo.Location = new System.Drawing.Point(94, 41);
            this.labelTituloPanelIzquierdo.Name = "labelTituloPanelIzquierdo";
            this.labelTituloPanelIzquierdo.Size = new System.Drawing.Size(227, 19);
            this.labelTituloPanelIzquierdo.TabIndex = 2;
            this.labelTituloPanelIzquierdo.Text = "Veterinaria \"Colita Blanca\"";
            // 
            // logoBox
            // 
            this.logoBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoBox.Image = global::Veterinaria.Properties.Resources.png_transparent_dog_veterinarian_banfield_pet_hospital_veterinary_medicine_dog_angle_animals_text;
            this.logoBox.Location = new System.Drawing.Point(16, 9);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(77, 76);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 1;
            this.logoBox.TabStop = false;
            // 
            // picturePrincipalHija
            // 
            this.picturePrincipalHija.Image = global::Veterinaria.Properties.Resources.grupo_de_animales_domésticos_en_el_fondo_blanco_92949807;
            this.picturePrincipalHija.Location = new System.Drawing.Point(322, 0);
            this.picturePrincipalHija.Name = "picturePrincipalHija";
            this.picturePrincipalHija.Size = new System.Drawing.Size(559, 423);
            this.picturePrincipalHija.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePrincipalHija.TabIndex = 1;
            this.picturePrincipalHija.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 420);
            this.Controls.Add(this.picturePrincipalHija);
            this.Controls.Add(this.panelMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenuLateral.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePrincipalHija)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label labelTituloPanelIzquierdo;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox picturePrincipalHija;
    }
}

