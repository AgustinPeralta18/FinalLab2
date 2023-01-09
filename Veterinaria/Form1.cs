using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void abrirPanelHijo(Form panelHijo)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = panelHijo;
            panelHijo.TopLevel = false;
            panelHijo.FormBorderStyle = FormBorderStyle.None;
            panelHijo.Dock = DockStyle.Fill;
            picturePrincipalHija.Controls.Add(panelHijo);
            picturePrincipalHija.Tag = panelHijo;
            panelHijo.Show();
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            abrirPanelHijo(new Form2());
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            abrirPanelHijo(new Form3());
        }
    }
}
