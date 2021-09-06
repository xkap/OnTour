namespace Sistema_On_Tour.Vistas
{
    partial class VentanaPrincipalEjecutivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipalEjecutivo));
            this.label5 = new System.Windows.Forms.Label();
            this.BtnPaquetes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnInformaciones = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnRegistro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(373, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Paquetes";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BtnPaquetes
            // 
            this.BtnPaquetes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPaquetes.BackgroundImage")));
            this.BtnPaquetes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPaquetes.Location = new System.Drawing.Point(349, 285);
            this.BtnPaquetes.Name = "BtnPaquetes";
            this.BtnPaquetes.Size = new System.Drawing.Size(122, 111);
            this.BtnPaquetes.TabIndex = 15;
            this.BtnPaquetes.UseVisualStyleBackColor = true;
            this.BtnPaquetes.Click += new System.EventHandler(this.BtnContratos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Informaciones";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BtnInformaciones
            // 
            this.BtnInformaciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnInformaciones.BackgroundImage")));
            this.BtnInformaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInformaciones.Location = new System.Drawing.Point(472, 139);
            this.BtnInformaciones.Name = "BtnInformaciones";
            this.BtnInformaciones.Size = new System.Drawing.Size(122, 111);
            this.BtnInformaciones.TabIndex = 13;
            this.BtnInformaciones.UseVisualStyleBackColor = true;
            this.BtnInformaciones.Click += new System.EventHandler(this.BtnInformaciones_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(214, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Registro Apoderado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRegistro.BackgroundImage")));
            this.BtnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRegistro.Location = new System.Drawing.Point(229, 139);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(122, 111);
            this.BtnRegistro.TabIndex = 11;
            this.BtnRegistro.UseVisualStyleBackColor = true;
            this.BtnRegistro.Click += new System.EventHandler(this.BtnDepositos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seleccione una opción:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Agencia de Viajes On Tour";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VentanaPrincipalEjecutivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnPaquetes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnInformaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaPrincipalEjecutivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipalEjecutivo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnPaquetes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnInformaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnRegistro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}