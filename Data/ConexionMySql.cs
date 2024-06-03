using MySql.Data.MySqlClient;
using ProyectoFinal.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
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


        
        public ConexionMySql()
        {
            connection = new MySqlConnection(connectionString);
        }

        public void Insertar(string nombre, string apellido, decimal nivelPoder, DateTime fechaAgregado, string aldea, string rango)
        {
            try
            {
                string query = "INSERT INTO personajes_naruto (Nombre, Apellido, Nivel_Poder, Fecha_Agregado, Aldea, Rango) VALUES (@Nombre, @Apellido, @Nivel_Poder, @Fecha_Agregado, @Aldea, @Rango)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Nivel_Poder", nivelPoder);
                cmd.Parameters.AddWithValue("@Fecha_Agregado", fechaAgregado);
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

        public void Actualizar(int id, string nombre, string apellido, decimal nivelPoder, DateTime fechaAgregado, string aldea, string rango)
        {
            try
            {
                string query = "UPDATE personajes_naruto SET Nombre = @Nombre, Apellido = @Apellido, Nivel_Poder = @Nivel_Poder, Fecha_Agregado = @Fecha_Agregado, Aldea = @Aldea, Rango = @Rango WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Nombre", nombre);
                cmd.Parameters.AddWithValue("@Apellido", apellido);
                cmd.Parameters.AddWithValue("@Nivel_Poder", nivelPoder);
                cmd.Parameters.AddWithValue("@Fecha_Agregado", fechaAgregado);
                cmd.Parameters.AddWithValue("@Aldea", aldea);
                cmd.Parameters.AddWithValue("@Rango", rango);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable LeerTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT * FROM personajes_naruto";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los registros: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public DataRow LeerPorId(int id)
        {
            DataTable dt = new DataTable();
            try
            {
                string query = "SELECT ID, Nombre, Apellido, Nivel_Poder, Fecha_Agregado, Aldea, Rango FROM personajes_naruto WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt.Rows.Count > 0 ? dt.Rows[0] : null;
        }


        public void Insertar(PersonajeNaruto personaje)
        {
            try
            {
                string query = "INSERT INTO Personajes_Naruto (Nombre, Apellido, Nivel_Poder, Fecha_Agregado, Aldea, Rango) VALUES (@Nombre, @Apellido, @Nivel_Poder, @Fecha_Agregado, @Aldea, @Rango)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", personaje.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", personaje.Apellido);
                cmd.Parameters.AddWithValue("@Nivel_Poder", personaje.NivelPoder);
                cmd.Parameters.AddWithValue("@Fecha_Agregado", personaje.FechaAgregado);
                cmd.Parameters.AddWithValue("@Aldea", personaje.Aldea);
                cmd.Parameters.AddWithValue("@Rango", personaje.Rango);
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

        public List<PersonajeNaruto> ObtenerTodosLosPersonajes()
        {
            List<PersonajeNaruto> personajes = new List<PersonajeNaruto>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Personajes_Naruto";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        PersonajeNaruto personaje = new PersonajeNaruto
                        (
                            id: reader.GetInt32("ID"),
                            nombre: reader.GetString("Nombre"),
                            apellido: reader.GetString("Apellido"),
                            nivelPoder: (int)reader.GetDecimal("Nivel_Poder"),
                            fechaAgregado: reader.GetDateTime("Fecha_Agregado"),
                            aldea: reader.GetString("Aldea"),
                            rango: reader.GetString("Rango")
                        );

                        personajes.Add(personaje);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return personajes;
        }

        public void Eliminar(int id)
        {
            try
            {
                string query = "DELETE FROM personajes_naruto WHERE ID = @ID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@ID", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
