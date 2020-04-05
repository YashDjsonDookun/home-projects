namespace ClassPractice1
{
    partial class Cylinder
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtR1 = new System.Windows.Forms.TextBox();
            this.txtH1 = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.lblR = new System.Windows.Forms.Label();
            this.lblR1 = new System.Windows.Forms.Label();
            this.lblH1 = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblValues = new System.Windows.Forms.Label();
            this.txtR2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(120, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(234, 29);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Volume of Cylinder";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(140, 303);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(132, 23);
            this.btnCalculate.TabIndex = 22;
            this.btnCalculate.Text = "Calculate Volume";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(93, 171);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 20);
            this.txtR.TabIndex = 21;
            // 
            // txtR1
            // 
            this.txtR1.Location = new System.Drawing.Point(93, 231);
            this.txtR1.Name = "txtR1";
            this.txtR1.Size = new System.Drawing.Size(100, 20);
            this.txtR1.TabIndex = 20;
            // 
            // txtH1
            // 
            this.txtH1.Location = new System.Drawing.Point(93, 202);
            this.txtH1.Name = "txtH1";
            this.txtH1.Size = new System.Drawing.Size(100, 20);
            this.txtH1.TabIndex = 19;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(93, 142);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(100, 20);
            this.txtH.TabIndex = 18;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(66, 178);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(13, 13);
            this.lblR.TabIndex = 17;
            this.lblR.Text = "r:";
            // 
            // lblR1
            // 
            this.lblR1.AutoSize = true;
            this.lblR1.Location = new System.Drawing.Point(66, 238);
            this.lblR1.Name = "lblR1";
            this.lblR1.Size = new System.Drawing.Size(19, 13);
            this.lblR1.TabIndex = 16;
            this.lblR1.Text = "r1:";
            // 
            // lblH1
            // 
            this.lblH1.AutoSize = true;
            this.lblH1.Location = new System.Drawing.Point(66, 209);
            this.lblH1.Name = "lblH1";
            this.lblH1.Size = new System.Drawing.Size(22, 13);
            this.lblH1.TabIndex = 15;
            this.lblH1.Text = "h1:";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(66, 149);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(16, 13);
            this.lblH.TabIndex = 14;
            this.lblH.Text = "h:";
            // 
            // lblValues
            // 
            this.lblValues.AutoSize = true;
            this.lblValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValues.Location = new System.Drawing.Point(16, 90);
            this.lblValues.Name = "lblValues";
            this.lblValues.Size = new System.Drawing.Size(136, 18);
            this.lblValues.TabIndex = 13;
            this.lblValues.Text = "Input values below: ";
            // 
            // txtR2
            // 
            this.txtR2.Location = new System.Drawing.Point(93, 257);
            this.txtR2.Name = "txtR2";
            this.txtR2.Size = new System.Drawing.Size(100, 20);
            this.txtR2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "r2:";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(66, 368);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(144, 13);
            this.lblVolume.TabIndex = 27;
            this.lblVolume.Text = "Volume of Concrete required:";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(216, 361);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.ReadOnly = true;
            this.txtVolume.Size = new System.Drawing.Size(100, 20);
            this.txtVolume.TabIndex = 28;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(344, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Cylinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtR2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtR1);
            this.Controls.Add(this.txtH1);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblR1);
            this.Controls.Add(this.lblH1);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblValues);
            this.Name = "Cylinder";
            this.Text = "Cylinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtR1;
        private System.Windows.Forms.TextBox txtH1;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblR1;
        private System.Windows.Forms.Label lblH1;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblValues;
        private System.Windows.Forms.TextBox txtR2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Button btnExit;
    }
}