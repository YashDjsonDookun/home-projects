namespace Hypotenuse
{
    partial class RightTriangle
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
            this.Hypotenuse = new System.Windows.Forms.Panel();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.txt_hypotenuse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Hypotenuse.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hypotenuse
            // 
            this.Hypotenuse.Controls.Add(this.label3);
            this.Hypotenuse.Controls.Add(this.label2);
            this.Hypotenuse.Controls.Add(this.label1);
            this.Hypotenuse.Controls.Add(this.txt_hypotenuse);
            this.Hypotenuse.Controls.Add(this.btn_calc);
            this.Hypotenuse.Controls.Add(this.txt_b);
            this.Hypotenuse.Controls.Add(this.txt_a);
            this.Hypotenuse.Location = new System.Drawing.Point(12, 12);
            this.Hypotenuse.Name = "Hypotenuse";
            this.Hypotenuse.Size = new System.Drawing.Size(643, 340);
            this.Hypotenuse.TabIndex = 0;
            // 
            // txt_a
            // 
            this.txt_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a.Location = new System.Drawing.Point(153, 56);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(193, 26);
            this.txt_a.TabIndex = 0;
            // 
            // txt_b
            // 
            this.txt_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_b.Location = new System.Drawing.Point(153, 116);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(193, 26);
            this.txt_b.TabIndex = 1;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(153, 172);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(193, 35);
            this.btn_calc.TabIndex = 2;
            this.btn_calc.Text = "Calculate Hypotenuse";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.Btn_calc_Click);
            // 
            // txt_hypotenuse
            // 
            this.txt_hypotenuse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hypotenuse.Location = new System.Drawing.Point(153, 235);
            this.txt_hypotenuse.Name = "txt_hypotenuse";
            this.txt_hypotenuse.ReadOnly = true;
            this.txt_hypotenuse.Size = new System.Drawing.Size(193, 26);
            this.txt_hypotenuse.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter side a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter side b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hypotenuse:";
            // 
            // RightTriangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 364);
            this.Controls.Add(this.Hypotenuse);
            this.Name = "RightTriangle";
            this.Text = "Right Triangle";
            this.Hypotenuse.ResumeLayout(false);
            this.Hypotenuse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Hypotenuse;
        private System.Windows.Forms.TextBox txt_hypotenuse;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

