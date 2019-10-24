namespace AppDesktop
{
    partial class FormAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAyuda));
            this.labelAyuda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAyuda
            // 
            this.labelAyuda.AutoSize = true;
            this.labelAyuda.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAyuda.Location = new System.Drawing.Point(12, 9);
            this.labelAyuda.MaximumSize = new System.Drawing.Size(750, 600);
            this.labelAyuda.Name = "labelAyuda";
            this.labelAyuda.Size = new System.Drawing.Size(749, 510);
            this.labelAyuda.TabIndex = 0;
            //this.labelAyuda.Text = resources.GetString("labelAyuda.Text");
            // 
            // FormAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(790, 582);
            this.Controls.Add(this.labelAyuda);
            this.Name = "FormAyuda";
            this.Text = "Ajuda - Petita guia per a la inserció/modificació de preguntes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAyuda;
    }
}