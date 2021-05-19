
namespace Calculator {
    partial class BinaryCalculatorForm {
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
            this.txtResBinCalc         = new System.Windows.Forms.TextBox();
            this.panelFAQBinCalculator = new System.Windows.Forms.Panel();
            this.label1                = new System.Windows.Forms.Label();
            this.FAQBinCalculator      = new System.Windows.Forms.Label();
            this.txtBinGlobalDown      = new System.Windows.Forms.TextBox();
            this.panel1                = new System.Windows.Forms.Panel();
            this.txtResultBinCalc      = new System.Windows.Forms.TextBox();
            this.butCalculationBin     = new System.Windows.Forms.Button();
            this.cmbOperationBin       = new System.Windows.Forms.ComboBox();
            this.editRightBin          = new System.Windows.Forms.TextBox();
            this.editLeftBin           = new System.Windows.Forms.TextBox();
            this.cmbTypeBinRight       = new System.Windows.Forms.ComboBox();
            this.cmbTypeBinLeft        = new System.Windows.Forms.ComboBox();
            this.butConvertBin         = new System.Windows.Forms.Button();
            this.txtToTypeBin          = new System.Windows.Forms.TextBox();
            this.cmbTypeBin            = new System.Windows.Forms.ComboBox();
            this.txtFromTypeBin        = new System.Windows.Forms.TextBox();
            this.txtBinGlobalUp        = new System.Windows.Forms.TextBox();
            this.editToBin             = new System.Windows.Forms.TextBox();
            this.editFromBin           = new System.Windows.Forms.TextBox();
            this.panelFAQBinCalculator.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResBinCalc
            // 
            this.txtResBinCalc.BackColor   = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (55)))), ((int) (((byte) (78)))));
            this.txtResBinCalc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResBinCalc.Font        = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.txtResBinCalc.ForeColor   = System.Drawing.Color.FromArgb(((int) (((byte) (234)))), ((int) (((byte) (234)))), ((int) (((byte) (234)))));
            this.txtResBinCalc.Location    = new System.Drawing.Point(1, 378);
            this.txtResBinCalc.Name        = "txtResBinCalc";
            this.txtResBinCalc.Size        = new System.Drawing.Size(299, 19);
            this.txtResBinCalc.TabIndex    = 72;
            this.txtResBinCalc.Text        = "Result";
            this.txtResBinCalc.TextAlign   = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResBinCalc.Visible     = false;
            // 
            // panelFAQBinCalculator
            // 
            this.panelFAQBinCalculator.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (29)))), ((int) (((byte) (41)))), ((int) (((byte) (58)))));
            this.panelFAQBinCalculator.Controls.Add(this.label1);
            this.panelFAQBinCalculator.Location = new System.Drawing.Point(96, 153);
            this.panelFAQBinCalculator.Name     = "panelFAQBinCalculator";
            this.panelFAQBinCalculator.Size     = new System.Drawing.Size(200, 100);
            this.panelFAQBinCalculator.TabIndex = 71;
            this.panelFAQBinCalculator.Visible  = false;
            // 
            // label1
            // 
            this.label1.AutoSize  = true;
            this.label1.Font      = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (234)))), ((int) (((byte) (234)))), ((int) (((byte) (234)))));
            this.label1.Location  = new System.Drawing.Point(9, 21);
            this.label1.Name      = "label1";
            this.label1.Size      = new System.Drawing.Size(194, 60);
            this.label1.TabIndex  = 0;
            this.label1.Text      = "If the calculation systems are \r\ndifferent, the result will be in \r\nthe system yo" + "u chose first";
            // 
            // FAQBinCalculator
            // 
            this.FAQBinCalculator.AutoSize   =  true;
            this.FAQBinCalculator.Cursor     =  System.Windows.Forms.Cursors.Hand;
            this.FAQBinCalculator.Font       =  new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.FAQBinCalculator.ForeColor  =  System.Drawing.Color.FromArgb(((int) (((byte) (234)))), ((int) (((byte) (234)))), ((int) (((byte) (234)))));
            this.FAQBinCalculator.Location   =  new System.Drawing.Point(279, 256);
            this.FAQBinCalculator.Name       =  "FAQBinCalculator";
            this.FAQBinCalculator.Size       =  new System.Drawing.Size(17, 20);
            this.FAQBinCalculator.TabIndex   =  70;
            this.FAQBinCalculator.Text       =  "?";
            this.FAQBinCalculator.MouseEnter += new System.EventHandler(this.FAQBinCalculator_MouseEnter);
            this.FAQBinCalculator.MouseLeave += new System.EventHandler(this.FAQBinCalculator_MouseLeave);
            // 
            // txtBinGlobalDown
            // 
            this.txtBinGlobalDown.BackColor   = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (55)))), ((int) (((byte) (78)))));
            this.txtBinGlobalDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBinGlobalDown.Font        = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.txtBinGlobalDown.ForeColor   = System.Drawing.Color.FromArgb(((int) (((byte) (234)))), ((int) (((byte) (234)))), ((int) (((byte) (234)))));
            this.txtBinGlobalDown.Location    = new System.Drawing.Point(0, 248);
            this.txtBinGlobalDown.Name        = "txtBinGlobalDown";
            this.txtBinGlobalDown.Size        = new System.Drawing.Size(299, 19);
            this.txtBinGlobalDown.TabIndex    = 69;
            this.txtBinGlobalDown.Text        = "Binary calculator";
            this.txtBinGlobalDown.TextAlign   = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (29)))), ((int) (((byte) (41)))), ((int) (((byte) (58)))));
            this.panel1.Location  = new System.Drawing.Point(-1, 237);
            this.panel1.Name      = "panel1";
            this.panel1.Size      = new System.Drawing.Size(300, 5);
            this.panel1.TabIndex  = 68;
            // 
            // txtResultBinCalc
            // 
            this.txtResultBinCalc.BackColor   = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (55)))), ((int) (((byte) (78)))));
            this.txtResultBinCalc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultBinCalc.Font        = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtResultBinCalc.ForeColor   = System.Drawing.Color.FromArgb(((int) (((byte) (234)))), ((int) (((byte) (234)))), ((int) (((byte) (234)))));
            this.txtResultBinCalc.Location    = new System.Drawing.Point(2, 403);
            this.txtResultBinCalc.Name        = "txtResultBinCalc";
            this.txtResultBinCalc.ReadOnly    = true;
            this.txtResultBinCalc.Size        = new System.Drawing.Size(299, 23);
            this.txtResultBinCalc.TabIndex    = 54;
            this.txtResultBinCalc.TextAlign   = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butCalculationBin
            // 
            this.butCalculationBin.BackColor                 =  System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (120)))), ((int) (((byte) (170)))));
            this.butCalculationBin.Cursor                    =  System.Windows.Forms.Cursors.Hand;
            this.butCalculationBin.FlatAppearance.BorderSize =  0;
            this.butCalculationBin.FlatStyle                 =  System.Windows.Forms.FlatStyle.Flat;
            this.butCalculationBin.Font                      =  new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.butCalculationBin.ForeColor                 =  System.Drawing.Color.FromArgb(((int) (((byte) (234)))), ((int) (((byte) (234)))), ((int) (((byte) (234)))));
            this.butCalculationBin.Location                  =  new System.Drawing.Point(123, 342);
            this.butCalculationBin.Name                      =  "butCalculationBin";
            this.butCalculationBin.Size                      =  new System.Drawing.Size(164, 30);
            this.butCalculationBin.TabIndex                  =  67;
            this.butCalculationBin.Text                      =  "Calculate";
            this.butCalculationBin.UseVisualStyleBackColor   =  false;
            this.butCalculationBin.Visible                   =  false;
            this.butCalculationBin.Click                     += new System.EventHandler(this.butCalculationBin_Click);
            // 
            // cmbOperationBin
            // 
            this.cmbOperationBin.BackColor         = System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (67)))), ((int) (((byte) (87)))));
            this.cmbOperationBin.Cursor            = System.Windows.Forms.Cursors.Hand;
            this.cmbOperationBin.DropDownStyle     = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperationBin.Font              = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cmbOperationBin.ForeColor         = System.Drawing.Color.FromArgb(((int) (((byte) (234)))), ((int) (((byte) (234)))), ((int) (((byte) (234)))));
            this.cmbOperationBin.FormattingEnabled = true;
            this.cmbOperationBin.Items.AddRange(new object[] {"Plus", "Minus", "Multiplic", "Division"});
            this.cmbOperationBin.Location = new System.Drawing.Point(119, 312);
            this.cmbOperationBin.Name     = "cmbOperationBin";
            this.cmbOperationBin.Size     = new System.Drawing.Size(66, 24);
            this.cmbOperationBin.TabIndex = 66;
            this.cmbOperationBin.Visible  = false;
            // 
            // editRightBin
            // 
            this.editRightBin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.editRightBin.Font      = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.editRightBin.Location  = new System.Drawing.Point(195, 314);
            this.editRightBin.Name      = "editRightBin";
            this.editRightBin.Size      = new System.Drawing.Size(92, 22);
            this.editRightBin.TabIndex  = 65;
            this.editRightBin.Visible   = false;
            // 
            // editLeftBin
            // 
            this.editLeftBin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.editLeftBin.Font      = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.editLeftBin.Location  = new System.Drawing.Point(16, 314);
            this.editLeftBin.Name      = "editLeftBin";
            this.editLeftBin.Size      = new System.Drawing.Size(92, 22);
            this.editLeftBin.TabIndex  = 64;
            this.editLeftBin.Visible   = false;
            // 
            // cmbTypeBinRight
            // 
            this.cmbTypeBinRight.BackColor            =  System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (67)))), ((int) (((byte) (87)))));
            this.cmbTypeBinRight.Cursor               =  System.Windows.Forms.Cursors.Hand;
            this.cmbTypeBinRight.DropDownStyle        =  System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeBinRight.Font                 =  new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cmbTypeBinRight.ForeColor            =  System.Drawing.Color.FromArgb(((int) (((byte) (234)))), ((int) (((byte) (234)))), ((int) (((byte) (234)))));
            this.cmbTypeBinRight.FormattingEnabled    =  true;
            this.cmbTypeBinRight.Location             =  new System.Drawing.Point(204, 284);
            this.cmbTypeBinRight.Name                 =  "cmbTypeBinRight";
            this.cmbTypeBinRight.Size                 =  new System.Drawing.Size(82, 24);
            this.cmbTypeBinRight.TabIndex             =  63;
            this.cmbTypeBinRight.SelectedIndexChanged += new System.EventHandler(this.cmbTypeBinRight_SelectedIndexChanged);
            // 
            // cmbTypeBinLeft
            // 
            this.cmbTypeBinLeft.BackColor            =  System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (67)))), ((int) (((byte) (87)))));
            this.cmbTypeBinLeft.Cursor               =  System.Windows.Forms.Cursors.Hand;
            this.cmbTypeBinLeft.DropDownStyle        =  System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeBinLeft.Font                 =  new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cmbTypeBinLeft.ForeColor            =  System.Drawing.Color.FromArgb(((int) (((byte) (234)))), ((int) (((byte) (234)))), ((int) (((byte) (234)))));
            this.cmbTypeBinLeft.FormattingEnabled    =  true;
            this.cmbTypeBinLeft.Location             =  new System.Drawing.Point(16, 284);
            this.cmbTypeBinLeft.Name                 =  "cmbTypeBinLeft";
            this.cmbTypeBinLeft.Size                 =  new System.Drawing.Size(82, 24);
            this.cmbTypeBinLeft.TabIndex             =  62;
            this.cmbTypeBinLeft.SelectedIndexChanged += new System.EventHandler(this.cmbTypeBinLeft_SelectedIndexChanged);
            // 
            // butConvertBin
            // 
            this.butConvertBin.BackColor                 =  System.Drawing.Color.FromArgb(((int) (((byte) (90)))), ((int) (((byte) (120)))), ((int) (((byte) (170)))));
            this.butConvertBin.Cursor                    =  System.Windows.Forms.Cursors.Hand;
            this.butConvertBin.FlatAppearance.BorderSize =  0;
            this.butConvertBin.FlatStyle                 =  System.Windows.Forms.FlatStyle.Flat;
            this.butConvertBin.Font                      =  new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.butConvertBin.ForeColor                 =  System.Drawing.Color.FromArgb(((int) (((byte) (234)))), ((int) (((byte) (234)))), ((int) (((byte) (234)))));
            this.butConvertBin.Location                  =  new System.Drawing.Point(115, 190);
            this.butConvertBin.Name                      =  "butConvertBin";
            this.butConvertBin.Size                      =  new System.Drawing.Size(170, 30);
            this.butConvertBin.TabIndex                  =  58;
            this.butConvertBin.Text                      =  "Convert";
            this.butConvertBin.UseVisualStyleBackColor   =  false;
            this.butConvertBin.Visible                   =  false;
            this.butConvertBin.Click                     += new System.EventHandler(this.butConvertBin_Click);
            // 
            // txtToTypeBin
            // 
            this.txtToTypeBin.BackColor   = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (55)))), ((int) (((byte) (78)))));
            this.txtToTypeBin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToTypeBin.Font        = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtToTypeBin.ForeColor   = System.Drawing.Color.FromArgb(((int) (((byte) (234)))), ((int) (((byte) (234)))), ((int) (((byte) (234)))));
            this.txtToTypeBin.Location    = new System.Drawing.Point(2, 147);
            this.txtToTypeBin.Name        = "txtToTypeBin";
            this.txtToTypeBin.Size        = new System.Drawing.Size(107, 15);
            this.txtToTypeBin.TabIndex    = 61;
            this.txtToTypeBin.TextAlign   = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToTypeBin.Visible     = false;
            // 
            // cmbTypeBin
            // 
            this.cmbTypeBin.BackColor            =  System.Drawing.Color.FromArgb(((int) (((byte) (53)))), ((int) (((byte) (67)))), ((int) (((byte) (87)))));
            this.cmbTypeBin.Cursor               =  System.Windows.Forms.Cursors.Hand;
            this.cmbTypeBin.DropDownStyle        =  System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeBin.Font                 =  new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.cmbTypeBin.ForeColor            =  System.Drawing.Color.FromArgb(((int) (((byte) (234)))), ((int) (((byte) (234)))), ((int) (((byte) (234)))));
            this.cmbTypeBin.FormattingEnabled    =  true;
            this.cmbTypeBin.Location             =  new System.Drawing.Point(15, 60);
            this.cmbTypeBin.Name                 =  "cmbTypeBin";
            this.cmbTypeBin.Size                 =  new System.Drawing.Size(270, 24);
            this.cmbTypeBin.TabIndex             =  57;
            this.cmbTypeBin.SelectedIndexChanged += new System.EventHandler(this.cmbTypeBin_SelectedIndexChanged);
            // 
            // txtFromTypeBin
            // 
            this.txtFromTypeBin.BackColor   = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (55)))), ((int) (((byte) (78)))));
            this.txtFromTypeBin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFromTypeBin.Font        = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtFromTypeBin.ForeColor   = System.Drawing.Color.FromArgb(((int) (((byte) (234)))), ((int) (((byte) (234)))), ((int) (((byte) (234)))));
            this.txtFromTypeBin.Location    = new System.Drawing.Point(2, 107);
            this.txtFromTypeBin.Name        = "txtFromTypeBin";
            this.txtFromTypeBin.Size        = new System.Drawing.Size(107, 15);
            this.txtFromTypeBin.TabIndex    = 60;
            this.txtFromTypeBin.TextAlign   = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromTypeBin.Visible     = false;
            // 
            // txtBinGlobalUp
            // 
            this.txtBinGlobalUp.BackColor   = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (55)))), ((int) (((byte) (78)))));
            this.txtBinGlobalUp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBinGlobalUp.Font        = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.txtBinGlobalUp.ForeColor   = System.Drawing.Color.FromArgb(((int) (((byte) (234)))), ((int) (((byte) (234)))), ((int) (((byte) (234)))));
            this.txtBinGlobalUp.Location    = new System.Drawing.Point(0, 20);
            this.txtBinGlobalUp.Name        = "txtBinGlobalUp";
            this.txtBinGlobalUp.Size        = new System.Drawing.Size(299, 19);
            this.txtBinGlobalUp.TabIndex    = 56;
            this.txtBinGlobalUp.Text        = "Binary convert";
            this.txtBinGlobalUp.TextAlign   = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // editToBin
            // 
            this.editToBin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.editToBin.Font      = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.editToBin.Location  = new System.Drawing.Point(115, 140);
            this.editToBin.Name      = "editToBin";
            this.editToBin.ReadOnly  = true;
            this.editToBin.Size      = new System.Drawing.Size(170, 22);
            this.editToBin.TabIndex  = 59;
            this.editToBin.Visible   = false;
            // 
            // editFromBin
            // 
            this.editFromBin.BackColor = System.Drawing.SystemColors.MenuBar;
            this.editFromBin.Font      = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.editFromBin.Location  = new System.Drawing.Point(115, 100);
            this.editFromBin.Name      = "editFromBin";
            this.editFromBin.Size      = new System.Drawing.Size(170, 22);
            this.editFromBin.TabIndex  = 55;
            this.editFromBin.Visible   = false;
            // 
            // BinaryCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(((int) (((byte) (40)))), ((int) (((byte) (55)))), ((int) (((byte) (78)))));
            this.ClientSize          = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.txtResBinCalc);
            this.Controls.Add(this.panelFAQBinCalculator);
            this.Controls.Add(this.FAQBinCalculator);
            this.Controls.Add(this.txtBinGlobalDown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtResultBinCalc);
            this.Controls.Add(this.butCalculationBin);
            this.Controls.Add(this.cmbOperationBin);
            this.Controls.Add(this.editRightBin);
            this.Controls.Add(this.editLeftBin);
            this.Controls.Add(this.cmbTypeBinRight);
            this.Controls.Add(this.cmbTypeBinLeft);
            this.Controls.Add(this.butConvertBin);
            this.Controls.Add(this.txtToTypeBin);
            this.Controls.Add(this.cmbTypeBin);
            this.Controls.Add(this.txtFromTypeBin);
            this.Controls.Add(this.txtBinGlobalUp);
            this.Controls.Add(this.editToBin);
            this.Controls.Add(this.editFromBin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name            = "BinaryCalculatorForm";
            this.Text            = "BinaryCalculatorForm";
            this.panelFAQBinCalculator.ResumeLayout(false);
            this.panelFAQBinCalculator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox  txtResBinCalc;
        private System.Windows.Forms.Panel    panelFAQBinCalculator;
        private System.Windows.Forms.Label    label1;
        private System.Windows.Forms.Label    FAQBinCalculator;
        private System.Windows.Forms.TextBox  txtBinGlobalDown;
        private System.Windows.Forms.Panel    panel1;
        private System.Windows.Forms.TextBox  txtResultBinCalc;
        private System.Windows.Forms.Button   butCalculationBin;
        private System.Windows.Forms.ComboBox cmbOperationBin;
        private System.Windows.Forms.TextBox  editRightBin;
        private System.Windows.Forms.TextBox  editLeftBin;
        private System.Windows.Forms.ComboBox cmbTypeBinRight;
        private System.Windows.Forms.ComboBox cmbTypeBinLeft;
        private System.Windows.Forms.Button   butConvertBin;
        private System.Windows.Forms.TextBox  txtToTypeBin;
        private System.Windows.Forms.ComboBox cmbTypeBin;
        private System.Windows.Forms.TextBox  txtFromTypeBin;
        private System.Windows.Forms.TextBox  txtBinGlobalUp;
        private System.Windows.Forms.TextBox  editToBin;
        private System.Windows.Forms.TextBox  editFromBin;
    }
}