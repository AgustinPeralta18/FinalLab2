using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.capaEntidad;

namespace Veterinaria
{
    public partial class Form3 : Form
    {
        CNCliente cNCliente = new CNCliente();
        public Form3()
        {
            InitializeComponent();
        }

        

        

        private void Form3_Load(object sender, EventArgs e)
        {
            gridDatos.DataSource = cNCliente.obtenerDatos().Tables["tbl"];
        }
    }
}
