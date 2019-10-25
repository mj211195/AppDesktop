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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSuport));
            this.groupBoxContacto = new System.Windows.Forms.GroupBox();
            this.button_WOCEnviar = new AppDesktop.Button_WOC();
            this.richTextBoxContacto = new System.Windows.Forms.RichTextBox();
            this.groupBoxContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxContacto
            // 
            this.groupBoxContacto.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxContacto.Controls.Add(this.button_WOCEnviar);
            this.groupBoxContacto.Controls.Add(this.richTextBoxContacto);
            this.groupBoxContacto.Location = new System.Drawing.Point(13, 13);
            this.groupBoxContacto.Name = "groupBoxContacto";
            this.groupBoxContacto.Size = new System.Drawing.Size(363, 247);
            this.groupBoxContacto.TabIndex = 2;
            this.groupBoxContacto.TabStop = false;
            this.groupBoxContacto.Text = "Contacte";
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
            this.button_WOCEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOCEnviar.Location = new System.Drawing.Point(269, 212);
            this.button_WOCEnviar.Name = "button_WOCEnviar";
            this.button_WOCEnviar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOCEnviar.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOCEnviar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOCEnviar.Size = new System.Drawing.Size(88, 28);
            this.button_WOCEnviar.TabIndex = 4;
            this.button_WOCEnviar.Text = "Enviar";
            this.button_WOCEnviar.TextColor = System.Drawing.Color.Black;
            this.button_WOCEnviar.UseVisualStyleBackColor = false;
            this.button_WOCEnviar.Click += new System.EventHandler(this.button_WOCEnviar_Click);
            // 
            // richTextBoxContacto
            // 
            this.richTextBoxContacto.Location = new System.Drawing.Point(7, 20);
            this.richTextBoxContacto.Name = "richTextBoxContacto";
            this.richTextBoxContacto.Size = new System.Drawing.Size(350, 186);
            this.richTextBoxContacto.TabIndex = 2;
            this.richTextBoxContacto.Text = "";
            // 
            // FormSuport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppDesktop.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(388, 271);
            this.Controls.Add(this.groupBoxContacto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSuport";
            this.Text = "Suport";
            this.groupBoxContacto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxContacto;
        private System.Windows.Forms.RichTextBox richTextBoxContacto;
        private Button_WOC button_WOCEnviar;
    }
}