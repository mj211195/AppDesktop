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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //Contador de campos correctos
            byte cont = 0;

            if (comboBoxIdioma.SelectedIndex>-1)
            {
                cont++;
                if (comboBoxNivel.SelectedIndex>-1)
                {
                    cont++;
                    if (textBoxPregunta.Text.Length < 140 &&
                        textBoxPregunta.Text.Length > 20 &&
                        textBoxPregunta.Text.Equals(" ") &&
                        textBoxPregunta.ReadOnly==true)
                    {
                        cont++;
                        if (dataGridView1.RowCount==4)
                        {
                            cont++;
                            //Ultimo verificador: que una respuesta sea válida
                            /*if ()
                            {
                                cont++;
                            }*/
                        }
                    }
                }
            }

            /*
            //En funcion del numero de campos erroneos se abre un msgbox o otro
            if ()
            {

            }
            else if()
            {
            }
            */

        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            comboBoxIdioma.Items.Clear();
            comboBoxNivel.Items.Clear();
            textBoxPregunta.ReadOnly = false;
            textBoxPregunta.Clear();
            textBoxResposta.Clear();
            checkBoxCorrecta.Checked = false;
            //dataGridView1.Rows.Clear();
        }
        /// <summary>
        /// Vuelve a llenar los comboBoxs Idioma y Nivel y actualiza el GridView
        /// </summary>
        private void refrescar()
        {

        }
    }
}
