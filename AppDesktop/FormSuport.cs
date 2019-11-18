using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class FormSuport : Form
    {
        private const String DEFAULT_MSG =
            "Si us plau, escrigui el que ens vulgui comunicar deixant un email/telèfon de contacte." +
            "\nGràcies.";

        public FormSuport()
        {
            InitializeComponent();
        }

        private void FormSuport_Load(object sender, EventArgs e)
        {
            richTextBoxContacto.Text = DEFAULT_MSG;
        }

        private void button_WOCEnviar_Click(object sender, EventArgs e)
        {
            //Se intenta abrir el Outlook, el 'body' del mail será el texto del textBoxContacto
            try
            {
                String prueba = (String)richTextBoxContacto.Text;
                //Se tienen que reemplazar algunos carácteres para cargar correctamente Outlook
                prueba = prueba.Replace(" ", "%20");
                prueba = prueba.Replace("\n", "%0A");
                prueba = prueba.Replace(",", "%2C");

                String mensaje = "/c ipm.note /m space.experience.game@gmail.com&subject=Contacte%20Museu%20Terrassa&body=" + prueba;
                Process.Start("Outlook.exew", mensaje);
            }
            //En caso de que haya algún problema, mostrará error y más tarde cerrará el formulario
            catch
            {   
                DialogResult resultado =  MessageBox.Show("No s'ha pogut obrir correctament l'Outlook." +
                    "\n\nSi us plau, enviï'ns un correu expressant el seu problema/suggeriment al nostre correu: space.experience.game@gmail.com." +
                    "\nGràcies.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                if (resultado == DialogResult.OK)
                {
                    Close();
                }
            }
        }

        private void button_WOCreiniciar_Click(object sender, EventArgs e)
        {
            richTextBoxContacto.Text = null;
        }
    }
}
