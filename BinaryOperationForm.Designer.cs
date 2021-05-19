
namespace Calculator {
    partial class BinaryOperationForm {
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
            this.txtBinOperDown = new System.Windows.Forms.TextBox();
            this.txtBinOperResult = new System.Windows.Forms.TextBox();
            this.butBinOper = new System.Windows.Forms.Button();
            this.editRightOper = new System.Windows.Forms.TextBox();
            this.cmbLogicalOper = new System.Windows.Forms.ComboBox();
            this.cmbTypeBinOper = new System.Windows.Forms.ComboBox();
            this.editLeftOper = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBinOperDown
            // 
            this.txtBinOperDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.txtBinOperDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBinOperDown.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBinOperDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.txtBinOperDown.Location = new System.Drawing.Point(0, 184);
            this.txtBinOperDown.Name = "txtBinOperDown";
            this.txtBinOperDown.Size = new System.Drawing.Size(299, 19);
            this.txtBinOperDown.TabIndex = 65;
            this.txtBinOperDown.Text = "Result";
            this.txtBinOperDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBinOperDown.Visible = false;
            // 
            // txtBinOperResult
            // 
            this.txtBinOperResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.txtBinOperResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBinOperResult.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinOperResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.txtBinOperResult.Location = new System.Drawing.Point(0, 211);
            this.txtBinOperResult.Name = "txtBinOperResult";
            this.txtBinOperResult.ReadOnly = true;
            this.txtBinOperResult.Size = new System.Drawing.Size(300, 23);
            this.txtBinOperResult.TabIndex = 58;
            this.txtBinOperResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // butBinOper
            // 
            this.butBinOper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(170)))));
            this.butBinOper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butBinOper.FlatAppearance.BorderSize = 0;
            this.butBinOper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBinOper.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butBinOper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butBinOper.Location = new System.Drawing.Point(121, 148);
            this.butBinOper.Name = "butBinOper";
            this.butBinOper.Size = new System.Drawing.Size(164, 30);
            this.butBinOper.TabIndex = 64;
            this.butBinOper.Text = "Calculate";
            this.butBinOper.UseVisualStyleBackColor = false;
            this.butBinOper.Visible = false;
            this.butBinOper.Click += new System.EventHandler(this.butBinOper_Click);
            // 
            // editRightOper
            // 
            this.editRightOper.BackColor = System.Drawing.SystemColors.MenuBar;
            this.editRightOper.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editRightOper.Location = new System.Drawing.Point(193, 104);
            this.editRightOper.Name = "editRightOper";
            this.editRightOper.Size = new System.Drawing.Size(92, 22);
            this.editRightOper.TabIndex = 63;
            this.editRightOper.Visible = false;
            // 
            // cmbLogicalOper
            // 
            this.cmbLogicalOper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.cmbLogicalOper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbLogicalOper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLogicalOper.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbLogicalOper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.cmbLogicalOper.FormattingEnabled = true;
            this.cmbLogicalOper.Items.AddRange(new object[] {
            "AND",
            "OR",
            "XOR",
            "<<",
            ">>"});
            this.cmbLogicalOper.Location = new System.Drawing.Point(118, 102);
            this.cmbLogicalOper.Name = "cmbLogicalOper";
            this.cmbLogicalOper.Size = new System.Drawing.Size(66, 24);
            this.cmbLogicalOper.TabIndex = 59;
            this.cmbLogicalOper.Visible = false;
            // 
            // cmbTypeBinOper
            // 
            this.cmbTypeBinOper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.cmbTypeBinOper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTypeBinOper.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeBinOper.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTypeBinOper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.cmbTypeBinOper.FormattingEnabled = true;
            this.cmbTypeBinOper.Location = new System.Drawing.Point(15, 60);
            this.cmbTypeBinOper.Name = "cmbTypeBinOper";
            this.cmbTypeBinOper.Size = new System.Drawing.Size(270, 24);
            this.cmbTypeBinOper.TabIndex = 60;
            this.cmbTypeBinOper.SelectedIndexChanged += new System.EventHandler(this.cmbTypeBinOper_SelectedIndexChanged);
            // 
            // editLeftOper
            // 
            this.editLeftOper.BackColor = System.Drawing.SystemColors.MenuBar;
            this.editLeftOper.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editLeftOper.Location = new System.Drawing.Point(15, 104);
            this.editLeftOper.Name = "editLeftOper";
            this.editLeftOper.Size = new System.Drawing.Size(92, 22);
            this.editLeftOper.TabIndex = 61;
            this.editLeftOper.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.textBox1.Location = new System.Drawing.Point(0, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 19);
            this.textBox1.TabIndex = 62;
            this.textBox1.Text = "Binary operations";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BinaryOperationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.txtBinOperDown);
            this.Controls.Add(this.txtBinOperResult);
            this.Controls.Add(this.butBinOper);
            this.Controls.Add(this.editRightOper);
            this.Controls.Add(this.cmbLogicalOper);
            this.Controls.Add(this.cmbTypeBinOper);
            this.Controls.Add(this.editLeftOper);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BinaryOperationForm";
            this.Text = "BinaryOperationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox  txtBinOperDown;
        private System.Windows.Forms.TextBox  txtBinOperResult;
        private System.Windows.Forms.Button   butBinOper;
        private System.Windows.Forms.TextBox  editRightOper;
        private System.Windows.Forms.ComboBox cmbLogicalOper;
        private System.Windows.Forms.ComboBox cmbTypeBinOper;
        private System.Windows.Forms.TextBox  editLeftOper;
        private System.Windows.Forms.TextBox  textBox1;
    }
}