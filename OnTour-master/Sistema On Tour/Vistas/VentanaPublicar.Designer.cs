﻿namespace Sistema_On_Tour.Vistas
{
    partial class VentanaPublicar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPublicar));
            this.TxtInformacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnPublicar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtInformacion
            // 
            this.TxtInformacion.Location = new System.Drawing.Point(177, 147);
            this.TxtInformacion.Multiline = true;
            this.TxtInformacion.Name = "TxtInformacion";
            this.TxtInformacion.Size = new System.Drawing.Size(480, 202);
            this.TxtInformacion.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 24);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ingrese la información que desea publicar:";
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.SystemColors.Control;
            this.BtnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVolver.BackgroundImage")));
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnVolver.Location = new System.Drawing.Point(28, 51);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(74, 72);
            this.BtnVolver.TabIndex = 30;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnPublicar
            // 
            this.BtnPublicar.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPublicar.Location = new System.Drawing.Point(328, 370);
            this.BtnPublicar.Name = "BtnPublicar";
            this.BtnPublicar.Size = new System.Drawing.Size(129, 38);
            this.BtnPublicar.TabIndex = 29;
            this.BtnPublicar.Text = "Publicar";
            this.BtnPublicar.UseVisualStyleBackColor = true;
            this.BtnPublicar.Click += new System.EventHandler(this.BtnPublicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Agencia de Viajes On Tour";
            // 
            // VentanaPublicar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtInformacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnPublicar);
            this.Controls.Add(this.label1);
            this.Name = "VentanaPublicar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPublicar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtInformacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnPublicar;
        private System.Windows.Forms.Label label1;
    }
}