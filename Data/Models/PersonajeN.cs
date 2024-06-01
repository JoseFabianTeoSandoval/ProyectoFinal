using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoFinal.Data.Models
{
    internal class PersonajeN
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NivelPoder { get; set; }
        public DateTime FechaAgregado { get; set; }
        public string Aldea { get; set; }
        public string Rango { get; set; }

        public PersonajeN(int id, string nombre, string apellido, int nivelPoder, DateTime fechaAgregado, string aldea, string rango)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NivelPoder = nivelPoder;
            FechaAgregado = fechaAgregado;
            Aldea = aldea;
            Rango = rango;
        }

    }
}
