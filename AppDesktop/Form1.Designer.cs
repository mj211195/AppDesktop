namespace AppDesktop
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.button_WOCGestionar = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogo.Image = global::AppDesktop.Properties.Resources.Logo_Museu;
            this.pictureBoxLogo.Location = new System.Drawing.Point(95, 22);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(144, 145);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // button_WOCGestionar
            // 
            this.button_WOCGestionar.BackColor = System.Drawing.Color.Transparent;
            this.button_WOCGestionar.BorderColor = System.Drawing.Color.Black;
            this.button_WOCGestionar.ButtonColor = System.Drawing.SystemColors.Info;
            this.button_WOCGestionar.FlatAppearance.BorderSize = 0;
            this.button_WOCGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOCGestionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOCGestionar.Location = new System.Drawing.Point(95, 194);
            this.button_WOCGestionar.Name = "button_WOCGestionar";
            this.button_WOCGestionar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOCGestionar.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.button_WOCGestionar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOCGestionar.Size = new System.Drawing.Size(144, 58);
            this.button_WOCGestionar.TabIndex = 3;
            this.button_WOCGestionar.Text = "Gestionar";
            this.button_WOCGestionar.TextColor = System.Drawing.Color.Black;
            this.button_WOCGestionar.UseVisualStyleBackColor = false;
            this.button_WOCGestionar.MouseHover += new System.EventHandler(this.button_WOC1_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppDesktop.Properties.Resources.Terrasa1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(323, 359);
            this.Controls.Add(this.button_WOCGestionar);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private ePOSOne.btnProduct.Button_WOC button_WOCGestionar;
    }
}

