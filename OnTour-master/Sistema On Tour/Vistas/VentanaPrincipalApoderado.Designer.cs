namespace Sistema_On_Tour.Vistas
{
    partial class VentanaPrincipalApoderado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipalApoderado));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDepositos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnInformaciones = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnContratos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agencia de Viajes On Tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione una opción:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BtnDepositos
            // 
            this.BtnDepositos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDepositos.BackgroundImage")));
            this.BtnDepositos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDepositos.Location = new System.Drawing.Point(204, 136);
            this.BtnDepositos.Name = "BtnDepositos";
            this.BtnDepositos.Size = new System.Drawing.Size(122, 111);
            this.BtnDepositos.TabIndex = 3;
            this.BtnDepositos.UseVisualStyleBackColor = true;
            this.BtnDepositos.Click += new System.EventHandler(this.BtnDepositos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Depósitos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(455, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Informaciones";
            // 
            // BtnInformaciones
            // 
            this.BtnInformaciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnInformaciones.BackgroundImage")));
            this.BtnInformaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnInformaciones.Location = new System.Drawing.Point(447, 136);
            this.BtnInformaciones.Name = "BtnInformaciones";
            this.BtnInformaciones.Size = new System.Drawing.Size(122, 111);
            this.BtnInformaciones.TabIndex = 5;
            this.BtnInformaciones.UseVisualStyleBackColor = true;
            this.BtnInformaciones.Click += new System.EventHandler(this.BtnInformaciones_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contratos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BtnContratos
            // 
            this.BtnContratos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnContratos.BackgroundImage")));
            this.BtnContratos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnContratos.Location = new System.Drawing.Point(324, 282);
            this.BtnContratos.Name = "BtnContratos";
            this.BtnContratos.Size = new System.Drawing.Size(122, 111);
            this.BtnContratos.TabIndex = 7;
            this.BtnContratos.UseVisualStyleBackColor = true;
            this.BtnContratos.Click += new System.EventHandler(this.button2_Click);
            // 
            // VentanaPrincipalApoderado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnContratos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnInformaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDepositos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VentanaPrincipalApoderado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDepositos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnInformaciones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnContratos;
    }
}