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
            this.labelPreguntas = new System.Windows.Forms.Label();
            this.groupBoxPreguntas = new System.Windows.Forms.GroupBox();
            this.button_WOC_Eliminar = new AppDesktop.Button_WOC();
            this.button_WOC_Modificar = new AppDesktop.Button_WOC();
            this.button_WOC_NovaPregunta = new AppDesktop.Button_WOC();
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
            this.labelNivel.Font = new System.Drawing.Font("Consolas", 9F);
            this.labelNivel.Location = new System.Drawing.Point(340, 31);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(49, 14);
            this.labelNivel.TabIndex = 0;
            this.labelNivel.Text = "Nivell";
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNivel.Enabled = false;
            this.comboBoxNivel.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Items.AddRange(new object[] {
            "Infantil",
            "Adult (Fàcil)",
            "Adult (Intermedi)",
            "Adult (Difícil)"});
            this.comboBoxNivel.Location = new System.Drawing.Point(400, 28);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(204, 22);
            this.comboBoxNivel.TabIndex = 1;
            this.comboBoxNivel.SelectedIndexChanged += new System.EventHandler(this.comboBoxNivel_SelectedIndexChanged);
            // 
            // labelPreguntas
            // 
            this.labelPreguntas.AutoSize = true;
            this.labelPreguntas.Location = new System.Drawing.Point(15, 56);
            this.labelPreguntas.Name = "labelPreguntas";
            this.labelPreguntas.Size = new System.Drawing.Size(70, 14);
            this.labelPreguntas.TabIndex = 5;
            this.labelPreguntas.Text = "Preguntes";
            // 
            // groupBoxPreguntas
            // 
            this.groupBoxPreguntas.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPreguntas.Controls.Add(this.button_WOC_Eliminar);
            this.groupBoxPreguntas.Controls.Add(this.button_WOC_Modificar);
            this.groupBoxPreguntas.Controls.Add(this.button_WOC_NovaPregunta);
            this.groupBoxPreguntas.Controls.Add(this.dataGridViewRespuestas);
            this.groupBoxPreguntas.Controls.Add(this.labelRespuestas);
            this.groupBoxPreguntas.Controls.Add(this.listBoxPreguntas);
            this.groupBoxPreguntas.Controls.Add(this.labelPreguntas);
            this.groupBoxPreguntas.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBoxPreguntas.Location = new System.Drawing.Point(14, 79);
            this.groupBoxPreguntas.Name = "groupBoxPreguntas";
            this.groupBoxPreguntas.Size = new System.Drawing.Size(846, 390);
            this.groupBoxPreguntas.TabIndex = 6;
            this.groupBoxPreguntas.TabStop = false;
            this.groupBoxPreguntas.Text = "Preguntes";
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
            this.button_WOC_Eliminar.Location = new System.Drawing.Point(256, 18);
            this.button_WOC_Eliminar.Name = "button_WOC_Eliminar";
            this.button_WOC_Eliminar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC_Eliminar.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOC_Eliminar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC_Eliminar.Size = new System.Drawing.Size(101, 23);
            this.button_WOC_Eliminar.TabIndex = 13;
            this.button_WOC_Eliminar.Text = "Eliminar";
            this.button_WOC_Eliminar.TextColor = System.Drawing.Color.Black;
            this.button_WOC_Eliminar.UseVisualStyleBackColor = false;
            this.button_WOC_Eliminar.Click += new System.EventHandler(this.button_WOC_Eliminar_Click);
            // 
            // button_WOC_Modificar
            // 
            this.button_WOC_Modificar.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Modificar.BorderColor = System.Drawing.Color.Black;
            this.button_WOC_Modificar.ButtonColor = System.Drawing.SystemColors.Info;
            this.button_WOC_Modificar.FlatAppearance.BorderSize = 0;
            this.button_WOC_Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC_Modificar.Font = new System.Drawing.Font("Consolas", 10F);
            this.button_WOC_Modificar.Location = new System.Drawing.Point(146, 18);
            this.button_WOC_Modificar.Name = "button_WOC_Modificar";
            this.button_WOC_Modificar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC_Modificar.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOC_Modificar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC_Modificar.Size = new System.Drawing.Size(101, 23);
            this.button_WOC_Modificar.TabIndex = 12;
            this.button_WOC_Modificar.Text = "Modificar";
            this.button_WOC_Modificar.TextColor = System.Drawing.Color.Black;
            this.button_WOC_Modificar.UseVisualStyleBackColor = false;
            this.button_WOC_Modificar.Click += new System.EventHandler(this.button_WOC_Modificar_Click);
            // 
            // button_WOC_NovaPregunta
            // 
            this.button_WOC_NovaPregunta.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC_NovaPregunta.BorderColor = System.Drawing.Color.Black;
            this.button_WOC_NovaPregunta.ButtonColor = System.Drawing.SystemColors.Info;
            this.button_WOC_NovaPregunta.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_WOC_NovaPregunta.FlatAppearance.BorderSize = 0;
            this.button_WOC_NovaPregunta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC_NovaPregunta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC_NovaPregunta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC_NovaPregunta.Font = new System.Drawing.Font("Consolas", 10F);
            this.button_WOC_NovaPregunta.Location = new System.Drawing.Point(36, 18);
            this.button_WOC_NovaPregunta.Name = "button_WOC_NovaPregunta";
            this.button_WOC_NovaPregunta.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC_NovaPregunta.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOC_NovaPregunta.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC_NovaPregunta.Size = new System.Drawing.Size(101, 23);
            this.button_WOC_NovaPregunta.TabIndex = 11;
            this.button_WOC_NovaPregunta.Text = "Nova";
            this.button_WOC_NovaPregunta.TextColor = System.Drawing.Color.Black;
            this.button_WOC_NovaPregunta.UseVisualStyleBackColor = false;
            this.button_WOC_NovaPregunta.Click += new System.EventHandler(this.button_WOC_NovaPregunta_Click);
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
            this.dataGridViewRespuestas.MultiSelect = false;
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
            this.labelRespuestas.Size = new System.Drawing.Size(70, 14);
            this.labelRespuestas.TabIndex = 7;
            this.labelRespuestas.Text = "Respostes";
            // 
            // listBoxPreguntas
            // 
            this.listBoxPreguntas.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.listBoxPreguntas.FormattingEnabled = true;
            this.listBoxPreguntas.ItemHeight = 14;
            this.listBoxPreguntas.Location = new System.Drawing.Point(18, 72);
            this.listBoxPreguntas.Name = "listBoxPreguntas";
            this.listBoxPreguntas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPreguntas.Size = new System.Drawing.Size(322, 284);
            this.listBoxPreguntas.TabIndex = 6;
            this.listBoxPreguntas.SelectedIndexChanged += new System.EventHandler(this.listBoxPreguntas_SelectedIndexChanged);
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.Font = new System.Drawing.Font("Consolas", 9F);
            this.labelIdioma.Location = new System.Drawing.Point(21, 31);
            this.labelIdioma.Name = "labelIdioma";
            this.labelIdioma.Size = new System.Drawing.Size(49, 14);
            this.labelIdioma.TabIndex = 7;
            this.labelIdioma.Text = "Idioma";
            // 
            // comboBoxIdioma
            // 
            this.comboBoxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIdioma.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.Items.AddRange(new object[] {
            "Català",
            "Castellà",
            "Anglès"});
            this.comboBoxIdioma.Location = new System.Drawing.Point(81, 28);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(204, 22);
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
        private System.Windows.Forms.Label labelPreguntas;
        private System.Windows.Forms.GroupBox groupBoxPreguntas;
        private System.Windows.Forms.ListBox listBoxPreguntas;
        private System.Windows.Forms.Label labelRespuestas;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.ComboBox comboBoxIdioma;
        private System.Windows.Forms.DataGridView dataGridViewRespuestas;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuesta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Correcta;
        private Button_WOC button_WOC_NovaPregunta;
        private Button_WOC button_WOC_Modificar;
        private Button_WOC button_WOC_Eliminar;
    }
}