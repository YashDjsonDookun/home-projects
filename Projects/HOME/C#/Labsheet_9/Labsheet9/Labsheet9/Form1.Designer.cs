namespace Labsheet9
{
    partial class Labsheet9
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
            this.btn_Question1 = new System.Windows.Forms.Button();
            this.btn_Question2 = new System.Windows.Forms.Button();
            this.btn_Question3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Question3);
            this.panel1.Controls.Add(this.btn_Question2);
            this.panel1.Controls.Add(this.btn_Question1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 351);
            this.panel1.TabIndex = 0;
            // 
            // btn_Question1
            // 
            this.btn_Question1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Question1.Location = new System.Drawing.Point(169, 60);
            this.btn_Question1.Name = "btn_Question1";
            this.btn_Question1.Size = new System.Drawing.Size(201, 47);
            this.btn_Question1.TabIndex = 0;
            this.btn_Question1.Text = "Question 1";
            this.btn_Question1.UseVisualStyleBackColor = true;
            this.btn_Question1.Click += new System.EventHandler(this.Btn_Question1_Click);
            // 
            // btn_Question2
            // 
            this.btn_Question2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Question2.Location = new System.Drawing.Point(169, 145);
            this.btn_Question2.Name = "btn_Question2";
            this.btn_Question2.Size = new System.Drawing.Size(201, 47);
            this.btn_Question2.TabIndex = 1;
            this.btn_Question2.Text = "Question 2";
            this.btn_Question2.UseVisualStyleBackColor = true;
            this.btn_Question2.Click += new System.EventHandler(this.Btn_Question2_Click);
            // 
            // btn_Question3
            // 
            this.btn_Question3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Question3.Location = new System.Drawing.Point(169, 231);
            this.btn_Question3.Name = "btn_Question3";
            this.btn_Question3.Size = new System.Drawing.Size(201, 47);
            this.btn_Question3.TabIndex = 2;
            this.btn_Question3.Text = "Question 3";
            this.btn_Question3.UseVisualStyleBackColor = true;
            this.btn_Question3.Click += new System.EventHandler(this.Btn_Question3_Click);
            // 
            // Labsheet9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 376);
            this.Controls.Add(this.panel1);
            this.Name = "Labsheet9";
            this.Text = "Labsheet 9";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Question3;
        private System.Windows.Forms.Button btn_Question2;
        private System.Windows.Forms.Button btn_Question1;
    }
}

