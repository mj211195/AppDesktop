using AppDesktop.Clases;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        const byte MAX_CHAR_PREG = 140;
        const byte MAX_CHAR_RESP = 50;
        /*
        BindingList<Nivel> inf = new BindingList<Nivel>();
        BindingList<Nivel> aFac = new BindingList<Nivel>();
        BindingList<Nivel> aInt = new BindingList<Nivel>();
        BindingList<Nivel> aDif = new BindingList<Nivel>();*/

        List<Respuesta> listaRespuestas = new List<Respuesta>();


        public AnadirPregunta()
        {
            InitializeComponent();
        }
        
        private void AnadirPregunta_Load(object sender, EventArgs e)
        {
            //actualizarDGV();

            labelCarPre.Text = MAX_CHAR_PREG.ToString();
            labelCarRes.Text = MAX_CHAR_RESP.ToString();

            toolTipAyuda.Active = false;
            //Le indicamos al Visual que no genere automáticamente las columnas y conserve los headers tal cual
            //se lo hemos indicado
            dataGridView1.AutoGenerateColumns = false;
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

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            if (textBoxResposta.Text.Length>0 &&
                textBoxResposta.Text.Length<=MAX_CHAR_RESP)
            {
                Respuesta r = new Respuesta();

                r.respuesta = textBoxResposta.Text;
                if (checkBoxCorrecta.Checked)
                {
                    r.correcta = true;
                }
                else
                {
                    r.correcta = false;
                }
                listaRespuestas.Add(r);

                textBoxResposta.Text = "";
                checkBoxCorrecta.Checked = false;

                actualizarDGV();
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //Contador de campos correctos
            byte cont = 0;

            string msgError = "No s'ha pogut guadar correctament la pregunta perquè: ";

            //Comprobamos cuales son los campos correctos y los incorrectos
            //En los incorrectos, concatenamos mensajes de error para que luego la usuaria sepa qué debe hacer
            if (comboBoxIdioma.SelectedIndex > -1)
            {
                cont++;
            }
            else
            {
                msgError += "\n  - S'ha d'escollir un idioma";
            }


            if (comboBoxNivel.SelectedIndex > -1)
            {
                cont++;
            }
            else
            {
                msgError += "\n  - S'ha d'escollir un nivell";
            }


            if (textBoxPregunta.Text.Length <= MAX_CHAR_PREG &&
                textBoxPregunta.Text.Length >= 20 &&
                textBoxPregunta.ReadOnly == true)
            {
                cont++;
            }
            else
            {
                msgError += "\n  - S'ha d'escriure una pregunta vàlida i ha d'estar validada";
            }


            if (dataGridView1.RowCount == 4)
            {
                cont++;

                //Contamos cuantas respuestas están marcadas como válidas
                byte numCorrectas = 0;
                foreach (Respuesta r in listaRespuestas)
                {
                    if (r.correcta)
                    {
                        numCorrectas++;
                    }
                }
                //que una de las respuestas sea la correcta respuesta sea la correcta //////////////////////////////// PENDIENTE
                if (numCorrectas==1)
                {
                    cont++;
                }
                else
                {
                    msgError += "\n  - Només una de les respostes ha d'estar marcada com a correcte";
                }
            }
            else
            {
                msgError += "\n  - Ha d'haver-hi cuatre respostes";
            }


            //Si todos los campos son correctos se guarda la pregunta, si no, muestra mensaje indicando los errores
            if (cont==5)
            {
                int indexIdioma = comboBoxIdioma.SelectedIndex,
                    indexNivel = comboBoxNivel.SelectedIndex;

                Pregunta p = new Pregunta(textBoxPregunta.Text, listaRespuestas);
                /*
                //guardar la pregunta
                switch (indexNivel)
                {
                    //infantil
                    case 0:
                        switch (indexIdioma)
                        {
                            //catalan
                            case 0:
                                break;

                            //castellano
                            case 1:
                                break;

                            //ingles
                            default:
                                break;
                        }
                        break;

                    //adulto (facil)
                    case 1:
                        break;

                    //adulto (intermedio)
                    case 2:
                        break;

                    //adulto (dificil)
                    default:
                        break;
                }*/


                limpiarCampos();
            }
            else
            {
                MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        /// <summary>
        /// Limpia (deja en blanco) todos los campos, comboBoxs, DGV...
        /// </summary>
        private void limpiarCampos()
        {
            comboBoxIdioma.SelectedIndex = -1;
            comboBoxNivel.SelectedIndex = -1;
            textBoxPregunta.ReadOnly = false;
            textBoxPregunta.Clear();
            textBoxResposta.Clear();
            checkBoxCorrecta.Checked = false;
            radioButtonNo.Checked = true;

            dataGridView1.DataSource = null;
            listaRespuestas.Clear();
        }

        //Activamos/Desactivamos la ayuda (ToolTip)
        private void radioButtonSi_CheckedChanged(object sender, EventArgs e)
        {
            toolTipAyuda.Active = true;
        }
        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            toolTipAyuda.Active = false;
        }

        //Eventos para los contadores de números de carácteres de los textBox pregunta y respuesta
        private void textBoxPregunta_TextChanged(object sender, EventArgs e)
        {
            int numCar = MAX_CHAR_PREG - textBoxPregunta.Text.Length;
            labelCarPre.Text = numCar.ToString();
        }
        private void textBoxResposta_TextChanged(object sender, EventArgs e)
        {
            int numCar = MAX_CHAR_RESP - textBoxResposta.Text.Length;
            labelCarRes.Text = numCar.ToString();
        }

        private void actualizarDGV()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaRespuestas;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    //Eliminamos la fila seleccionada
                    listaRespuestas.RemoveAt(dataGridView1.CurrentRow.Index);

                    //Actualizamos el DataGridView para que se reflejen los cambios
                    actualizarDGV();

                }
            }
        }
    }
}
