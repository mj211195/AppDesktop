﻿namespace AppDesktop
{
    partial class formGestionPreguntas
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
            this.labelNivel = new System.Windows.Forms.Label();
            this.comboBoxNivel = new System.Windows.Forms.ComboBox();
            this.buttonNuevaPregunta = new System.Windows.Forms.Button();
            this.buttonModificarPregunta = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelPreguntas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxPreguntas = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNivel
            // 
            this.labelNivel.AutoSize = true;
            this.labelNivel.Location = new System.Drawing.Point(23, 42);
            this.labelNivel.Name = "labelNivel";
            this.labelNivel.Size = new System.Drawing.Size(33, 13);
            this.labelNivel.TabIndex = 0;
            this.labelNivel.Text = "Nivell";
            // 
            // comboBoxNivel
            // 
            this.comboBoxNivel.FormattingEnabled = true;
            this.comboBoxNivel.Location = new System.Drawing.Point(74, 33);
            this.comboBoxNivel.Name = "comboBoxNivel";
            this.comboBoxNivel.Size = new System.Drawing.Size(147, 21);
            this.comboBoxNivel.TabIndex = 1;
            // 
            // buttonNuevaPregunta
            // 
            this.buttonNuevaPregunta.Location = new System.Drawing.Point(6, 19);
            this.buttonNuevaPregunta.Name = "buttonNuevaPregunta";
            this.buttonNuevaPregunta.Size = new System.Drawing.Size(101, 23);
            this.buttonNuevaPregunta.TabIndex = 2;
            this.buttonNuevaPregunta.Text = "Nova pregunta";
            this.buttonNuevaPregunta.UseVisualStyleBackColor = true;
            // 
            // buttonModificarPregunta
            // 
            this.buttonModificarPregunta.Location = new System.Drawing.Point(120, 19);
            this.buttonModificarPregunta.Name = "buttonModificarPregunta";
            this.buttonModificarPregunta.Size = new System.Drawing.Size(75, 23);
            this.buttonModificarPregunta.TabIndex = 3;
            this.buttonModificarPregunta.Text = "Modificar";
            this.buttonModificarPregunta.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(214, 19);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 4;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // labelPreguntas
            // 
            this.labelPreguntas.AutoSize = true;
            this.labelPreguntas.Location = new System.Drawing.Point(15, 56);
            this.labelPreguntas.Name = "labelPreguntas";
            this.labelPreguntas.Size = new System.Drawing.Size(58, 13);
            this.labelPreguntas.TabIndex = 5;
            this.labelPreguntas.Text = "Preguntes:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxPreguntas);
            this.groupBox1.Controls.Add(this.labelPreguntas);
            this.groupBox1.Controls.Add(this.buttonEliminar);
            this.groupBox1.Controls.Add(this.buttonNuevaPregunta);
            this.groupBox1.Controls.Add(this.buttonModificarPregunta);
            this.groupBox1.Location = new System.Drawing.Point(26, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 390);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBoxPreguntas";
            // 
            // listBoxPreguntas
            // 
            this.listBoxPreguntas.FormattingEnabled = true;
            this.listBoxPreguntas.Location = new System.Drawing.Point(18, 72);
            this.listBoxPreguntas.Name = "listBoxPreguntas";
            this.listBoxPreguntas.Size = new System.Drawing.Size(322, 290);
            this.listBoxPreguntas.TabIndex = 6;
            // 
            // formGestionPreguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxNivel);
            this.Controls.Add(this.labelNivel);
            this.Name = "formGestionPreguntas";
            this.Text = "Gestió de preguntes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNivel;
        private System.Windows.Forms.ComboBox comboBoxNivel;
        private System.Windows.Forms.Button buttonNuevaPregunta;
        private System.Windows.Forms.Button buttonModificarPregunta;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label labelPreguntas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxPreguntas;
    }
}