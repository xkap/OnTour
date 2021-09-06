namespace Sistema_On_Tour.Vistas
{
    partial class VentanaRegistrarApoderado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaRegistrarApoderado));
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtCurso = new System.Windows.Forms.TextBox();
            this.TxtCant = new System.Windows.Forms.TextBox();
            this.TxtRun = new System.Windows.Forms.TextBox();
            this.TxtAppaterno = new System.Windows.Forms.TextBox();
            this.TxtColegio = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.RadioM = new System.Windows.Forms.RadioButton();
            this.RadioF = new System.Windows.Forms.RadioButton();
            this.GrupoGenero = new System.Windows.Forms.GroupBox();
            this.RadioCasado = new System.Windows.Forms.RadioButton();
            this.RadioSoltero = new System.Windows.Forms.RadioButton();
            this.GrupoECivil = new System.Windows.Forms.GroupBox();
            this.RadioViudo = new System.Windows.Forms.RadioButton();
            this.RadioDivorciado = new System.Windows.Forms.RadioButton();
            this.TxtApmaterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LblContra = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.errorFecha = new System.Windows.Forms.ErrorProvider(this.components);
            this.GrupoGenero.SuspendLayout();
            this.GrupoECivil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.SystemColors.Control;
            this.BtnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVolver.BackgroundImage")));
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnVolver.Cursor = System.Windows.Forms.Cursors.Default;
            this.BtnVolver.Location = new System.Drawing.Point(43, 45);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(74, 72);
            this.BtnVolver.TabIndex = 30;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.Location = new System.Drawing.Point(355, 480);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(97, 29);
            this.BtnRegistrar.TabIndex = 16;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 37);
            this.label1.TabIndex = 28;
            this.label1.Text = "Agencia de Viajes On Tour";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(221, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 33;
            this.label4.Text = "Cant de Alumnos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(221, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Curso";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 35;
            this.label6.Text = "Colegio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(221, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 36;
            this.label7.Text = "Estado Civil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(221, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 18);
            this.label8.TabIndex = 37;
            this.label8.Text = "Genero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(219, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 18);
            this.label9.TabIndex = 38;
            this.label9.Text = "Fecha de Nacimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(219, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 18);
            this.label10.TabIndex = 39;
            this.label10.Text = "Run";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(219, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 18);
            this.label11.TabIndex = 40;
            this.label11.Text = "Apellido Paterno";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(386, 97);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(219, 20);
            this.TxtNombres.TabIndex = 2;
            // 
            // TxtCurso
            // 
            this.TxtCurso.Location = new System.Drawing.Point(388, 356);
            this.TxtCurso.Name = "TxtCurso";
            this.TxtCurso.Size = new System.Drawing.Size(219, 20);
            this.TxtCurso.TabIndex = 13;
            // 
            // TxtCant
            // 
            this.TxtCant.Location = new System.Drawing.Point(388, 385);
            this.TxtCant.Name = "TxtCant";
            this.TxtCant.Size = new System.Drawing.Size(219, 20);
            this.TxtCant.TabIndex = 14;
            // 
            // TxtRun
            // 
            this.TxtRun.Location = new System.Drawing.Point(386, 59);
            this.TxtRun.Name = "TxtRun";
            this.TxtRun.Size = new System.Drawing.Size(219, 20);
            this.TxtRun.TabIndex = 1;
            // 
            // TxtAppaterno
            // 
            this.TxtAppaterno.Location = new System.Drawing.Point(386, 128);
            this.TxtAppaterno.Name = "TxtAppaterno";
            this.TxtAppaterno.Size = new System.Drawing.Size(219, 20);
            this.TxtAppaterno.TabIndex = 3;
            // 
            // TxtColegio
            // 
            this.TxtColegio.Location = new System.Drawing.Point(388, 413);
            this.TxtColegio.Name = "TxtColegio";
            this.TxtColegio.Size = new System.Drawing.Size(219, 20);
            this.TxtColegio.TabIndex = 15;
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(386, 186);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(219, 20);
            this.Fecha.TabIndex = 5;
            // 
            // RadioM
            // 
            this.RadioM.AutoSize = true;
            this.RadioM.Checked = true;
            this.RadioM.Location = new System.Drawing.Point(6, 19);
            this.RadioM.Name = "RadioM";
            this.RadioM.Size = new System.Drawing.Size(73, 17);
            this.RadioM.TabIndex = 7;
            this.RadioM.TabStop = true;
            this.RadioM.Text = "Masculino";
            this.RadioM.UseVisualStyleBackColor = true;
            // 
            // RadioF
            // 
            this.RadioF.AutoSize = true;
            this.RadioF.Location = new System.Drawing.Point(127, 19);
            this.RadioF.Name = "RadioF";
            this.RadioF.Size = new System.Drawing.Size(71, 17);
            this.RadioF.TabIndex = 8;
            this.RadioF.Text = "Femenino";
            this.RadioF.UseVisualStyleBackColor = true;
            // 
            // GrupoGenero
            // 
            this.GrupoGenero.Controls.Add(this.RadioM);
            this.GrupoGenero.Controls.Add(this.RadioF);
            this.GrupoGenero.Location = new System.Drawing.Point(388, 243);
            this.GrupoGenero.Name = "GrupoGenero";
            this.GrupoGenero.Size = new System.Drawing.Size(219, 53);
            this.GrupoGenero.TabIndex = 50;
            this.GrupoGenero.TabStop = false;
            // 
            // RadioCasado
            // 
            this.RadioCasado.AutoSize = true;
            this.RadioCasado.Location = new System.Drawing.Point(127, 14);
            this.RadioCasado.Name = "RadioCasado";
            this.RadioCasado.Size = new System.Drawing.Size(61, 17);
            this.RadioCasado.TabIndex = 10;
            this.RadioCasado.TabStop = true;
            this.RadioCasado.Text = "Casado";
            this.RadioCasado.UseVisualStyleBackColor = true;
            // 
            // RadioSoltero
            // 
            this.RadioSoltero.AutoSize = true;
            this.RadioSoltero.Checked = true;
            this.RadioSoltero.Location = new System.Drawing.Point(6, 16);
            this.RadioSoltero.Name = "RadioSoltero";
            this.RadioSoltero.Size = new System.Drawing.Size(58, 17);
            this.RadioSoltero.TabIndex = 9;
            this.RadioSoltero.TabStop = true;
            this.RadioSoltero.Text = "Soltero";
            this.RadioSoltero.UseVisualStyleBackColor = true;
            // 
            // GrupoECivil
            // 
            this.GrupoECivil.Controls.Add(this.RadioCasado);
            this.GrupoECivil.Controls.Add(this.RadioViudo);
            this.GrupoECivil.Controls.Add(this.RadioSoltero);
            this.GrupoECivil.Controls.Add(this.RadioDivorciado);
            this.GrupoECivil.Location = new System.Drawing.Point(388, 288);
            this.GrupoECivil.Name = "GrupoECivil";
            this.GrupoECivil.Size = new System.Drawing.Size(219, 62);
            this.GrupoECivil.TabIndex = 53;
            this.GrupoECivil.TabStop = false;
            this.GrupoECivil.Enter += new System.EventHandler(this.GrupoECivil_Enter);
            // 
            // RadioViudo
            // 
            this.RadioViudo.AutoSize = true;
            this.RadioViudo.Location = new System.Drawing.Point(127, 37);
            this.RadioViudo.Name = "RadioViudo";
            this.RadioViudo.Size = new System.Drawing.Size(52, 17);
            this.RadioViudo.TabIndex = 12;
            this.RadioViudo.TabStop = true;
            this.RadioViudo.Text = "Viudo";
            this.RadioViudo.UseVisualStyleBackColor = true;
            // 
            // RadioDivorciado
            // 
            this.RadioDivorciado.AutoSize = true;
            this.RadioDivorciado.Location = new System.Drawing.Point(6, 37);
            this.RadioDivorciado.Name = "RadioDivorciado";
            this.RadioDivorciado.Size = new System.Drawing.Size(76, 17);
            this.RadioDivorciado.TabIndex = 11;
            this.RadioDivorciado.TabStop = true;
            this.RadioDivorciado.Text = "Divorciado";
            this.RadioDivorciado.UseVisualStyleBackColor = true;
            // 
            // TxtApmaterno
            // 
            this.TxtApmaterno.Location = new System.Drawing.Point(386, 156);
            this.TxtApmaterno.Name = "TxtApmaterno";
            this.TxtApmaterno.Size = new System.Drawing.Size(219, 20);
            this.TxtApmaterno.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 54;
            this.label3.Text = "Apellido Materno";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(220, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 20);
            this.label12.TabIndex = 56;
            this.label12.Text = "Contraseña Generada:";
            // 
            // LblContra
            // 
            this.LblContra.AutoSize = true;
            this.LblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContra.Location = new System.Drawing.Point(444, 446);
            this.LblContra.Name = "LblContra";
            this.LblContra.Size = new System.Drawing.Size(28, 18);
            this.LblContra.TabIndex = 57;
            this.LblContra.Text = "----";
            this.LblContra.Click += new System.EventHandler(this.LblContra_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(222, 225);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 18);
            this.label13.TabIndex = 58;
            this.label13.Text = "Correo";
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(386, 217);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(219, 20);
            this.TxtCorreo.TabIndex = 6;
            // 
            // errorFecha
            // 
            this.errorFecha.ContainerControl = this;
            // 
            // VentanaRegistrarApoderado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.LblContra);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtApmaterno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GrupoECivil);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.TxtColegio);
            this.Controls.Add(this.TxtAppaterno);
            this.Controls.Add(this.TxtRun);
            this.Controls.Add(this.TxtCant);
            this.Controls.Add(this.TxtCurso);
            this.Controls.Add(this.TxtNombres);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnVolver);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GrupoGenero);
            this.Name = "VentanaRegistrarApoderado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaRegistrarApoderado";
            this.GrupoGenero.ResumeLayout(false);
            this.GrupoGenero.PerformLayout();
            this.GrupoECivil.ResumeLayout(false);
            this.GrupoECivil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.TextBox TxtCurso;
        private System.Windows.Forms.TextBox TxtCant;
        private System.Windows.Forms.TextBox TxtRun;
        private System.Windows.Forms.TextBox TxtAppaterno;
        private System.Windows.Forms.TextBox TxtColegio;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.RadioButton RadioM;
        private System.Windows.Forms.RadioButton RadioF;
        private System.Windows.Forms.GroupBox GrupoGenero;
        private System.Windows.Forms.RadioButton RadioCasado;
        private System.Windows.Forms.RadioButton RadioSoltero;
        private System.Windows.Forms.GroupBox GrupoECivil;
        private System.Windows.Forms.RadioButton RadioViudo;
        private System.Windows.Forms.RadioButton RadioDivorciado;
        private System.Windows.Forms.TextBox TxtApmaterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblContra;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.ErrorProvider errorFecha;
    }
}