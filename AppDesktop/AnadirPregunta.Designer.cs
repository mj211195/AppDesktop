namespace AppDesktop
{
    partial class AnadirPregunta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirPregunta));
            this.comboBoxIdioma = new System.Windows.Forms.ComboBox();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvRespuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCorrecta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkBoxCorrecta = new System.Windows.Forms.CheckBox();
            this.textBoxResposta = new System.Windows.Forms.TextBox();
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonAnadir = new System.Windows.Forms.Button();
            this.buttonValidar = new System.Windows.Forms.Button();
            this.labelResposta = new System.Windows.Forms.Label();
            this.labelPregunta = new System.Windows.Forms.Label();
            this.labelNivel = new System.Windows.Forms.Label();
            this.groupBoxAfegirPregunta = new System.Windows.Forms.GroupBox();
            this.labelCarRes = new System.Windows.Forms.Label();
            this.labelCarPre = new System.Windows.Forms.Label();
            this.groupBoxMostrarAjuda = new System.Windows.Forms.GroupBox();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.radioButtonSi = new System.Windows.Forms.RadioButton();
            this.groupBoxGestionRespuestas = new System.Windows.Forms.GroupBox();
            this.toolTipAyuda = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxAfegirPregunta.SuspendLayout();
            this.groupBoxMostrarAjuda.SuspendLayout();
            this.groupBoxGestionRespuestas.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxIdioma
            // 
            this.comboBoxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.Items.AddRange(new object[] {
            "Català",
            "Castellà",
            "Anglès"});
            this.comboBoxIdioma.Location = new System.Drawing.Point(73, 26);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(143, 21);
            this.comboBoxIdioma.TabIndex = 54;
            this.toolTipAyuda.SetToolTip(this.comboBoxIdioma, "Seleccionar l\'idioma de la pregunta");
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Location = new System.Drawing.Point(6, 29);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(38, 13);
            this.labelIdioma.TabIndex = 53;
            this.labelIdioma.Text = "Idioma";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(564, 464);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(108, 23);
            this.buttonGuardar.TabIndex = 52;
            this.buttonGuardar.Text = "Guardar";
            this.toolTipAyuda.SetToolTip(this.buttonGuardar, "Guarda la pregunta");
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvRespuesta,
            this.dgvCorrecta});
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(560, 167);
            this.dataGridView1.TabIndex = 51;
            // 
            // dgvRespuesta
            // 
            this.dgvRespuesta.DataPropertyName = "respuesta";
            this.dgvRespuesta.HeaderText = "Respostes";
            this.dgvRespuesta.Name = "dgvRespuesta";
            this.dgvRespuesta.Width = 400;
            // 
            // dgvCorrecta
            // 
            this.dgvCorrecta.DataPropertyName = "correcta";
            this.dgvCorrecta.HeaderText = "Correcta";
            this.dgvCorrecta.Name = "dgvCorrecta";
            // 
            // checkBoxCorrecta
            // 
            this.checkBoxCorrecta.AutoSize = true;
            this.checkBoxCorrecta.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxCorrecta.Location = new System.Drawing.Point(521, 153);
            this.checkBoxCorrecta.Name = "checkBoxCorrecta";
            this.checkBoxCorrecta.Size = new System.Drawing.Size(51, 31);
            this.checkBoxCorrecta.TabIndex = 49;
            this.checkBoxCorrecta.Text = "Correcta";
            this.toolTipAyuda.SetToolTip(this.checkBoxCorrecta, "Si aquesta resposta és la correcta, s\'ha de marcar amb el tick");
            this.checkBoxCorrecta.UseVisualStyleBackColor = true;
            // 
            // textBoxResposta
            // 
            this.textBoxResposta.Location = new System.Drawing.Point(88, 164);
            this.textBoxResposta.Name = "textBoxResposta";
            this.textBoxResposta.Size = new System.Drawing.Size(417, 20);
            this.textBoxResposta.TabIndex = 47;
            this.textBoxResposta.TextChanged += new System.EventHandler(this.textBoxResposta_TextChanged);
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Location = new System.Drawing.Point(88, 76);
            this.textBoxPregunta.Multiline = true;
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.Size = new System.Drawing.Size(417, 43);
            this.textBoxPregunta.TabIndex = 46;
            this.textBoxPregunta.TextChanged += new System.EventHandler(this.textBoxPregunta_TextChanged);
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Items.AddRange(new object[] {
            "Infantil",
            "Adult (Fàcil)",
            "Adult (Intermedi)",
            "Adult (Difícil)"});
            this.comboBoxNivel.Location = new System.Drawing.Point(482, 26);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(159, 21);
            this.comboBoxNivel.TabIndex = 45;
            this.toolTipAyuda.SetToolTip(this.comboBoxNivel, "Seleccionar el nivel de la pregunta");
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(457, 464);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(101, 23);
            this.buttonReiniciar.TabIndex = 44;
            this.buttonReiniciar.Text = "Reiniciar";
            this.toolTipAyuda.SetToolTip(this.buttonReiniciar, "Buida tots els camps i menús desplegables");
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(578, 86);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 43;
            this.buttonEliminar.Text = "Eliminar seleccionada";
            this.toolTipAyuda.SetToolTip(this.buttonEliminar, "Elimina la pregunta seleccionada");
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonAnadir
            // 
            this.buttonAnadir.Location = new System.Drawing.Point(584, 159);
            this.buttonAnadir.Name = "buttonAnadir";
            this.buttonAnadir.Size = new System.Drawing.Size(75, 23);
            this.buttonAnadir.TabIndex = 41;
            this.buttonAnadir.Text = "Afegir";
            this.buttonAnadir.UseVisualStyleBackColor = true;
            this.buttonAnadir.Click += new System.EventHandler(this.buttonAnadir_Click);
            // 
            // buttonValidar
            // 
            this.buttonValidar.Location = new System.Drawing.Point(543, 74);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(75, 23);
            this.buttonValidar.TabIndex = 40;
            this.buttonValidar.Text = "Validar";
            this.toolTipAyuda.SetToolTip(this.buttonValidar, "Un cop es doni per bona la pregunta, prémer [Validar].\r\nNota: no es podrà afegir " +
        "una pregunta (guardar-la al final) si no està validada!\r\n");
            this.buttonValidar.UseVisualStyleBackColor = true;
            this.buttonValidar.Click += new System.EventHandler(this.buttonValidar_Click);
            // 
            // labelResposta
            // 
            this.labelResposta.AutoSize = true;
            this.labelResposta.Location = new System.Drawing.Point(6, 164);
            this.labelResposta.Name = "labelResposta";
            this.labelResposta.Size = new System.Drawing.Size(52, 13);
            this.labelResposta.TabIndex = 39;
            this.labelResposta.Text = "Resposta";
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.Location = new System.Drawing.Point(6, 76);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(50, 13);
            this.labelPregunta.TabIndex = 38;
            this.labelPregunta.Text = "Pregunta";
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.Location = new System.Drawing.Point(433, 29);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(33, 13);
            this.labelNivel.TabIndex = 37;
            this.labelNivel.Text = "Nivell";
            // 
            // groupBoxAfegirPregunta
            // 
            this.groupBoxAfegirPregunta.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAfegirPregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxAfegirPregunta.Controls.Add(this.labelCarRes);
            this.groupBoxAfegirPregunta.Controls.Add(this.labelCarPre);
            this.groupBoxAfegirPregunta.Controls.Add(this.groupBoxMostrarAjuda);
            this.groupBoxAfegirPregunta.Controls.Add(this.groupBoxGestionRespuestas);
            this.groupBoxAfegirPregunta.Controls.Add(this.labelNivel);
            this.groupBoxAfegirPregunta.Controls.Add(this.buttonGuardar);
            this.groupBoxAfegirPregunta.Controls.Add(this.labelIdioma);
            this.groupBoxAfegirPregunta.Controls.Add(this.buttonReiniciar);
            this.groupBoxAfegirPregunta.Controls.Add(this.comboBoxIdioma);
            this.groupBoxAfegirPregunta.Controls.Add(this.checkBoxCorrecta);
            this.groupBoxAfegirPregunta.Controls.Add(this.comboBoxNivel);
            this.groupBoxAfegirPregunta.Controls.Add(this.labelPregunta);
            this.groupBoxAfegirPregunta.Controls.Add(this.textBoxResposta);
            this.groupBoxAfegirPregunta.Controls.Add(this.buttonAnadir);
            this.groupBoxAfegirPregunta.Controls.Add(this.textBoxPregunta);
            this.groupBoxAfegirPregunta.Controls.Add(this.labelResposta);
            this.groupBoxAfegirPregunta.Controls.Add(this.buttonValidar);
            this.groupBoxAfegirPregunta.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAfegirPregunta.Name = "groupBoxAfegirPregunta";
            this.groupBoxAfegirPregunta.Size = new System.Drawing.Size(686, 493);
            this.groupBoxAfegirPregunta.TabIndex = 55;
            this.groupBoxAfegirPregunta.TabStop = false;
            this.groupBoxAfegirPregunta.Text = "Afegir pregunta";
            // 
            // labelCarRes
            // 
            this.labelCarRes.AutoSize = true;
            this.labelCarRes.Location = new System.Drawing.Point(90, 188);
            this.labelCarRes.Name = "labelCarRes";
            this.labelCarRes.Size = new System.Drawing.Size(0, 13);
            this.labelCarRes.TabIndex = 62;
            this.toolTipAyuda.SetToolTip(this.labelCarRes, "Número de caràcters restants");
            // 
            // labelCarPre
            // 
            this.labelCarPre.AutoSize = true;
            this.labelCarPre.Location = new System.Drawing.Point(88, 123);
            this.labelCarPre.Name = "labelCarPre";
            this.labelCarPre.Size = new System.Drawing.Size(0, 13);
            this.labelCarPre.TabIndex = 61;
            this.toolTipAyuda.SetToolTip(this.labelCarPre, "Número de caràcters restants");
            // 
            // groupBoxMostrarAjuda
            // 
            this.groupBoxMostrarAjuda.Controls.Add(this.radioButtonNo);
            this.groupBoxMostrarAjuda.Controls.Add(this.radioButtonSi);
            this.groupBoxMostrarAjuda.Location = new System.Drawing.Point(12, 431);
            this.groupBoxMostrarAjuda.Name = "groupBoxMostrarAjuda";
            this.groupBoxMostrarAjuda.Size = new System.Drawing.Size(119, 48);
            this.groupBoxMostrarAjuda.TabIndex = 60;
            this.groupBoxMostrarAjuda.TabStop = false;
            this.groupBoxMostrarAjuda.Text = "Mostrar ajuda";
            this.toolTipAyuda.SetToolTip(this.groupBoxMostrarAjuda, "Activa/Desactiva els missatges d\'ajuda");
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Checked = true;
            this.radioButtonNo.Location = new System.Drawing.Point(50, 20);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(39, 17);
            this.radioButtonNo.TabIndex = 1;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "No";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            this.radioButtonNo.CheckedChanged += new System.EventHandler(this.radioButtonNo_CheckedChanged);
            // 
            // radioButtonSi
            // 
            this.radioButtonSi.AutoSize = true;
            this.radioButtonSi.Location = new System.Drawing.Point(7, 20);
            this.radioButtonSi.Name = "radioButtonSi";
            this.radioButtonSi.Size = new System.Drawing.Size(36, 17);
            this.radioButtonSi.TabIndex = 0;
            this.radioButtonSi.Text = "Sí";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            this.radioButtonSi.CheckedChanged += new System.EventHandler(this.radioButtonSi_CheckedChanged);
            // 
            // groupBoxGestionRespuestas
            // 
            this.groupBoxGestionRespuestas.Controls.Add(this.dataGridView1);
            this.groupBoxGestionRespuestas.Controls.Add(this.buttonEliminar);
            this.groupBoxGestionRespuestas.Location = new System.Drawing.Point(6, 216);
            this.groupBoxGestionRespuestas.Name = "groupBoxGestionRespuestas";
            this.groupBoxGestionRespuestas.Size = new System.Drawing.Size(670, 209);
            this.groupBoxGestionRespuestas.TabIndex = 55;
            this.groupBoxGestionRespuestas.TabStop = false;
            this.groupBoxGestionRespuestas.Text = "Graella de respostes";
            // 
            // toolTipAyuda
            // 
            this.toolTipAyuda.AutomaticDelay = 250;
            this.toolTipAyuda.AutoPopDelay = 10000;
            this.toolTipAyuda.InitialDelay = 250;
            this.toolTipAyuda.ReshowDelay = 50;
            this.toolTipAyuda.ToolTipTitle = "Ajuda";
            // 
            // AnadirPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppDesktop.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 517);
            this.Controls.Add(this.groupBoxAfegirPregunta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(721, 556);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(721, 556);
            this.Name = "AnadirPregunta";
            this.Text = "Afegir pregunta";
            this.Load += new System.EventHandler(this.AnadirPregunta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxAfegirPregunta.ResumeLayout(false);
            this.groupBoxAfegirPregunta.PerformLayout();
            this.groupBoxMostrarAjuda.ResumeLayout(false);
            this.groupBoxMostrarAjuda.PerformLayout();
            this.groupBoxGestionRespuestas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIdioma;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxCorrecta;
        private System.Windows.Forms.TextBox textBoxResposta;
        private System.Windows.Forms.TextBox textBoxPregunta;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.Button buttonReiniciar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonAnadir;
        private System.Windows.Forms.Button buttonValidar;
        private System.Windows.Forms.Label labelResposta;
        private System.Windows.Forms.Label labelPregunta;
        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.GroupBox groupBoxAfegirPregunta;
        private System.Windows.Forms.GroupBox groupBoxGestionRespuestas;
        private System.Windows.Forms.ToolTip toolTipAyuda;
        private System.Windows.Forms.GroupBox groupBoxMostrarAjuda;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.RadioButton radioButtonSi;
        private System.Windows.Forms.Label labelCarPre;
        private System.Windows.Forms.Label labelCarRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRespuesta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvCorrecta;
    }
}