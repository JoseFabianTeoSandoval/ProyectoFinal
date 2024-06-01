using ProyectoFinal.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        ConexionMySql Clscone = new ConexionMySql();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            Clscone.Insertar(textBoxnombre.Text, textBoxapellido.Text,(int)numericUpDownnivelpoder.Value, dateTimePickerfechaagregado.Value, textBoxaldea.Text, textBoxrango.Text);
        }

    }
}
