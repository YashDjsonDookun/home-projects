namespace Question1_LoginForm
{
    partial class Question7_carCoverPt1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optRiot = new System.Windows.Forms.CheckBox();
            this.optTheft = new System.Windows.Forms.CheckBox();
            this.optFire = new System.Windows.Forms.CheckBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.sumInsuredInput = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sum Insured:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optFire);
            this.groupBox1.Controls.Add(this.optTheft);
            this.groupBox1.Controls.Add(this.optRiot);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(107, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Additional Benefits";
            // 
            // optRiot
            // 
            this.optRiot.AutoSize = true;
            this.optRiot.Location = new System.Drawing.Point(40, 29);
            this.optRiot.Name = "optRiot";
            this.optRiot.Size = new System.Drawing.Size(112, 22);
            this.optRiot.TabIndex = 0;
            this.optRiot.Text = "Riot ($ 2000)";
            this.optRiot.UseVisualStyleBackColor = true;
            // 
            // optTheft
            // 
            this.optTheft.AutoSize = true;
            this.optTheft.Location = new System.Drawing.Point(40, 52);
            this.optTheft.Name = "optTheft";
            this.optTheft.Size = new System.Drawing.Size(118, 22);
            this.optTheft.TabIndex = 1;
            this.optTheft.Text = "Theft ($ 4500)";
            this.optTheft.UseVisualStyleBackColor = true;
            // 
            // optFire
            // 
            this.optFire.AutoSize = true;
            this.optFire.Location = new System.Drawing.Point(40, 75);
            this.optFire.Name = "optFire";
            this.optFire.Size = new System.Drawing.Size(110, 22);
            this.optFire.TabIndex = 2;
            this.optFire.Text = "Fire ($ 3750)";
            this.optFire.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(164, 203);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(93, 28);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(104, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Premium:";
            // 
            // sumInsuredInput
            // 
            this.sumInsuredInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumInsuredInput.Location = new System.Drawing.Point(220, 31);
            this.sumInsuredInput.Name = "sumInsuredInput";
            this.sumInsuredInput.Size = new System.Drawing.Size(87, 24);
            this.sumInsuredInput.TabIndex = 4;
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(220, 255);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(87, 24);
            this.output.TabIndex = 5;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Question7_carCoverPt1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 325);
            this.Controls.Add(this.output);
            this.Controls.Add(this.sumInsuredInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Question7_carCoverPt1";
            this.Text = "Question7_carCoverPt1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox optFire;
        private System.Windows.Forms.CheckBox optTheft;
        private System.Windows.Forms.CheckBox optRiot;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sumInsuredInput;
        private System.Windows.Forms.TextBox output;
    }
}