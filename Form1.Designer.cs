namespace MyCompiler
{
    partial class Form1
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
            this.btnSintactico = new System.Windows.Forms.Button();
            this.listErrors = new System.Windows.Forms.ListBox();
            this.btnCodigo = new System.Windows.Forms.Button();
            this.btnLexico = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelCalculator = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcAbs = new System.Windows.Forms.Button();
            this.btnCalcFactorial = new System.Windows.Forms.Button();
            this.btnCalcPi = new System.Windows.Forms.Button();
            this.btnCalcEuler = new System.Windows.Forms.Button();
            this.btnCalcParenthesisClose = new System.Windows.Forms.Button();
            this.btnCalcParenthesisOpen = new System.Windows.Forms.Button();
            this.btnCalcPercentage = new System.Windows.Forms.Button();
            this.btnCalcDel = new System.Windows.Forms.Button();
            this.btnCalcLn = new System.Windows.Forms.Button();
            this.btnCalcMod = new System.Windows.Forms.Button();
            this.btnCalcCotan = new System.Windows.Forms.Button();
            this.btnCalcCsc = new System.Windows.Forms.Button();
            this.btnCalcSec = new System.Windows.Forms.Button();
            this.btnCalcExp = new System.Windows.Forms.Button();
            this.btnCalcLog = new System.Windows.Forms.Button();
            this.btnCalcTan = new System.Windows.Forms.Button();
            this.btnCalcCos = new System.Windows.Forms.Button();
            this.btnCalcSin = new System.Windows.Forms.Button();
            this.textBoxCalculatorDisplay = new System.Windows.Forms.TextBox();
            this.btnCalcClear = new System.Windows.Forms.Button();
            this.btnCalcEquals = new System.Windows.Forms.Button();
            this.btnCalcDivide = new System.Windows.Forms.Button();
            this.btnCalcMultiply = new System.Windows.Forms.Button();
            this.btnCalcSubtract = new System.Windows.Forms.Button();
            this.btnCalcAdd = new System.Windows.Forms.Button();
            this.btnCalcDecimal = new System.Windows.Forms.Button();
            this.btnCalc0 = new System.Windows.Forms.Button();
            this.btnCalc9 = new System.Windows.Forms.Button();
            this.btnCalc8 = new System.Windows.Forms.Button();
            this.btnCalc7 = new System.Windows.Forms.Button();
            this.btnCalc6 = new System.Windows.Forms.Button();
            this.btnCalc5 = new System.Windows.Forms.Button();
            this.btnCalc4 = new System.Windows.Forms.Button();
            this.btnCalc3 = new System.Windows.Forms.Button();
            this.btnCalc2 = new System.Windows.Forms.Button();
            this.btnCalc1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lexemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simboloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panelCalculator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simboloBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSintactico
            // 
            this.btnSintactico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSintactico.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSintactico.FlatAppearance.BorderSize = 0;
            this.btnSintactico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSintactico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSintactico.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSintactico.Location = new System.Drawing.Point(713, 32);
            this.btnSintactico.Margin = new System.Windows.Forms.Padding(4);
            this.btnSintactico.Name = "btnSintactico";
            this.btnSintactico.Size = new System.Drawing.Size(94, 40);
            this.btnSintactico.TabIndex = 14;
            this.btnSintactico.Text = "Sintáctico";
            this.btnSintactico.UseVisualStyleBackColor = false;
            this.btnSintactico.Click += new System.EventHandler(this.btnSintactico_Click);
            // 
            // listErrors
            // 
            this.listErrors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listErrors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.listErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listErrors.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listErrors.ForeColor = System.Drawing.Color.OrangeRed;
            this.listErrors.FormattingEnabled = true;
            this.listErrors.ItemHeight = 20;
            this.listErrors.Location = new System.Drawing.Point(16, 684);
            this.listErrors.Name = "listErrors";
            this.listErrors.Size = new System.Drawing.Size(1176, 80);
            this.listErrors.TabIndex = 13;
            // 
            // btnCodigo
            // 
            this.btnCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCodigo.BackColor = System.Drawing.Color.Teal;
            this.btnCodigo.FlatAppearance.BorderSize = 0;
            this.btnCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodigo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCodigo.Location = new System.Drawing.Point(935, 32);
            this.btnCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(101, 40);
            this.btnCodigo.TabIndex = 16;
            this.btnCodigo.Text = "Código";
            this.btnCodigo.UseVisualStyleBackColor = false;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // btnLexico
            // 
            this.btnLexico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLexico.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLexico.FlatAppearance.BorderSize = 0;
            this.btnLexico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLexico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLexico.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLexico.Location = new System.Drawing.Point(608, 32);
            this.btnLexico.Margin = new System.Windows.Forms.Padding(4);
            this.btnLexico.Name = "btnLexico";
            this.btnLexico.Size = new System.Drawing.Size(86, 40);
            this.btnLexico.TabIndex = 10;
            this.btnLexico.Text = "Léxico";
            this.btnLexico.UseVisualStyleBackColor = false;
            this.btnLexico.Click += new System.EventHandler(this.btnLexico_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "smm";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "smm";
            this.openFileDialog1.Filter = "My compiler files|*.smm|All files|*.*";
            // 
            // panelCalculator
            // 
            this.panelCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            this.panelCalculator.Controls.Add(this.lblResultado);
            this.panelCalculator.Controls.Add(this.btnCalcAbs);
            this.panelCalculator.Controls.Add(this.btnCalcFactorial);
            this.panelCalculator.Controls.Add(this.btnCalcPi);
            this.panelCalculator.Controls.Add(this.btnCalcEuler);
            this.panelCalculator.Controls.Add(this.btnCalcParenthesisClose);
            this.panelCalculator.Controls.Add(this.btnCalcParenthesisOpen);
            this.panelCalculator.Controls.Add(this.btnCalcPercentage);
            this.panelCalculator.Controls.Add(this.btnCalcDel);
            this.panelCalculator.Controls.Add(this.btnCalcLn);
            this.panelCalculator.Controls.Add(this.btnCalcMod);
            this.panelCalculator.Controls.Add(this.btnCalcCotan);
            this.panelCalculator.Controls.Add(this.btnCalcCsc);
            this.panelCalculator.Controls.Add(this.btnCalcSec);
            this.panelCalculator.Controls.Add(this.btnCalcExp);
            this.panelCalculator.Controls.Add(this.btnCalcLog);
            this.panelCalculator.Controls.Add(this.btnCalcTan);
            this.panelCalculator.Controls.Add(this.btnCalcCos);
            this.panelCalculator.Controls.Add(this.btnCalcSin);
            this.panelCalculator.Controls.Add(this.textBoxCalculatorDisplay);
            this.panelCalculator.Controls.Add(this.btnCalcClear);
            this.panelCalculator.Controls.Add(this.btnCalcEquals);
            this.panelCalculator.Controls.Add(this.btnCalcDivide);
            this.panelCalculator.Controls.Add(this.btnCalcMultiply);
            this.panelCalculator.Controls.Add(this.btnCalcSubtract);
            this.panelCalculator.Controls.Add(this.btnCalcAdd);
            this.panelCalculator.Controls.Add(this.btnCalcDecimal);
            this.panelCalculator.Controls.Add(this.btnCalc0);
            this.panelCalculator.Controls.Add(this.btnCalc9);
            this.panelCalculator.Controls.Add(this.btnCalc8);
            this.panelCalculator.Controls.Add(this.btnCalc7);
            this.panelCalculator.Controls.Add(this.btnCalc6);
            this.panelCalculator.Controls.Add(this.btnCalc5);
            this.panelCalculator.Controls.Add(this.btnCalc4);
            this.panelCalculator.Controls.Add(this.btnCalc3);
            this.panelCalculator.Controls.Add(this.btnCalc2);
            this.panelCalculator.Controls.Add(this.btnCalc1);
            this.panelCalculator.Location = new System.Drawing.Point(16, 31);
            this.panelCalculator.Name = "panelCalculator";
            this.panelCalculator.Size = new System.Drawing.Size(555, 549);
            this.panelCalculator.TabIndex = 18;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblResultado.Location = new System.Drawing.Point(11, 106);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(21, 24);
            this.lblResultado.TabIndex = 44;
            this.lblResultado.Text = "0";
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnCalcAbs
            // 
            this.btnCalcAbs.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcAbs.FlatAppearance.BorderSize = 0;
            this.btnCalcAbs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcAbs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcAbs.ForeColor = System.Drawing.Color.White;
            this.btnCalcAbs.Location = new System.Drawing.Point(346, 409);
            this.btnCalcAbs.Name = "btnCalcAbs";
            this.btnCalcAbs.Size = new System.Drawing.Size(60, 40);
            this.btnCalcAbs.TabIndex = 43;
            this.btnCalcAbs.Text = "abs";
            this.btnCalcAbs.UseVisualStyleBackColor = false;
            this.btnCalcAbs.Click += new System.EventHandler(this.btnCalcAbs_Click);
            // 
            // btnCalcFactorial
            // 
            this.btnCalcFactorial.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcFactorial.FlatAppearance.BorderSize = 0;
            this.btnCalcFactorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcFactorial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcFactorial.ForeColor = System.Drawing.Color.White;
            this.btnCalcFactorial.Location = new System.Drawing.Point(412, 409);
            this.btnCalcFactorial.Name = "btnCalcFactorial";
            this.btnCalcFactorial.Size = new System.Drawing.Size(60, 40);
            this.btnCalcFactorial.TabIndex = 40;
            this.btnCalcFactorial.Text = "n!";
            this.btnCalcFactorial.UseVisualStyleBackColor = false;
            this.btnCalcFactorial.Click += new System.EventHandler(this.btnCalcFactorial_Click);
            // 
            // btnCalcPi
            // 
            this.btnCalcPi.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcPi.FlatAppearance.BorderSize = 0;
            this.btnCalcPi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcPi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcPi.ForeColor = System.Drawing.Color.White;
            this.btnCalcPi.Location = new System.Drawing.Point(346, 360);
            this.btnCalcPi.Name = "btnCalcPi";
            this.btnCalcPi.Size = new System.Drawing.Size(60, 40);
            this.btnCalcPi.TabIndex = 39;
            this.btnCalcPi.Text = "π";
            this.btnCalcPi.UseVisualStyleBackColor = false;
            this.btnCalcPi.Click += new System.EventHandler(this.btnCalcPi_Click);
            // 
            // btnCalcEuler
            // 
            this.btnCalcEuler.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcEuler.FlatAppearance.BorderSize = 0;
            this.btnCalcEuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcEuler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcEuler.ForeColor = System.Drawing.Color.White;
            this.btnCalcEuler.Location = new System.Drawing.Point(346, 314);
            this.btnCalcEuler.Name = "btnCalcEuler";
            this.btnCalcEuler.Size = new System.Drawing.Size(60, 40);
            this.btnCalcEuler.TabIndex = 38;
            this.btnCalcEuler.Text = "e";
            this.btnCalcEuler.UseVisualStyleBackColor = false;
            this.btnCalcEuler.Click += new System.EventHandler(this.btnCalcEuler_Click);
            // 
            // btnCalcParenthesisClose
            // 
            this.btnCalcParenthesisClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCalcParenthesisClose.FlatAppearance.BorderSize = 0;
            this.btnCalcParenthesisClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcParenthesisClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcParenthesisClose.ForeColor = System.Drawing.Color.White;
            this.btnCalcParenthesisClose.Location = new System.Drawing.Point(208, 222);
            this.btnCalcParenthesisClose.Name = "btnCalcParenthesisClose";
            this.btnCalcParenthesisClose.Size = new System.Drawing.Size(60, 40);
            this.btnCalcParenthesisClose.TabIndex = 37;
            this.btnCalcParenthesisClose.Text = ")";
            this.btnCalcParenthesisClose.UseVisualStyleBackColor = false;
            this.btnCalcParenthesisClose.Click += new System.EventHandler(this.btnCalcParenthesisClose_Click);
            // 
            // btnCalcParenthesisOpen
            // 
            this.btnCalcParenthesisOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCalcParenthesisOpen.FlatAppearance.BorderSize = 0;
            this.btnCalcParenthesisOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcParenthesisOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcParenthesisOpen.ForeColor = System.Drawing.Color.White;
            this.btnCalcParenthesisOpen.Location = new System.Drawing.Point(142, 222);
            this.btnCalcParenthesisOpen.Name = "btnCalcParenthesisOpen";
            this.btnCalcParenthesisOpen.Size = new System.Drawing.Size(60, 40);
            this.btnCalcParenthesisOpen.TabIndex = 36;
            this.btnCalcParenthesisOpen.Text = "(";
            this.btnCalcParenthesisOpen.UseVisualStyleBackColor = false;
            this.btnCalcParenthesisOpen.Click += new System.EventHandler(this.btnCalcParenthesisOpen_Click);
            // 
            // btnCalcPercentage
            // 
            this.btnCalcPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCalcPercentage.FlatAppearance.BorderSize = 0;
            this.btnCalcPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcPercentage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcPercentage.ForeColor = System.Drawing.Color.White;
            this.btnCalcPercentage.Location = new System.Drawing.Point(76, 222);
            this.btnCalcPercentage.Name = "btnCalcPercentage";
            this.btnCalcPercentage.Size = new System.Drawing.Size(60, 40);
            this.btnCalcPercentage.TabIndex = 35;
            this.btnCalcPercentage.Text = "%";
            this.btnCalcPercentage.UseVisualStyleBackColor = false;
            this.btnCalcPercentage.Click += new System.EventHandler(this.btnCalcPercentage_Click);
            // 
            // btnCalcDel
            // 
            this.btnCalcDel.BackColor = System.Drawing.Color.Red;
            this.btnCalcDel.FlatAppearance.BorderSize = 0;
            this.btnCalcDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcDel.ForeColor = System.Drawing.Color.White;
            this.btnCalcDel.Location = new System.Drawing.Point(346, 176);
            this.btnCalcDel.Name = "btnCalcDel";
            this.btnCalcDel.Size = new System.Drawing.Size(60, 40);
            this.btnCalcDel.TabIndex = 34;
            this.btnCalcDel.Text = "del";
            this.btnCalcDel.UseVisualStyleBackColor = false;
            this.btnCalcDel.Click += new System.EventHandler(this.btnCalcDel_Click);
            // 
            // btnCalcLn
            // 
            this.btnCalcLn.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcLn.FlatAppearance.BorderSize = 0;
            this.btnCalcLn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcLn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcLn.ForeColor = System.Drawing.Color.White;
            this.btnCalcLn.Location = new System.Drawing.Point(412, 360);
            this.btnCalcLn.Name = "btnCalcLn";
            this.btnCalcLn.Size = new System.Drawing.Size(60, 40);
            this.btnCalcLn.TabIndex = 32;
            this.btnCalcLn.Text = "Ln";
            this.btnCalcLn.UseVisualStyleBackColor = false;
            this.btnCalcLn.Click += new System.EventHandler(this.btnCalcLn_Click);
            // 
            // btnCalcMod
            // 
            this.btnCalcMod.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcMod.FlatAppearance.BorderSize = 0;
            this.btnCalcMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcMod.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcMod.ForeColor = System.Drawing.Color.White;
            this.btnCalcMod.Location = new System.Drawing.Point(412, 314);
            this.btnCalcMod.Name = "btnCalcMod";
            this.btnCalcMod.Size = new System.Drawing.Size(60, 40);
            this.btnCalcMod.TabIndex = 31;
            this.btnCalcMod.Text = "mod";
            this.btnCalcMod.UseVisualStyleBackColor = false;
            this.btnCalcMod.Click += new System.EventHandler(this.btnCalcMod_Click);
            // 
            // btnCalcCotan
            // 
            this.btnCalcCotan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcCotan.FlatAppearance.BorderSize = 0;
            this.btnCalcCotan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcCotan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcCotan.ForeColor = System.Drawing.Color.White;
            this.btnCalcCotan.Location = new System.Drawing.Point(412, 222);
            this.btnCalcCotan.Name = "btnCalcCotan";
            this.btnCalcCotan.Size = new System.Drawing.Size(60, 40);
            this.btnCalcCotan.TabIndex = 30;
            this.btnCalcCotan.Text = "cotan";
            this.btnCalcCotan.UseVisualStyleBackColor = false;
            this.btnCalcCotan.Click += new System.EventHandler(this.btnCalcATan_Click);
            // 
            // btnCalcCsc
            // 
            this.btnCalcCsc.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcCsc.FlatAppearance.BorderSize = 0;
            this.btnCalcCsc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcCsc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcCsc.ForeColor = System.Drawing.Color.White;
            this.btnCalcCsc.Location = new System.Drawing.Point(346, 222);
            this.btnCalcCsc.Name = "btnCalcCsc";
            this.btnCalcCsc.Size = new System.Drawing.Size(60, 40);
            this.btnCalcCsc.TabIndex = 29;
            this.btnCalcCsc.Text = "csc";
            this.btnCalcCsc.UseVisualStyleBackColor = false;
            this.btnCalcCsc.Click += new System.EventHandler(this.btnCalcCsc_Click);
            // 
            // btnCalcSec
            // 
            this.btnCalcSec.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcSec.FlatAppearance.BorderSize = 0;
            this.btnCalcSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcSec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcSec.ForeColor = System.Drawing.Color.White;
            this.btnCalcSec.Location = new System.Drawing.Point(280, 176);
            this.btnCalcSec.Name = "btnCalcSec";
            this.btnCalcSec.Size = new System.Drawing.Size(60, 40);
            this.btnCalcSec.TabIndex = 28;
            this.btnCalcSec.Text = "sec";
            this.btnCalcSec.UseVisualStyleBackColor = false;
            this.btnCalcSec.Click += new System.EventHandler(this.btnCalcSec_Click);
            // 
            // btnCalcExp
            // 
            this.btnCalcExp.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcExp.FlatAppearance.BorderSize = 0;
            this.btnCalcExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcExp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcExp.ForeColor = System.Drawing.Color.White;
            this.btnCalcExp.Location = new System.Drawing.Point(346, 268);
            this.btnCalcExp.Name = "btnCalcExp";
            this.btnCalcExp.Size = new System.Drawing.Size(60, 40);
            this.btnCalcExp.TabIndex = 27;
            this.btnCalcExp.Text = "exp";
            this.btnCalcExp.UseVisualStyleBackColor = false;
            this.btnCalcExp.Click += new System.EventHandler(this.btnCalcExp_Click);
            // 
            // btnCalcLog
            // 
            this.btnCalcLog.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcLog.FlatAppearance.BorderSize = 0;
            this.btnCalcLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcLog.ForeColor = System.Drawing.Color.White;
            this.btnCalcLog.Location = new System.Drawing.Point(412, 268);
            this.btnCalcLog.Name = "btnCalcLog";
            this.btnCalcLog.Size = new System.Drawing.Size(60, 40);
            this.btnCalcLog.TabIndex = 26;
            this.btnCalcLog.Text = "log";
            this.btnCalcLog.UseVisualStyleBackColor = false;
            this.btnCalcLog.Click += new System.EventHandler(this.btnCalcLog_Click);
            // 
            // btnCalcTan
            // 
            this.btnCalcTan.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcTan.FlatAppearance.BorderSize = 0;
            this.btnCalcTan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcTan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcTan.ForeColor = System.Drawing.Color.White;
            this.btnCalcTan.Location = new System.Drawing.Point(208, 176);
            this.btnCalcTan.Name = "btnCalcTan";
            this.btnCalcTan.Size = new System.Drawing.Size(60, 40);
            this.btnCalcTan.TabIndex = 25;
            this.btnCalcTan.Text = "tan";
            this.btnCalcTan.UseVisualStyleBackColor = false;
            this.btnCalcTan.Click += new System.EventHandler(this.btnCalcTan_Click);
            // 
            // btnCalcCos
            // 
            this.btnCalcCos.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcCos.FlatAppearance.BorderSize = 0;
            this.btnCalcCos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcCos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcCos.ForeColor = System.Drawing.Color.White;
            this.btnCalcCos.Location = new System.Drawing.Point(142, 176);
            this.btnCalcCos.Name = "btnCalcCos";
            this.btnCalcCos.Size = new System.Drawing.Size(60, 40);
            this.btnCalcCos.TabIndex = 24;
            this.btnCalcCos.Text = "cos";
            this.btnCalcCos.UseVisualStyleBackColor = false;
            this.btnCalcCos.Click += new System.EventHandler(this.btnCalcCos_Click);
            // 
            // btnCalcSin
            // 
            this.btnCalcSin.BackColor = System.Drawing.Color.DarkCyan;
            this.btnCalcSin.FlatAppearance.BorderSize = 0;
            this.btnCalcSin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcSin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcSin.ForeColor = System.Drawing.Color.White;
            this.btnCalcSin.Location = new System.Drawing.Point(76, 176);
            this.btnCalcSin.Name = "btnCalcSin";
            this.btnCalcSin.Size = new System.Drawing.Size(60, 40);
            this.btnCalcSin.TabIndex = 23;
            this.btnCalcSin.Text = "sin";
            this.btnCalcSin.UseVisualStyleBackColor = false;
            this.btnCalcSin.Click += new System.EventHandler(this.btnCalcSin_Click);
            // 
            // textBoxCalculatorDisplay
            // 
            this.textBoxCalculatorDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxCalculatorDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCalculatorDisplay.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCalculatorDisplay.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBoxCalculatorDisplay.Location = new System.Drawing.Point(15, 24);
            this.textBoxCalculatorDisplay.Multiline = true;
            this.textBoxCalculatorDisplay.Name = "textBoxCalculatorDisplay";
            this.textBoxCalculatorDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCalculatorDisplay.Size = new System.Drawing.Size(517, 66);
            this.textBoxCalculatorDisplay.TabIndex = 22;
            this.textBoxCalculatorDisplay.Text = "0";
            this.textBoxCalculatorDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCalculatorDisplay.TextChanged += new System.EventHandler(this.textBoxCalculatorDisplay_TextChanged);
            // 
            // btnCalcClear
            // 
            this.btnCalcClear.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCalcClear.FlatAppearance.BorderSize = 0;
            this.btnCalcClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcClear.ForeColor = System.Drawing.Color.White;
            this.btnCalcClear.Location = new System.Drawing.Point(412, 176);
            this.btnCalcClear.Name = "btnCalcClear";
            this.btnCalcClear.Size = new System.Drawing.Size(60, 40);
            this.btnCalcClear.TabIndex = 21;
            this.btnCalcClear.Text = "C";
            this.btnCalcClear.UseVisualStyleBackColor = false;
            this.btnCalcClear.Click += new System.EventHandler(this.btnCalcClear_Click);
            // 
            // btnCalcEquals
            // 
            this.btnCalcEquals.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalcEquals.FlatAppearance.BorderSize = 0;
            this.btnCalcEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcEquals.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcEquals.ForeColor = System.Drawing.Color.White;
            this.btnCalcEquals.Location = new System.Drawing.Point(280, 409);
            this.btnCalcEquals.Name = "btnCalcEquals";
            this.btnCalcEquals.Size = new System.Drawing.Size(60, 40);
            this.btnCalcEquals.TabIndex = 20;
            this.btnCalcEquals.Text = "=";
            this.btnCalcEquals.UseVisualStyleBackColor = false;
            this.btnCalcEquals.Click += new System.EventHandler(this.btnCalcEquals_Click);
            // 
            // btnCalcDivide
            // 
            this.btnCalcDivide.BackColor = System.Drawing.Color.SlateGray;
            this.btnCalcDivide.FlatAppearance.BorderSize = 0;
            this.btnCalcDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcDivide.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcDivide.ForeColor = System.Drawing.Color.White;
            this.btnCalcDivide.Location = new System.Drawing.Point(280, 222);
            this.btnCalcDivide.Name = "btnCalcDivide";
            this.btnCalcDivide.Size = new System.Drawing.Size(60, 40);
            this.btnCalcDivide.TabIndex = 19;
            this.btnCalcDivide.Text = "/";
            this.btnCalcDivide.UseVisualStyleBackColor = false;
            this.btnCalcDivide.Click += new System.EventHandler(this.btnCalcDivide_Click);
            // 
            // btnCalcMultiply
            // 
            this.btnCalcMultiply.BackColor = System.Drawing.Color.SlateGray;
            this.btnCalcMultiply.FlatAppearance.BorderSize = 0;
            this.btnCalcMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcMultiply.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcMultiply.ForeColor = System.Drawing.Color.White;
            this.btnCalcMultiply.Location = new System.Drawing.Point(280, 268);
            this.btnCalcMultiply.Name = "btnCalcMultiply";
            this.btnCalcMultiply.Size = new System.Drawing.Size(60, 40);
            this.btnCalcMultiply.TabIndex = 18;
            this.btnCalcMultiply.Text = "*";
            this.btnCalcMultiply.UseVisualStyleBackColor = false;
            this.btnCalcMultiply.Click += new System.EventHandler(this.btnCalcMultiply_Click);
            // 
            // btnCalcSubtract
            // 
            this.btnCalcSubtract.BackColor = System.Drawing.Color.SlateGray;
            this.btnCalcSubtract.FlatAppearance.BorderSize = 0;
            this.btnCalcSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcSubtract.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcSubtract.ForeColor = System.Drawing.Color.White;
            this.btnCalcSubtract.Location = new System.Drawing.Point(280, 314);
            this.btnCalcSubtract.Name = "btnCalcSubtract";
            this.btnCalcSubtract.Size = new System.Drawing.Size(60, 40);
            this.btnCalcSubtract.TabIndex = 17;
            this.btnCalcSubtract.Text = "-";
            this.btnCalcSubtract.UseVisualStyleBackColor = false;
            this.btnCalcSubtract.Click += new System.EventHandler(this.btnCalcSubtract_Click);
            // 
            // btnCalcAdd
            // 
            this.btnCalcAdd.BackColor = System.Drawing.Color.SlateGray;
            this.btnCalcAdd.FlatAppearance.BorderSize = 0;
            this.btnCalcAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcAdd.ForeColor = System.Drawing.Color.White;
            this.btnCalcAdd.Location = new System.Drawing.Point(280, 360);
            this.btnCalcAdd.Name = "btnCalcAdd";
            this.btnCalcAdd.Size = new System.Drawing.Size(60, 40);
            this.btnCalcAdd.TabIndex = 16;
            this.btnCalcAdd.Text = "+";
            this.btnCalcAdd.UseVisualStyleBackColor = false;
            this.btnCalcAdd.Click += new System.EventHandler(this.btnCalcAdd_Click);
            // 
            // btnCalcDecimal
            // 
            this.btnCalcDecimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCalcDecimal.FlatAppearance.BorderSize = 0;
            this.btnCalcDecimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcDecimal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcDecimal.ForeColor = System.Drawing.Color.White;
            this.btnCalcDecimal.Location = new System.Drawing.Point(208, 409);
            this.btnCalcDecimal.Name = "btnCalcDecimal";
            this.btnCalcDecimal.Size = new System.Drawing.Size(60, 40);
            this.btnCalcDecimal.TabIndex = 15;
            this.btnCalcDecimal.Text = ".";
            this.btnCalcDecimal.UseVisualStyleBackColor = false;
            this.btnCalcDecimal.Click += new System.EventHandler(this.btnCalcDecimal_Click);
            // 
            // btnCalc0
            // 
            this.btnCalc0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCalc0.FlatAppearance.BorderSize = 0;
            this.btnCalc0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc0.ForeColor = System.Drawing.Color.White;
            this.btnCalc0.Location = new System.Drawing.Point(76, 409);
            this.btnCalc0.Name = "btnCalc0";
            this.btnCalc0.Size = new System.Drawing.Size(126, 40);
            this.btnCalc0.TabIndex = 14;
            this.btnCalc0.Text = "0";
            this.btnCalc0.UseVisualStyleBackColor = false;
            this.btnCalc0.Click += new System.EventHandler(this.btnCalc0_Click);
            // 
            // btnCalc9
            // 
            this.btnCalc9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCalc9.FlatAppearance.BorderSize = 0;
            this.btnCalc9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc9.ForeColor = System.Drawing.Color.White;
            this.btnCalc9.Location = new System.Drawing.Point(208, 268);
            this.btnCalc9.Name = "btnCalc9";
            this.btnCalc9.Size = new System.Drawing.Size(60, 40);
            this.btnCalc9.TabIndex = 13;
            this.btnCalc9.Text = "9";
            this.btnCalc9.UseVisualStyleBackColor = false;
            this.btnCalc9.Click += new System.EventHandler(this.btnCalc9_Click);
            // 
            // btnCalc8
            // 
            this.btnCalc8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCalc8.FlatAppearance.BorderSize = 0;
            this.btnCalc8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc8.ForeColor = System.Drawing.Color.White;
            this.btnCalc8.Location = new System.Drawing.Point(142, 268);
            this.btnCalc8.Name = "btnCalc8";
            this.btnCalc8.Size = new System.Drawing.Size(60, 40);
            this.btnCalc8.TabIndex = 12;
            this.btnCalc8.Text = "8";
            this.btnCalc8.UseVisualStyleBackColor = false;
            this.btnCalc8.Click += new System.EventHandler(this.btnCalc8_Click);
            // 
            // btnCalc7
            // 
            this.btnCalc7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCalc7.FlatAppearance.BorderSize = 0;
            this.btnCalc7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc7.ForeColor = System.Drawing.Color.White;
            this.btnCalc7.Location = new System.Drawing.Point(76, 268);
            this.btnCalc7.Name = "btnCalc7";
            this.btnCalc7.Size = new System.Drawing.Size(60, 40);
            this.btnCalc7.TabIndex = 11;
            this.btnCalc7.Text = "7";
            this.btnCalc7.UseVisualStyleBackColor = false;
            this.btnCalc7.Click += new System.EventHandler(this.btnCalc7_Click);
            // 
            // btnCalc6
            // 
            this.btnCalc6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCalc6.FlatAppearance.BorderSize = 0;
            this.btnCalc6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc6.ForeColor = System.Drawing.Color.White;
            this.btnCalc6.Location = new System.Drawing.Point(208, 314);
            this.btnCalc6.Name = "btnCalc6";
            this.btnCalc6.Size = new System.Drawing.Size(60, 40);
            this.btnCalc6.TabIndex = 10;
            this.btnCalc6.Text = "6";
            this.btnCalc6.UseVisualStyleBackColor = false;
            this.btnCalc6.Click += new System.EventHandler(this.btnCalc6_Click);
            // 
            // btnCalc5
            // 
            this.btnCalc5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCalc5.FlatAppearance.BorderSize = 0;
            this.btnCalc5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc5.ForeColor = System.Drawing.Color.White;
            this.btnCalc5.Location = new System.Drawing.Point(142, 314);
            this.btnCalc5.Name = "btnCalc5";
            this.btnCalc5.Size = new System.Drawing.Size(60, 40);
            this.btnCalc5.TabIndex = 9;
            this.btnCalc5.Text = "5";
            this.btnCalc5.UseVisualStyleBackColor = false;
            this.btnCalc5.Click += new System.EventHandler(this.btnCalc5_Click);
            // 
            // btnCalc4
            // 
            this.btnCalc4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCalc4.FlatAppearance.BorderSize = 0;
            this.btnCalc4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc4.ForeColor = System.Drawing.Color.White;
            this.btnCalc4.Location = new System.Drawing.Point(76, 314);
            this.btnCalc4.Name = "btnCalc4";
            this.btnCalc4.Size = new System.Drawing.Size(60, 40);
            this.btnCalc4.TabIndex = 8;
            this.btnCalc4.Text = "4";
            this.btnCalc4.UseVisualStyleBackColor = false;
            this.btnCalc4.Click += new System.EventHandler(this.btnCalc4_Click);
            // 
            // btnCalc3
            // 
            this.btnCalc3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCalc3.FlatAppearance.BorderSize = 0;
            this.btnCalc3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc3.ForeColor = System.Drawing.Color.White;
            this.btnCalc3.Location = new System.Drawing.Point(208, 360);
            this.btnCalc3.Name = "btnCalc3";
            this.btnCalc3.Size = new System.Drawing.Size(60, 40);
            this.btnCalc3.TabIndex = 7;
            this.btnCalc3.Text = "3";
            this.btnCalc3.UseVisualStyleBackColor = false;
            this.btnCalc3.Click += new System.EventHandler(this.btnCalc3_Click);
            // 
            // btnCalc2
            // 
            this.btnCalc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCalc2.FlatAppearance.BorderSize = 0;
            this.btnCalc2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc2.ForeColor = System.Drawing.Color.White;
            this.btnCalc2.Location = new System.Drawing.Point(142, 360);
            this.btnCalc2.Name = "btnCalc2";
            this.btnCalc2.Size = new System.Drawing.Size(60, 40);
            this.btnCalc2.TabIndex = 6;
            this.btnCalc2.Text = "2";
            this.btnCalc2.UseVisualStyleBackColor = false;
            this.btnCalc2.Click += new System.EventHandler(this.btnCalc2_Click);
            // 
            // btnCalc1
            // 
            this.btnCalc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnCalc1.FlatAppearance.BorderSize = 0;
            this.btnCalc1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc1.ForeColor = System.Drawing.Color.White;
            this.btnCalc1.Location = new System.Drawing.Point(76, 360);
            this.btnCalc1.Name = "btnCalc1";
            this.btnCalc1.Size = new System.Drawing.Size(60, 40);
            this.btnCalc1.TabIndex = 5;
            this.btnCalc1.Text = "1";
            this.btnCalc1.UseVisualStyleBackColor = false;
            this.btnCalc1.Click += new System.EventHandler(this.btnCalc1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lexemaDataGridViewTextBoxColumn,
            this.tokenDataGridViewTextBoxColumn,
            this.lineaDataGridViewTextBoxColumn,
            this.columnaDataGridViewTextBoxColumn});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView1.DataSource = this.simboloBindingSource1;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(608, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(584, 570);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // lexemaDataGridViewTextBoxColumn
            // 
            this.lexemaDataGridViewTextBoxColumn.DataPropertyName = "Lexema";
            this.lexemaDataGridViewTextBoxColumn.HeaderText = "Lexema";
            this.lexemaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lexemaDataGridViewTextBoxColumn.Name = "lexemaDataGridViewTextBoxColumn";
            this.lexemaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tokenDataGridViewTextBoxColumn
            // 
            this.tokenDataGridViewTextBoxColumn.DataPropertyName = "Token";
            this.tokenDataGridViewTextBoxColumn.HeaderText = "Token";
            this.tokenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tokenDataGridViewTextBoxColumn.Name = "tokenDataGridViewTextBoxColumn";
            this.tokenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lineaDataGridViewTextBoxColumn
            // 
            this.lineaDataGridViewTextBoxColumn.DataPropertyName = "Linea";
            this.lineaDataGridViewTextBoxColumn.HeaderText = "Linea";
            this.lineaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lineaDataGridViewTextBoxColumn.Name = "lineaDataGridViewTextBoxColumn";
            this.lineaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // columnaDataGridViewTextBoxColumn
            // 
            this.columnaDataGridViewTextBoxColumn.DataPropertyName = "Columna";
            this.columnaDataGridViewTextBoxColumn.HeaderText = "Columna";
            this.columnaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.columnaDataGridViewTextBoxColumn.Name = "columnaDataGridViewTextBoxColumn";
            this.columnaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // simboloBindingSource1
            // 
            this.simboloBindingSource1.DataSource = typeof(MyCompiler.Simbolo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1219, 797);
            this.Controls.Add(this.panelCalculator);
            this.Controls.Add(this.btnSintactico);
            this.Controls.Add(this.listErrors);
            this.Controls.Add(this.btnCodigo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLexico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Compiler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCalculator.ResumeLayout(false);
            this.panelCalculator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simboloBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSintactico;
        private System.Windows.Forms.ListBox listErrors;
        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.Button btnLexico;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource simboloBindingSource1;
        private System.Windows.Forms.Panel panelCalculator;
        private System.Windows.Forms.Button btnCalcClear;
        private System.Windows.Forms.Button btnCalcEquals;
        private System.Windows.Forms.Button btnCalcDivide;
        private System.Windows.Forms.Button btnCalcMultiply;
        private System.Windows.Forms.Button btnCalcSubtract;
        private System.Windows.Forms.Button btnCalcAdd;
        private System.Windows.Forms.Button btnCalcDecimal;
        private System.Windows.Forms.Button btnCalc0;
        private System.Windows.Forms.Button btnCalc9;
        private System.Windows.Forms.Button btnCalc8;
        private System.Windows.Forms.Button btnCalc7;
        private System.Windows.Forms.Button btnCalc6;
        private System.Windows.Forms.Button btnCalc5;
        private System.Windows.Forms.Button btnCalc4;
        private System.Windows.Forms.Button btnCalc3;
        private System.Windows.Forms.Button btnCalc2;
        private System.Windows.Forms.Button btnCalc1;
        private System.Windows.Forms.TextBox textBoxCalculatorDisplay;
        private System.Windows.Forms.Button btnCalcExp;
        private System.Windows.Forms.Button btnCalcLog;
        private System.Windows.Forms.Button btnCalcTan;
        private System.Windows.Forms.Button btnCalcCos;
        private System.Windows.Forms.Button btnCalcSin;
        private System.Windows.Forms.Button btnCalcLn;
        private System.Windows.Forms.Button btnCalcMod;
        private System.Windows.Forms.Button btnCalcCotan;
        private System.Windows.Forms.Button btnCalcCsc;
        private System.Windows.Forms.Button btnCalcSec;
        private System.Windows.Forms.Button btnCalcEuler;
        private System.Windows.Forms.Button btnCalcPi;
        private System.Windows.Forms.Button btnCalcAbs;
        private System.Windows.Forms.Button btnCalcDel;
        private System.Windows.Forms.Button btnCalcPercentage;
        private System.Windows.Forms.Button btnCalcParenthesisOpen;
        private System.Windows.Forms.Button btnCalcParenthesisClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lexemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCalcFactorial;
        private System.Windows.Forms.Label lblResultado;
    }
}