using AppDesktop.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class AnadirPregunta : Form
    {
        //Constantes
        const byte MAX_CHAR_PREG = 100;
        const byte MIN_CHAR_PREG = 10;
        const byte MAX_CHAR_RESP = 35;
        const byte MIN_CHAR_RESP = 0;

        //Objetos
        BindingList<Respuesta> listaRespuestas = new BindingList<Respuesta>();
        Idioma castellano;
        Idioma ingles;
        Idioma catalan;
        String idiomaOriginal = null,
                nivelOrigional = null;
        Pregunta pregunta = new Pregunta();

        bool preguntaModificada = false;

        //Constructores
        public AnadirPregunta(Idioma castellano, Idioma catalan, Idioma ingles)
        {
            InitializeComponent();
            this.castellano = castellano;
            this.catalan = catalan;
            this.ingles = ingles;
        }
        public AnadirPregunta(Idioma castellano, Idioma catalan, Idioma ingles, Pregunta pregunta, Respuesta[] r, String idioma, String nivel)
        {
            InitializeComponent();

            this.castellano = castellano;
            this.catalan = catalan;
            this.ingles = ingles;
            this.pregunta = pregunta;
            this.idiomaOriginal = idioma;
            this.nivelOrigional = nivel;
            comboBoxIdioma.SelectedItem = idioma;
            comboBoxNivel.SelectedItem = nivel;

            preguntaModificada = true;

            textBoxPregunta.Text = pregunta.pregunta;

            List<Respuesta> lr = new List<Respuesta>(r);
            BindingList<Respuesta> blist2 = new BindingList<Respuesta>(lr);
            listaRespuestas = blist2;

            actualizarDGV();
        }

        /*** E V E N T O S  ***/
        //Al cargar el formulario
        private void AnadirPregunta_Load(object sender, EventArgs e)
        {
            if (preguntaModificada == true)
            {
                this.Text = "Modificar pregunta";
                groupBoxAfegirPregunta.Text = "Modificar pregunta";
            }


            //"Iniciamos" las labels de contadores de carácteres para pregunta y respuesta
            mostrarCharsPregunta();
            mostrarCharsResposta();

            //Indicamos que, de inicio, no se muestre la ayuda
            toolTipAyuda.Active = false;

            //Le indicamos al Visual que no genere automáticamente las columnas y conserve los headers tal cual
            //se lo hemos indicado
            dataGridViewRespuestas.AutoGenerateColumns = false;
        }

        //Al cerrar el formulario
        private void AnadirPregunta_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Si hay algún campo editado muestra un mensaje para confirmar el cerrado del formulario
            if (comboBoxIdioma.SelectedIndex != -1 || comboBoxNivel.SelectedIndex != -1 ||
                textBoxPregunta.Text.Length > 0 || textBoxResposta.Text.Length > 0 || listaRespuestas.Count > 0)
            {
                DialogResult result = MessageBox.Show("S'han fet modificacions pero no s'han guardat. \nDesitja sortir sense guardarles?", "Advertència",
                                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                //Si se presiona el botón [Cancelar], no se cierra el formulario, de lo contrario sí
                if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
        }

        //Para los contadores de números de carácteres de los textBox: pregunta y respuesta
        private void textBoxPregunta_TextChanged(object sender, EventArgs e)
        {
            mostrarCharsPregunta();
        }
        private void textBoxResposta_TextChanged(object sender, EventArgs e)
        {
            mostrarCharsResposta();
        }

        //Al clickar el botón [Añadir]
        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            //Añadimos la respuesta si cumple ambos requisitos
            if (textBoxResposta.Text.Length > MIN_CHAR_RESP &&
                textBoxResposta.Text.Length <= MAX_CHAR_RESP)
            {
                Respuesta r = new Respuesta();

                //Asignamos la respuesta que hay en el TextBoxResposta al atributo respuesta del objeto respuesta
                r.respuesta = textBoxResposta.Text;

                //Si está marcada el checkbox de respuesta correcta, asignamos el atributo correcta del objeto respuesta a true
                if (checkBoxCorrecta.Checked)
                {
                    r.correcta = true;
                }
                else
                {
                    r.correcta = false;
                }

                //Añadimos el objeto respuesta creado a la lista de respuestas
                listaRespuestas.Add(r);

                //Limpiamos campos
                textBoxResposta.Text = "";
                checkBoxCorrecta.Checked = false;

                //Actualizamos la DataGridView
                actualizarDGV();
                dataGridViewRespuestas.ClearSelection();

                //Cambiamos el focus para hacer más cómodo al tabular
                if (dataGridViewRespuestas.RowCount < 4)
                {
                    textBoxResposta.Focus();
                }
                else if (dataGridViewRespuestas.RowCount == 4)
                {
                    buttonGuardar.Focus();

                }
            }
        }

        //Al clickar el botón [Eliminar]
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

        //Al clickar el botón [Reiniciar]
        private void buttonReiniciar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        //Al clickar el botón [Guardar]
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //Contador de campos correctos
            byte cont = 0;

            //Mensaje inicial que saldrá cuando haya algun campo incorrecto (luego se concatenarán otros strings indicando qué errores hay)
            string msgError = "No s'ha pogut afegir correctament la pregunta perquè: ";


            //Comprobamos cuales son los campos correctos y los incorrectos
            //En los incorrectos, concatenamos mensajes de error para que luego la usuaria sepa qué debe hacer
            //Checkeo del Idioma
            if (comboBoxIdioma.SelectedIndex > -1)
            {
                //Si hay algún campo seleccionado, aumentamos el contador en 1
                cont++;
            }
            else
            {
                //Sumamos (concatenamos) este string al string de errores
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
                textBoxPregunta.Text.Length >= MIN_CHAR_PREG)
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
                //Si hay un total de 4 respuestas sumamos el contador de campos correctos en 1
                cont++;

                //Contador de respuestas que están marcadas como válidas
                byte numCorrectas = 0;

                //Comprobamos respuesta por respuesta en la lista de respuestas
                foreach (Respuesta r in listaRespuestas)
                {
                    //Si el atributo de la respuesta es true...
                    if (r.correcta)
                    {
                        //... sumamos el contador en 1
                        numCorrectas++;
                    }
                }


                //Si el numero de respuestas correctas es 1...
                if (numCorrectas == 1)
                {
                    //...El numero de campos correctos lo sumamos en 1
                    cont++;
                }
                else
                {
                    msgError += "\n  - Només pot haver-hi una resposta marcada com a correcta";
                }

            }
            //Si no hay cuatro respuestas, concatena otro mensaje de error
            else
            {
                msgError += "\n  - Ha d'haver-hi cuatre respostes";
            }


            //Si todos los campos son correctos se guarda la pregunta, si no, muestra mensaje indicando los errores
            if (cont == 5)
            {
                if (preguntaModificada)
                {
                    eliminarPregunta(pregunta);
                }
                //Creamos una pregunta: sus atributos pregunta y respuesta se le pasa por parámetro
                Pregunta p = new Pregunta(textBoxPregunta.Text, listaRespuestas);

                anadirPregunta(p);

                limpiarCampos();

                if (preguntaModificada == true)
                {
                    MessageBox.Show("Pregunta modificada correctament!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Pregunta afegida correctament!");
                }
            }
            else
            {
                MessageBox.Show(msgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Para activar/desactivar la ayuda (ToolTip)
        private void radioButtonSi_CheckedChanged(object sender, EventArgs e)
        {
            toolTipAyuda.Active = true;
        }
        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            toolTipAyuda.Active = false;
        }


        /*** M E T O D O S  ***/
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

        /// <summary>
        /// Refrescamos la DataGridView con la lista de respuestas
        /// </summary>
        private void actualizarDGV()
        {
            dataGridViewRespuestas.DataSource = null;
            dataGridViewRespuestas.DataSource = listaRespuestas;
        }

        /// <summary>
        /// Añadimos la pregunta, en función de su idioma y nivel, a una lista de preguntas. Se le pasa por parámetro una pregunta
        /// </summary>
        /// <param name="p">La pregunta</param>
        private void anadirPregunta(Pregunta p)
        {
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
        }

        /// <summary>
        /// Elimina la pregunta la lista en la que se encuentre. Se le pasa por parámetro la pregunta
        /// </summary>
        /// <param name="pregunta">Un objeto de la clase Pregunta</param>
        private void eliminarPregunta(Pregunta pregunta)
        {
            if (idiomaOriginal == comboBoxIdioma.SelectedItem.ToString())
            {
                if (nivelOrigional == comboBoxNivel.SelectedItem.ToString())
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
                else //nivel != original (se ha cambiado el nivel)
                {
                    if (comboBoxIdioma.SelectedItem.ToString().Equals("Anglès"))
                    {
                        switch (nivelOrigional)
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
                        switch (nivelOrigional)
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
                        switch (nivelOrigional)
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
            else //idioma != original (ha cambiado de idioma)
            {
                if (nivelOrigional == comboBoxNivel.SelectedItem.ToString())
                {
                    if (idiomaOriginal == "Anglès")
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
                    else if (idiomaOriginal == "Català")
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
                    else if (idiomaOriginal == "Castellà")
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
                else //nivel != original (se ha cambiado el idioma)
                {
                    if (idiomaOriginal == "Anglès")
                    {
                        switch (nivelOrigional)
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
                    else if (idiomaOriginal == "Català")
                    {
                        switch (nivelOrigional)
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
                    else if (idiomaOriginal == "Castellà")
                    {
                        switch (nivelOrigional)
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

        /// <summary>
        /// Cambia el label contador de carácteres restantes en el textBox pregunta
        /// </summary>
        private void mostrarCharsPregunta()
        {
            int numCar = MAX_CHAR_PREG - textBoxPregunta.Text.Length;
            labelCarPre.Text = numCar.ToString();
        }

        /// <summary>
        /// Cambia el label contador de carácteres restantes en el textBox pregunta
        /// </summary>
        private void mostrarCharsResposta()
        {
            int numCar = MAX_CHAR_RESP - textBoxResposta.Text.Length;
            labelCarRes.Text = numCar.ToString();
        }
    }
}