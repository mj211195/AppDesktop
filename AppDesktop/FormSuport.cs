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

        private void linkLabelCorreo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("Outlook.exe", "/c ipm.note /m carlos25840@gmail.com");
        }
    }
}
