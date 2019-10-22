using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ePOSOne.btnProduct; /// <summary>
/// prueba
/// </summary>

namespace AppDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_WOCSuport_MouseDown(object sender, MouseEventArgs e)
        {
            button_WOCSuport.OnHoverButtonColor = Color.DarkGray;
        }

        private void button_WOCSuport_MouseUp(object sender, MouseEventArgs e)
        {
            button_WOCSuport.OnHoverButtonColor = Color.Beige;
        }


        private void button_WOCGestionar_MouseDown(object sender, MouseEventArgs e)
        {
            button_WOCGestionar.OnHoverButtonColor = Color.DarkGray;
        }

        private void button_WOCGestionar_MouseUp(object sender, MouseEventArgs e)
        {
            button_WOCGestionar.OnHoverButtonColor = Color.Beige;
        }
    }
}
