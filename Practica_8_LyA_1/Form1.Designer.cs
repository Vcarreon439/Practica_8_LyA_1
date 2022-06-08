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
            this.rdbtnNA2 = new System.Windows.Forms.RadioButton();
            this.rdbtnCmp4 = new System.Windows.Forms.RadioButton();
            this.rdbtnCmp3 = new System.Windows.Forms.RadioButton();
            this.rdbtnCmp2 = new System.Windows.Forms.RadioButton();
            this.rdbtnCmp1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtERComprobar = new System.Windows.Forms.TextBox();
            this.tbPgDocumentacion = new System.Windows.Forms.TabPage();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPgInfo = new System.Windows.Forms.TabPage();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCntrl.SuspendLayout();
            this.tbPgGenerador.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tbPgComprobador.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbPgDocumentacion.SuspendLayout();
            this.tbPgInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCntrl
            // 
            this.tbCntrl.Controls.Add(this.tbPgGenerador);
            this.tbCntrl.Controls.Add(this.tbPgComprobador);
            this.tbCntrl.Controls.Add(this.tbPgDocumentacion);
            this.tbCntrl.Controls.Add(this.tbPgInfo);
            this.tbCntrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCntrl.Location = new System.Drawing.Point(12, 12);
            this.tbCntrl.Name = "tbCntrl";
            this.tbCntrl.SelectedIndex = 0;
            this.tbCntrl.Size = new System.Drawing.Size(776, 417);
            this.tbCntrl.TabIndex = 0;
            // 
            // tbPgGenerador
            // 
            this.tbPgGenerador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tbPgGenerador.Controls.Add(this.groupBox1);
            this.tbPgGenerador.Controls.Add(this.label2);
            this.tbPgGenerador.Controls.Add(this.btnGenerar);
            this.tbPgGenerador.Controls.Add(this.label1);
            this.tbPgGenerador.Controls.Add(this.numericUpDown1);
            this.tbPgGenerador.Controls.Add(this.lstResultados);
            this.tbPgGenerador.Controls.Add(this.txtRegex);
            this.tbPgGenerador.Location = new System.Drawing.Point(4, 25);
            this.tbPgGenerador.Name = "tbPgGenerador";
            this.tbPgGenerador.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgGenerador.Size = new System.Drawing.Size(768, 388);
            this.tbPgGenerador.TabIndex = 0;
            this.tbPgGenerador.Text = "Generador";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnNA);
            this.groupBox1.Controls.Add(this.rdbtnEjer4);
            this.groupBox1.Controls.Add(this.rdbtnEjer3);
            this.groupBox1.Controls.Add(this.rdbtnEjer2);
            this.groupBox1.Controls.Add(this.rdbtnEjer1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(15, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 132);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precargar Expresiones";
            // 
            // rdbtnNA
            // 
            this.rdbtnNA.AutoSize = true;
            this.rdbtnNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNA.Location = new System.Drawing.Point(137, 59);
            this.rdbtnNA.Name = "rdbtnNA";
            this.rdbtnNA.Size = new System.Drawing.Size(86, 24);
            this.rdbtnNA.TabIndex = 4;
            this.rdbtnNA.TabStop = true;
            this.rdbtnNA.Text = "Ninguno";
            this.rdbtnNA.UseVisualStyleBackColor = true;
            this.rdbtnNA.Click += new System.EventHandler(this.rdbtnNA_Click);
            // 
            // rdbtnEjer4
            // 
            this.rdbtnEjer4.AutoSize = true;
            this.rdbtnEjer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnEjer4.Location = new System.Drawing.Point(137, 29);
            this.rdbtnEjer4.Name = "rdbtnEjer4";
            this.rdbtnEjer4.Size = new System.Drawing.Size(99, 24);
            this.rdbtnEjer4.TabIndex = 3;
            this.rdbtnEjer4.TabStop = true;
            this.rdbtnEjer4.Text = "Ejercicio 4";
            this.rdbtnEjer4.UseVisualStyleBackColor = true;
            this.rdbtnEjer4.Click += new System.EventHandler(this.rdbtnEjer4_Click);
            // 
            // rdbtnEjer3
            // 
            this.rdbtnEjer3.AutoSize = true;
            this.rdbtnEjer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnEjer3.Location = new System.Drawing.Point(23, 89);
            this.rdbtnEjer3.Name = "rdbtnEjer3";
            this.rdbtnEjer3.Size = new System.Drawing.Size(99, 24);
            this.rdbtnEjer3.TabIndex = 2;
            this.rdbtnEjer3.TabStop = true;
            this.rdbtnEjer3.Text = "Ejercicio 3";
            this.rdbtnEjer3.UseVisualStyleBackColor = true;
            this.rdbtnEjer3.Click += new System.EventHandler(this.rdbtnEjer3_Click);
            // 
            // rdbtnEjer2
            // 
            this.rdbtnEjer2.AutoSize = true;
            this.rdbtnEjer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnEjer2.Location = new System.Drawing.Point(23, 59);
            this.rdbtnEjer2.Name = "rdbtnEjer2";
            this.rdbtnEjer2.Size = new System.Drawing.Size(99, 24);
            this.rdbtnEjer2.TabIndex = 1;
            this.rdbtnEjer2.TabStop = true;
            this.rdbtnEjer2.Text = "Ejercicio 2";
            this.rdbtnEjer2.UseVisualStyleBackColor = true;
            this.rdbtnEjer2.Click += new System.EventHandler(this.rdbtnEjer2_Click);
            // 
            // rdbtnEjer1
            // 
            this.rdbtnEjer1.AutoSize = true;
            this.rdbtnEjer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnEjer1.Location = new System.Drawing.Point(23, 29);
            this.rdbtnEjer1.Name = "rdbtnEjer1";
            this.rdbtnEjer1.Size = new System.Drawing.Size(99, 24);
            this.rdbtnEjer1.TabIndex = 0;
            this.rdbtnEjer1.TabStop = true;
            this.rdbtnEjer1.Text = "Ejercicio 1";
            this.rdbtnEjer1.UseVisualStyleBackColor = true;
            this.rdbtnEjer1.Click += new System.EventHandler(this.rdbtnEjer1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(332, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Resultados";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(15, 81);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(90, 32);
            this.btnGenerar.TabIndex = 4;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Expresión Regular";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(258, 85);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 26);
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
            this.lstResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 20;
            this.lstResultados.Location = new System.Drawing.Point(336, 45);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(414, 324);
            this.lstResultados.TabIndex = 1;
            // 
            // txtRegex
            // 
            this.txtRegex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegex.Location = new System.Drawing.Point(15, 45);
            this.txtRegex.Name = "txtRegex";
            this.txtRegex.Size = new System.Drawing.Size(303, 26);
            this.txtRegex.TabIndex = 0;
            // 
            // tbPgComprobador
            // 
            this.tbPgComprobador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tbPgComprobador.Controls.Add(this.txtContenedorPruebas);
            this.tbPgComprobador.Controls.Add(this.btnComprobar);
            this.tbPgComprobador.Controls.Add(this.groupBox2);
            this.tbPgComprobador.Controls.Add(this.label3);
            this.tbPgComprobador.Controls.Add(this.txtERComprobar);
            this.tbPgComprobador.Location = new System.Drawing.Point(4, 25);
            this.tbPgComprobador.Name = "tbPgComprobador";
            this.tbPgComprobador.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgComprobador.Size = new System.Drawing.Size(768, 388);
            this.tbPgComprobador.TabIndex = 1;
            this.tbPgComprobador.Text = "Comprobar";
            // 
            // txtContenedorPruebas
            // 
            this.txtContenedorPruebas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContenedorPruebas.Location = new System.Drawing.Point(336, 39);
            this.txtContenedorPruebas.Multiline = true;
            this.txtContenedorPruebas.Name = "txtContenedorPruebas";
            this.txtContenedorPruebas.Size = new System.Drawing.Size(414, 329);
            this.txtContenedorPruebas.TabIndex = 9;
            // 
            // btnComprobar
            // 
            this.btnComprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobar.Location = new System.Drawing.Point(15, 81);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(108, 32);
            this.btnComprobar.TabIndex = 8;
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbtnNA2);
            this.groupBox2.Controls.Add(this.rdbtnCmp4);
            this.groupBox2.Controls.Add(this.rdbtnCmp3);
            this.groupBox2.Controls.Add(this.rdbtnCmp2);
            this.groupBox2.Controls.Add(this.rdbtnCmp1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(15, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 132);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precargar Expresiones";
            // 
            // rdbtnNA2
            // 
            this.rdbtnNA2.AutoSize = true;
            this.rdbtnNA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNA2.Location = new System.Drawing.Point(137, 59);
            this.rdbtnNA2.Name = "rdbtnNA2";
            this.rdbtnNA2.Size = new System.Drawing.Size(86, 24);
            this.rdbtnNA2.TabIndex = 4;
            this.rdbtnNA2.Text = "Ninguno";
            this.rdbtnNA2.UseVisualStyleBackColor = true;
            this.rdbtnNA2.Click += new System.EventHandler(this.rdbtnNA2_Click);
            // 
            // rdbtnCmp4
            // 
            this.rdbtnCmp4.AutoSize = true;
            this.rdbtnCmp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnCmp4.Location = new System.Drawing.Point(137, 29);
            this.rdbtnCmp4.Name = "rdbtnCmp4";
            this.rdbtnCmp4.Size = new System.Drawing.Size(99, 24);
            this.rdbtnCmp4.TabIndex = 3;
            this.rdbtnCmp4.Text = "Ejercicio 4";
            this.rdbtnCmp4.UseVisualStyleBackColor = true;
            this.rdbtnCmp4.Click += new System.EventHandler(this.rdbtnCmp4_Click);
            // 
            // rdbtnCmp3
            // 
            this.rdbtnCmp3.AutoSize = true;
            this.rdbtnCmp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnCmp3.Location = new System.Drawing.Point(23, 89);
            this.rdbtnCmp3.Name = "rdbtnCmp3";
            this.rdbtnCmp3.Size = new System.Drawing.Size(99, 24);
            this.rdbtnCmp3.TabIndex = 2;
            this.rdbtnCmp3.Text = "Ejercicio 3";
            this.rdbtnCmp3.UseVisualStyleBackColor = true;
            this.rdbtnCmp3.Click += new System.EventHandler(this.rdbtnCmp3_Click);
            // 
            // rdbtnCmp2
            // 
            this.rdbtnCmp2.AutoSize = true;
            this.rdbtnCmp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnCmp2.Location = new System.Drawing.Point(23, 59);
            this.rdbtnCmp2.Name = "rdbtnCmp2";
            this.rdbtnCmp2.Size = new System.Drawing.Size(99, 24);
            this.rdbtnCmp2.TabIndex = 1;
            this.rdbtnCmp2.Text = "Ejercicio 2";
            this.rdbtnCmp2.UseVisualStyleBackColor = true;
            this.rdbtnCmp2.Click += new System.EventHandler(this.rdbtnCmp2_Click);
            // 
            // rdbtnCmp1
            // 
            this.rdbtnCmp1.AutoSize = true;
            this.rdbtnCmp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnCmp1.Location = new System.Drawing.Point(23, 29);
            this.rdbtnCmp1.Name = "rdbtnCmp1";
            this.rdbtnCmp1.Size = new System.Drawing.Size(99, 24);
            this.rdbtnCmp1.TabIndex = 0;
            this.rdbtnCmp1.Text = "Ejercicio 1";
            this.rdbtnCmp1.UseVisualStyleBackColor = true;
            this.rdbtnCmp1.Click += new System.EventHandler(this.rdbtnCmp1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expresión Regular";
            // 
            // txtERComprobar
            // 
            this.txtERComprobar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtERComprobar.Location = new System.Drawing.Point(15, 45);
            this.txtERComprobar.Name = "txtERComprobar";
            this.txtERComprobar.Size = new System.Drawing.Size(303, 26);
            this.txtERComprobar.TabIndex = 4;
            // 
            // tbPgDocumentacion
            // 
            this.tbPgDocumentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tbPgDocumentacion.Controls.Add(this.linkLabel6);
            this.tbPgDocumentacion.Controls.Add(this.linkLabel5);
            this.tbPgDocumentacion.Controls.Add(this.linkLabel4);
            this.tbPgDocumentacion.Controls.Add(this.label8);
            this.tbPgDocumentacion.Location = new System.Drawing.Point(4, 25);
            this.tbPgDocumentacion.Name = "tbPgDocumentacion";
            this.tbPgDocumentacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgDocumentacion.Size = new System.Drawing.Size(768, 388);
            this.tbPgDocumentacion.TabIndex = 2;
            this.tbPgDocumentacion.Text = "Documentación";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel6.LinkColor = System.Drawing.Color.White;
            this.linkLabel6.Location = new System.Drawing.Point(22, 127);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(229, 20);
            this.linkLabel6.TabIndex = 8;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Tabla de expresiones regulares";
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.Color.White;
            this.linkLabel5.Location = new System.Drawing.Point(35, 56);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(242, 20);
            this.linkLabel5.TabIndex = 6;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "System.Text.RegularExpressions";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.White;
            this.linkLabel4.Location = new System.Drawing.Point(35, 85);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(381, 20);
            this.linkLabel4.TabIndex = 5;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Fare - [F]inite [A]utomata and [R]egular [E]xpressions";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(22, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Librerias Utilizadas";
            // 
            // tbPgInfo
            // 
            this.tbPgInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tbPgInfo.Controls.Add(this.linkLabel3);
            this.tbPgInfo.Controls.Add(this.linkLabel2);
            this.tbPgInfo.Controls.Add(this.linkLabel1);
            this.tbPgInfo.Controls.Add(this.label7);
            this.tbPgInfo.Controls.Add(this.label6);
            this.tbPgInfo.Controls.Add(this.label5);
            this.tbPgInfo.Controls.Add(this.label4);
            this.tbPgInfo.Location = new System.Drawing.Point(4, 25);
            this.tbPgInfo.Name = "tbPgInfo";
            this.tbPgInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgInfo.Size = new System.Drawing.Size(768, 388);
            this.tbPgInfo.TabIndex = 3;
            this.tbPgInfo.Text = "Información ";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.White;
            this.linkLabel3.Location = new System.Drawing.Point(29, 227);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(331, 20);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Edgar Eduardo Arguijo Vazquez - 192310252";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(29, 194);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(292, 20);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Andrea Evelyn Mejia Rubio - 192310177";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(29, 161);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(295, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Victor Hugo Carreon Pulido - 192310436";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Autores";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Docente: Lic. Roberto Garcia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Materia: Lenguajes y Automatas I";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Instituto Tecnológico Superior de Lerdo";
            // 
            // frmPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 438);
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
            this.tbPgDocumentacion.ResumeLayout(false);
            this.tbPgDocumentacion.PerformLayout();
            this.tbPgInfo.ResumeLayout(false);
            this.tbPgInfo.PerformLayout();
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
        private System.Windows.Forms.RadioButton rdbtnNA2;
        private System.Windows.Forms.RadioButton rdbtnCmp4;
        private System.Windows.Forms.RadioButton rdbtnCmp3;
        private System.Windows.Forms.RadioButton rdbtnCmp2;
        private System.Windows.Forms.RadioButton rdbtnCmp1;
        private System.Windows.Forms.TextBox txtContenedorPruebas;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabel6;
    }
}

