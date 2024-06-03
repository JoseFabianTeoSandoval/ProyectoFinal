using ProyectoFinal.Data;
using ProyectoFinal.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        private string[] aldeasnaruto =
        {
            "Konoha", // Aldea Oculta de la Hoja
            "Suna", // Aldea Oculta de la Arena
            "Kiri", // Aldea Oculta de la Niebla
            "Iwa", // Aldea Oculta de la Roca
            "Kumo", // Aldea Oculta de la Nube
            "Amegakure", // Aldea Oculta de la Lluvia
            "Otogakure", // Aldea Oculta del Sonido
            "Yugakure", // Aldea Oculta de las Fuentes Termales
            "Takigakure", // Aldea Oculta de la Cascada
            "Kusagakure" // Aldea Oculta de la Hierba

        };

        private string[] rangosnaruto =
        {
                "Genin",       // Rango más bajo de los ninjas
                "Chunin",      // Ninja de rango medio
                "Jonin",       // Ninja de rango alto
                "Anbu",        // Operaciones especiales
                "Kage",        // Líder de una aldea
                "Sannin",      // Tres ninjas legendarios
        };

        ConexionMySql Clscone = new ConexionMySql();
        PersonajeNaruto personaje = new PersonajeNaruto();
        List<PersonajeNaruto> todos;
        ClsCursor cursor1 = new ClsCursor();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxaldea.Items.AddRange(aldeasnaruto);
            comboBoxrango.Items.AddRange(rangosnaruto);
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            PersonajeNaruto personaje = new PersonajeNaruto
            {
                Nombre = textBoxnombre.Text,
                Apellido = textBoxapellido.Text,
                NivelPoder = (int)numericUpDownnivelpoder.Value,
                FechaAgregado = dateTimePickerfechaagregado.Value,
                Aldea = textBoxaldea.Text,
                Rango = textBoxrango.Text
            };

            Clscone.Insertar(personaje);
        }

        private void buttoncargar_Click(object sender, EventArgs e)
        {
            DataTable dt = Clscone.LeerTodos();
            if (dt.Rows.Count > 0)
            {
                dataGridView.DataSource = dt;
                todos = Clscone.ObtenerTodosLosPersonajes();
                cursor1.totalRegistros = todos.Count;
                cursor1.current = 0;
                MostrarRegistro();
            }
            else
            {
                MessageBox.Show("No hay registros");
            }
        }
        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            DataRow resp = Clscone.LeerPorId(int.Parse(textBoxid.Text));
            if (resp != null)
            {
                textBoxnombre.Text = resp["Nombre"].ToString();
                textBoxapellido.Text = resp["Apellido"].ToString();
                numericUpDownnivelpoder.Value = Convert.ToDecimal(resp["Nivel_Poder"]);
                dateTimePickerfechaagregado.Value = (DateTime)resp["Fecha_Agregado"];
                textBoxaldea.Text = resp["Aldea"].ToString();
                textBoxrango.Text = resp["Rango"].ToString();
            }
            else
            {
                MessageBox.Show("No se encontró el registro");
            }

        }
        

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            Clscone.Actualizar(int.Parse(textBoxid.Text), textBoxnombre.Text, textBoxapellido.Text, int.Parse(numericUpDownnivelpoder.Value.ToString()),  dateTimePickerfechaagregado.Value, textBoxaldea.Text, textBoxrango.Text);
        }



        // Función para mostrar el registro actual
        private void MostrarRegistro()
        {
            if (cursor1.current >= 0 && cursor1.current < cursor1.totalRegistros)
            {
                PersonajeNaruto p = todos[cursor1.current];
                textBoxid.Text = p.ID.ToString();
                textBoxnombre.Text = p.Nombre;
                textBoxapellido.Text = p.Apellido;
                numericUpDownnivelpoder.Value = (decimal)p.NivelPoder;
                dateTimePickerfechaagregado.Value = p.FechaAgregado;
                textBoxaldea.Text = p.Aldea;
                textBoxrango.Text = p.Rango;
                // Incrementar el cursor y validar que no se pase del total de registros
                cursor1.current++;
                if (cursor1.current >= cursor1.totalRegistros)
                {
                    cursor1.current = 0;
                    MessageBox.Show("Fin de los registros");
                }
            }
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            MostrarRegistro();
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxid.Text))
            {
                int id = int.Parse(textBoxid.Text);
                var result = MessageBox.Show("¿Estás seguro de que deseas eliminar este personaje?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Clscone.Eliminar(id);
                    MessageBox.Show("Personaje eliminado correctamente.");
                    // Actualiza la lista de personajes después de eliminar
                    todos = Clscone.ObtenerTodosLosPersonajes();
                    MostrarRegistro();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un personaje para eliminar.");
            }
        }

        private void MostrarRegistroAnterior()
        {
            if (cursor1.current > 0 && cursor1.current <= cursor1.totalRegistros)
            {
                cursor1.current--;
                PersonajeNaruto p = todos[cursor1.current];
                textBoxid.Text = p.ID.ToString();
                textBoxnombre.Text = p.Nombre;
                textBoxapellido.Text = p.Apellido;
                numericUpDownnivelpoder.Value = (decimal)p.NivelPoder;
                dateTimePickerfechaagregado.Value = p.FechaAgregado;
                textBoxaldea.Text = p.Aldea;
                textBoxrango.Text = p.Rango;
            }
            else
            {
                MessageBox.Show("No hay registros anteriores.");
            }
        }

        private void buttonanterior_Click(object sender, EventArgs e)
        {
            MostrarRegistroAnterior();
        }
    }
}
