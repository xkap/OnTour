namespace Sistema_On_Tour.Vistas
{
    partial class VentanaDepositos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaDepositos));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDepositar = new System.Windows.Forms.Button();
            this.BtnListado = new System.Windows.Forms.Button();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Agencia de Viajes On Tour";
            // 
            // BtnDepositar
            // 
            this.BtnDepositar.Font = new System.Drawing.Font("Perpetua", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDepositar.Location = new System.Drawing.Point(267, 109);
            this.BtnDepositar.Name = "BtnDepositar";
            this.BtnDepositar.Size = new System.Drawing.Size(236, 104);
            this.BtnDepositar.TabIndex = 10;
            this.BtnDepositar.Text = "Depositar";
            this.BtnDepositar.UseVisualStyleBackColor = true;
            this.BtnDepositar.Click += new System.EventHandler(this.BtnDepositar_Click);
            // 
            // BtnListado
            // 
            this.BtnListado.Font = new System.Drawing.Font("Perpetua", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListado.Location = new System.Drawing.Point(267, 268);
            this.BtnListado.Name = "BtnListado";
            this.BtnListado.Size = new System.Drawing.Size(236, 104);
            this.BtnListado.TabIndex = 11;
            this.BtnListado.Text = "Listado de Depositos";
            this.BtnListado.UseVisualStyleBackColor = true;
            this.BtnListado.Click += new System.EventHandler(this.BtnListado_Click);
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.SystemColors.Control;
            this.BtnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVolver.BackgroundImage")));
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnVolver.Location = new System.Drawing.Point(23, 43);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(74, 72);
            this.BtnVolver.TabIndex = 12;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // VentanaDepositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnListado);
            this.Controls.Add(this.BtnDepositar);
            this.Controls.Add(this.label1);
            this.Name = "VentanaDepositos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaDepositos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDepositar;
        private System.Windows.Forms.Button BtnListado;
        private System.Windows.Forms.Button BtnVolver;
    }
}