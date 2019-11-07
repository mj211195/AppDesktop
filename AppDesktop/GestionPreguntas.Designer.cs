namespace AppDesktop
{
    partial class FormGestionPreguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionPreguntas));
            this.labelNivel = new System.Windows.Forms.Label();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.buttonNuevaPregunta = new System.Windows.Forms.Button();
            this.buttonModificarPregunta = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelPreguntas = new System.Windows.Forms.Label();
            this.groupBoxPreguntas = new System.Windows.Forms.GroupBox();
            this.dataGridViewRespuestas = new System.Windows.Forms.DataGridView();
            this.respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correcta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelRespuestas = new System.Windows.Forms.Label();
            this.listBoxPreguntas = new System.Windows.Forms.ListBox();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.comboBoxIdioma = new System.Windows.Forms.ComboBox();
            this.groupBoxPreguntas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRespuestas)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.Location = new System.Drawing.Point(313, 31);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(36, 13);
            this.labelNivel.TabIndex = 0;
            this.labelNivel.Text = "Nivell:";
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNivel.Enabled = false;
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Items.AddRange(new object[] {
            "Infantil",
            "Adult (Fàcil)",
            "Adult (Intermedi)",
            "Adult (Difícil)"});
            this.comboBoxNivel.Location = new System.Drawing.Point(355, 28);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(204, 21);
            this.comboBoxNivel.TabIndex = 1;
            this.comboBoxNivel.SelectedIndexChanged += new System.EventHandler(this.comboBoxNivel_SelectedIndexChanged);
            // 
            // buttonNuevaPregunta
            // 
            this.buttonNuevaPregunta.Location = new System.Drawing.Point(18, 19);
            this.buttonNuevaPregunta.Name = "buttonNuevaPregunta";
            this.buttonNuevaPregunta.Size = new System.Drawing.Size(101, 23);
            this.buttonNuevaPregunta.TabIndex = 2;
            this.buttonNuevaPregunta.Text = "Nova pregunta";
            this.buttonNuevaPregunta.UseVisualStyleBackColor = true;
            this.buttonNuevaPregunta.Click += new System.EventHandler(this.buttonNuevaPregunta_Click);
            // 
            // buttonModificarPregunta
            // 
            this.buttonModificarPregunta.Location = new System.Drawing.Point(125, 19);
            this.buttonModificarPregunta.Name = "buttonModificarPregunta";
            this.buttonModificarPregunta.Size = new System.Drawing.Size(101, 23);
            this.buttonModificarPregunta.TabIndex = 3;
            this.buttonModificarPregunta.Text = "Modificar";
            this.buttonModificarPregunta.UseVisualStyleBackColor = true;
            this.buttonModificarPregunta.Click += new System.EventHandler(this.buttonModificarPregunta_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(232, 19);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(101, 23);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelPreguntas
            // 
            this.labelPreguntas.AutoSize = true;
            this.labelPreguntas.Location = new System.Drawing.Point(15, 56);
            this.labelPreguntas.Name = "labelPreguntas";
            this.labelPreguntas.Size = new System.Drawing.Size(58, 13);
            this.labelPreguntas.TabIndex = 5;
            this.labelPreguntas.Text = "Preguntes:";
            // 
            // groupBoxPreguntas
            // 
            this.groupBoxPreguntas.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPreguntas.Controls.Add(this.dataGridViewRespuestas);
            this.groupBoxPreguntas.Controls.Add(this.labelRespuestas);
            this.groupBoxPreguntas.Controls.Add(this.listBoxPreguntas);
            this.groupBoxPreguntas.Controls.Add(this.labelPreguntas);
            this.groupBoxPreguntas.Controls.Add(this.buttonEliminar);
            this.groupBoxPreguntas.Controls.Add(this.buttonNuevaPregunta);
            this.groupBoxPreguntas.Controls.Add(this.buttonModificarPregunta);
            this.groupBoxPreguntas.Location = new System.Drawing.Point(14, 79);
            this.groupBoxPreguntas.Name = "groupBoxPreguntas";
            this.groupBoxPreguntas.Size = new System.Drawing.Size(846, 390);
            this.groupBoxPreguntas.TabIndex = 6;
            this.groupBoxPreguntas.TabStop = false;
            // 
            // dataGridViewRespuestas
            // 
            this.dataGridViewRespuestas.AllowUserToAddRows = false;
            this.dataGridViewRespuestas.AllowUserToDeleteRows = false;
            this.dataGridViewRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRespuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.respuesta,
            this.Correcta});
            this.dataGridViewRespuestas.Location = new System.Drawing.Point(393, 72);
            this.dataGridViewRespuestas.Name = "dataGridViewRespuestas";
            this.dataGridViewRespuestas.ReadOnly = true;
            this.dataGridViewRespuestas.Size = new System.Drawing.Size(425, 290);
            this.dataGridViewRespuestas.TabIndex = 8;
            // 
            // respuesta
            // 
            this.respuesta.DataPropertyName = "respuesta";
            this.respuesta.HeaderText = "Resposta";
            this.respuesta.Name = "respuesta";
            this.respuesta.ReadOnly = true;
            this.respuesta.Width = 280;
            // 
            // Correcta
            // 
            this.Correcta.DataPropertyName = "correcta";
            this.Correcta.HeaderText = "Correcta";
            this.Correcta.Name = "Correcta";
            this.Correcta.ReadOnly = true;
            // 
            // labelRespuestas
            // 
            this.labelRespuestas.AutoSize = true;
            this.labelRespuestas.Location = new System.Drawing.Point(390, 55);
            this.labelRespuestas.Name = "labelRespuestas";
            this.labelRespuestas.Size = new System.Drawing.Size(60, 13);
            this.labelRespuestas.TabIndex = 7;
            this.labelRespuestas.Text = "Respostes:";
            // 
            // listBoxPreguntas
            // 
            this.listBoxPreguntas.FormattingEnabled = true;
            this.listBoxPreguntas.Location = new System.Drawing.Point(18, 72);
            this.listBoxPreguntas.Name = "listBoxPreguntas";
            this.listBoxPreguntas.Size = new System.Drawing.Size(322, 290);
            this.listBoxPreguntas.TabIndex = 6;
            this.listBoxPreguntas.SelectedIndexChanged += new System.EventHandler(this.listBoxPreguntas_SelectedIndexChanged);
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Location = new System.Drawing.Point(13, 31);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(41, 13);
            this.labelIdioma.TabIndex = 7;
            this.labelIdioma.Text = "Idioma:";
            // 
            // comboBoxIdioma
            // 
            this.comboBoxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.Items.AddRange(new object[] {
            "Català",
            "Castellà",
            "Anglès"});
            this.comboBoxIdioma.Location = new System.Drawing.Point(60, 28);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(204, 21);
            this.comboBoxIdioma.TabIndex = 8;
            this.comboBoxIdioma.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdioma_SelectedIndexChanged);
            // 
            // FormGestionPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppDesktop.Properties.Resources.grande_fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 478);
            this.Controls.Add(this.comboBoxIdioma);
            this.Controls.Add(this.labelIdioma);
            this.Controls.Add(this.groupBoxPreguntas);
            this.Controls.Add(this.comboBoxNivel);
            this.Controls.Add(this.labelNivel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGestionPreguntas";
            this.Text = "Gestió de preguntes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestionPreguntas_FormClosing);
            this.Load += new System.EventHandler(this.FormGestionPreguntas_Load);
            this.groupBoxPreguntas.ResumeLayout(false);
            this.groupBoxPreguntas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRespuestas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.Button buttonNuevaPregunta;
        private System.Windows.Forms.Button buttonModificarPregunta;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label labelPreguntas;
        private System.Windows.Forms.GroupBox groupBoxPreguntas;
        private System.Windows.Forms.ListBox listBoxPreguntas;
        private System.Windows.Forms.Label labelRespuestas;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.ComboBox comboBoxIdioma;
        private System.Windows.Forms.DataGridView dataGridViewRespuestas;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuesta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Correcta;
    }
}