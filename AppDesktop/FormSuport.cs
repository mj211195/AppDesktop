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
        public FormSuport()
        {
            InitializeComponent();
        }

        private void button_WOCEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                String prueba = (String)richTextBoxContacto.Text;
                prueba = prueba.Replace(" ", "%20");
                String mensaje = "/c ipm.note /m space.experience.game@gmail.com&subject=Contacte%20Museu%20Terrassa&body=" + prueba;
                Process.Start("Outlook.exe", mensaje);
            }
            catch
            {
                MessageBox.Show("No s'ha pogut obrir correctament l'Outlook.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
