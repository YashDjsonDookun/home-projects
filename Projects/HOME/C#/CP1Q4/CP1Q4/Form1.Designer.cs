namespace CP1Q4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.xOneInput = new System.Windows.Forms.TextBox();
            this.yOneInput = new System.Windows.Forms.TextBox();
            this.xTwoInput = new System.Windows.Forms.TextBox();
            this.yTwoInput = new System.Windows.Forms.TextBox();
            this.Coord1 = new System.Windows.Forms.Label();
            this.Coord2 = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.Output = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Output);
            this.groupBox1.Controls.Add(this.CalculateBtn);
            this.groupBox1.Controls.Add(this.Coord2);
            this.groupBox1.Controls.Add(this.Coord1);
            this.groupBox1.Controls.Add(this.yTwoInput);
            this.groupBox1.Controls.Add(this.xTwoInput);
            this.groupBox1.Controls.Add(this.yOneInput);
            this.groupBox1.Controls.Add(this.xOneInput);
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinates";
            // 
            // xOneInput
            // 
            this.xOneInput.Location = new System.Drawing.Point(263, 66);
            this.xOneInput.Name = "xOneInput";
            this.xOneInput.Size = new System.Drawing.Size(52, 20);
            this.xOneInput.TabIndex = 0;
            this.xOneInput.Text = "X1";
            this.xOneInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yOneInput
            // 
            this.yOneInput.Location = new System.Drawing.Point(351, 66);
            this.yOneInput.Name = "yOneInput";
            this.yOneInput.Size = new System.Drawing.Size(52, 20);
            this.yOneInput.TabIndex = 1;
            this.yOneInput.Text = "Y1";
            this.yOneInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xTwoInput
            // 
            this.xTwoInput.Location = new System.Drawing.Point(263, 118);
            this.xTwoInput.Name = "xTwoInput";
            this.xTwoInput.Size = new System.Drawing.Size(52, 20);
            this.xTwoInput.TabIndex = 2;
            this.xTwoInput.Text = "X2";
            this.xTwoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yTwoInput
            // 
            this.yTwoInput.Location = new System.Drawing.Point(351, 118);
            this.yTwoInput.Name = "yTwoInput";
            this.yTwoInput.Size = new System.Drawing.Size(52, 20);
            this.yTwoInput.TabIndex = 3;
            this.yTwoInput.Text = "Y2";
            this.yTwoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Coord1
            // 
            this.Coord1.AutoSize = true;
            this.Coord1.Location = new System.Drawing.Point(182, 73);
            this.Coord1.Name = "Coord1";
            this.Coord1.Size = new System.Drawing.Size(44, 13);
            this.Coord1.TabIndex = 4;
            this.Coord1.Text = "Coord1:";
            // 
            // Coord2
            // 
            this.Coord2.AutoSize = true;
            this.Coord2.Location = new System.Drawing.Point(182, 121);
            this.Coord2.Name = "Coord2";
            this.Coord2.Size = new System.Drawing.Size(44, 13);
            this.Coord2.TabIndex = 5;
            this.Coord2.Text = "Coord2:";
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(263, 185);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(142, 57);
            this.CalculateBtn.TabIndex = 6;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(185, 286);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(312, 81);
            this.Output.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label Coord2;
        private System.Windows.Forms.Label Coord1;
        private System.Windows.Forms.TextBox yTwoInput;
        private System.Windows.Forms.TextBox xTwoInput;
        private System.Windows.Forms.TextBox yOneInput;
        private System.Windows.Forms.TextBox xOneInput;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

