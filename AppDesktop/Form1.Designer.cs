
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripInicio = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonGestionar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSuport = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSortir = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxLogoSE = new System.Windows.Forms.PictureBox();
            this.button_WOCSuport = new AppDesktop.Button_WOC();
            this.button_WOCGestionar = new AppDesktop.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.toolStripInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoSE)).BeginInit();
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStripInicio
            // 
            this.toolStripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonGestionar,
            this.toolStripButtonSuport,
            this.toolStripSeparator1,
            this.toolStripButtonSortir});
            this.toolStripInicio.Location = new System.Drawing.Point(0, 0);
            this.toolStripInicio.Name = "toolStripInicio";
            this.toolStripInicio.Size = new System.Drawing.Size(341, 25);
            this.toolStripInicio.TabIndex = 6;
            this.toolStripInicio.Text = "ToolStripInicio";
            // 
            // toolStripButtonGestionar
            // 
            this.toolStripButtonGestionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGestionar.Image = global::AppDesktop.Properties.Resources._006_edit;
            this.toolStripButtonGestionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGestionar.Name = "toolStripButtonGestionar";
            this.toolStripButtonGestionar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButtonGestionar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonGestionar.Text = "Gestionar";
            this.toolStripButtonGestionar.Click += new System.EventHandler(this.toolStripButtonGestionar_Click);
            // 
            // toolStripButtonSuport
            // 
            this.toolStripButtonSuport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSuport.Image = global::AppDesktop.Properties.Resources._012_envelope;
            this.toolStripButtonSuport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSuport.Name = "toolStripButtonSuport";
            this.toolStripButtonSuport.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSuport.Text = "Suport";
            this.toolStripButtonSuport.Click += new System.EventHandler(this.toolStripButtonSuport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSortir
            // 
            this.toolStripButtonSortir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSortir.Image = global::AppDesktop.Properties.Resources._022_logout;
            this.toolStripButtonSortir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSortir.Name = "toolStripButtonSortir";
            this.toolStripButtonSortir.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSortir.Text = "Sortir";
            this.toolStripButtonSortir.Click += new System.EventHandler(this.toolStripButtonSortir_Click);
            // 
            // pictureBoxLogoSE
            // 
            this.pictureBoxLogoSE.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogoSE.Image = global::AppDesktop.Properties.Resources.logo_sin_fondo;
            this.pictureBoxLogoSE.Location = new System.Drawing.Point(125, 333);
            this.pictureBoxLogoSE.Name = "pictureBoxLogoSE";
            this.pictureBoxLogoSE.Size = new System.Drawing.Size(87, 72);
            this.pictureBoxLogoSE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoSE.TabIndex = 7;
            this.pictureBoxLogoSE.TabStop = false;
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
            this.button_WOCSuport.Font = new System.Drawing.Font("Consolas", 12F);
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
            this.button_WOCGestionar.Font = new System.Drawing.Font("Consolas", 12F);
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
            this.ClientSize = new System.Drawing.Size(341, 431);
            this.Controls.Add(this.pictureBoxLogoSE);
            this.Controls.Add(this.toolStripInicio);
            this.Controls.Add(this.button_WOCSuport);
            this.Controls.Add(this.button_WOCGestionar);
            this.Controls.Add(this.pictureBoxLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.toolStripInicio.ResumeLayout(false);
            this.toolStripInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoSE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private AppDesktop.Button_WOC button_WOCGestionar;
        private AppDesktop.Button_WOC button_WOCSuport;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStripInicio;
        private System.Windows.Forms.ToolStripButton toolStripButtonGestionar;
        private System.Windows.Forms.ToolStripButton toolStripButtonSuport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSortir;
        private System.Windows.Forms.PictureBox pictureBoxLogoSE;
    }
}

