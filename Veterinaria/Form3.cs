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
using Veterinaria;

namespace Veterinaria
{
    public partial class Form3 : Form
    {
        CNCliente cNCliente = new CNCliente();
        CECliente cECliente = new CECliente();
        

        public Form3()
        {
            InitializeComponent();
        }


        private void CargarDatos()
        {
            gridDatos.DataSource = cNCliente.obtenerDatos().Tables["tbl"];
        }
        
        

        private void Form3_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        //Evento para elegir los registros del dataset para su edicion o eliminacion
        private void gridDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtId.Value = (int)gridDatos.CurrentRow.Cells["id"].Value;
            txtNombre.Text = (string)gridDatos.CurrentRow.Cells["nombreMascota"].Value;
            txtAnimal.Text = (string)gridDatos.CurrentRow.Cells["animal"].Value;
            txtRaza.Text = (string)gridDatos.CurrentRow.Cells["raza"].Value;
            txtNombreDuenio.Text = (string)gridDatos.CurrentRow.Cells["nombreDuenio"].Value;


        }

        //Evento de click de editar depende su funcionalidad de la clase CECliente y CNCliente

        private void button2_Click(object sender, EventArgs e)
        {
            CECliente cECliente = new CECliente();

            cECliente.id = (int)txtId.Value;
            cECliente.nombreMascota = txtNombre.Text;
            cECliente.nombreDuenio = txtNombreDuenio.Text;
            cECliente.animal = txtAnimal.Text;
            cECliente.raza = txtRaza.Text;
           
            
            cNCliente.Editar(cECliente);
            CargarDatos();
        }
        
        //Evento boton eliminar para que salga un messsagebox con la pregunta si está se
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Value == 0)
            {
                return;
            }

            if (MessageBox.Show("¿Estas seguro de eliminar este registro?","Titulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                CECliente cE = new CECliente();
                cE.id = (int)txtId.Value;
                cNCliente.Eliminar(cE);
                CargarDatos();
            }
        }
    }
}
