using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.capaEntidad; //dependencia y asociacion

namespace Veterinaria.capaEntidad
{
    class CNCliente
    {
        CDCliente cDCliente = new CDCliente();
        public bool validarDatos(CECliente cliente)
        {

            bool resultado = true;

            if (cliente.nombreMascota == string.Empty)
            {
                MessageBox.Show("Ingrese el nombre de la mascota");
                resultado = false;
            }
            if (cliente.nombreDuenio == string.Empty)
            {
                MessageBox.Show("Ingrese el nombre del duenio");
                resultado = false;
            }

            return resultado;
        }
        
        //Se llaman a los metodos creados en la clase cdCliente, se genera una dependencia y asociacion entre estas dos clases. 
        public void crearCliente(CECliente cE)
        {
            cDCliente.Crear(cE);
        }

        public DataSet obtenerDatos()
        {
            return cDCliente.Listar();
        }

        public void Editar(CECliente cE)
        {
            cDCliente.Editar(cE);
        }

        public void Eliminar(CECliente cE)
        {
            cDCliente.Eliminar(cE);
        }
    }
}
