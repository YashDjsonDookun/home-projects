namespace Question3
{
    partial class frmSources
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_dividend = new System.Windows.Forms.MaskedTextBox();
            this.txt_interest = new System.Windows.Forms.MaskedTextBox();
            this.txt_wages = new System.Windows.Forms.MaskedTextBox();
            this.btn_computeIncome = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_dividend);
            this.panel1.Controls.Add(this.txt_interest);
            this.panel1.Controls.Add(this.txt_wages);
            this.panel1.Controls.Add(this.btn_computeIncome);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 298);
            this.panel1.TabIndex = 0;
            // 
            // txt_dividend
            // 
            this.txt_dividend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dividend.Location = new System.Drawing.Point(218, 181);
            this.txt_dividend.Mask = "000000000000000000000000";
            this.txt_dividend.Name = "txt_dividend";
            this.txt_dividend.Size = new System.Drawing.Size(157, 26);
            this.txt_dividend.TabIndex = 13;
            // 
            // txt_interest
            // 
            this.txt_interest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_interest.Location = new System.Drawing.Point(218, 141);
            this.txt_interest.Mask = "0000000000000000000000";
            this.txt_interest.Name = "txt_interest";
            this.txt_interest.Size = new System.Drawing.Size(157, 26);
            this.txt_interest.TabIndex = 12;
            // 
            // txt_wages
            // 
            this.txt_wages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_wages.Location = new System.Drawing.Point(218, 93);
            this.txt_wages.Mask = "00000000000000000000000";
            this.txt_wages.Name = "txt_wages";
            this.txt_wages.Size = new System.Drawing.Size(157, 26);
            this.txt_wages.TabIndex = 11;
            // 
            // btn_computeIncome
            // 
            this.btn_computeIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_computeIncome.Location = new System.Drawing.Point(105, 225);
            this.btn_computeIncome.Name = "btn_computeIncome";
            this.btn_computeIncome.Size = new System.Drawing.Size(254, 27);
            this.btn_computeIncome.TabIndex = 10;
            this.btn_computeIncome.Text = "Compute Total Income";
            this.btn_computeIncome.UseVisualStyleBackColor = true;
            this.btn_computeIncome.Click += new System.EventHandler(this.Btn_computeIncome_Click);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(218, 46);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(157, 26);
            this.txt_name.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dividend Income:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Interest Income:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wages:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // frmSources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 323);
            this.Controls.Add(this.panel1);
            this.Name = "frmSources";
            this.Text = "Sources Of Income";
            this.Load += new System.EventHandler(this.FrmSources_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_computeIncome;
        private System.Windows.Forms.MaskedTextBox txt_dividend;
        private System.Windows.Forms.MaskedTextBox txt_interest;
        private System.Windows.Forms.MaskedTextBox txt_wages;
    }
}