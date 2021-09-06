namespace Sistema_On_Tour.Vistas
{
    partial class VentanaInformacionesEjecutivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInformacionesEjecutivo));
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnPublicar = new System.Windows.Forms.Button();
            this.BtnInformar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.SystemColors.Control;
            this.BtnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVolver.BackgroundImage")));
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnVolver.Location = new System.Drawing.Point(45, 59);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(74, 72);
            this.BtnVolver.TabIndex = 16;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnPublicar
            // 
            this.BtnPublicar.Font = new System.Drawing.Font("Perpetua", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPublicar.Location = new System.Drawing.Point(289, 284);
            this.BtnPublicar.Name = "BtnPublicar";
            this.BtnPublicar.Size = new System.Drawing.Size(236, 104);
            this.BtnPublicar.TabIndex = 15;
            this.BtnPublicar.Text = "Publicar Información";
            this.BtnPublicar.UseVisualStyleBackColor = true;
            this.BtnPublicar.Click += new System.EventHandler(this.BtnPublicar_Click);
            // 
            // BtnInformar
            // 
            this.BtnInformar.Font = new System.Drawing.Font("Perpetua", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInformar.Location = new System.Drawing.Point(289, 125);
            this.BtnInformar.Name = "BtnInformar";
            this.BtnInformar.Size = new System.Drawing.Size(236, 104);
            this.BtnInformar.TabIndex = 14;
            this.BtnInformar.Text = "Informar Cliente";
            this.BtnInformar.UseVisualStyleBackColor = true;
            this.BtnInformar.Click += new System.EventHandler(this.BtnInformar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Agencia de Viajes On Tour";
            // 
            // VentanaInformacionesEjecutivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnPublicar);
            this.Controls.Add(this.BtnInformar);
            this.Controls.Add(this.label1);
            this.Name = "VentanaInformacionesEjecutivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaInformacionesEjecutivo";
            this.Load += new System.EventHandler(this.VentanaInformacionesEjecutivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnPublicar;
        private System.Windows.Forms.Button BtnInformar;
        private System.Windows.Forms.Label label1;
    }
}