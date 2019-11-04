using AppDesktop.Clases;
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
        const byte MAX_CHAR_PREG = 100;
        const byte MAX_CHAR_RESP = 35;

        //List<Pregunta> listaPreguntas = new List<Pregunta>();
        List<Respuesta> listaRespuestas = new List<Respuesta>();
        Nivel castellano = new Nivel();
        Nivel ingles = new Nivel();
        Nivel catalan = new Nivel();


        public AnadirPregunta()
        {
            InitializeComponent();
        }
        
        private void AnadirPregunta_Load(object sender, EventArgs e)
        {
            //"Iniciamos" las labels de contadores de carácteres para pregunta y respuesta
            labelCarPre.Text = MAX_CHAR_PREG.ToString();
            labelCarRes.Text = MAX_CHAR_RESP.ToString();

            //Indicamos que, de inicio, no se muestre la ayuda
            toolTipAyuda.Active = false;

            //Le indicamos al Visual que no genere automáticamente las columnas y conserve los headers tal cual
            //se lo hemos indicado
            dataGridView1.AutoGenerateColumns = false;
        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {
            //Cambiamos el textBox pregunta a ReadOnly o no cada vez que presionemos el botón [Validar]
            if (textBoxPregunta.ReadOnly)
            {
                textBoxPregunta.ReadOnly = false;
            }
            else
            {
                textBoxPregunta.ReadOnly = true;
            }

        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            //Añadimos la respuesta si cumple ambos requisitos
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

                //La añadimos a la lista
                listaRespuestas.Add(r);

                //Limpiamos campos
                textBoxResposta.Text = "";
                checkBoxCorrecta.Checked = false;

                actualizarDGV();
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //Contador de campos correctos
            byte cont = 0;

            string msgError = "No s'ha pogut afegir correctament la pregunta perquè: ";

            //Comprobamos cuales son los campos correctos y los incorrectos
            //En los incorrectos, concatenamos mensajes de error para que luego la usuaria sepa qué debe hacer
            //Checkeo del Idioma
            if (comboBoxIdioma.SelectedIndex > -1)
            {
                cont++;
            }
            else
            {
                msgError += "\n  - S'ha d'escollir un idioma";
            }


            //Checkeo del Nivel
            if (comboBoxNivel.SelectedIndex > -1)
            {
                cont++;
            }
            else
            {
                msgError += "\n  - S'ha d'escollir un nivell";
            }


            //Checkeo de la pregunta
            if (textBoxPregunta.Text.Length <= MAX_CHAR_PREG &&
                textBoxPregunta.Text.Length >= 10 &&
                textBoxPregunta.ReadOnly == true)
            {
                cont++;
            }
            else
            {
                msgError += "\n  - S'ha d'escriure una pregunta vàlida i ha d'estar validada";
            }


            //Checkeo de las respuestas
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
                Pregunta p = new Pregunta(textBoxPregunta.Text, listaRespuestas);
                if ((String)comboBoxIdioma.SelectedItem == "Anglès")
                {
                    switch((byte)comboBoxNivel.SelectedIndex)
                    {
                        case 1:
                            ingles.infantil.Add(p);
                            break;
                        case 2:
                            ingles.facil.Add(p);
                            break;
                        case 3:
                            ingles.medio.Add(p);
                            break;
                        case 4:
                            ingles.dificil.Add(p);
                            break;

                    }
                }
                else if ((String)comboBoxIdioma.SelectedItem == "Català")
                {
                    switch ((byte)comboBoxNivel.SelectedIndex)
                    {
                        case 1:
                            catalan.infantil.Add(p);
                            break;
                        case 2:
                            catalan.facil.Add(p);
                            break;
                        case 3:
                            catalan.medio.Add(p);
                            break;
                        case 4:
                            catalan.dificil.Add(p);
                            break;

                    }
                }
                else if ((String)comboBoxIdioma.SelectedItem == "Castellà")
                {
                    switch ((byte)comboBoxNivel.SelectedIndex)
                    {
                        case 1:
                            castellano.infantil.Add(p);
                            break;
                        case 2:
                            castellano.facil.Add(p);
                            break;
                        case 3:
                            castellano.medio.Add(p);
                            break;
                        case 4:
                            castellano.dificil.Add(p);
                            break;

                    }
                }

                //listaPreguntas.Add(p);

                MessageBox.Show("Pregunta afegida correctament!");

                /*
                //chivato
                int contador = listaPreguntas.Count;
                MessageBox.Show("Numero de preguntas añadidas " + contador);
                */

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

        /// <summary>
        /// Refrescamos la DataGridView con la lista de respuestas
        /// </summary>
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
