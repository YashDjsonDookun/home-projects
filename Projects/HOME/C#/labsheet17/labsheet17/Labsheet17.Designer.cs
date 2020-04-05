namespace labsheet17
{
    partial class Labsheet17
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
            this.btnQuestion1 = new System.Windows.Forms.Button();
            this.btnQuestion2 = new System.Windows.Forms.Button();
            this.btnQuestion3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQuestion1
            // 
            this.btnQuestion1.Location = new System.Drawing.Point(44, 33);
            this.btnQuestion1.Name = "btnQuestion1";
            this.btnQuestion1.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion1.TabIndex = 0;
            this.btnQuestion1.Text = "Question 1";
            this.btnQuestion1.UseVisualStyleBackColor = true;
            this.btnQuestion1.Click += new System.EventHandler(this.btnQuestion1_Click);
            // 
            // btnQuestion2
            // 
            this.btnQuestion2.Location = new System.Drawing.Point(44, 79);
            this.btnQuestion2.Name = "btnQuestion2";
            this.btnQuestion2.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion2.TabIndex = 1;
            this.btnQuestion2.Text = "Question 2";
            this.btnQuestion2.UseVisualStyleBackColor = true;
            this.btnQuestion2.Click += new System.EventHandler(this.btnQuestion2_Click);
            // 
            // btnQuestion3
            // 
            this.btnQuestion3.Location = new System.Drawing.Point(44, 130);
            this.btnQuestion3.Name = "btnQuestion3";
            this.btnQuestion3.Size = new System.Drawing.Size(75, 23);
            this.btnQuestion3.TabIndex = 2;
            this.btnQuestion3.Text = "Question 3";
            this.btnQuestion3.UseVisualStyleBackColor = true;
            this.btnQuestion3.Click += new System.EventHandler(this.btnQuestion3_Click);
            // 
            // Labsheet17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 272);
            this.Controls.Add(this.btnQuestion3);
            this.Controls.Add(this.btnQuestion2);
            this.Controls.Add(this.btnQuestion1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(524, 311);
            this.MinimumSize = new System.Drawing.Size(524, 311);
            this.Name = "Labsheet17";
            this.Text = "Labsheet17";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuestion1;
        private System.Windows.Forms.Button btnQuestion2;
        private System.Windows.Forms.Button btnQuestion3;
    }
}