namespace Sistema_On_Tour.Vistas
{
    partial class VentanaPaquetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPaquetes));
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnContratar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboPaquetes = new System.Windows.Forms.ComboBox();
            this.ComboCursos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.SystemColors.Control;
            this.BtnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVolver.BackgroundImage")));
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnVolver.Location = new System.Drawing.Point(33, 56);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(74, 72);
            this.BtnVolver.TabIndex = 16;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnContratar
            // 
            this.BtnContratar.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContratar.Location = new System.Drawing.Point(333, 361);
            this.BtnContratar.Name = "BtnContratar";
            this.BtnContratar.Size = new System.Drawing.Size(129, 38);
            this.BtnContratar.TabIndex = 15;
            this.BtnContratar.Text = "Contratar";
            this.BtnContratar.UseVisualStyleBackColor = true;
            this.BtnContratar.Click += new System.EventHandler(this.BtnContratar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Agencia de Viajes On Tour";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Paquetes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Curso";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ComboPaquetes
            // 
            this.ComboPaquetes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPaquetes.FormattingEnabled = true;
            this.ComboPaquetes.Location = new System.Drawing.Point(380, 174);
            this.ComboPaquetes.Name = "ComboPaquetes";
            this.ComboPaquetes.Size = new System.Drawing.Size(240, 21);
            this.ComboPaquetes.Sorted = true;
            this.ComboPaquetes.TabIndex = 19;
            this.ComboPaquetes.SelectedIndexChanged += new System.EventHandler(this.ComboPaquetes_SelectedIndexChanged);
            // 
            // ComboCursos
            // 
            this.ComboCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCursos.FormattingEnabled = true;
            this.ComboCursos.Location = new System.Drawing.Point(380, 236);
            this.ComboCursos.Name = "ComboCursos";
            this.ComboCursos.Size = new System.Drawing.Size(240, 21);
            this.ComboCursos.Sorted = true;
            this.ComboCursos.TabIndex = 20;
            this.ComboCursos.SelectedIndexChanged += new System.EventHandler(this.ComboCursos_SelectedIndexChanged);
            // 
            // VentanaPaquetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComboCursos);
            this.Controls.Add(this.ComboPaquetes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnContratar);
            this.Controls.Add(this.label1);
            this.Name = "VentanaPaquetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPaquetes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnContratar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboPaquetes;
        private System.Windows.Forms.ComboBox ComboCursos;
    }
}