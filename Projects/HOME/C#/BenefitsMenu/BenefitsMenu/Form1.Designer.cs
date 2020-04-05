namespace BenefitsMenu
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
            this.DrugChk = new System.Windows.Forms.CheckBox();
            this.DentalChk = new System.Windows.Forms.CheckBox();
            this.VisionChk = new System.Windows.Forms.CheckBox();
            this.MedicalChk = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DrugChk
            // 
            this.DrugChk.AutoSize = true;
            this.DrugChk.Location = new System.Drawing.Point(30, 12);
            this.DrugChk.Name = "DrugChk";
            this.DrugChk.Size = new System.Drawing.Size(173, 17);
            this.DrugChk.TabIndex = 0;
            this.DrugChk.Text = "Prescription Drug Plan ($39.15)";
            this.DrugChk.UseVisualStyleBackColor = true;
            // 
            // DentalChk
            // 
            this.DentalChk.AutoSize = true;
            this.DentalChk.Location = new System.Drawing.Point(30, 35);
            this.DentalChk.Name = "DentalChk";
            this.DentalChk.Size = new System.Drawing.Size(123, 17);
            this.DentalChk.TabIndex = 1;
            this.DentalChk.Text = "Dental Plan ($10.81)";
            this.DentalChk.UseVisualStyleBackColor = true;
            // 
            // VisionChk
            // 
            this.VisionChk.AutoSize = true;
            this.VisionChk.Location = new System.Drawing.Point(30, 58);
            this.VisionChk.Name = "VisionChk";
            this.VisionChk.Size = new System.Drawing.Size(114, 17);
            this.VisionChk.TabIndex = 2;
            this.VisionChk.Text = "Vision Plan ($2.25)";
            this.VisionChk.UseVisualStyleBackColor = true;
            // 
            // MedicalChk
            // 
            this.MedicalChk.AutoSize = true;
            this.MedicalChk.Location = new System.Drawing.Point(30, 81);
            this.MedicalChk.Name = "MedicalChk";
            this.MedicalChk.Size = new System.Drawing.Size(129, 17);
            this.MedicalChk.TabIndex = 3;
            this.MedicalChk.Text = "Medical Plan ($55.52)";
            this.MedicalChk.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Determine Total Monthly Cost";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Monthly Cost: ";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(135, 153);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(68, 20);
            this.output.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 175);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MedicalChk);
            this.Controls.Add(this.VisionChk);
            this.Controls.Add(this.DentalChk);
            this.Controls.Add(this.DrugChk);
            this.Name = "Form1";
            this.Text = "Benefits Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DrugChk;
        private System.Windows.Forms.CheckBox DentalChk;
        private System.Windows.Forms.CheckBox VisionChk;
        private System.Windows.Forms.CheckBox MedicalChk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox output;
    }
}

