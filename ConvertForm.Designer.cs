
namespace Calculator {
    partial class ConvertForm {
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
            this.txtToType = new System.Windows.Forms.TextBox();
            this.txtFromType = new System.Windows.Forms.TextBox();
            this.butConvert = new System.Windows.Forms.Button();
            this.editTo = new System.Windows.Forms.TextBox();
            this.editFrom = new System.Windows.Forms.TextBox();
            this.cmbTypeConvertation = new System.Windows.Forms.ComboBox();
            this.txtConverter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtToType
            // 
            this.txtToType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.txtToType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtToType.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.txtToType.Location = new System.Drawing.Point(2, 150);
            this.txtToType.Name = "txtToType";
            this.txtToType.Size = new System.Drawing.Size(107, 15);
            this.txtToType.TabIndex = 45;
            this.txtToType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtToType.Visible = false;
            // 
            // txtFromType
            // 
            this.txtFromType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.txtFromType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFromType.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFromType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.txtFromType.Location = new System.Drawing.Point(2, 111);
            this.txtFromType.Name = "txtFromType";
            this.txtFromType.Size = new System.Drawing.Size(107, 15);
            this.txtFromType.TabIndex = 44;
            this.txtFromType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFromType.Visible = false;
            // 
            // butConvert
            // 
            this.butConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(170)))));
            this.butConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butConvert.FlatAppearance.BorderSize = 0;
            this.butConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butConvert.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.butConvert.Location = new System.Drawing.Point(124, 202);
            this.butConvert.Name = "butConvert";
            this.butConvert.Size = new System.Drawing.Size(164, 30);
            this.butConvert.TabIndex = 43;
            this.butConvert.Text = "Convert";
            this.butConvert.UseVisualStyleBackColor = false;
            this.butConvert.Visible = false;
            this.butConvert.Click += new System.EventHandler(this.butConvert_Click);
            // 
            // editTo
            // 
            this.editTo.BackColor = System.Drawing.SystemColors.MenuBar;
            this.editTo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editTo.Location = new System.Drawing.Point(115, 147);
            this.editTo.Name = "editTo";
            this.editTo.ReadOnly = true;
            this.editTo.Size = new System.Drawing.Size(173, 22);
            this.editTo.TabIndex = 42;
            this.editTo.Visible = false;
            // 
            // editFrom
            // 
            this.editFrom.BackColor = System.Drawing.SystemColors.MenuBar;
            this.editFrom.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editFrom.Location = new System.Drawing.Point(115, 108);
            this.editFrom.Name = "editFrom";
            this.editFrom.Size = new System.Drawing.Size(173, 22);
            this.editFrom.TabIndex = 41;
            this.editFrom.Visible = false;
            // 
            // cmbTypeConvertation
            // 
            this.cmbTypeConvertation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.cmbTypeConvertation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTypeConvertation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeConvertation.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbTypeConvertation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.cmbTypeConvertation.FormattingEnabled = true;
            this.cmbTypeConvertation.Location = new System.Drawing.Point(15, 60);
            this.cmbTypeConvertation.Name = "cmbTypeConvertation";
            this.cmbTypeConvertation.Size = new System.Drawing.Size(270, 24);
            this.cmbTypeConvertation.TabIndex = 40;
            this.cmbTypeConvertation.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // txtConverter
            // 
            this.txtConverter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.txtConverter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConverter.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtConverter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.txtConverter.Location = new System.Drawing.Point(0, 20);
            this.txtConverter.Name = "txtConverter";
            this.txtConverter.Size = new System.Drawing.Size(299, 19);
            this.txtConverter.TabIndex = 39;
            this.txtConverter.Text = "Converter";
            this.txtConverter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.txtToType);
            this.Controls.Add(this.txtFromType);
            this.Controls.Add(this.butConvert);
            this.Controls.Add(this.editTo);
            this.Controls.Add(this.editFrom);
            this.Controls.Add(this.cmbTypeConvertation);
            this.Controls.Add(this.txtConverter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConvertForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToType;
        private System.Windows.Forms.TextBox txtFromType;
        private System.Windows.Forms.Button butConvert;
        private System.Windows.Forms.TextBox editTo;
        private System.Windows.Forms.TextBox editFrom;
        private System.Windows.Forms.ComboBox cmbTypeConvertation;
        private System.Windows.Forms.TextBox txtConverter;
    }
}