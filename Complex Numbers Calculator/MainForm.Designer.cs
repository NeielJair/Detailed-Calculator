namespace Complex_Numbers_Calculator
{
    partial class MainForm
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
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.RootMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RootMenuStrip_y = new System.Windows.Forms.ToolStripMenuItem();
            this.RootMenuStrip_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.RootMenuStrip_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExp = new System.Windows.Forms.Button();
            this.ExpMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExpMenuStrip_y = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpMenuStrip_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExpMenuStrip_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnFact = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnLog10 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btn10exp = new System.Windows.Forms.Button();
            this.btnOpenPar = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnClosePar = new System.Windows.Forms.Button();
            this.btnUnfold = new System.Windows.Forms.Button();
            this.ResultBox = new System.Windows.Forms.Label();
            this.btnAns = new System.Windows.Forms.Button();
            this.AnsMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClear = new System.Windows.Forms.Button();
            this.ResultLog = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnVar = new System.Windows.Forms.Button();
            this.labelAns = new System.Windows.Forms.Label();
            this.RootMenuStrip.SuspendLayout();
            this.ExpMenuStrip.SuspendLayout();
            this.AnsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberBox
            // 
            this.NumberBox.Font = new System.Drawing.Font("Cambria Math", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.NumberBox.Location = new System.Drawing.Point(16, 54);
            this.NumberBox.Multiline = true;
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NumberBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NumberBox.Size = new System.Drawing.Size(344, 48);
            this.NumberBox.TabIndex = 0;
            this.NumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumberBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumberBox_KeyDown);
            // 
            // btnErase
            // 
            this.btnErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErase.Location = new System.Drawing.Point(296, 108);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(64, 48);
            this.btnErase.TabIndex = 3;
            this.btnErase.Text = "⌫";
            this.ToolTip.SetToolTip(this.btnErase, "Delete");
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRoot.ContextMenuStrip = this.RootMenuStrip;
            this.btnRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoot.Location = new System.Drawing.Point(86, 108);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(64, 48);
            this.btnRoot.TabIndex = 4;
            this.btnRoot.Text = "ʸ√x";
            this.btnRoot.UseVisualStyleBackColor = false;
            this.btnRoot.Click += new System.EventHandler(this.btnRoot_Click);
            // 
            // RootMenuStrip
            // 
            this.RootMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RootMenuStrip_y,
            this.RootMenuStrip_2,
            this.RootMenuStrip_3});
            this.RootMenuStrip.Name = "RootMenuStrip";
            this.RootMenuStrip.Size = new System.Drawing.Size(92, 70);
            this.RootMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.RootMenuStrip_ItemClicked);
            // 
            // RootMenuStrip_y
            // 
            this.RootMenuStrip_y.Name = "RootMenuStrip_y";
            this.RootMenuStrip_y.Size = new System.Drawing.Size(91, 22);
            this.RootMenuStrip_y.Text = "ʸ√x";
            // 
            // RootMenuStrip_2
            // 
            this.RootMenuStrip_2.Name = "RootMenuStrip_2";
            this.RootMenuStrip_2.Size = new System.Drawing.Size(91, 22);
            this.RootMenuStrip_2.Text = "√x";
            // 
            // RootMenuStrip_3
            // 
            this.RootMenuStrip_3.Name = "RootMenuStrip_3";
            this.RootMenuStrip_3.Size = new System.Drawing.Size(91, 22);
            this.RootMenuStrip_3.Text = "³√x";
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExp.ContextMenuStrip = this.ExpMenuStrip;
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExp.Location = new System.Drawing.Point(16, 108);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(64, 48);
            this.btnExp.TabIndex = 5;
            this.btnExp.Text = "xʸ";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // ExpMenuStrip
            // 
            this.ExpMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExpMenuStrip_y,
            this.ExpMenuStrip_2,
            this.ExpMenuStrip_3,
            this.xToolStripMenuItem,
            this.xToolStripMenuItem1,
            this.xToolStripMenuItem2});
            this.ExpMenuStrip.Name = "contextMenuStrip1";
            this.ExpMenuStrip.Size = new System.Drawing.Size(88, 136);
            this.ExpMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ExpMenuStrip_ItemClicked);
            // 
            // ExpMenuStrip_y
            // 
            this.ExpMenuStrip_y.Name = "ExpMenuStrip_y";
            this.ExpMenuStrip_y.Size = new System.Drawing.Size(87, 22);
            this.ExpMenuStrip_y.Text = "xʸ";
            // 
            // ExpMenuStrip_2
            // 
            this.ExpMenuStrip_2.Name = "ExpMenuStrip_2";
            this.ExpMenuStrip_2.Size = new System.Drawing.Size(87, 22);
            this.ExpMenuStrip_2.Text = "x²";
            // 
            // ExpMenuStrip_3
            // 
            this.ExpMenuStrip_3.Name = "ExpMenuStrip_3";
            this.ExpMenuStrip_3.Size = new System.Drawing.Size(87, 22);
            this.ExpMenuStrip_3.Text = "x³";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.xToolStripMenuItem.Text = "x⁻¹";
            // 
            // xToolStripMenuItem1
            // 
            this.xToolStripMenuItem1.Name = "xToolStripMenuItem1";
            this.xToolStripMenuItem1.Size = new System.Drawing.Size(87, 22);
            this.xToolStripMenuItem1.Text = "x⁻²";
            // 
            // xToolStripMenuItem2
            // 
            this.xToolStripMenuItem2.Name = "xToolStripMenuItem2";
            this.xToolStripMenuItem2.Size = new System.Drawing.Size(87, 22);
            this.xToolStripMenuItem2.Text = "x⁻³";
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(156, 162);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(64, 48);
            this.btnLog.TabIndex = 10;
            this.btnLog.Text = "logₓ";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnFact
            // 
            this.btnFact.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFact.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFact.Location = new System.Drawing.Point(226, 162);
            this.btnFact.Name = "btnFact";
            this.btnFact.Size = new System.Drawing.Size(64, 48);
            this.btnFact.TabIndex = 9;
            this.btnFact.Text = "n!";
            this.btnFact.UseVisualStyleBackColor = false;
            this.btnFact.Click += new System.EventHandler(this.btnFact_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(296, 162);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(64, 48);
            this.btnDiv.TabIndex = 8;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.InputContent);
            // 
            // btnLn
            // 
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLn.Location = new System.Drawing.Point(86, 162);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(64, 48);
            this.btnLn.TabIndex = 7;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = true;
            this.btnLn.Click += new System.EventHandler(this.InputFunction);
            // 
            // btnLog10
            // 
            this.btnLog10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog10.Location = new System.Drawing.Point(16, 162);
            this.btnLog10.Name = "btnLog10";
            this.btnLog10.Size = new System.Drawing.Size(64, 48);
            this.btnLog10.TabIndex = 6;
            this.btnLog10.Text = "log";
            this.btnLog10.UseVisualStyleBackColor = true;
            this.btnLog10.Click += new System.EventHandler(this.InputFunction);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(226, 216);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(64, 48);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.InputContent);
            // 
            // btnMult
            // 
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(296, 216);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(64, 48);
            this.btnMult.TabIndex = 13;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.InputContent);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(86, 216);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(64, 48);
            this.btn7.TabIndex = 12;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.InputContent);
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.Location = new System.Drawing.Point(16, 216);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(64, 48);
            this.btnPi.TabIndex = 11;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.InputMultContent);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(156, 270);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(64, 48);
            this.btn5.TabIndex = 20;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.InputContent);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(226, 270);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(64, 48);
            this.btn6.TabIndex = 19;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.InputContent);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(296, 270);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(64, 48);
            this.btnSubtract.TabIndex = 18;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.InputContent);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(86, 270);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(64, 48);
            this.btn4.TabIndex = 17;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.InputContent);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(16, 270);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(64, 48);
            this.btnE.TabIndex = 16;
            this.btnE.Text = "e";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.InputMultContent);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(156, 324);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(64, 48);
            this.btn2.TabIndex = 25;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.InputContent);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(226, 324);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(64, 48);
            this.btn3.TabIndex = 24;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.InputContent);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(296, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(64, 48);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.InputContent);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(86, 324);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(64, 48);
            this.btn1.TabIndex = 22;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.InputContent);
            // 
            // btnImg
            // 
            this.btnImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.Location = new System.Drawing.Point(16, 324);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(64, 48);
            this.btnImg.TabIndex = 21;
            this.btnImg.Text = "i";
            this.btnImg.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(156, 378);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(64, 48);
            this.btn0.TabIndex = 30;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.InputContent);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(226, 378);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(64, 48);
            this.btnDecimal.TabIndex = 29;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.InputContent);
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(296, 378);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(64, 48);
            this.btnEqual.TabIndex = 28;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btn10exp
            // 
            this.btn10exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10exp.Location = new System.Drawing.Point(86, 378);
            this.btn10exp.Name = "btn10exp";
            this.btn10exp.Size = new System.Drawing.Size(64, 48);
            this.btn10exp.TabIndex = 27;
            this.btn10exp.Text = "10ˣ";
            this.btn10exp.UseVisualStyleBackColor = true;
            this.btn10exp.Click += new System.EventHandler(this.btn10exp_Click);
            // 
            // btnOpenPar
            // 
            this.btnOpenPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPar.Location = new System.Drawing.Point(16, 378);
            this.btnOpenPar.Name = "btnOpenPar";
            this.btnOpenPar.Size = new System.Drawing.Size(32, 48);
            this.btnOpenPar.TabIndex = 26;
            this.btnOpenPar.Text = "(";
            this.btnOpenPar.UseVisualStyleBackColor = true;
            this.btnOpenPar.Click += new System.EventHandler(this.InputMultContent);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(156, 216);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(64, 48);
            this.btn8.TabIndex = 31;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.InputContent);
            // 
            // btnClosePar
            // 
            this.btnClosePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePar.Location = new System.Drawing.Point(48, 378);
            this.btnClosePar.Name = "btnClosePar";
            this.btnClosePar.Size = new System.Drawing.Size(32, 48);
            this.btnClosePar.TabIndex = 33;
            this.btnClosePar.Text = ")";
            this.btnClosePar.UseVisualStyleBackColor = true;
            this.btnClosePar.Click += new System.EventHandler(this.InputContent);
            // 
            // btnUnfold
            // 
            this.btnUnfold.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnfold.Location = new System.Drawing.Point(296, 16);
            this.btnUnfold.Name = "btnUnfold";
            this.btnUnfold.Size = new System.Drawing.Size(64, 32);
            this.btnUnfold.TabIndex = 34;
            this.btnUnfold.Text = ">>";
            this.ToolTip.SetToolTip(this.btnUnfold, "Open Result Log");
            this.btnUnfold.UseVisualStyleBackColor = true;
            this.btnUnfold.Click += new System.EventHandler(this.btnUnfold_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ResultBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.Location = new System.Drawing.Point(86, 16);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultBox.Size = new System.Drawing.Size(204, 32);
            this.ResultBox.TabIndex = 35;
            this.ResultBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnAns
            // 
            this.btnAns.ContextMenuStrip = this.AnsMenuStrip;
            this.btnAns.Enabled = false;
            this.btnAns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns.Location = new System.Drawing.Point(16, 16);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(64, 32);
            this.btnAns.TabIndex = 36;
            this.btnAns.Text = "Ans";
            this.ToolTip.SetToolTip(this.btnAns, "Previous Result");
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.InputMultContent);
            this.btnAns.Paint += new System.Windows.Forms.PaintEventHandler(this.btnAns_Paint);
            // 
            // AnsMenuStrip
            // 
            this.AnsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem});
            this.AnsMenuStrip.Name = "AnsMenuStrip";
            this.AnsMenuStrip.Size = new System.Drawing.Size(102, 26);
            this.AnsMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.AnsMenuStrip_ItemClicked);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(226, 108);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 48);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "C";
            this.ToolTip.SetToolTip(this.btnClear, "Clear");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // ResultLog
            // 
            this.ResultLog.Font = new System.Drawing.Font("Cambria Math", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.ResultLog.Location = new System.Drawing.Point(366, 16);
            this.ResultLog.Multiline = true;
            this.ResultLog.Name = "ResultLog";
            this.ResultLog.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ResultLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultLog.Size = new System.Drawing.Size(390, 411);
            this.ResultLog.TabIndex = 38;
            this.ResultLog.WordWrap = false;
            // 
            // btnVar
            // 
            this.btnVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVar.Location = new System.Drawing.Point(156, 108);
            this.btnVar.Name = "btnVar";
            this.btnVar.Size = new System.Drawing.Size(64, 48);
            this.btnVar.TabIndex = 40;
            this.btnVar.Text = "var";
            this.ToolTip.SetToolTip(this.btnVar, "Delete");
            this.btnVar.UseVisualStyleBackColor = true;
            this.btnVar.Click += new System.EventHandler(this.btnVar_Click);
            // 
            // labelAns
            // 
            this.labelAns.AutoSize = true;
            this.labelAns.BackColor = System.Drawing.Color.Transparent;
            this.labelAns.Location = new System.Drawing.Point(14, 3);
            this.labelAns.Name = "labelAns";
            this.labelAns.Size = new System.Drawing.Size(28, 13);
            this.labelAns.TabIndex = 39;
            this.labelAns.Text = "Ans:";
            this.labelAns.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 439);
            this.Controls.Add(this.btnVar);
            this.Controls.Add(this.labelAns);
            this.Controls.Add(this.ResultLog);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAns);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.btnUnfold);
            this.Controls.Add(this.btnClosePar);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btn10exp);
            this.Controls.Add(this.btnOpenPar);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnE);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnFact);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnLn);
            this.Controls.Add(this.btnLog10);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.NumberBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.RootMenuStrip.ResumeLayout(false);
            this.ExpMenuStrip.ResumeLayout(false);
            this.AnsMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnFact;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnLog10;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btn10exp;
        private System.Windows.Forms.Button btnOpenPar;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnClosePar;
        private System.Windows.Forms.Button btnUnfold;
        private System.Windows.Forms.Label ResultBox;
        private System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox ResultLog;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.ContextMenuStrip AnsMenuStrip;
        private System.Windows.Forms.Label labelAns;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ExpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ExpMenuStrip_2;
        private System.Windows.Forms.ToolStripMenuItem ExpMenuStrip_y;
        private System.Windows.Forms.ToolStripMenuItem ExpMenuStrip_3;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip RootMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RootMenuStrip_y;
        private System.Windows.Forms.ToolStripMenuItem RootMenuStrip_2;
        private System.Windows.Forms.ToolStripMenuItem RootMenuStrip_3;
        private System.Windows.Forms.Button btnVar;
    }
}

