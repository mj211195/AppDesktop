using AppDesktop.Clases;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class AnadirPregunta : Form
    {
        const byte MAX_CHAR_PREG = 100;
        const byte MAX_CHAR_RESP = 35;

        //List<Pregunta> listaPreguntas = new List<Pregunta>();
        BindingList<Respuesta> listaRespuestas = new BindingList<Respuesta>();
        Nivel castellano;
        Nivel ingles;
        Nivel catalan;
        Pregunta pregunta = new Pregunta();


        public AnadirPregunta(Nivel castellano, Nivel catalan, Nivel ingles)
        {
            InitializeComponent();
            this.castellano = castellano;
            this.catalan = catalan;
            this.ingles = ingles;
        }

        public AnadirPregunta(Nivel castellano, Nivel catalan, Nivel ingles, Pregunta pregunta, String idioma, String nivel)
        {
            InitializeComponent();
            this.castellano = castellano;
            this.catalan = catalan;
            this.ingles = ingles;
            this.pregunta = pregunta;
            eliminarPregunta();
            comboBoxIdioma.SelectedItem= idioma;
            comboBoxNivel.SelectedItem = nivel;
            textBoxPregunta.Text = pregunta.pregunta;
            listaRespuestas = pregunta.respuestas;
            actualizarDGV();

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
                textBoxPregunta.Text.Length >= 10)
            {
                cont++;
            }
            else
            {
                msgError += "\n  - S'ha d'escriure una pregunta vàlida";
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
                if (comboBoxIdioma.SelectedItem.ToString().Equals("Anglès"))
                {
                    switch (comboBoxNivel.SelectedItem.ToString())
                    {
                        case "Infantil":
                            ingles.infantil.Add(p);
                            break;
                        case "Adult (Fàcil)":

                            ingles.facil.Add(p);
                            break;
                        case "Adult (Intermedi)":
                            ingles.medio.Add(p);
                            break;
                        case "Adult (Difícil)":
                            ingles.dificil.Add(p);
                            break;
                    }
                }
                else if (comboBoxIdioma.SelectedItem.ToString().Equals("Català"))
                {
                    switch (comboBoxNivel.SelectedItem.ToString())
                    {
                        case "Infantil":
                            catalan.infantil.Add(p);
                            break;
                        case "Adult (Fàcil)":
                            catalan.facil.Add(p);
                            break;
                        case "Adult (Intermedi)":
                            catalan.medio.Add(p);
                            break;
                        case "Adult (Difícil)":
                            catalan.dificil.Add(p);
                            break;

                    }
                }
                else if (comboBoxIdioma.SelectedItem.ToString().Equals("Castellà"))
                {
                    switch (comboBoxNivel.SelectedItem.ToString())
                    {
                        case "Infantil":
                            castellano.infantil.Add(p);
                            break;
                        case "Adult (Fàcil)":
                            castellano.facil.Add(p);
                            break;
                        case "Adult (Intermedi)":
                            castellano.medio.Add(p);
                            break;
                        case "Adult (Difícil)":
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
        private void eliminarPregunta() //Elimina la pregunta que se pasa en el constructor en las listas para poder volver a modificar la pregunta
        {
            //Catalán
            catalan.infantil.Remove(pregunta);
            catalan.facil.Remove(pregunta);
            catalan.medio.Remove(pregunta);
            catalan.dificil.Remove(pregunta);
            //Castellano
            castellano.infantil.Remove(pregunta);
            castellano.facil.Remove(pregunta);
            castellano.medio.Remove(pregunta);
            castellano.dificil.Remove(pregunta);
            //Inglés
            ingles.infantil.Remove(pregunta);
            ingles.facil.Remove(pregunta);
            ingles.medio.Remove(pregunta);
            ingles.dificil.Remove(pregunta);
        }
    }
}
