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
        public AnadirPregunta()
        {
            InitializeComponent();
        }

        private void buttonAyuda_Click(object sender, EventArgs e)
        {
            FormAyuda f = new FormAyuda();

            f.Show();
        }
    }
}
