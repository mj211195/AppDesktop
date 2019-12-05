using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace AppDesktop
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_WOCGestionar_Click(object sender, EventArgs e)
        {
            FormGestionPreguntas formGestionar = new FormGestionPreguntas();
            formGestionar.Show();
        }

        private void button_WOCSuport_Click(object sender, EventArgs e)
        {
            FormSuport formSuport = new FormSuport();
            formSuport.ShowDialog();
        }

        private void toolStripButtonSortir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonGestionar_Click(object sender, EventArgs e)
        {
            FormGestionPreguntas formGestionar = new FormGestionPreguntas();
            formGestionar.Show();
        }

        private void toolStripButtonSuport_Click(object sender, EventArgs e)
        {
            FormSuport formSuport = new FormSuport();
            formSuport.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeControlStyles(button_WOCGestionar, ControlStyles.Selectable, false);
            ChangeControlStyles(button_WOCSuport, ControlStyles.Selectable, false);
        }
        //Método que anula la selección de los botones
        private void ChangeControlStyles(Control ctrl, ControlStyles flag, bool value)
        {
            MethodInfo method = ctrl.GetType().GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.NonPublic);
            if (method != null)
                method.Invoke(ctrl, new object[] { flag, value });
        }
    }
}
