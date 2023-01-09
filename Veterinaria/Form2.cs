using MySql.Data.MySqlClient;
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
    public partial class Form2 : Form
    {
        CNCliente cNCliente = new CNCliente();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            CECliente cECliente = new CECliente();
            bool resultado;

            cECliente.nombreMascota = tbNombreMascota.Text;
            cECliente.nombreDuenio = tbNombreDuenio.Text;
            cECliente.animal = tbAnimal.Text;
            cECliente.raza = tbRaza.Text;


            resultado = cNCliente.validarDatos(cECliente);
            if (resultado == false)
            {
                return;
            }

            cNCliente.crearCliente(cECliente);

        }

        
    }
}
