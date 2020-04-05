namespace CP1Q5
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Cylinder = new System.Windows.Forms.GroupBox();
            this.calculateH = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.radiusR = new System.Windows.Forms.TextBox();
            this.heightH = new System.Windows.Forms.TextBox();
            this.rTwo = new System.Windows.Forms.TextBox();
            this.hTwo = new System.Windows.Forms.TextBox();
            this.rOne = new System.Windows.Forms.TextBox();
            this.hOne = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Cylinder.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cylinder
            // 
            this.Cylinder.Controls.Add(this.label11);
            this.Cylinder.Controls.Add(this.label10);
            this.Cylinder.Controls.Add(this.label9);
            this.Cylinder.Controls.Add(this.label8);
            this.Cylinder.Controls.Add(this.label7);
            this.Cylinder.Controls.Add(this.label6);
            this.Cylinder.Controls.Add(this.calculateH);
            this.Cylinder.Controls.Add(this.label5);
            this.Cylinder.Controls.Add(this.label4);
            this.Cylinder.Controls.Add(this.label3);
            this.Cylinder.Controls.Add(this.label2);
            this.Cylinder.Controls.Add(this.label1);
            this.Cylinder.Controls.Add(this.output);
            this.Cylinder.Controls.Add(this.radiusR);
            this.Cylinder.Controls.Add(this.heightH);
            this.Cylinder.Controls.Add(this.rTwo);
            this.Cylinder.Controls.Add(this.hTwo);
            this.Cylinder.Controls.Add(this.rOne);
            this.Cylinder.Controls.Add(this.hOne);
            this.Cylinder.Location = new System.Drawing.Point(12, 12);
            this.Cylinder.Name = "Cylinder";
            this.Cylinder.Size = new System.Drawing.Size(776, 426);
            this.Cylinder.TabIndex = 0;
            this.Cylinder.TabStop = false;
            this.Cylinder.Text = "Cylinder";
            // 
            // calculateH
            // 
            this.calculateH.Location = new System.Drawing.Point(287, 269);
            this.calculateH.Name = "calculateH";
            this.calculateH.Size = new System.Drawing.Size(233, 69);
            this.calculateH.TabIndex = 12;
            this.calculateH.Text = "Calculate Volume";
            this.calculateH.UseVisualStyleBackColor = true;
            this.calculateH.Click += new System.EventHandler(this.CalculateH_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Volume of Concrete Required: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Radius, r:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Height, h: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Larger Cylinder (h2, r2):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Smaller Cylinder (h1, r1):";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(367, 361);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(123, 20);
            this.output.TabIndex = 6;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radiusR
            // 
            this.radiusR.Location = new System.Drawing.Point(367, 222);
            this.radiusR.Name = "radiusR";
            this.radiusR.Size = new System.Drawing.Size(62, 20);
            this.radiusR.TabIndex = 5;
            this.radiusR.Text = "r";
            this.radiusR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // heightH
            // 
            this.heightH.Location = new System.Drawing.Point(367, 170);
            this.heightH.Name = "heightH";
            this.heightH.ReadOnly = true;
            this.heightH.Size = new System.Drawing.Size(62, 20);
            this.heightH.TabIndex = 4;
            this.heightH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rTwo
            // 
            this.rTwo.Location = new System.Drawing.Point(486, 114);
            this.rTwo.Name = "rTwo";
            this.rTwo.Size = new System.Drawing.Size(62, 20);
            this.rTwo.TabIndex = 3;
            this.rTwo.Text = "r2";
            this.rTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hTwo
            // 
            this.hTwo.Location = new System.Drawing.Point(360, 114);
            this.hTwo.Name = "hTwo";
            this.hTwo.Size = new System.Drawing.Size(62, 20);
            this.hTwo.TabIndex = 2;
            this.hTwo.Text = "h2";
            this.hTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rOne
            // 
            this.rOne.Location = new System.Drawing.Point(486, 66);
            this.rOne.Name = "rOne";
            this.rOne.Size = new System.Drawing.Size(62, 20);
            this.rOne.TabIndex = 1;
            this.rOne.Text = "r1";
            this.rOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hOne
            // 
            this.hOne.Location = new System.Drawing.Point(360, 66);
            this.hOne.Name = "hOne";
            this.hOne.Size = new System.Drawing.Size(62, 20);
            this.hOne.TabIndex = 0;
            this.hOne.Text = "h1";
            this.hOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "m";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(428, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "m";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(435, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "m";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "m";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(554, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "m";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(554, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "m";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cylinder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Cylinder.ResumeLayout(false);
            this.Cylinder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox Cylinder;
        private System.Windows.Forms.TextBox hTwo;
        private System.Windows.Forms.TextBox rOne;
        private System.Windows.Forms.TextBox hOne;
        private System.Windows.Forms.TextBox rTwo;
        private System.Windows.Forms.TextBox heightH;
        private System.Windows.Forms.Button calculateH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.TextBox radiusR;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

