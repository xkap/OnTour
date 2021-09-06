namespace Sistema_On_Tour.Vistas
{
    partial class VentanaInformar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInformar));
            this.ComboContacto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnInformar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComboContacto
            // 
            this.ComboContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboContacto.FormattingEnabled = true;
            this.ComboContacto.Location = new System.Drawing.Point(365, 118);
            this.ComboContacto.Name = "ComboContacto";
            this.ComboContacto.Size = new System.Drawing.Size(240, 21);
            this.ComboContacto.Sorted = true;
            this.ComboContacto.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ingrese el mensaje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Contacto";
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.SystemColors.Control;
            this.BtnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVolver.BackgroundImage")));
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnVolver.Location = new System.Drawing.Point(33, 54);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(74, 72);
            this.BtnVolver.TabIndex = 23;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnInformar
            // 
            this.BtnInformar.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInformar.Location = new System.Drawing.Point(333, 373);
            this.BtnInformar.Name = "BtnInformar";
            this.BtnInformar.Size = new System.Drawing.Size(129, 38);
            this.BtnInformar.TabIndex = 22;
            this.BtnInformar.Text = "Informar";
            this.BtnInformar.UseVisualStyleBackColor = true;
            this.BtnInformar.Click += new System.EventHandler(this.BtnInformar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Agencia de Viajes On Tour";
            // 
            // TxtMensaje
            // 
            this.TxtMensaje.Location = new System.Drawing.Point(182, 212);
            this.TxtMensaje.Multiline = true;
            this.TxtMensaje.Name = "TxtMensaje";
            this.TxtMensaje.Size = new System.Drawing.Size(500, 136);
            this.TxtMensaje.TabIndex = 27;
            // 
            // VentanaInformar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtMensaje);
            this.Controls.Add(this.ComboContacto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnInformar);
            this.Controls.Add(this.label1);
            this.Name = "VentanaInformar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaInformar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboContacto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnInformar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMensaje;
    }
}