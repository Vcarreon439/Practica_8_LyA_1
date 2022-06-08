namespace Practica_8_LyA_1
{
    partial class frmPrograma
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCntrl = new System.Windows.Forms.TabControl();
            this.tbPgGenerador = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnNA = new System.Windows.Forms.RadioButton();
            this.rdbtnEjer4 = new System.Windows.Forms.RadioButton();
            this.rdbtnEjer3 = new System.Windows.Forms.RadioButton();
            this.rdbtnEjer2 = new System.Windows.Forms.RadioButton();
            this.rdbtnEjer1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.txtRegex = new System.Windows.Forms.TextBox();
            this.tbPgComprobador = new System.Windows.Forms.TabPage();
            this.txtContenedorPruebas = new System.Windows.Forms.TextBox();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtERComprobar = new System.Windows.Forms.TextBox();
            this.tbPgDocumentacion = new System.Windows.Forms.TabPage();
            this.tbPgInfo = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCntrl.SuspendLayout();
            this.tbPgGenerador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tbPgComprobador.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCntrl
            // 
            this.tbCntrl.Controls.Add(this.tbPgGenerador);
            this.tbCntrl.Controls.Add(this.tbPgComprobador);
            this.tbCntrl.Controls.Add(this.tbPgDocumentacion);
            this.tbCntrl.Controls.Add(this.tbPgInfo);
            this.tbCntrl.Location = new System.Drawing.Point(12, 12);
            this.tbCntrl.Name = "tbCntrl";
            this.tbCntrl.SelectedIndex = 0;
            this.tbCntrl.Size = new System.Drawing.Size(776, 417);
            this.tbCntrl.TabIndex = 0;
            // 
            // tbPgGenerador
            // 
            this.tbPgGenerador.Controls.Add(this.button1);
            this.tbPgGenerador.Controls.Add(this.groupBox1);
            this.tbPgGenerador.Controls.Add(this.label2);
            this.tbPgGenerador.Controls.Add(this.btnGenerar);
            this.tbPgGenerador.Controls.Add(this.label1);
            this.tbPgGenerador.Controls.Add(this.numericUpDown1);
            this.tbPgGenerador.Controls.Add(this.lstResultados);
            this.tbPgGenerador.Controls.Add(this.txtRegex);
            this.tbPgGenerador.Location = new System.Drawing.Point(4, 22);
            this.tbPgGenerador.Name = "tbPgGenerador";
            this.tbPgGenerador.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgGenerador.Size = new System.Drawing.Size(768, 391);
            this.tbPgGenerador.TabIndex = 0;
            this.tbPgGenerador.Text = "Generador";
            this.tbPgGenerador.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnNA);
            this.groupBox1.Controls.Add(this.rdbtnEjer4);
            this.groupBox1.Controls.Add(this.rdbtnEjer3);
            this.groupBox1.Controls.Add(this.rdbtnEjer2);
            this.groupBox1.Controls.Add(this.rdbtnEjer1);
            this.groupBox1.Location = new System.Drawing.Point(15, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 99);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precargar Expresiones";
            // 
            // rdbtnNA
            // 
            this.rdbtnNA.AutoSize = true;
            this.rdbtnNA.Location = new System.Drawing.Point(207, 29);
            this.rdbtnNA.Name = "rdbtnNA";
            this.rdbtnNA.Size = new System.Drawing.Size(65, 17);
            this.rdbtnNA.TabIndex = 4;
            this.rdbtnNA.TabStop = true;
            this.rdbtnNA.Text = "Ninguno";
            this.rdbtnNA.UseVisualStyleBackColor = true;
            this.rdbtnNA.Click += new System.EventHandler(this.rdbtnNA_Click);
            // 
            // rdbtnEjer4
            // 
            this.rdbtnEjer4.AutoSize = true;
            this.rdbtnEjer4.Location = new System.Drawing.Point(116, 52);
            this.rdbtnEjer4.Name = "rdbtnEjer4";
            this.rdbtnEjer4.Size = new System.Drawing.Size(74, 17);
            this.rdbtnEjer4.TabIndex = 3;
            this.rdbtnEjer4.TabStop = true;
            this.rdbtnEjer4.Text = "Ejercicio 4";
            this.rdbtnEjer4.UseVisualStyleBackColor = true;
            this.rdbtnEjer4.Click += new System.EventHandler(this.rdbtnEjer4_Click);
            // 
            // rdbtnEjer3
            // 
            this.rdbtnEjer3.AutoSize = true;
            this.rdbtnEjer3.Location = new System.Drawing.Point(116, 29);
            this.rdbtnEjer3.Name = "rdbtnEjer3";
            this.rdbtnEjer3.Size = new System.Drawing.Size(74, 17);
            this.rdbtnEjer3.TabIndex = 2;
            this.rdbtnEjer3.TabStop = true;
            this.rdbtnEjer3.Text = "Ejercicio 3";
            this.rdbtnEjer3.UseVisualStyleBackColor = true;
            this.rdbtnEjer3.Click += new System.EventHandler(this.rdbtnEjer3_Click);
            // 
            // rdbtnEjer2
            // 
            this.rdbtnEjer2.AutoSize = true;
            this.rdbtnEjer2.Location = new System.Drawing.Point(15, 52);
            this.rdbtnEjer2.Name = "rdbtnEjer2";
            this.rdbtnEjer2.Size = new System.Drawing.Size(74, 17);
            this.rdbtnEjer2.TabIndex = 1;
            this.rdbtnEjer2.TabStop = true;
            this.rdbtnEjer2.Text = "Ejercicio 2";
            this.rdbtnEjer2.UseVisualStyleBackColor = true;
            this.rdbtnEjer2.Click += new System.EventHandler(this.rdbtnEjer2_Click);
            // 
            // rdbtnEjer1
            // 
            this.rdbtnEjer1.AutoSize = true;
            this.rdbtnEjer1.Location = new System.Drawing.Point(15, 29);
            this.rdbtnEjer1.Name = "rdbtnEjer1";
            this.rdbtnEjer1.Size = new System.Drawing.Size(74, 17);
            this.rdbtnEjer1.TabIndex = 0;
            this.rdbtnEjer1.TabStop = true;
            this.rdbtnEjer1.Text = "Ejercicio 1";
            this.rdbtnEjer1.UseVisualStyleBackColor = true;
            this.rdbtnEjer1.Click += new System.EventHandler(this.rdbtnEjer1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultados";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(15, 65);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(90, 23);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Expresión Regular";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(258, 68);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.Location = new System.Drawing.Point(336, 39);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(414, 329);
            this.lstResultados.TabIndex = 1;
            // 
            // txtRegex
            // 
            this.txtRegex.Location = new System.Drawing.Point(15, 39);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(303, 20);
            this.txtRegex.TabIndex = 0;
            // 
            // tbPgComprobador
            // 
            this.tbPgComprobador.Controls.Add(this.txtContenedorPruebas);
            this.tbPgComprobador.Controls.Add(this.btnComprobar);
            this.tbPgComprobador.Controls.Add(this.groupBox2);
            this.tbPgComprobador.Controls.Add(this.label3);
            this.tbPgComprobador.Controls.Add(this.txtERComprobar);
            this.tbPgComprobador.Location = new System.Drawing.Point(4, 22);
            this.tbPgComprobador.Name = "tbPgComprobador";
            this.tbPgComprobador.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgComprobador.Size = new System.Drawing.Size(768, 391);
            this.tbPgComprobador.TabIndex = 1;
            this.tbPgComprobador.Text = "Comprobar";
            this.tbPgComprobador.UseVisualStyleBackColor = true;
            // 
            // txtContenedorPruebas
            // 
            this.txtContenedorPruebas.Location = new System.Drawing.Point(336, 39);
            this.txtContenedorPruebas.Multiline = true;
            this.txtContenedorPruebas.Name = "txtContenedorPruebas";
            this.txtContenedorPruebas.Size = new System.Drawing.Size(414, 329);
            this.txtContenedorPruebas.TabIndex = 9;
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(15, 65);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(90, 23);
            this.btnComprobar.TabIndex = 8;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Location = new System.Drawing.Point(15, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 99);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precargar Expresiones";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(207, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ninguno";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(116, 52);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ejercicio 4";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(116, 29);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ejercicio 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 52);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(74, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Ejercicio 2";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(15, 29);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(74, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Ejercicio 1";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expresión Regular";
            // 
            // txtERComprobar
            // 
            this.txtERComprobar.Location = new System.Drawing.Point(15, 39);
            this.txtERComprobar.Name = "txtERComprobar";
            this.txtERComprobar.Size = new System.Drawing.Size(303, 20);
            this.txtERComprobar.TabIndex = 4;
            // 
            // tbPgDocumentacion
            // 
            this.tbPgDocumentacion.Location = new System.Drawing.Point(4, 22);
            this.tbPgDocumentacion.Name = "tbPgDocumentacion";
            this.tbPgDocumentacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgDocumentacion.Size = new System.Drawing.Size(768, 391);
            this.tbPgDocumentacion.TabIndex = 2;
            this.tbPgDocumentacion.Text = "Documentación";
            this.tbPgDocumentacion.UseVisualStyleBackColor = true;
            // 
            // tbPgInfo
            // 
            this.tbPgInfo.Location = new System.Drawing.Point(4, 22);
            this.tbPgInfo.Name = "tbPgInfo";
            this.tbPgInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgInfo.Size = new System.Drawing.Size(768, 391);
            this.tbPgInfo.TabIndex = 3;
            this.tbPgInfo.Text = "Información ";
            this.tbPgInfo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCntrl);
            this.Name = "frmPrograma";
            this.Text = "Practica 8 - Lenguajes y Automatas";
            this.tbCntrl.ResumeLayout(false);
            this.tbPgGenerador.ResumeLayout(false);
            this.tbPgGenerador.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tbPgComprobador.ResumeLayout(false);
            this.tbPgComprobador.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbCntrl;
        private System.Windows.Forms.TabPage tbPgGenerador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnNA;
        private System.Windows.Forms.RadioButton rdbtnEjer4;
        private System.Windows.Forms.RadioButton rdbtnEjer3;
        private System.Windows.Forms.RadioButton rdbtnEjer2;
        private System.Windows.Forms.RadioButton rdbtnEjer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.TextBox txtRegex;
        private System.Windows.Forms.TabPage tbPgComprobador;
        private System.Windows.Forms.TabPage tbPgDocumentacion;
        private System.Windows.Forms.TabPage tbPgInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtERComprobar;
        private System.Windows.Forms.Button btnComprobar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.TextBox txtContenedorPruebas;
        private System.Windows.Forms.Button button1;
    }
}

