using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class AnadirPregunta : Form
    {
        //booleano para marcar como ReadOnly o desmarcarlo la pregunta validada
        bool preguntaValidada = false;
        public AnadirPregunta()
        {
            InitializeComponent();
        }

        private void buttonAyuda_Click(object sender, EventArgs e)
        {
            FormAyuda f = new FormAyuda();

            f.Show();
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            //condicional para marcar/desmarcar como ReadOnly la pregunta
            if (preguntaValidada == false)
            {
                textBoxPregunta.ReadOnly = true;
                preguntaValidada = true;
            }
            else
            {
                textBoxPregunta.ReadOnly = false;
                preguntaValidada = false;
            }
        }
    }
}
