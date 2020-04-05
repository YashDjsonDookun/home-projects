namespace ClassPractice1
{
    partial class frmTemperature
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
            this.btnCalculateTemp = new System.Windows.Forms.Button();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDepth = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCelsius = new System.Windows.Forms.Label();
            this.lblFarenheit = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.txtFarenheit = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculateTemp
            // 
            this.btnCalculateTemp.Location = new System.Drawing.Point(164, 190);
            this.btnCalculateTemp.Name = "btnCalculateTemp";
            this.btnCalculateTemp.Size = new System.Drawing.Size(122, 23);
            this.btnCalculateTemp.TabIndex = 8;
            this.btnCalculateTemp.Text = "Calculate Temperature";
            this.btnCalculateTemp.UseVisualStyleBackColor = true;
            this.btnCalculateTemp.Click += new System.EventHandler(this.BtnCalculateTemp_Click);
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(183, 136);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(203, 20);
            this.txtDepth.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(433, 39);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Temperature Inside Earth";
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepth.Location = new System.Drawing.Point(70, 138);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(103, 18);
            this.lblDepth.TabIndex = 5;
            this.lblDepth.Text = "Enter a depth: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFarenheit);
            this.groupBox1.Controls.Add(this.txtCelsius);
            this.groupBox1.Controls.Add(this.lblFarenheit);
            this.groupBox1.Controls.Add(this.lblCelsius);
            this.groupBox1.Location = new System.Drawing.Point(73, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 93);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature ";
            this.groupBox1.Visible = false;
            // 
            // lblCelsius
            // 
            this.lblCelsius.AutoSize = true;
            this.lblCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsius.Location = new System.Drawing.Point(20, 28);
            this.lblCelsius.Name = "lblCelsius";
            this.lblCelsius.Size = new System.Drawing.Size(92, 18);
            this.lblCelsius.TabIndex = 0;
            this.lblCelsius.Text = "In Celsius: ";
            // 
            // lblFarenheit
            // 
            this.lblFarenheit.AutoSize = true;
            this.lblFarenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarenheit.Location = new System.Drawing.Point(20, 55);
            this.lblFarenheit.Name = "lblFarenheit";
            this.lblFarenheit.Size = new System.Drawing.Size(101, 18);
            this.lblFarenheit.TabIndex = 1;
            this.lblFarenheit.Text = "In Farenheit:";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(131, 25);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.ReadOnly = true;
            this.txtCelsius.Size = new System.Drawing.Size(182, 20);
            this.txtCelsius.TabIndex = 2;
            // 
            // txtFarenheit
            // 
            this.txtFarenheit.Location = new System.Drawing.Point(131, 51);
            this.txtFarenheit.Name = "txtFarenheit";
            this.txtFarenheit.ReadOnly = true;
            this.txtFarenheit.Size = new System.Drawing.Size(182, 20);
            this.txtFarenheit.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(183, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 407);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculateTemp);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDepth);
            this.Name = "frmTemperature";
            this.Text = "Temperature Inside the Earth";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalculateTemp;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFarenheit;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Label lblFarenheit;
        private System.Windows.Forms.Label lblCelsius;
        private System.Windows.Forms.Button btnExit;
    }
}