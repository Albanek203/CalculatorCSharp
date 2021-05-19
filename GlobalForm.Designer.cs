
namespace Calculator {
    partial class GlobalForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalForm));
            this.pnLeft = new System.Windows.Forms.Panel();
            this.tbLayPnAddition = new System.Windows.Forms.TableLayoutPanel();
            this.butConverter = new System.Windows.Forms.Button();
            this.butBinaryCalculator = new System.Windows.Forms.Button();
            this.butBinaryOperation = new System.Windows.Forms.Button();
            this.pnCenter = new System.Windows.Forms.Panel();
            this.movePanel = new System.Windows.Forms.Panel();
            this.butClose = new System.Windows.Forms.PictureBox();
            this.txtResultBefore = new System.Windows.Forms.TextBox();
            this.txtRecent = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.butAllClear = new System.Windows.Forms.Button();
            this.butChangeMark = new System.Windows.Forms.Button();
            this.butInterest = new System.Windows.Forms.Button();
            this.butDivision = new System.Windows.Forms.Button();
            this.butMultiplication = new System.Windows.Forms.Button();
            this.butMinus = new System.Windows.Forms.Button();
            this.butPlus = new System.Windows.Forms.Button();
            this.butEqual = new System.Windows.Forms.Button();
            this.butDot = new System.Windows.Forms.Button();
            this.butNumber0 = new System.Windows.Forms.Button();
            this.butNumber2 = new System.Windows.Forms.Button();
            this.butNumber6 = new System.Windows.Forms.Button();
            this.butNumber3 = new System.Windows.Forms.Button();
            this.butNumber1 = new System.Windows.Forms.Button();
            this.butNumber5 = new System.Windows.Forms.Button();
            this.butNumber7 = new System.Windows.Forms.Button();
            this.butNumber8 = new System.Windows.Forms.Button();
            this.butNumber9 = new System.Windows.Forms.Button();
            this.butNumber4 = new System.Windows.Forms.Button();
            this.pnRight = new System.Windows.Forms.Panel();
            this.pnLeft.SuspendLayout();
            this.tbLayPnAddition.SuspendLayout();
            this.pnCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.butClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.pnLeft.Controls.Add(this.tbLayPnAddition);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 0);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(170, 450);
            this.pnLeft.TabIndex = 16;
            // 
            // tbLayPnAddition
            // 
            this.tbLayPnAddition.ColumnCount = 1;
            this.tbLayPnAddition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLayPnAddition.Controls.Add(this.butConverter, 0, 0);
            this.tbLayPnAddition.Controls.Add(this.butBinaryCalculator, 0, 1);
            this.tbLayPnAddition.Controls.Add(this.butBinaryOperation, 0, 2);
            this.tbLayPnAddition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbLayPnAddition.Location = new System.Drawing.Point(0, 147);
            this.tbLayPnAddition.Name = "tbLayPnAddition";
            this.tbLayPnAddition.RowCount = 4;
            this.tbLayPnAddition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.13131F));
            this.tbLayPnAddition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.13131F));
            this.tbLayPnAddition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.13131F));
            this.tbLayPnAddition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.60606F));
            this.tbLayPnAddition.Size = new System.Drawing.Size(170, 303);
            this.tbLayPnAddition.TabIndex = 0;
            // 
            // butConverter
            // 
            this.butConverter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(170)))));
            this.butConverter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butConverter.FlatAppearance.BorderSize = 0;
            this.butConverter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butConverter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butConverter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butConverter.Location = new System.Drawing.Point(3, 3);
            this.butConverter.Name = "butConverter";
            this.butConverter.Size = new System.Drawing.Size(164, 33);
            this.butConverter.TabIndex = 0;
            this.butConverter.Text = "Converter";
            this.butConverter.UseVisualStyleBackColor = false;
            this.butConverter.Click += new System.EventHandler(this.butAddition_Click);
            // 
            // butBinaryCalculator
            // 
            this.butBinaryCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(170)))));
            this.butBinaryCalculator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBinaryCalculator.FlatAppearance.BorderSize = 0;
            this.butBinaryCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBinaryCalculator.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butBinaryCalculator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butBinaryCalculator.Location = new System.Drawing.Point(3, 42);
            this.butBinaryCalculator.Name = "butBinaryCalculator";
            this.butBinaryCalculator.Size = new System.Drawing.Size(164, 33);
            this.butBinaryCalculator.TabIndex = 1;
            this.butBinaryCalculator.Text = "Binary calculator";
            this.butBinaryCalculator.UseVisualStyleBackColor = false;
            this.butBinaryCalculator.Click += new System.EventHandler(this.butAddition_Click);
            // 
            // butBinaryOperation
            // 
            this.butBinaryOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(170)))));
            this.butBinaryOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBinaryOperation.FlatAppearance.BorderSize = 0;
            this.butBinaryOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBinaryOperation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butBinaryOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butBinaryOperation.Location = new System.Drawing.Point(3, 81);
            this.butBinaryOperation.Name = "butBinaryOperation";
            this.butBinaryOperation.Size = new System.Drawing.Size(164, 33);
            this.butBinaryOperation.TabIndex = 2;
            this.butBinaryOperation.Text = "Binary operation";
            this.butBinaryOperation.UseVisualStyleBackColor = false;
            this.butBinaryOperation.Click += new System.EventHandler(this.butAddition_Click);
            // 
            // pnCenter
            // 
            this.pnCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.pnCenter.Controls.Add(this.movePanel);
            this.pnCenter.Controls.Add(this.butClose);
            this.pnCenter.Controls.Add(this.txtResultBefore);
            this.pnCenter.Controls.Add(this.txtRecent);
            this.pnCenter.Controls.Add(this.txtResult);
            this.pnCenter.Controls.Add(this.txtEnter);
            this.pnCenter.Controls.Add(this.butAllClear);
            this.pnCenter.Controls.Add(this.butChangeMark);
            this.pnCenter.Controls.Add(this.butInterest);
            this.pnCenter.Controls.Add(this.butDivision);
            this.pnCenter.Controls.Add(this.butMultiplication);
            this.pnCenter.Controls.Add(this.butMinus);
            this.pnCenter.Controls.Add(this.butPlus);
            this.pnCenter.Controls.Add(this.butEqual);
            this.pnCenter.Controls.Add(this.butDot);
            this.pnCenter.Controls.Add(this.butNumber0);
            this.pnCenter.Controls.Add(this.butNumber2);
            this.pnCenter.Controls.Add(this.butNumber6);
            this.pnCenter.Controls.Add(this.butNumber3);
            this.pnCenter.Controls.Add(this.butNumber1);
            this.pnCenter.Controls.Add(this.butNumber5);
            this.pnCenter.Controls.Add(this.butNumber7);
            this.pnCenter.Controls.Add(this.butNumber8);
            this.pnCenter.Controls.Add(this.butNumber9);
            this.pnCenter.Controls.Add(this.butNumber4);
            this.pnCenter.Location = new System.Drawing.Point(170, 0);
            this.pnCenter.Name = "pnCenter";
            this.pnCenter.Size = new System.Drawing.Size(410, 450);
            this.pnCenter.TabIndex = 17;
            // 
            // movePanel
            // 
            this.movePanel.Location = new System.Drawing.Point(0, 0);
            this.movePanel.Name = "movePanel";
            this.movePanel.Size = new System.Drawing.Size(377, 25);
            this.movePanel.TabIndex = 2;
            this.movePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseDown);
            this.movePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movePanel_MouseMove);
            // 
            // butClose
            // 
            this.butClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butClose.Image = ((System.Drawing.Image)(resources.GetObject("butClose.Image")));
            this.butClose.Location = new System.Drawing.Point(375, 0);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(35, 35);
            this.butClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.butClose.TabIndex = 32;
            this.butClose.TabStop = false;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // txtResultBefore
            // 
            this.txtResultBefore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtResultBefore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultBefore.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultBefore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
            this.txtResultBefore.Location = new System.Drawing.Point(9, 418);
            this.txtResultBefore.Name = "txtResultBefore";
            this.txtResultBefore.ReadOnly = true;
            this.txtResultBefore.Size = new System.Drawing.Size(400, 16);
            this.txtResultBefore.TabIndex = 31;
            this.txtResultBefore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRecent
            // 
            this.txtRecent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecent.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.txtRecent.Location = new System.Drawing.Point(104, 368);
            this.txtRecent.Name = "txtRecent";
            this.txtRecent.Size = new System.Drawing.Size(215, 15);
            this.txtRecent.TabIndex = 30;
            this.txtRecent.Text = "Recent Calculations";
            this.txtRecent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.txtResult.Location = new System.Drawing.Point(9, 389);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(400, 23);
            this.txtResult.TabIndex = 29;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEnter
            // 
            this.txtEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.txtEnter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEnter.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.txtEnter.Location = new System.Drawing.Point(14, 54);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.ReadOnly = true;
            this.txtEnter.Size = new System.Drawing.Size(306, 33);
            this.txtEnter.TabIndex = 28;
            this.txtEnter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // butAllClear
            // 
            this.butAllClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.butAllClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butAllClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butAllClear.FlatAppearance.BorderSize = 0;
            this.butAllClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.butAllClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAllClear.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAllClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butAllClear.Location = new System.Drawing.Point(104, 92);
            this.butAllClear.Name = "butAllClear";
            this.butAllClear.Size = new System.Drawing.Size(50, 50);
            this.butAllClear.TabIndex = 27;
            this.butAllClear.Text = "AC";
            this.butAllClear.UseVisualStyleBackColor = false;
            this.butAllClear.Click += new System.EventHandler(this.butAllClear_Click);
            // 
            // butChangeMark
            // 
            this.butChangeMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butChangeMark.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butChangeMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butChangeMark.FlatAppearance.BorderSize = 0;
            this.butChangeMark.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butChangeMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butChangeMark.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butChangeMark.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butChangeMark.Location = new System.Drawing.Point(159, 92);
            this.butChangeMark.Name = "butChangeMark";
            this.butChangeMark.Size = new System.Drawing.Size(50, 50);
            this.butChangeMark.TabIndex = 26;
            this.butChangeMark.Text = "[+/-]";
            this.butChangeMark.UseVisualStyleBackColor = false;
            this.butChangeMark.Click += new System.EventHandler(this.butChangeMark_Click);
            // 
            // butInterest
            // 
            this.butInterest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butInterest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butInterest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butInterest.FlatAppearance.BorderSize = 0;
            this.butInterest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butInterest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butInterest.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butInterest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butInterest.Location = new System.Drawing.Point(214, 92);
            this.butInterest.Name = "butInterest";
            this.butInterest.Size = new System.Drawing.Size(50, 50);
            this.butInterest.TabIndex = 25;
            this.butInterest.Text = "%";
            this.butInterest.UseVisualStyleBackColor = false;
            this.butInterest.Click += new System.EventHandler(this.butInterest_Click);
            // 
            // butDivision
            // 
            this.butDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butDivision.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butDivision.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDivision.FlatAppearance.BorderSize = 0;
            this.butDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDivision.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butDivision.Location = new System.Drawing.Point(270, 92);
            this.butDivision.Name = "butDivision";
            this.butDivision.Size = new System.Drawing.Size(50, 50);
            this.butDivision.TabIndex = 24;
            this.butDivision.Text = "/";
            this.butDivision.UseVisualStyleBackColor = false;
            this.butDivision.Click += new System.EventHandler(this.butDivision_Click);
            // 
            // butMultiplication
            // 
            this.butMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butMultiplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butMultiplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butMultiplication.FlatAppearance.BorderSize = 0;
            this.butMultiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMultiplication.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMultiplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butMultiplication.Location = new System.Drawing.Point(270, 147);
            this.butMultiplication.Name = "butMultiplication";
            this.butMultiplication.Size = new System.Drawing.Size(50, 50);
            this.butMultiplication.TabIndex = 23;
            this.butMultiplication.Text = "х";
            this.butMultiplication.UseVisualStyleBackColor = false;
            this.butMultiplication.Click += new System.EventHandler(this.butMultiplication_Click);
            // 
            // butMinus
            // 
            this.butMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butMinus.FlatAppearance.BorderSize = 0;
            this.butMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMinus.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butMinus.Location = new System.Drawing.Point(270, 202);
            this.butMinus.Name = "butMinus";
            this.butMinus.Size = new System.Drawing.Size(50, 50);
            this.butMinus.TabIndex = 22;
            this.butMinus.Text = "-";
            this.butMinus.UseVisualStyleBackColor = false;
            this.butMinus.Click += new System.EventHandler(this.butMinus_Click);
            // 
            // butPlus
            // 
            this.butPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butPlus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butPlus.FlatAppearance.BorderSize = 0;
            this.butPlus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butPlus.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butPlus.Location = new System.Drawing.Point(270, 257);
            this.butPlus.Name = "butPlus";
            this.butPlus.Size = new System.Drawing.Size(50, 50);
            this.butPlus.TabIndex = 21;
            this.butPlus.Text = "+";
            this.butPlus.UseVisualStyleBackColor = false;
            this.butPlus.Click += new System.EventHandler(this.butPlus_Click);
            // 
            // butEqual
            // 
            this.butEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.butEqual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butEqual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butEqual.FlatAppearance.BorderSize = 0;
            this.butEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.butEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEqual.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEqual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butEqual.Location = new System.Drawing.Point(269, 312);
            this.butEqual.Name = "butEqual";
            this.butEqual.Size = new System.Drawing.Size(50, 50);
            this.butEqual.TabIndex = 20;
            this.butEqual.Text = "=";
            this.butEqual.UseVisualStyleBackColor = false;
            this.butEqual.Click += new System.EventHandler(this.butEqual_Click);
            // 
            // butDot
            // 
            this.butDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butDot.FlatAppearance.BorderSize = 0;
            this.butDot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDot.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butDot.Location = new System.Drawing.Point(214, 312);
            this.butDot.Name = "butDot";
            this.butDot.Size = new System.Drawing.Size(50, 50);
            this.butDot.TabIndex = 19;
            this.butDot.Text = ".";
            this.butDot.UseVisualStyleBackColor = false;
            this.butDot.Click += new System.EventHandler(this.butDot_Click);
            // 
            // butNumber0
            // 
            this.butNumber0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butNumber0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butNumber0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNumber0.FlatAppearance.BorderSize = 0;
            this.butNumber0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butNumber0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNumber0.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNumber0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butNumber0.Location = new System.Drawing.Point(104, 312);
            this.butNumber0.Name = "butNumber0";
            this.butNumber0.Size = new System.Drawing.Size(105, 50);
            this.butNumber0.TabIndex = 18;
            this.butNumber0.Text = "0";
            this.butNumber0.UseVisualStyleBackColor = false;
            // 
            // butNumber2
            // 
            this.butNumber2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butNumber2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butNumber2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNumber2.FlatAppearance.BorderSize = 0;
            this.butNumber2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butNumber2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNumber2.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNumber2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butNumber2.Location = new System.Drawing.Point(159, 257);
            this.butNumber2.Name = "butNumber2";
            this.butNumber2.Size = new System.Drawing.Size(50, 50);
            this.butNumber2.TabIndex = 17;
            this.butNumber2.Text = "2";
            this.butNumber2.UseVisualStyleBackColor = false;
            this.butNumber2.Click += new System.EventHandler(this.butNumbers_Click);
            // 
            // butNumber6
            // 
            this.butNumber6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butNumber6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butNumber6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNumber6.FlatAppearance.BorderSize = 0;
            this.butNumber6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butNumber6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNumber6.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNumber6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butNumber6.Location = new System.Drawing.Point(214, 202);
            this.butNumber6.Name = "butNumber6";
            this.butNumber6.Size = new System.Drawing.Size(50, 50);
            this.butNumber6.TabIndex = 16;
            this.butNumber6.Text = "6";
            this.butNumber6.UseVisualStyleBackColor = false;
            this.butNumber6.Click += new System.EventHandler(this.butNumbers_Click);
            // 
            // butNumber3
            // 
            this.butNumber3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butNumber3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butNumber3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNumber3.FlatAppearance.BorderSize = 0;
            this.butNumber3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butNumber3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNumber3.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNumber3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butNumber3.Location = new System.Drawing.Point(214, 257);
            this.butNumber3.Name = "butNumber3";
            this.butNumber3.Size = new System.Drawing.Size(50, 50);
            this.butNumber3.TabIndex = 15;
            this.butNumber3.Text = "3";
            this.butNumber3.UseVisualStyleBackColor = false;
            this.butNumber3.Click += new System.EventHandler(this.butNumbers_Click);
            // 
            // butNumber1
            // 
            this.butNumber1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butNumber1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butNumber1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNumber1.FlatAppearance.BorderSize = 0;
            this.butNumber1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butNumber1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNumber1.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNumber1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butNumber1.Location = new System.Drawing.Point(104, 257);
            this.butNumber1.Name = "butNumber1";
            this.butNumber1.Size = new System.Drawing.Size(50, 50);
            this.butNumber1.TabIndex = 14;
            this.butNumber1.Text = "1";
            this.butNumber1.UseVisualStyleBackColor = false;
            this.butNumber1.Click += new System.EventHandler(this.butNumbers_Click);
            // 
            // butNumber5
            // 
            this.butNumber5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butNumber5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butNumber5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNumber5.FlatAppearance.BorderSize = 0;
            this.butNumber5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butNumber5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNumber5.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNumber5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butNumber5.Location = new System.Drawing.Point(159, 202);
            this.butNumber5.Name = "butNumber5";
            this.butNumber5.Size = new System.Drawing.Size(50, 50);
            this.butNumber5.TabIndex = 13;
            this.butNumber5.Text = "5";
            this.butNumber5.UseVisualStyleBackColor = false;
            this.butNumber5.Click += new System.EventHandler(this.butNumbers_Click);
            // 
            // butNumber7
            // 
            this.butNumber7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butNumber7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butNumber7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNumber7.FlatAppearance.BorderSize = 0;
            this.butNumber7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butNumber7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNumber7.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNumber7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butNumber7.Location = new System.Drawing.Point(104, 147);
            this.butNumber7.Name = "butNumber7";
            this.butNumber7.Size = new System.Drawing.Size(50, 50);
            this.butNumber7.TabIndex = 12;
            this.butNumber7.Text = "7";
            this.butNumber7.UseVisualStyleBackColor = false;
            this.butNumber7.Click += new System.EventHandler(this.butNumbers_Click);
            // 
            // butNumber8
            // 
            this.butNumber8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butNumber8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butNumber8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNumber8.FlatAppearance.BorderSize = 0;
            this.butNumber8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butNumber8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNumber8.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNumber8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butNumber8.Location = new System.Drawing.Point(159, 147);
            this.butNumber8.Name = "butNumber8";
            this.butNumber8.Size = new System.Drawing.Size(50, 50);
            this.butNumber8.TabIndex = 11;
            this.butNumber8.Text = "8";
            this.butNumber8.UseVisualStyleBackColor = false;
            this.butNumber8.Click += new System.EventHandler(this.butNumbers_Click);
            // 
            // butNumber9
            // 
            this.butNumber9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butNumber9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butNumber9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNumber9.FlatAppearance.BorderSize = 0;
            this.butNumber9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butNumber9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNumber9.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNumber9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butNumber9.Location = new System.Drawing.Point(214, 147);
            this.butNumber9.Name = "butNumber9";
            this.butNumber9.Size = new System.Drawing.Size(50, 50);
            this.butNumber9.TabIndex = 10;
            this.butNumber9.Text = "9";
            this.butNumber9.UseVisualStyleBackColor = false;
            this.butNumber9.Click += new System.EventHandler(this.butNumbers_Click);
            // 
            // butNumber4
            // 
            this.butNumber4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.butNumber4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.butNumber4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butNumber4.FlatAppearance.BorderSize = 0;
            this.butNumber4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(74)))), ((int)(((byte)(96)))));
            this.butNumber4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butNumber4.Font = new System.Drawing.Font("Unispace", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butNumber4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butNumber4.Location = new System.Drawing.Point(104, 202);
            this.butNumber4.Name = "butNumber4";
            this.butNumber4.Size = new System.Drawing.Size(50, 50);
            this.butNumber4.TabIndex = 9;
            this.butNumber4.Text = "4";
            this.butNumber4.UseVisualStyleBackColor = false;
            this.butNumber4.Click += new System.EventHandler(this.butNumbers_Click);
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.pnRight.Location = new System.Drawing.Point(580, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(300, 450);
            this.pnRight.TabIndex = 18;
            // 
            // GlobalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnCenter);
            this.Controls.Add(this.pnLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(880, 450);
            this.MinimumSize = new System.Drawing.Size(580, 450);
            this.Name = "GlobalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnLeft.ResumeLayout(false);
            this.tbLayPnAddition.ResumeLayout(false);
            this.pnCenter.ResumeLayout(false);
            this.pnCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.butClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnCenter;
        private System.Windows.Forms.Panel movePanel;
        private System.Windows.Forms.PictureBox butClose;
        private System.Windows.Forms.TextBox txtResultBefore;
        private System.Windows.Forms.TextBox txtRecent;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.Button butAllClear;
        private System.Windows.Forms.Button butChangeMark;
        private System.Windows.Forms.Button butInterest;
        private System.Windows.Forms.Button butDivision;
        private System.Windows.Forms.Button butMultiplication;
        private System.Windows.Forms.Button butMinus;
        private System.Windows.Forms.Button butPlus;
        private System.Windows.Forms.Button butEqual;
        private System.Windows.Forms.Button butDot;
        private System.Windows.Forms.Button butNumber0;
        private System.Windows.Forms.Button butNumber2;
        private System.Windows.Forms.Button butNumber6;
        private System.Windows.Forms.Button butNumber3;
        private System.Windows.Forms.Button butNumber1;
        private System.Windows.Forms.Button butNumber5;
        private System.Windows.Forms.Button butNumber7;
        private System.Windows.Forms.Button butNumber8;
        private System.Windows.Forms.Button butNumber9;
        private System.Windows.Forms.Button butNumber4;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.TableLayoutPanel tbLayPnAddition;
        private System.Windows.Forms.Button butConverter;
        private System.Windows.Forms.Button butBinaryCalculator;
        private System.Windows.Forms.Button butBinaryOperation;
    }
}

