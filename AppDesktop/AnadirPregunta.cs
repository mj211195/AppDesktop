﻿using AppDesktop.Clases;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class AnadirPregunta : Form
    {
        //Constantes
        const byte MAX_CHAR_PREG = 100;
        const byte MAX_CHAR_RESP = 35;

        //Objetos
        BindingList<Respuesta> listaRespuestas = new BindingList<Respuesta>();
        Idioma castellano;
        Idioma ingles;
        Idioma catalan;
        Pregunta pregunta = new Pregunta();

        //Constructores
        public AnadirPregunta(Idioma castellano, Idioma catalan, Idioma ingles)
        {
            InitializeComponent();
            this.castellano = castellano;
            this.catalan = catalan;
            this.ingles = ingles;
        }

        public AnadirPregunta(Idioma castellano, Idioma catalan, Idioma ingles, Pregunta pregunta, String idioma, String nivel)
        {
            InitializeComponent();
            this.castellano = castellano;
            this.catalan = catalan;
            this.ingles = ingles;
            this.pregunta = pregunta;
            comboBoxIdioma.SelectedItem= idioma;
            comboBoxNivel.SelectedItem = nivel;
            eliminarPregunta(pregunta);
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
            dataGridViewRespuestas.AutoGenerateColumns = false;
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
            if (dataGridViewRespuestas.RowCount == 4)
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

            dataGridViewRespuestas.DataSource = null;
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


        //Refrescamos la DataGridView con la lista de respuestas
        private void actualizarDGV()
        {
            dataGridViewRespuestas.DataSource = null;
            dataGridViewRespuestas.DataSource = listaRespuestas;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewRespuestas.CurrentRow != null)
            {
                if (dataGridViewRespuestas.CurrentRow.Index != -1)
                {
                    //Eliminamos la fila seleccionada
                    listaRespuestas.RemoveAt(dataGridViewRespuestas.CurrentRow.Index);

                    //Actualizamos el DataGridView para que se reflejen los cambios
                    actualizarDGV();

                }
            }
        }

        //Elimina la pregunta que se pasa en el constructor en las listas para poder volver a modificar la pregunta
        private void eliminarPregunta(Pregunta pregunta) 
        {
            if (comboBoxIdioma.SelectedItem.ToString().Equals("Anglès"))
            {
                switch (comboBoxNivel.SelectedItem.ToString())
                {
                    case "Infantil":
                        ingles.infantil.Remove(pregunta);
                        break;
                    case "Adult (Fàcil)":

                        ingles.facil.Remove(pregunta);
                        break;
                    case "Adult (Intermedi)":
                        ingles.medio.Remove(pregunta);
                        break;
                    case "Adult (Difícil)":
                        ingles.dificil.Remove(pregunta);
                        break;
                }
            }
            else if (comboBoxIdioma.SelectedItem.ToString().Equals("Català"))
            {
                switch (comboBoxNivel.SelectedItem.ToString())
                {
                    case "Infantil":
                        catalan.infantil.Remove(pregunta);
                        break;
                    case "Adult (Fàcil)":
                        catalan.facil.Remove(pregunta);
                        break;
                    case "Adult (Intermedi)":
                        catalan.medio.Remove(pregunta);
                        break;
                    case "Adult (Difícil)":
                        catalan.dificil.Remove(pregunta);
                        break;

                }
            }
            else if (comboBoxIdioma.SelectedItem.ToString().Equals("Castellà"))
            {
                switch (comboBoxNivel.SelectedItem.ToString())
                {
                    case "Infantil":
                        castellano.infantil.Remove(pregunta);
                        break;
                    case "Adult (Fàcil)":
                        castellano.facil.Remove(pregunta);
                        break;
                    case "Adult (Intermedi)":
                        castellano.medio.Remove(pregunta);
                        break;
                    case "Adult (Difícil)":
                        castellano.dificil.Remove(pregunta);
                        break;
                }
            }
        }
    }
}
