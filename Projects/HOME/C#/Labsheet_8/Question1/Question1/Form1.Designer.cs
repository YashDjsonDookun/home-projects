namespace Question1
{
    partial class Dental_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_regular = new System.Windows.Forms.RadioButton();
            this.rad_visiting = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_cleaning = new System.Windows.Forms.CheckBox();
            this.chk_filling = new System.Windows.Forms.CheckBox();
            this.chk_xray = new System.Windows.Forms.CheckBox();
            this.txt_cleaning = new System.Windows.Forms.TextBox();
            this.txt_filling = new System.Windows.Forms.TextBox();
            this.txt_xray = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_total);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 381);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dental Payment Form";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_visiting);
            this.groupBox1.Controls.Add(this.rad_regular);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rad_regular
            // 
            this.rad_regular.AutoSize = true;
            this.rad_regular.Location = new System.Drawing.Point(40, 21);
            this.rad_regular.Name = "rad_regular";
            this.rad_regular.Size = new System.Drawing.Size(74, 20);
            this.rad_regular.TabIndex = 0;
            this.rad_regular.TabStop = true;
            this.rad_regular.Text = "Regular";
            this.rad_regular.UseVisualStyleBackColor = true;
            this.rad_regular.Click += FormLoad;
            // 
            // rad_visiting
            // 
            this.rad_visiting.AutoSize = true;
            this.rad_visiting.Location = new System.Drawing.Point(40, 47);
            this.rad_visiting.Name = "rad_visiting";
            this.rad_visiting.Size = new System.Drawing.Size(69, 20);
            this.rad_visiting.TabIndex = 1;
            this.rad_visiting.TabStop = true;
            this.rad_visiting.Text = "Visiting";
            this.rad_visiting.UseVisualStyleBackColor = true;
            this.rad_visiting.Click += FormLoad;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_xray);
            this.groupBox2.Controls.Add(this.txt_filling);
            this.groupBox2.Controls.Add(this.txt_cleaning);
            this.groupBox2.Controls.Add(this.chk_xray);
            this.groupBox2.Controls.Add(this.chk_filling);
            this.groupBox2.Controls.Add(this.chk_cleaning);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(34, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Treatment";
            // 
            // chk_cleaning
            // 
            this.chk_cleaning.AutoSize = true;
            this.chk_cleaning.Location = new System.Drawing.Point(6, 32);
            this.chk_cleaning.Name = "chk_cleaning";
            this.chk_cleaning.Size = new System.Drawing.Size(80, 20);
            this.chk_cleaning.TabIndex = 0;
            this.chk_cleaning.Text = "Cleaning";
            this.chk_cleaning.UseVisualStyleBackColor = true;
            this.chk_cleaning.Click += FormLoad;
            // 
            // chk_filling
            // 
            this.chk_filling.AutoSize = true;
            this.chk_filling.Location = new System.Drawing.Point(6, 60);
            this.chk_filling.Name = "chk_filling";
            this.chk_filling.Size = new System.Drawing.Size(102, 20);
            this.chk_filling.TabIndex = 1;
            this.chk_filling.Text = "Cavity Filling";
            this.chk_filling.UseVisualStyleBackColor = true;
            this.chk_filling.Click += FormLoad;
            // 
            // chk_xray
            // 
            this.chk_xray.AutoSize = true;
            this.chk_xray.Location = new System.Drawing.Point(6, 88);
            this.chk_xray.Name = "chk_xray";
            this.chk_xray.Size = new System.Drawing.Size(64, 20);
            this.chk_xray.TabIndex = 2;
            this.chk_xray.Text = "X-Ray";
            this.chk_xray.UseVisualStyleBackColor = true;
            this.chk_xray.Click += FormLoad;
            // 
            // txt_cleaning
            // 
            this.txt_cleaning.Location = new System.Drawing.Point(117, 30);
            this.txt_cleaning.Name = "txt_cleaning";
            this.txt_cleaning.ReadOnly = true;
            this.txt_cleaning.Size = new System.Drawing.Size(66, 22);
            this.txt_cleaning.TabIndex = 3;
            // 
            // txt_filling
            // 
            this.txt_filling.Location = new System.Drawing.Point(117, 60);
            this.txt_filling.Name = "txt_filling";
            this.txt_filling.ReadOnly = true;
            this.txt_filling.Size = new System.Drawing.Size(66, 22);
            this.txt_filling.TabIndex = 4;
            // 
            // txt_xray
            // 
            this.txt_xray.Location = new System.Drawing.Point(117, 88);
            this.txt_xray.Name = "txt_xray";
            this.txt_xray.ReadOnly = true;
            this.txt_xray.Size = new System.Drawing.Size(66, 22);
            this.txt_xray.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(151, 304);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(66, 20);
            this.txt_total.TabIndex = 6;
            // 
            // Dental_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 406);
            this.Controls.Add(this.panel1);
            this.Name = "Dental_Form";
            this.Text = "Dental Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.Load += FormLoad;
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_xray;
        private System.Windows.Forms.TextBox txt_filling;
        private System.Windows.Forms.TextBox txt_cleaning;
        private System.Windows.Forms.CheckBox chk_xray;
        private System.Windows.Forms.CheckBox chk_filling;
        private System.Windows.Forms.CheckBox chk_cleaning;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_visiting;
        private System.Windows.Forms.RadioButton rad_regular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label2;
    }
}

