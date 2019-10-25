﻿using System;
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
    public partial class FormGestionPreguntas : Form
    {
        public FormGestionPreguntas()
        {
            InitializeComponent();
        }

        private void buttonNuevaPregunta_Click(object sender, EventArgs e)
        {
            AnadirPregunta anadirPregunta = new AnadirPregunta();
            anadirPregunta.ShowDialog();
        }

        private void comboBoxIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNivel.Enabled = true;
        }
    }
}
