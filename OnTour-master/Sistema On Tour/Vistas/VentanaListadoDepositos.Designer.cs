namespace Sistema_On_Tour.Vistas
{
    partial class VentanaListadoDepositos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaListadoDepositos));
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnRecargar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataDepositos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataDepositos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.SystemColors.Control;
            this.BtnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVolver.BackgroundImage")));
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnVolver.Location = new System.Drawing.Point(32, 58);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(74, 72);
            this.BtnVolver.TabIndex = 16;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnRecargar
            // 
            this.BtnRecargar.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecargar.Location = new System.Drawing.Point(347, 380);
            this.BtnRecargar.Name = "BtnRecargar";
            this.BtnRecargar.Size = new System.Drawing.Size(105, 33);
            this.BtnRecargar.TabIndex = 15;
            this.BtnRecargar.Text = "Recargar";
            this.BtnRecargar.UseVisualStyleBackColor = true;
            this.BtnRecargar.Click += new System.EventHandler(this.BtnRecargar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Agencia de Viajes On Tour";
            // 
            // DataDepositos
            // 
            this.DataDepositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDepositos.Location = new System.Drawing.Point(145, 105);
            this.DataDepositos.Name = "DataDepositos";
            this.DataDepositos.ReadOnly = true;
            this.DataDepositos.Size = new System.Drawing.Size(548, 250);
            this.DataDepositos.TabIndex = 17;
            // 
            // VentanaListadoDepositos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataDepositos);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnRecargar);
            this.Controls.Add(this.label1);
            this.Name = "VentanaListadoDepositos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaListadoDepositos";
            this.Load += new System.EventHandler(this.VentanaListadoDepositos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataDepositos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnRecargar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataDepositos;
    }
}