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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionPreguntas));
            this.labelNivel = new System.Windows.Forms.Label();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.groupBoxPreguntas = new System.Windows.Forms.GroupBox();
            this.labelContadorPreguntas = new System.Windows.Forms.Label();
            this.listBoxPreguntas = new System.Windows.Forms.ListBox();
            this.dataGridViewRespuestas = new System.Windows.Forms.DataGridView();
            this.respuesta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correcta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelIdioma = new System.Windows.Forms.Label();
            this.comboBoxIdioma = new System.Windows.Forms.ComboBox();
            this.groupBoxResposta = new System.Windows.Forms.GroupBox();
            this.button_WOC_Eliminar = new AppDesktop.Button_WOC();
            this.button_WOC_Modificar = new AppDesktop.Button_WOC();
            this.button_WOC_NovaPregunta = new AppDesktop.Button_WOC();
            this.groupBoxPreguntas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRespuestas)).BeginInit();
            this.groupBoxResposta.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.BackColor = System.Drawing.Color.Transparent;
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
            this.comboBoxNivel.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Items.AddRange(new object[] {
            "Infantil",
            "Adult (Fàcil)",
            "Adult (Intermedi)",
            "Adult (Difícil)"});
            this.comboBoxNivel.Location = new System.Drawing.Point(400, 28);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(204, 21);
            this.comboBoxNivel.TabIndex = 2;
            this.comboBoxNivel.SelectedIndexChanged += new System.EventHandler(this.comboBoxNivel_SelectedIndexChanged);
            // 
            // groupBoxPreguntas
            // 
            this.groupBoxPreguntas.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxPreguntas.Controls.Add(this.labelContadorPreguntas);
            this.groupBoxPreguntas.Controls.Add(this.button_WOC_Eliminar);
            this.groupBoxPreguntas.Controls.Add(this.button_WOC_Modificar);
            this.groupBoxPreguntas.Controls.Add(this.button_WOC_NovaPregunta);
            this.groupBoxPreguntas.Controls.Add(this.listBoxPreguntas);
            this.groupBoxPreguntas.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBoxPreguntas.Location = new System.Drawing.Point(14, 79);
            this.groupBoxPreguntas.Name = "groupBoxPreguntas";
            this.groupBoxPreguntas.Size = new System.Drawing.Size(375, 390);
            this.groupBoxPreguntas.TabIndex = 6;
            this.groupBoxPreguntas.TabStop = false;
            this.groupBoxPreguntas.Text = "Preguntes";
            // 
            // labelContadorPreguntas
            // 
            this.labelContadorPreguntas.AutoSize = true;
            this.labelContadorPreguntas.Font = new System.Drawing.Font("Consolas", 8F);
            this.labelContadorPreguntas.Location = new System.Drawing.Point(20, 363);
            this.labelContadorPreguntas.Name = "labelContadorPreguntas";
            this.labelContadorPreguntas.Size = new System.Drawing.Size(0, 13);
            this.labelContadorPreguntas.TabIndex = 14;
            // 
            // listBoxPreguntas
            // 
            this.listBoxPreguntas.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.listBoxPreguntas.FormattingEnabled = true;
            this.listBoxPreguntas.Location = new System.Drawing.Point(18, 72);
            this.listBoxPreguntas.Name = "listBoxPreguntas";
            this.listBoxPreguntas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPreguntas.Size = new System.Drawing.Size(322, 277);
            this.listBoxPreguntas.TabIndex = 3;
            this.listBoxPreguntas.SelectedIndexChanged += new System.EventHandler(this.listBoxPreguntas_SelectedIndexChanged);
            // 
            // dataGridViewRespuestas
            // 
            this.dataGridViewRespuestas.AllowUserToAddRows = false;
            this.dataGridViewRespuestas.AllowUserToDeleteRows = false;
            this.dataGridViewRespuestas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRespuestas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRespuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRespuestas.ColumnHeadersVisible = false;
            this.dataGridViewRespuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.respuesta,
            this.Correcta});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRespuestas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRespuestas.Location = new System.Drawing.Point(0, 21);
            this.dataGridViewRespuestas.MultiSelect = false;
            this.dataGridViewRespuestas.Name = "dataGridViewRespuestas";
            this.dataGridViewRespuestas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRespuestas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRespuestas.RowHeadersVisible = false;
            this.dataGridViewRespuestas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRespuestas.Size = new System.Drawing.Size(460, 90);
            this.dataGridViewRespuestas.TabIndex = 8;
            this.dataGridViewRespuestas.TabStop = false;
            // 
            // respuesta
            // 
            this.respuesta.DataPropertyName = "respuesta";
            this.respuesta.HeaderText = "Resposta";
            this.respuesta.Name = "respuesta";
            this.respuesta.ReadOnly = true;
            this.respuesta.Width = 355;
            // 
            // Correcta
            // 
            this.Correcta.DataPropertyName = "correcta";
            this.Correcta.HeaderText = "Correcta";
            this.Correcta.Name = "Correcta";
            this.Correcta.ReadOnly = true;
            this.Correcta.Width = 103;
            // 
            // labelIdioma
            // 
            this.labelIdioma.AutoSize = true;
            this.labelIdioma.BackColor = System.Drawing.Color.Transparent;
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
            this.comboBoxIdioma.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.Items.AddRange(new object[] {
            "Català",
            "Castellà",
            "Anglès"});
            this.comboBoxIdioma.Location = new System.Drawing.Point(81, 28);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(204, 21);
            this.comboBoxIdioma.TabIndex = 1;
            this.comboBoxIdioma.SelectedIndexChanged += new System.EventHandler(this.comboBoxIdioma_SelectedIndexChanged);
            // 
            // groupBoxResposta
            // 
            this.groupBoxResposta.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxResposta.Controls.Add(this.dataGridViewRespuestas);
            this.groupBoxResposta.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBoxResposta.Location = new System.Drawing.Point(395, 133);
            this.groupBoxResposta.Name = "groupBoxResposta";
            this.groupBoxResposta.Size = new System.Drawing.Size(473, 125);
            this.groupBoxResposta.TabIndex = 9;
            this.groupBoxResposta.TabStop = false;
            this.groupBoxResposta.Text = "Respostes";
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
            this.button_WOC_Eliminar.Location = new System.Drawing.Point(252, 18);
            this.button_WOC_Eliminar.Name = "button_WOC_Eliminar";
            this.button_WOC_Eliminar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC_Eliminar.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOC_Eliminar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC_Eliminar.Size = new System.Drawing.Size(101, 23);
            this.button_WOC_Eliminar.TabIndex = 6;
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
            this.button_WOC_Modificar.Location = new System.Drawing.Point(138, 18);
            this.button_WOC_Modificar.Name = "button_WOC_Modificar";
            this.button_WOC_Modificar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC_Modificar.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOC_Modificar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC_Modificar.Size = new System.Drawing.Size(101, 23);
            this.button_WOC_Modificar.TabIndex = 5;
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
            this.button_WOC_NovaPregunta.Location = new System.Drawing.Point(24, 18);
            this.button_WOC_NovaPregunta.Name = "button_WOC_NovaPregunta";
            this.button_WOC_NovaPregunta.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOC_NovaPregunta.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOC_NovaPregunta.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOC_NovaPregunta.Size = new System.Drawing.Size(101, 23);
            this.button_WOC_NovaPregunta.TabIndex = 4;
            this.button_WOC_NovaPregunta.Text = "Nova";
            this.button_WOC_NovaPregunta.TextColor = System.Drawing.Color.Black;
            this.button_WOC_NovaPregunta.UseVisualStyleBackColor = false;
            this.button_WOC_NovaPregunta.Click += new System.EventHandler(this.button_WOC_NovaPregunta_Click);
            // 
            // FormGestionPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppDesktop.Properties.Resources.grande_fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(880, 478);
            this.Controls.Add(this.groupBoxResposta);
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
            this.groupBoxResposta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.GroupBox groupBoxPreguntas;
        private System.Windows.Forms.ListBox listBoxPreguntas;
        private System.Windows.Forms.Label labelIdioma;
        private System.Windows.Forms.ComboBox comboBoxIdioma;
        private System.Windows.Forms.DataGridView dataGridViewRespuestas;
        private Button_WOC button_WOC_NovaPregunta;
        private Button_WOC button_WOC_Modificar;
        private Button_WOC button_WOC_Eliminar;
        private System.Windows.Forms.GroupBox groupBoxResposta;
        private System.Windows.Forms.Label labelContadorPreguntas;
        private System.Windows.Forms.DataGridViewTextBoxColumn respuesta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Correcta;
    }
}