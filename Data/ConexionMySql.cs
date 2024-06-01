using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Data
{
    internal class ConexionMySql
    {
        string connectionString = "server=localhost;database=proyecto_final;user=root;password=Shyro#23112004";
        MySqlConnection connection;


        //constructor
        public ConexionMySql()
        {
            connection = new MySqlConnection(connectionString);
        }

        public void Insertar(string nombre, string apellido, int nivelPoder, DateTime fechaAgregado, string aldea, string rango)
        {
            try
            {
                string query = "INSERT INTO personajes_naruto (Nombre, Apellido,NivelPoder, FechaAgregado, Aldea, Rango) VALUES (@Nombre, @Apellido, @NivelPoder, @FechaNacimiento, @Aldea, @Rango)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@NivelPoder", nivelPoder);
                cmd.Parameters.AddWithValue("@FechaAgregado", fechaAgregado);
                cmd.Parameters.AddWithValue("@Aldea", aldea);
                cmd.Parameters.AddWithValue("@Rango", rango);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
