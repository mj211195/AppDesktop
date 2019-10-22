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
            this.roundedButtonGestionar = new AppDesktop.RoundedButton();
            this.roundedButtonSuport = new AppDesktop.RoundedButton();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedButtonGestionar
            // 
            this.roundedButtonGestionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonGestionar.Location = new System.Drawing.Point(130, 191);
            this.roundedButtonGestionar.Name = "roundedButtonGestionar";
            this.roundedButtonGestionar.Size = new System.Drawing.Size(92, 35);
            this.roundedButtonGestionar.TabIndex = 0;
            this.roundedButtonGestionar.Text = "Gestionar";
            this.roundedButtonGestionar.UseVisualStyleBackColor = true;
            // 
            // roundedButtonSuport
            // 
            this.roundedButtonSuport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButtonSuport.Location = new System.Drawing.Point(130, 242);
            this.roundedButtonSuport.Name = "roundedButtonSuport";
            this.roundedButtonSuport.Size = new System.Drawing.Size(92, 35);
            this.roundedButtonSuport.TabIndex = 1;
            this.roundedButtonSuport.Text = "Suport";
            this.roundedButtonSuport.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::AppDesktop.Properties.Resources.Logo_Museu;
            this.pictureBoxLogo.Location = new System.Drawing.Point(112, 24);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(139, 115);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 359);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.roundedButtonSuport);
            this.Controls.Add(this.roundedButtonGestionar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RoundedButton roundedButtonGestionar;
        private RoundedButton roundedButtonSuport;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

