using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Veterinaria.capaEntidad;

namespace Veterinaria.capaEntidad
{
    class CDCliente
    {

        string cadenaConexion = "Server=localhost;User=root;Password=agustincapo8;Port=3306;database=veterinaria_bd";

        public void pruebaConexion()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);

            

            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar"+ ex.Message);
                return;
            }

            mySqlConnection.Close();
            MessageBox.Show("Conectado");
        }

        public void Crear(CECliente cE)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            mySqlConnection.Open();

            string query = "INSERT INTO `mascotas` (`nombreMascota`, `raza`, `animal`, `nombreDuenio`) VALUES ('"+ cE.nombreMascota +"', '"+ cE.raza +"', '"+ cE.animal +"', '" + cE.nombreDuenio + "');";

            MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            mySqlConnection.Close();

            MessageBox.Show("Registro creado");
        }

        public DataSet listar()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(cadenaConexion);
            mySqlConnection.Open();

            string query = "SELECT * FROM `mascotas` LIMIT 1000;";

            MySqlDataAdapter adaptador;
            DataSet dataSet = new DataSet();

            adaptador = new MySqlDataAdapter(query, mySqlConnection);
            adaptador.Fill(dataSet, "tbl");

            return dataSet;
        }

            
    }
}
