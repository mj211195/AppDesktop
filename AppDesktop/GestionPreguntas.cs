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
    public partial class FormGestionPreguntas : Form
    {
        Nivel castellano = new Nivel();
        Nivel ingles = new Nivel();
        Nivel catalan = new Nivel();
        string fileCatalan = @"..\..\JSONs\catalan.json";
        string fileCastellano = @"..\..\JSONs\castellano.json";
        string fileIngles = @"..\..\JSONs\ingles.json";
        public FormGestionPreguntas()
        {
            InitializeComponent();
        }

        private void guardarFichero(Nivel nivel, string idioma) //Función donde se implementa guardar el fichero
        {
            JArray jArrayNivel = (JArray)JToken.FromObject(nivel); //La lista de peliculas la casteamos al tipo JArray y hacemos los pasos para guardar el archivo 
            StreamWriter file = File.CreateText(idioma);
            JsonTextWriter jsonWriter = new JsonTextWriter(file);
            jArrayNivel.WriteTo(jsonWriter);
            jsonWriter.Close(); //Cerramos el editor para que se guarden bien los cambios
        }

        private Nivel cargarFichero(Nivel nivel, string idioma)
        {
            if (File.Exists(idioma) == true)
            {
                JArray jArrayNivel = JArray.Parse(File.ReadAllText(idioma));
                nivel = jArrayNivel.ToObject<Nivel>();
            }
            return nivel;
        }
        
        private void refrescarPreguntas(BindingList<Pregunta> preguntas)
        {
            listBoxPreguntas.DataSource = null;
            listBoxPreguntas.DataSource = preguntas;
            listBoxPreguntas.DisplayMember = "pregunta";
        }

        private void seleccionarNivel(Nivel nivel)
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

        private void CargarPreguntas()
        {
            if (comboBoxIdioma.SelectedIndex != -1 && comboBoxNivel.SelectedIndex != -1)
            {
                switch (comboBoxIdioma.SelectedItem.ToString())
                {
                    case "Català":
                        //catalan = cargarFichero(catalan, fileCatalan);
                        seleccionarNivel(catalan);
                        break;
                    case "Castellà":
                        //castellano = cargarFichero(castellano, fileCastellano);
                        seleccionarNivel(castellano);
                        break;
                    case "Anglès":
                        //ingles = cargarFichero(ingles, fileIngles);
                        seleccionarNivel(ingles);
                        break;
                }
            }
        }

        
        private void buttonNuevaPregunta_Click(object sender, EventArgs e)
        {
            AnadirPregunta anadirPregunta = new AnadirPregunta(castellano,catalan, ingles);
            anadirPregunta.ShowDialog();

            int i = 0;
        }

        private void comboBoxIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNivel.Enabled = true;
            CargarPreguntas();
        }

        private void comboBoxNivel_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPreguntas();
        }

        private void listBoxPreguntas_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewRespuestas.AutoGenerateColumns = false;
            Pregunta pregunta = (Pregunta)listBoxPreguntas.SelectedItem;
            if (pregunta != null)
            {
                dataGridViewRespuestas.DataSource = null;
                dataGridViewRespuestas.DataSource = pregunta.respuestas;
            }else
            {
                dataGridViewRespuestas.DataSource = null;
            }
        }

        private void buttonModificarPregunta_Click(object sender, EventArgs e)
        {
            Pregunta pregunta = (Pregunta)listBoxPreguntas.SelectedItem;
            String idioma = comboBoxIdioma.SelectedItem.ToString();
            String nivel = comboBoxNivel.SelectedItem.ToString();
            if (pregunta != null)
            {
                AnadirPregunta modificarPregunta = new AnadirPregunta(castellano, catalan, ingles, pregunta, idioma, nivel);
                modificarPregunta.ShowDialog();
            }
            else
            {
                //dataGridViewRespuestas.DataSource = null;
            }
        }
    }
}
