namespace Question3
{
    partial class frmIncome
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
            this.txt_name = new System.Windows.Forms.MaskedTextBox();
            this.btn_determineIncome = new System.Windows.Forms.Button();
            this.txt_TotalIncome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.btn_determineIncome);
            this.panel1.Controls.Add(this.txt_TotalIncome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 234);
            this.panel1.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(233, 64);
            this.txt_name.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLL";
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(157, 26);
            this.txt_name.TabIndex = 5;
            // 
            // btn_determineIncome
            // 
            this.btn_determineIncome.Location = new System.Drawing.Point(108, 166);
            this.btn_determineIncome.Name = "btn_determineIncome";
            this.btn_determineIncome.Size = new System.Drawing.Size(254, 27);
            this.btn_determineIncome.TabIndex = 4;
            this.btn_determineIncome.Text = "Determine Total Income";
            this.btn_determineIncome.UseVisualStyleBackColor = true;
            this.btn_determineIncome.Click += new System.EventHandler(this.Btn_determineIncome_Click);
            // 
            // txt_TotalIncome
            // 
            this.txt_TotalIncome.Location = new System.Drawing.Point(233, 107);
            this.txt_TotalIncome.Name = "txt_TotalIncome";
            this.txt_TotalIncome.ReadOnly = true;
            this.txt_TotalIncome.Size = new System.Drawing.Size(157, 26);
            this.txt_TotalIncome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Income:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // frmIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 258);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmIncome";
            this.Text = "Income";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.FormClosing += ClosingDialogue;
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txt_name;
        private System.Windows.Forms.Button btn_determineIncome;
        private System.Windows.Forms.TextBox txt_TotalIncome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

