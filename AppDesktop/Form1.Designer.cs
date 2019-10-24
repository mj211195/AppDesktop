
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.button_WOCSuport = new AppDesktop.Button_WOC();
            this.button_WOCGestionar = new AppDesktop.Button_WOC();
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
            // button_WOCSuport
            // 
            this.button_WOCSuport.BackColor = System.Drawing.Color.Transparent;
            this.button_WOCSuport.BorderColor = System.Drawing.Color.Black;
            this.button_WOCSuport.ButtonColor = System.Drawing.SystemColors.Info;
            this.button_WOCSuport.FlatAppearance.BorderSize = 0;
            this.button_WOCSuport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOCSuport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOCSuport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOCSuport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOCSuport.Location = new System.Drawing.Point(106, 251);
            this.button_WOCSuport.Name = "button_WOCSuport";
            this.button_WOCSuport.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOCSuport.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOCSuport.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOCSuport.Size = new System.Drawing.Size(117, 40);
            this.button_WOCSuport.TabIndex = 4;
            this.button_WOCSuport.Text = "Suport";
            this.button_WOCSuport.TextColor = System.Drawing.Color.Black;
            this.button_WOCSuport.UseVisualStyleBackColor = false;
            this.button_WOCSuport.Click += new System.EventHandler(this.button_WOCSuport_Click);
            // 
            // button_WOCGestionar
            // 
            this.button_WOCGestionar.BackColor = System.Drawing.Color.Transparent;
            this.button_WOCGestionar.BorderColor = System.Drawing.Color.Black;
            this.button_WOCGestionar.ButtonColor = System.Drawing.SystemColors.Info;
            this.button_WOCGestionar.FlatAppearance.BorderSize = 0;
            this.button_WOCGestionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOCGestionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOCGestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOCGestionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOCGestionar.Location = new System.Drawing.Point(106, 192);
            this.button_WOCGestionar.Name = "button_WOCGestionar";
            this.button_WOCGestionar.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.button_WOCGestionar.OnHoverButtonColor = System.Drawing.Color.Beige;
            this.button_WOCGestionar.OnHoverTextColor = System.Drawing.Color.Gray;
            this.button_WOCGestionar.Size = new System.Drawing.Size(117, 40);
            this.button_WOCGestionar.TabIndex = 3;
            this.button_WOCGestionar.Text = "Gestionar";
            this.button_WOCGestionar.TextColor = System.Drawing.Color.Black;
            this.button_WOCGestionar.UseVisualStyleBackColor = false;
            this.button_WOCGestionar.Click += new System.EventHandler(this.button_WOCGestionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppDesktop.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(341, 359);
            this.Controls.Add(this.button_WOCSuport);
            this.Controls.Add(this.button_WOCGestionar);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private AppDesktop.Button_WOC button_WOCGestionar;
        private AppDesktop.Button_WOC button_WOCSuport;
    }
}

