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
using System.Xml.Serialization;

namespace AppDesktop
{
    public partial class FormGestionPreguntas : Form
    {
        //Objetos
        Idioma castellano = new Idioma();
        Idioma ingles = new Idioma();
        Idioma catalan = new Idioma();
        
        //Rutas JSONs
        string fileCatalan = @"..\..\JSONs\catalan.json";
        string fileCastellano = @"..\..\JSONs\castellano.json";
        string fileIngles = @"..\..\JSONs\ingles.json";

        //Constructor
        public FormGestionPreguntas()
        {
            InitializeComponent();
        }

        private void FormGestionPreguntas_Load(object sender, EventArgs e)
        {
            //Al cargar el formulario nos carga el contenido de los 3 JSONs de idiomas en el correspondiente objecto del tipo Idioma
            if (File.Exists(fileCatalan) == true)
            {
                JObject jsonIdioma = JObject.Parse(File.ReadAllText(fileCatalan));
                catalan = jsonIdioma.ToObject<Idioma>();
            }
            if (File.Exists(fileCastellano) == true)
            {
                JObject jsonIdioma = JObject.Parse(File.ReadAllText(fileCastellano));
                castellano = jsonIdioma.ToObject<Idioma>();
            }
            if (File.Exists(fileIngles) == true)
            {
                JObject jsonIdioma = JObject.Parse(File.ReadAllText(fileIngles));
                ingles = jsonIdioma.ToObject<Idioma>();
            }
        }

        private void FormGestionPreguntas_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Al cerrar el formulario se guardan los objetos del tipo Idioma, en los JSONs correspondientes, para ello se llama a la función guardarFichero
            guardarFichero(catalan, fileCatalan);
            guardarFichero(castellano, fileCastellano);
            guardarFichero(ingles, fileIngles);
        }
        
        private void buttonNuevaPregunta_Click(object sender, EventArgs e)
        {
            //Al hacer click en el botón "Nova Pregunta" se inicia un formulario del tipo AnadirPregunta, donde se le pasan los 3 idiomas para así poder pasar la información entre forms
            AnadirPregunta anadirPregunta = new AnadirPregunta(castellano,catalan, ingles);

            anadirPregunta.ShowDialog();
        }

        private void comboBoxIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Una vez seleccionado el idioma, habilita la comboBox de Nivel y nos carga las preguntas correspondientes llamando a cargarPreguntas
            comboBoxNivel.Enabled = true;

            cargarPreguntas();

            listBoxPreguntas.ClearSelected();
        }

        private void comboBoxNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Nos carga las preguntas correspondientes llamando a cargarPreguntas
            cargarPreguntas();

            listBoxPreguntas.ClearSelected();
        }

        private void listBoxPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Si hay una pregunta seleccionada, nos carga la dataGridRespuestas con la lista de respuestas de esa pregunta, si no, no nos muestra nada

            dataGridViewRespuestas.AutoGenerateColumns = false;

            Pregunta pregunta = (Pregunta)listBoxPreguntas.SelectedItem;

            if (pregunta != null)
            {
                dataGridViewRespuestas.DataSource = null;
                dataGridViewRespuestas.DataSource = pregunta.respuestas;
            }
            else
            {
                dataGridViewRespuestas.DataSource = null;
            }
        }

        private void buttonModificarPregunta_Click(object sender, EventArgs e)
        {
            //Al hacer click en el botón "Moficicar" se guarda la pregunta seleccionada en un objeto del tipo Pregunta
            Pregunta pregunta = (Pregunta)listBoxPreguntas.SelectedItem;

            //Después se comprueba que realmente se haya seleccionado una pregunta (que pregunta no sea null)
            if (pregunta != null)
            {
                //Si hay una pregunta seleccionada, se guardan en dos String el nivel y el idioma
                String idioma = comboBoxIdioma.SelectedItem.ToString();
                String nivel = comboBoxNivel.SelectedItem.ToString();
               
                //Se crea un formulario del tipo AnadirPregunta, los 3 objetos del tipo Idioma, pasandole la pregunta, y los dos String
                AnadirPregunta modificarPregunta = new AnadirPregunta(castellano, catalan, ingles, pregunta, idioma, nivel);

                modificarPregunta.ShowDialog();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            //Se elimina la pregunta seleccionada de la lista que la contiene llamando a la funcion eliminarPregunta,
            //por ultimo se cargan las preguntas llamando a la función cargarPreguntas
            Pregunta pregunta = (Pregunta)listBoxPreguntas.SelectedItem;

            eliminarPregunta(pregunta);

            cargarPreguntas();
        }


        /// <summary>
        /// Elimina la pregunta que se pasa en el constructor en las lista seleccionada
        /// </summary>
        /// <param name="pregunta"></param>
        private void eliminarPregunta(Pregunta pregunta) 
        {
            //Comprueba el idioma seleccionado y una vez encontrado comprueba el nivel seleccionado para saber donde tiene que eliminar la pregunta
            if(comboBoxIdioma.SelectedItem != null && comboBoxNivel.SelectedItem != null)
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

        /// <summary>
        /// Función donde se implementa guardar el fichero
        /// </summary>
        private void guardarFichero(Idioma nivel, string idioma)
        {
            JObject jArrayNivel = (JObject)JToken.FromObject(nivel); //El objeto del tipo Idioma lo casteamos al tipo JObject y hacemos los pasos para guardar el archivo
            StreamWriter file = File.CreateText(idioma);
            JsonTextWriter jsonWriter = new JsonTextWriter(file);
            jArrayNivel.WriteTo(jsonWriter);
            jsonWriter.Close(); //Cerramos el editor para que se guarden bien los cambios
        }

        /// <summary>
        /// Función que refresca la listBoxPreguntas
        /// </summary>
        /// <param name="preguntas">Lista (BindingList) de preguntas</param>
        private void refrescarPreguntas(BindingList<Pregunta> preguntas)
        {
            listBoxPreguntas.DataSource = null;
            listBoxPreguntas.DataSource = preguntas;
            listBoxPreguntas.DisplayMember = "pregunta";
        }

        /// <summary>
        /// Función que dependiendo del nivel seleccionado, nos llama a la función refrescarPreguntas, pasandole la lista correspondiente
        /// </summary>
        /// <param name="nivel">El nivel</param>
        private void seleccionarNivel(Idioma nivel)
        {
            if (comboBoxNivel.SelectedItem.ToString().Equals("Infantil"))
            {
                refrescarPreguntas(nivel.infantil);
            }
            else if (comboBoxNivel.SelectedItem.ToString().Equals("Adult (Fàcil)"))
            {
                refrescarPreguntas(nivel.facil);
            }
            if (comboBoxNivel.SelectedItem.ToString().Equals("Adult (Intermedi)"))
            {
                refrescarPreguntas(nivel.medio);
            }
            else if (comboBoxNivel.SelectedItem.ToString().Equals("Adult (Difícil)"))
            {
                refrescarPreguntas(nivel.dificil);
            }
        }

        /// <summary>
        /// Función que dependiendo del idioma seleccionado nos llama a la función seleccionarNivel con uno u otro parametro
        /// </summary>
        private void cargarPreguntas()
        {
            if (comboBoxIdioma.SelectedIndex != -1 && comboBoxNivel.SelectedIndex != -1)
            {
                switch (comboBoxIdioma.SelectedItem.ToString())
                {
                    case "Català":
                        seleccionarNivel(catalan);
                        break;
                    case "Castellà":
                        seleccionarNivel(castellano);
                        break;
                    case "Anglès":
                        seleccionarNivel(ingles);
                        break;
                }
            }
        }
    }
}
