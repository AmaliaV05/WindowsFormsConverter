namespace WindowsFormsConverter
{
    partial class ConverterForm
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
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lstConvertFromCurrency = new System.Windows.Forms.ListBox();
            this.lstConvertToCurrency = new System.Windows.Forms.ListBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.chkApplyTransactionFee = new System.Windows.Forms.CheckBox();
            this.txtConvertedAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(125, 147);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(248, 30);
            this.txtAmount.TabIndex = 0;
            // 
            // lstConvertFromCurrency
            // 
            this.lstConvertFromCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConvertFromCurrency.FormattingEnabled = true;
            this.lstConvertFromCurrency.ItemHeight = 25;
            this.lstConvertFromCurrency.Location = new System.Drawing.Point(395, 147);
            this.lstConvertFromCurrency.Name = "lstConvertFromCurrency";
            this.lstConvertFromCurrency.Size = new System.Drawing.Size(150, 104);
            this.lstConvertFromCurrency.TabIndex = 1;
            // 
            // lstConvertToCurrency
            // 
            this.lstConvertToCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstConvertToCurrency.FormattingEnabled = true;
            this.lstConvertToCurrency.ItemHeight = 25;
            this.lstConvertToCurrency.Location = new System.Drawing.Point(599, 147);
            this.lstConvertToCurrency.Name = "lstConvertToCurrency";
            this.lstConvertToCurrency.Size = new System.Drawing.Size(150, 104);
            this.lstConvertToCurrency.TabIndex = 2;
            // 
            // btnConverter
            // 
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.Location = new System.Drawing.Point(395, 302);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(188, 38);
            this.btnConverter.TabIndex = 3;
            this.btnConverter.Text = "Convert";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.ConverterBtn_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(560, 185);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 20);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "to";
            // 
            // chkApplyTransactionFee
            // 
            this.chkApplyTransactionFee.AutoSize = true;
            this.chkApplyTransactionFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkApplyTransactionFee.Location = new System.Drawing.Point(612, 312);
            this.chkApplyTransactionFee.Name = "chkApplyTransactionFee";
            this.chkApplyTransactionFee.Size = new System.Drawing.Size(188, 24);
            this.chkApplyTransactionFee.TabIndex = 5;
            this.chkApplyTransactionFee.Text = "Apply transaction fee";
            this.chkApplyTransactionFee.UseVisualStyleBackColor = true;
            // 
            // txtConvertedAmount
            // 
            this.txtConvertedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvertedAmount.Location = new System.Drawing.Point(125, 390);
            this.txtConvertedAmount.Name = "txtConvertedAmount";
            this.txtConvertedAmount.Size = new System.Drawing.Size(248, 30);
            this.txtConvertedAmount.TabIndex = 8;
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 501);
            this.Controls.Add(this.txtConvertedAmount);
            this.Controls.Add(this.chkApplyTransactionFee);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lstConvertToCurrency);
            this.Controls.Add(this.lstConvertFromCurrency);
            this.Controls.Add(this.txtAmount);
            this.Name = "ConverterForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ListBox lstConvertFromCurrency;
        private System.Windows.Forms.ListBox lstConvertToCurrency;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.CheckBox chkApplyTransactionFee;
        private System.Windows.Forms.TextBox txtConvertedAmount;
    }
}

