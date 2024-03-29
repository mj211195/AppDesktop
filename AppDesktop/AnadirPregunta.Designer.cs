﻿namespace AppDesktop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirPregunta));
            this.comboBoxIdioma = new System.Windows.Forms.ComboBox();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.dataGridViewRespuestas = new System.Windows.Forms.DataGridView();
            this.checkBoxCorrecta = new System.Windows.Forms.CheckBox();
            this.textBoxResposta = new System.Windows.Forms.TextBox();
            this.textBoxPregunta = new System.Windows.Forms.TextBox();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
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
            this.button_WOC_Afegir = new AppDesktop.Button_WOC();
            this.button_WOC_Guardar = new AppDesktop.Button_WOC();
            this.button_WOC_Reiniciar = new AppDesktop.Button_WOC();
            this.button_WOC_Eliminar = new AppDesktop.Button_WOC();
            this.dgvRespuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCorrecta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRespuestas)).BeginInit();
            this.groupBoxAfegirPregunta.SuspendLayout();
            this.groupBoxMostrarAjuda.SuspendLayout();
            this.groupBoxGestionRespuestas.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxIdioma
            // 
            this.comboBoxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdioma.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.Items.AddRange(new object[] {
            "Català",
            "Castellà",
            "Anglès"});
            this.comboBoxIdioma.Location = new System.Drawing.Point(88, 26);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(143, 21);
            this.comboBoxIdioma.TabIndex = 0;
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.labelIdioma.Location = new System.Drawing.Point(6, 29);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(49, 14);
            this.labelIdioma.TabIndex = 53;
            this.labelIdioma.Text = "Idioma";
            this.toolTipAyuda.SetToolTip(this.labelIdioma, "Seleccionar l\'idioma de la pregunta");
            // 
            // dataGridViewRespuestas
            // 
            this.dataGridViewRespuestas.AllowUserToAddRows = false;
            this.dataGridViewRespuestas.AllowUserToDeleteRows = false;
            this.dataGridViewRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRespuestas.ColumnHeadersVisible = false;
            this.dataGridViewRespuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvRespuesta,
            this.dgvCorrecta});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.5F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRespuestas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRespuestas.Location = new System.Drawing.Point(6, 30);
            this.dataGridViewRespuestas.MultiSelect = false;
            this.dataGridViewRespuestas.Name = "dataGridViewRespuestas";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRespuestas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRespuestas.RowHeadersVisible = false;
            this.dataGridViewRespuestas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRespuestas.Size = new System.Drawing.Size(461, 93);
            this.dataGridViewRespuestas.TabIndex = 6;
            // 
            // checkBoxCorrecta
            // 
            this.checkBoxCorrecta.AutoSize = true;
            this.checkBoxCorrecta.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBoxCorrecta.Font = new System.Drawing.Font("Consolas", 8F);
            this.checkBoxCorrecta.Location = new System.Drawing.Point(519, 154);
            this.checkBoxCorrecta.Name = "checkBoxCorrecta";
            this.checkBoxCorrecta.Size = new System.Drawing.Size(59, 31);
            this.checkBoxCorrecta.TabIndex = 4;
            this.checkBoxCorrecta.Text = "Correcta";
            this.toolTipAyuda.SetToolTip(this.checkBoxCorrecta, "Si aquesta resposta és la correcta, s\'ha de marcar amb el tick. Es podrà modifica" +
        "r a la graella en cas de que així ho desitgi");
            this.checkBoxCorrecta.UseVisualStyleBackColor = true;
            // 
            // textBoxResposta
            // 
            this.textBoxResposta.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.textBoxResposta.Location = new System.Drawing.Point(88, 163);
            this.textBoxResposta.Name = "textBoxResposta";
            this.textBoxResposta.Size = new System.Drawing.Size(417, 21);
            this.textBoxResposta.TabIndex = 3;
            this.textBoxResposta.TextChanged += new System.EventHandler(this.textBoxResposta_TextChanged);
            // 
            // textBoxPregunta
            // 
            this.textBoxPregunta.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.textBoxPregunta.Location = new System.Drawing.Point(88, 75);
            this.textBoxPregunta.Multiline = true;
            this.textBoxPregunta.Name = "textBoxPregunta";
            this.textBoxPregunta.Size = new System.Drawing.Size(417, 43);
            this.textBoxPregunta.TabIndex = 2;
            this.textBoxPregunta.TextChanged += new System.EventHandler(this.textBoxPregunta_TextChanged);
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNivel.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Items.AddRange(new object[] {
            "Infantil",
            "Adult (Fàcil)",
            "Adult (Intermedi)",
            "Adult (Difícil)"});
            this.comboBoxNivel.Location = new System.Drawing.Point(490, 26);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(159, 21);
            this.comboBoxNivel.TabIndex = 1;
            // 
            // labelResposta
            // 
            this.labelResposta.AutoSize = true;
            this.labelResposta.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.labelResposta.Location = new System.Drawing.Point(6, 164);
            this.labelResposta.Name = "labelResposta";
            this.labelResposta.Size = new System.Drawing.Size(63, 14);
            this.labelResposta.TabIndex = 39;
            this.labelResposta.Text = "Resposta";
            this.toolTipAyuda.SetToolTip(this.labelResposta, "Les respostes de la pregunta. Hauran de ser cuatre");
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.labelPregunta.Location = new System.Drawing.Point(6, 76);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(63, 14);
            this.labelPregunta.TabIndex = 38;
            this.labelPregunta.Text = "Pregunta";
            this.toolTipAyuda.SetToolTip(this.labelPregunta, "La pregunta com a tal");
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.labelNivel.Location = new System.Drawing.Point(427, 29);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(49, 14);
            this.labelNivel.TabIndex = 37;
            this.labelNivel.Text = "Nivell";
            this.toolTipAyuda.SetToolTip(this.labelNivel, "Seleccionar el nivell de la pregunta");
            // 
            // groupBoxAfegirPregunta
            // 
            this.groupBoxAfegirPregunta.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAfegirPregunta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxAfegirPregunta.Controls.Add(this.button_WOC_Afegir);
            this.groupBoxAfegirPregunta.Controls.Add(this.button_WOC_Guardar);
            this.groupBoxAfegirPregunta.Controls.Add(this.button_WOC_Reiniciar);
            this.groupBoxAfegirPregunta.Controls.Add(this.labelCarRes);
            this.groupBoxAfegirPregunta.Controls.Add(this.labelCarPre);
            this.groupBoxAfegirPregunta.Controls.Add(this.groupBoxMostrarAjuda);
            this.groupBoxAfegirPregunta.Controls.Add(this.groupBoxGestionRespuestas);
            this.groupBoxAfegirPregunta.Controls.Add(this.labelNivel);
            this.groupBoxAfegirPregunta.Controls.Add(this.labelIdioma);
            this.groupBoxAfegirPregunta.Controls.Add(this.comboBoxIdioma);
            this.groupBoxAfegirPregunta.Controls.Add(this.checkBoxCorrecta);
            this.groupBoxAfegirPregunta.Controls.Add(this.comboBoxNivel);
            this.groupBoxAfegirPregunta.Controls.Add(this.labelPregunta);
            this.groupBoxAfegirPregunta.Controls.Add(this.textBoxResposta);
            this.groupBoxAfegirPregunta.Controls.Add(this.textBoxPregunta);
            this.groupBoxAfegirPregunta.Controls.Add(this.labelResposta);
            this.groupBoxAfegirPregunta.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBoxAfegirPregunta.Location = new System.Drawing.Point(10, 12);
            this.groupBoxAfegirPregunta.Name = "groupBoxAfegirPregunta";
            this.groupBoxAfegirPregunta.Size = new System.Drawing.Size(686, 402);
            this.groupBoxAfegirPregunta.TabIndex = 0;
            this.groupBoxAfegirPregunta.TabStop = false;
            this.groupBoxAfegirPregunta.Text = "Afegir pregunta";
            // 
            // labelCarRes
            // 
            this.labelCarRes.AutoSize = true;
            this.labelCarRes.Font = new System.Drawing.Font("Consolas", 8F);
            this.labelCarRes.Location = new System.Drawing.Point(90, 188);
            this.labelCarRes.Name = "labelCarRes";
            this.labelCarRes.Size = new System.Drawing.Size(0, 13);
            this.labelCarRes.TabIndex = 62;
            this.toolTipAyuda.SetToolTip(this.labelCarRes, "Número de caràcters restants");
            // 
            // labelCarPre
            // 
            this.labelCarPre.AutoSize = true;
            this.labelCarPre.Font = new System.Drawing.Font("Consolas", 8F);
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
            this.groupBoxMostrarAjuda.Location = new System.Drawing.Point(9, 355);
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
            this.radioButtonNo.Size = new System.Drawing.Size(39, 18);
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
            this.radioButtonSi.Size = new System.Drawing.Size(39, 18);
            this.radioButtonSi.TabIndex = 10;
            this.radioButtonSi.Text = "Sí";
            this.radioButtonSi.UseVisualStyleBackColor = true;
            this.radioButtonSi.CheckedChanged += new System.EventHandler(this.radioButtonSi_CheckedChanged);
            // 
            // groupBoxGestionRespuestas
            // 
            this.groupBoxGestionRespuestas.Controls.Add(this.button_WOC_Eliminar);
            this.groupBoxGestionRespuestas.Controls.Add(this.dataGridViewRespuestas);
            this.groupBoxGestionRespuestas.Font = new System.Drawing.Font("Consolas", 8F);
            this.groupBoxGestionRespuestas.Location = new System.Drawing.Point(55, 212);
            this.groupBoxGestionRespuestas.Name = "groupBoxGestionRespuestas";
            this.groupBoxGestionRespuestas.Size = new System.Drawing.Size(583, 146);
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
            // 
            // button_WOC_Afegir
            // 
            this.button_WOC_Afegir.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Afegir.BorderColor = System.Drawing.Color.Black;
            this.button_WOC_Afegir.ButtonColor = System.Drawing.SystemColors.Info;
            this.button_WOC_Afegir.FlatAppearance.BorderSize = 0;
            this.button_WOC_Afegir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Afegir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Afegir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC_Afegir.Font = new System.Drawing.Font("Consolas", 10F);
            this.button_WOC_Afegir.Location = new System.Drawing.Point(580, 163);
            this.button_WOC_Afegir.Name = "button_WOC_Afegir";
            this.button_WOC_Afegir.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC_Afegir.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOC_Afegir.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC_Afegir.Size = new System.Drawing.Size(90, 23);
            this.button_WOC_Afegir.TabIndex = 5;
            this.button_WOC_Afegir.Text = "Afegir";
            this.button_WOC_Afegir.TextColor = System.Drawing.Color.Black;
            this.toolTipAyuda.SetToolTip(this.button_WOC_Afegir, "Afegeix la reposta a la graella de respostes");
            this.button_WOC_Afegir.UseVisualStyleBackColor = false;
            this.button_WOC_Afegir.Click += new System.EventHandler(this.button_WOC_Afegir_Click);
            // 
            // button_WOC_Guardar
            // 
            this.button_WOC_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Guardar.BorderColor = System.Drawing.Color.Black;
            this.button_WOC_Guardar.ButtonColor = System.Drawing.SystemColors.Info;
            this.button_WOC_Guardar.FlatAppearance.BorderSize = 0;
            this.button_WOC_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC_Guardar.Font = new System.Drawing.Font("Consolas", 10F);
            this.button_WOC_Guardar.Location = new System.Drawing.Point(576, 368);
            this.button_WOC_Guardar.Name = "button_WOC_Guardar";
            this.button_WOC_Guardar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC_Guardar.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOC_Guardar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC_Guardar.Size = new System.Drawing.Size(90, 23);
            this.button_WOC_Guardar.TabIndex = 8;
            this.button_WOC_Guardar.Text = "Guardar";
            this.button_WOC_Guardar.TextColor = System.Drawing.Color.Black;
            this.toolTipAyuda.SetToolTip(this.button_WOC_Guardar, "Guarda la pregunta i l\'afegeix a una llista segons el nivell i l\'idioma seleccion" +
        "at");
            this.button_WOC_Guardar.UseVisualStyleBackColor = false;
            this.button_WOC_Guardar.Click += new System.EventHandler(this.button_WOC_Guardar_Click);
            // 
            // button_WOC_Reiniciar
            // 
            this.button_WOC_Reiniciar.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Reiniciar.BorderColor = System.Drawing.Color.Black;
            this.button_WOC_Reiniciar.ButtonColor = System.Drawing.SystemColors.Info;
            this.button_WOC_Reiniciar.FlatAppearance.BorderSize = 0;
            this.button_WOC_Reiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Reiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Reiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC_Reiniciar.Font = new System.Drawing.Font("Consolas", 10F);
            this.button_WOC_Reiniciar.Location = new System.Drawing.Point(473, 368);
            this.button_WOC_Reiniciar.Name = "button_WOC_Reiniciar";
            this.button_WOC_Reiniciar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC_Reiniciar.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOC_Reiniciar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC_Reiniciar.Size = new System.Drawing.Size(90, 23);
            this.button_WOC_Reiniciar.TabIndex = 9;
            this.button_WOC_Reiniciar.Text = "Reiniciar";
            this.button_WOC_Reiniciar.TextColor = System.Drawing.Color.Black;
            this.toolTipAyuda.SetToolTip(this.button_WOC_Reiniciar, "Buida tots els camps");
            this.button_WOC_Reiniciar.UseVisualStyleBackColor = false;
            this.button_WOC_Reiniciar.Click += new System.EventHandler(this.button_WOC_Reiniciar_Click);
            // 
            // button_WOC_Eliminar
            // 
            this.button_WOC_Eliminar.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Eliminar.BorderColor = System.Drawing.Color.Black;
            this.button_WOC_Eliminar.ButtonColor = System.Drawing.SystemColors.Info;
            this.button_WOC_Eliminar.FlatAppearance.BorderSize = 0;
            this.button_WOC_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC_Eliminar.Font = new System.Drawing.Font("Consolas", 10F);
            this.button_WOC_Eliminar.Location = new System.Drawing.Point(484, 67);
            this.button_WOC_Eliminar.Name = "button_WOC_Eliminar";
            this.button_WOC_Eliminar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC_Eliminar.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOC_Eliminar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC_Eliminar.Size = new System.Drawing.Size(90, 23);
            this.button_WOC_Eliminar.TabIndex = 7;
            this.button_WOC_Eliminar.Text = "Eliminar";
            this.button_WOC_Eliminar.TextColor = System.Drawing.Color.Black;
            this.toolTipAyuda.SetToolTip(this.button_WOC_Eliminar, "Elimina una resposta de la graella. En cas de que es vulgui editar, només cal fer" +
        " doble click on es vulgui editar");
            this.button_WOC_Eliminar.UseVisualStyleBackColor = false;
            this.button_WOC_Eliminar.Click += new System.EventHandler(this.button_WOC_Eliminar_Click);
            // 
            // dgvRespuesta
            // 
            this.dgvRespuesta.DataPropertyName = "respuesta";
            this.dgvRespuesta.HeaderText = "Respostes";
            this.dgvRespuesta.Name = "dgvRespuesta";
            this.dgvRespuesta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRespuesta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvRespuesta.Width = 355;
            // 
            // dgvCorrecta
            // 
            this.dgvCorrecta.DataPropertyName = "correcta";
            this.dgvCorrecta.HeaderText = "Correcta";
            this.dgvCorrecta.Name = "dgvCorrecta";
            this.dgvCorrecta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCorrecta.Width = 103;
            // 
            // AnadirPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppDesktop.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 428);
            this.Controls.Add(this.groupBoxAfegirPregunta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(721, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(721, 400);
            this.Name = "AnadirPregunta";
            this.Text = "Afegir pregunta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnadirPregunta_FormClosing);
            this.Load += new System.EventHandler(this.AnadirPregunta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRespuestas)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewRespuestas;
        private System.Windows.Forms.CheckBox checkBoxCorrecta;
        private System.Windows.Forms.TextBox textBoxResposta;
        private System.Windows.Forms.TextBox textBoxPregunta;
        private System.Windows.Forms.ComboBox comboBoxNivel;
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
        private Button_WOC button_WOC_Reiniciar;
        private Button_WOC button_WOC_Guardar;
        private Button_WOC button_WOC_Eliminar;
        private Button_WOC button_WOC_Afegir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRespuesta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgvCorrecta;
    }
}