namespace ClassPractice1
{
    partial class frmCircleArea
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
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnCalculateArea = new System.Windows.Forms.Button();
            this.lblCalculatedArea = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadius.Location = new System.Drawing.Point(65, 116);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(107, 18);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Enter a radius: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(95, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(271, 39);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Area of a Circle";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(178, 114);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(203, 20);
            this.txtRadius.TabIndex = 2;
            // 
            // btnCalculateArea
            // 
            this.btnCalculateArea.Location = new System.Drawing.Point(159, 168);
            this.btnCalculateArea.Name = "btnCalculateArea";
            this.btnCalculateArea.Size = new System.Drawing.Size(122, 23);
            this.btnCalculateArea.TabIndex = 3;
            this.btnCalculateArea.Text = "Calculate Area";
            this.btnCalculateArea.UseVisualStyleBackColor = true;
            this.btnCalculateArea.Click += new System.EventHandler(this.BtnCalculateArea_Click);
            // 
            // lblCalculatedArea
            // 
            this.lblCalculatedArea.AutoSize = true;
            this.lblCalculatedArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculatedArea.Location = new System.Drawing.Point(99, 233);
            this.lblCalculatedArea.Name = "lblCalculatedArea";
            this.lblCalculatedArea.Size = new System.Drawing.Size(121, 18);
            this.lblCalculatedArea.TabIndex = 4;
            this.lblCalculatedArea.Text = "lblCalculatedArea";
            this.lblCalculatedArea.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(306, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmCircleArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 308);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCalculatedArea);
            this.Controls.Add(this.btnCalculateArea);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRadius);
            this.Name = "frmCircleArea";
            this.Text = "Area of Circle";
            this.Load += new System.EventHandler(this.CircleArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnCalculateArea;
        private System.Windows.Forms.Label lblCalculatedArea;
        private System.Windows.Forms.Button btnExit;
    }
}

