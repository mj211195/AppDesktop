namespace AppDesktop
{
    partial class FormSuport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuport));
            this.labelNom = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.groupBoxContacto = new System.Windows.Forms.GroupBox();
            this.pictureBoxErrorMensaje = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrorAsunto = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrorEmailValid = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrorEmail = new System.Windows.Forms.PictureBox();
            this.pictureBoxErrorNombre = new System.Windows.Forms.PictureBox();
            this.textBoxMensaje = new System.Windows.Forms.TextBox();
            this.textBoxAsunto = new System.Windows.Forms.TextBox();
            this.textBoxCorreoVerificado = new System.Windows.Forms.TextBox();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_WOCreiniciar = new AppDesktop.Button_WOC();
            this.button_WOCEnviar = new AppDesktop.Button_WOC();
            this.toolTipErrores = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBoxLogoSE = new System.Windows.Forms.PictureBox();
            this.groupBoxContacto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorMensaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorAsunto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorEmailValid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoSE)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.labelNom.Location = new System.Drawing.Point(26, 36);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(28, 15);
            this.labelNom.TabIndex = 3;
            this.labelNom.Text = "Nom";
            this.toolTipInfo.SetToolTip(this.labelNom, "Indiqui el nom de la persona a la qual vol que ens referim\r\na l\'hora de contestar" +
        " el missatge");
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Consolas", 9F);
            this.labelCorreo.Location = new System.Drawing.Point(26, 105);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(133, 14);
            this.labelCorreo.TabIndex = 4;
            this.labelCorreo.Text = "Correu de contacte";
            this.toolTipInfo.SetToolTip(this.labelCorreo, "Indiqui un correu vàlid per tal de que podem contestar el missatge");
            // 
            // groupBoxContacto
            // 
            this.groupBoxContacto.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxContacto.Controls.Add(this.pictureBoxLogoSE);
            this.groupBoxContacto.Controls.Add(this.pictureBoxErrorMensaje);
            this.groupBoxContacto.Controls.Add(this.pictureBoxErrorAsunto);
            this.groupBoxContacto.Controls.Add(this.pictureBoxErrorEmailValid);
            this.groupBoxContacto.Controls.Add(this.pictureBoxErrorEmail);
            this.groupBoxContacto.Controls.Add(this.pictureBoxErrorNombre);
            this.groupBoxContacto.Controls.Add(this.textBoxMensaje);
            this.groupBoxContacto.Controls.Add(this.textBoxAsunto);
            this.groupBoxContacto.Controls.Add(this.textBoxCorreoVerificado);
            this.groupBoxContacto.Controls.Add(this.textBoxCorreo);
            this.groupBoxContacto.Controls.Add(this.textBoxNom);
            this.groupBoxContacto.Controls.Add(this.label3);
            this.groupBoxContacto.Controls.Add(this.label2);
            this.groupBoxContacto.Controls.Add(this.label1);
            this.groupBoxContacto.Controls.Add(this.labelCorreo);
            this.groupBoxContacto.Controls.Add(this.button_WOCreiniciar);
            this.groupBoxContacto.Controls.Add(this.labelNom);
            this.groupBoxContacto.Controls.Add(this.button_WOCEnviar);
            this.groupBoxContacto.Font = new System.Drawing.Font("Consolas", 9F);
            this.groupBoxContacto.Location = new System.Drawing.Point(13, 13);
            this.groupBoxContacto.Name = "groupBoxContacto";
            this.groupBoxContacto.Size = new System.Drawing.Size(398, 551);
            this.groupBoxContacto.TabIndex = 2;
            this.groupBoxContacto.TabStop = false;
            this.groupBoxContacto.Text = "Formulari de contacte";
            // 
            // pictureBoxErrorMensaje
            // 
            this.pictureBoxErrorMensaje.Image = global::AppDesktop.Properties.Resources.triangulo;
            this.pictureBoxErrorMensaje.Location = new System.Drawing.Point(364, 300);
            this.pictureBoxErrorMensaje.Name = "pictureBoxErrorMensaje";
            this.pictureBoxErrorMensaje.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxErrorMensaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxErrorMensaje.TabIndex = 18;
            this.pictureBoxErrorMensaje.TabStop = false;
            this.toolTipErrores.SetToolTip(this.pictureBoxErrorMensaje, "Per a que aquest camp sigui vàlid:\r\n    - No pot estar buit\r\n    - No pot estar c" +
        "ompost íntegrament d\'espais en blanc\r\n    - Ha de tenir una llargària mínima i m" +
        "àxima adients");
            this.pictureBoxErrorMensaje.Visible = false;
            // 
            // pictureBoxErrorAsunto
            // 
            this.pictureBoxErrorAsunto.Image = global::AppDesktop.Properties.Resources.triangulo;
            this.pictureBoxErrorAsunto.Location = new System.Drawing.Point(277, 257);
            this.pictureBoxErrorAsunto.Name = "pictureBoxErrorAsunto";
            this.pictureBoxErrorAsunto.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxErrorAsunto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxErrorAsunto.TabIndex = 17;
            this.pictureBoxErrorAsunto.TabStop = false;
            this.toolTipErrores.SetToolTip(this.pictureBoxErrorAsunto, "Per a que aquest camp sigui vàlid:\r\n    - No pot estar buit\r\n    - No pot estar c" +
        "ompost íntegrament d\'espais en blanc\r\n    - Ha de tenir una llargària mínima i m" +
        "àxima adients");
            this.pictureBoxErrorAsunto.Visible = false;
            // 
            // pictureBoxErrorEmailValid
            // 
            this.pictureBoxErrorEmailValid.Image = global::AppDesktop.Properties.Resources.triangulo;
            this.pictureBoxErrorEmailValid.Location = new System.Drawing.Point(277, 188);
            this.pictureBoxErrorEmailValid.Name = "pictureBoxErrorEmailValid";
            this.pictureBoxErrorEmailValid.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxErrorEmailValid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxErrorEmailValid.TabIndex = 16;
            this.pictureBoxErrorEmailValid.TabStop = false;
            this.toolTipErrores.SetToolTip(this.pictureBoxErrorEmailValid, "Per a que aquest camp sigui vàlid:\r\n    - No pot estar buit\r\n    - Ha de ser idèn" +
        "tic al correu previ");
            this.pictureBoxErrorEmailValid.Visible = false;
            // 
            // pictureBoxErrorEmail
            // 
            this.pictureBoxErrorEmail.Image = global::AppDesktop.Properties.Resources.triangulo;
            this.pictureBoxErrorEmail.Location = new System.Drawing.Point(277, 119);
            this.pictureBoxErrorEmail.Name = "pictureBoxErrorEmail";
            this.pictureBoxErrorEmail.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxErrorEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxErrorEmail.TabIndex = 15;
            this.pictureBoxErrorEmail.TabStop = false;
            this.toolTipErrores.SetToolTip(this.pictureBoxErrorEmail, "Per a que aquest camp sigui vàlid:\r\n    - No pot estar buit\r\n    - No pot tenir e" +
        "spais en blanc\r\n    - Ha de tenir una llargària mínima i màxima adients");
            this.pictureBoxErrorEmail.Visible = false;
            // 
            // pictureBoxErrorNombre
            // 
            this.pictureBoxErrorNombre.Image = global::AppDesktop.Properties.Resources.triangulo;
            this.pictureBoxErrorNombre.Location = new System.Drawing.Point(277, 50);
            this.pictureBoxErrorNombre.Name = "pictureBoxErrorNombre";
            this.pictureBoxErrorNombre.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxErrorNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxErrorNombre.TabIndex = 14;
            this.pictureBoxErrorNombre.TabStop = false;
            this.toolTipErrores.SetToolTip(this.pictureBoxErrorNombre, "Per a que aquest camp sigui vàlid:\r\n     - No pot estar buit\r\n     - No pot estar" +
        " compost íntegrament d\'espais en blanc\r\n     - Ha de tenir una llargària mínima " +
        "i màxima adients");
            this.pictureBoxErrorNombre.Visible = false;
            // 
            // textBoxMensaje
            // 
            this.textBoxMensaje.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMensaje.Location = new System.Drawing.Point(29, 331);
            this.textBoxMensaje.Multiline = true;
            this.textBoxMensaje.Name = "textBoxMensaje";
            this.textBoxMensaje.Size = new System.Drawing.Size(360, 170);
            this.textBoxMensaje.TabIndex = 5;
            // 
            // textBoxAsunto
            // 
            this.textBoxAsunto.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAsunto.Location = new System.Drawing.Point(29, 262);
            this.textBoxAsunto.Name = "textBoxAsunto";
            this.textBoxAsunto.Size = new System.Drawing.Size(242, 20);
            this.textBoxAsunto.TabIndex = 4;
            // 
            // textBoxCorreoVerificado
            // 
            this.textBoxCorreoVerificado.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreoVerificado.Location = new System.Drawing.Point(29, 193);
            this.textBoxCorreoVerificado.Name = "textBoxCorreoVerificado";
            this.textBoxCorreoVerificado.ShortcutsEnabled = false;
            this.textBoxCorreoVerificado.Size = new System.Drawing.Size(242, 20);
            this.textBoxCorreoVerificado.TabIndex = 3;
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCorreo.Location = new System.Drawing.Point(29, 124);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(242, 20);
            this.textBoxCorreo.TabIndex = 2;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNom.Location = new System.Drawing.Point(29, 55);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(242, 20);
            this.textBoxNom.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F);
            this.label3.Location = new System.Drawing.Point(29, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "El seu missatge";
            this.toolTipInfo.SetToolTip(this.label3, "El missatge com a tal");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F);
            this.label2.Location = new System.Drawing.Point(26, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Assumpte";
            this.toolTipInfo.SetToolTip(this.label2, "Indiqui l\'assumpte del missatge, per exemple, si es una sugerència,\r\nuna queixa, " +
        "un problema amb l\'aplicació, etc.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F);
            this.label1.Location = new System.Drawing.Point(26, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Verificar correu";
            this.toolTipInfo.SetToolTip(this.label1, "Verifiqui el correu de contacte per tal de que no hi hagi caràcters erronis");
            // 
            // button_WOCreiniciar
            // 
            this.button_WOCreiniciar.BackColor = System.Drawing.Color.Transparent;
            this.button_WOCreiniciar.BorderColor = System.Drawing.Color.Black;
            this.button_WOCreiniciar.ButtonColor = System.Drawing.SystemColors.Info;
            this.button_WOCreiniciar.FlatAppearance.BorderSize = 0;
            this.button_WOCreiniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOCreiniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOCreiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOCreiniciar.Font = new System.Drawing.Font("Arial", 11F);
            this.button_WOCreiniciar.Location = new System.Drawing.Point(194, 516);
            this.button_WOCreiniciar.Name = "button_WOCreiniciar";
            this.button_WOCreiniciar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOCreiniciar.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOCreiniciar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOCreiniciar.Size = new System.Drawing.Size(95, 28);
            this.button_WOCreiniciar.TabIndex = 7;
            this.button_WOCreiniciar.Text = "Reiniciar";
            this.button_WOCreiniciar.TextColor = System.Drawing.Color.Black;
            this.button_WOCreiniciar.UseVisualStyleBackColor = false;
            this.button_WOCreiniciar.Click += new System.EventHandler(this.button_WOCreiniciar_Click);
            // 
            // button_WOCEnviar
            // 
            this.button_WOCEnviar.BackColor = System.Drawing.Color.Transparent;
            this.button_WOCEnviar.BorderColor = System.Drawing.Color.Black;
            this.button_WOCEnviar.ButtonColor = System.Drawing.SystemColors.Info;
            this.button_WOCEnviar.FlatAppearance.BorderSize = 0;
            this.button_WOCEnviar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOCEnviar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOCEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOCEnviar.Font = new System.Drawing.Font("Arial", 11F);
            this.button_WOCEnviar.Location = new System.Drawing.Point(297, 516);
            this.button_WOCEnviar.Name = "button_WOCEnviar";
            this.button_WOCEnviar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOCEnviar.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOCEnviar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOCEnviar.Size = new System.Drawing.Size(95, 28);
            this.button_WOCEnviar.TabIndex = 6;
            this.button_WOCEnviar.Text = "Enviar";
            this.button_WOCEnviar.TextColor = System.Drawing.Color.Black;
            this.button_WOCEnviar.UseVisualStyleBackColor = false;
            this.button_WOCEnviar.Click += new System.EventHandler(this.button_WOCEnviar_Click);
            // 
            // toolTipErrores
            // 
            this.toolTipErrores.AutoPopDelay = 5000;
            this.toolTipErrores.InitialDelay = 500;
            this.toolTipErrores.ReshowDelay = 100;
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipInfo.ToolTipTitle = "Info";
            // 
            // pictureBoxLogoSE
            // 
            this.pictureBoxLogoSE.Image = global::AppDesktop.Properties.Resources.logo_sin_fondo;
            this.pictureBoxLogoSE.Location = new System.Drawing.Point(308, 19);
            this.pictureBoxLogoSE.Name = "pictureBoxLogoSE";
            this.pictureBoxLogoSE.Size = new System.Drawing.Size(84, 68);
            this.pictureBoxLogoSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoSE.TabIndex = 19;
            this.pictureBoxLogoSE.TabStop = false;
            // 
            // FormSuport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppDesktop.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 576);
            this.Controls.Add(this.groupBoxContacto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSuport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Suport";
            this.groupBoxContacto.ResumeLayout(false);
            this.groupBoxContacto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorMensaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorAsunto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorEmailValid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErrorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoSE)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelCorreo;
        private Button_WOC button_WOCEnviar;
        private Button_WOC button_WOCreiniciar;
        private System.Windows.Forms.GroupBox groupBoxContacto;
        private System.Windows.Forms.TextBox textBoxMensaje;
        private System.Windows.Forms.TextBox textBoxAsunto;
        private System.Windows.Forms.TextBox textBoxCorreoVerificado;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxErrorNombre;
        private System.Windows.Forms.PictureBox pictureBoxErrorEmail;
        private System.Windows.Forms.PictureBox pictureBoxErrorMensaje;
        private System.Windows.Forms.PictureBox pictureBoxErrorAsunto;
        private System.Windows.Forms.PictureBox pictureBoxErrorEmailValid;
        private System.Windows.Forms.ToolTip toolTipErrores;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.PictureBox pictureBoxLogoSE;
    }
}