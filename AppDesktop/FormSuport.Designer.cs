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
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.richTextBoxContacto = new System.Windows.Forms.RichTextBox();
            this.groupBoxContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxContacto
            // 
            this.groupBoxContacto.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxContacto.Controls.Add(this.buttonEnviar);
            this.groupBoxContacto.Controls.Add(this.richTextBoxContacto);
            this.groupBoxContacto.Location = new System.Drawing.Point(13, 13);
            this.groupBoxContacto.Name = "groupBoxContacto";
            this.groupBoxContacto.Size = new System.Drawing.Size(363, 237);
            this.groupBoxContacto.TabIndex = 2;
            this.groupBoxContacto.TabStop = false;
            this.groupBoxContacto.Text = "Contacte";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnviar.Location = new System.Drawing.Point(282, 208);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(75, 23);
            this.buttonEnviar.TabIndex = 3;
            this.buttonEnviar.Text = "Enviar";
            this.buttonEnviar.UseVisualStyleBackColor = true;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
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
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.groupBoxContacto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSuport";
            this.Text = "Suport";
            this.groupBoxContacto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxContacto;
        private System.Windows.Forms.RichTextBox richTextBoxContacto;
        private System.Windows.Forms.Button buttonEnviar;
    }
}