namespace ClassPractice1
{
    partial class frmStartUP
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
            this.btnQ1 = new System.Windows.Forms.Button();
            this.btnQ3 = new System.Windows.Forms.Button();
            this.btnQ2 = new System.Windows.Forms.Button();
            this.btnQ4 = new System.Windows.Forms.Button();
            this.btnQ5 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQ1
            // 
            this.btnQ1.Location = new System.Drawing.Point(121, 97);
            this.btnQ1.Name = "btnQ1";
            this.btnQ1.Size = new System.Drawing.Size(147, 23);
            this.btnQ1.TabIndex = 0;
            this.btnQ1.Text = "Launch Question 1";
            this.btnQ1.UseVisualStyleBackColor = true;
            this.btnQ1.Click += new System.EventHandler(this.BtnQ1_Click);
            // 
            // btnQ3
            // 
            this.btnQ3.Location = new System.Drawing.Point(121, 155);
            this.btnQ3.Name = "btnQ3";
            this.btnQ3.Size = new System.Drawing.Size(147, 23);
            this.btnQ3.TabIndex = 1;
            this.btnQ3.Text = "Launch Question 3";
            this.btnQ3.UseVisualStyleBackColor = true;
            this.btnQ3.Click += new System.EventHandler(this.BtnQ3_Click);
            // 
            // btnQ2
            // 
            this.btnQ2.Location = new System.Drawing.Point(121, 126);
            this.btnQ2.Name = "btnQ2";
            this.btnQ2.Size = new System.Drawing.Size(147, 23);
            this.btnQ2.TabIndex = 2;
            this.btnQ2.Text = "Launch Question 2";
            this.btnQ2.UseVisualStyleBackColor = true;
            this.btnQ2.Click += new System.EventHandler(this.BtnQ2_Click);
            // 
            // btnQ4
            // 
            this.btnQ4.Location = new System.Drawing.Point(121, 184);
            this.btnQ4.Name = "btnQ4";
            this.btnQ4.Size = new System.Drawing.Size(147, 23);
            this.btnQ4.TabIndex = 3;
            this.btnQ4.Text = "Launch Question 4";
            this.btnQ4.UseVisualStyleBackColor = true;
            this.btnQ4.Click += new System.EventHandler(this.BtnQ4_Click);
            // 
            // btnQ5
            // 
            this.btnQ5.Location = new System.Drawing.Point(121, 213);
            this.btnQ5.Name = "btnQ5";
            this.btnQ5.Size = new System.Drawing.Size(147, 23);
            this.btnQ5.TabIndex = 4;
            this.btnQ5.Text = "Launch Question 5";
            this.btnQ5.UseVisualStyleBackColor = true;
            this.btnQ5.Click += new System.EventHandler(this.BtnQ5_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(117, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 24);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Class Practice 1";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(121, 242);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmStartUP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 296);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnQ5);
            this.Controls.Add(this.btnQ4);
            this.Controls.Add(this.btnQ2);
            this.Controls.Add(this.btnQ3);
            this.Controls.Add(this.btnQ1);
            this.Name = "frmStartUP";
            this.Text = "StartUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQ1;
        private System.Windows.Forms.Button btnQ3;
        private System.Windows.Forms.Button btnQ2;
        private System.Windows.Forms.Button btnQ4;
        private System.Windows.Forms.Button btnQ5;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
    }
}