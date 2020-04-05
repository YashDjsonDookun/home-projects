namespace ClassPractice1
{
    partial class frmFuel
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
            this.lblEstimatedCost = new System.Windows.Forms.Label();
            this.lblLitresNeeded = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtCostLitre = new System.Windows.Forms.TextBox();
            this.txtKmPerLItre = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblCostLitre = new System.Windows.Forms.Label();
            this.lblKilometre = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblTrip = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEstimatedCost);
            this.groupBox1.Controls.Add(this.lblLitresNeeded);
            this.groupBox1.Location = new System.Drawing.Point(23, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculations";
            this.groupBox1.Visible = false;
            // 
            // lblEstimatedCost
            // 
            this.lblEstimatedCost.AutoSize = true;
            this.lblEstimatedCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimatedCost.Location = new System.Drawing.Point(18, 58);
            this.lblEstimatedCost.Name = "lblEstimatedCost";
            this.lblEstimatedCost.Size = new System.Drawing.Size(120, 18);
            this.lblEstimatedCost.TabIndex = 1;
            this.lblEstimatedCost.Text = "lblEstimatedCost";
            // 
            // lblLitresNeeded
            // 
            this.lblLitresNeeded.AutoSize = true;
            this.lblLitresNeeded.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLitresNeeded.Location = new System.Drawing.Point(18, 29);
            this.lblLitresNeeded.Name = "lblLitresNeeded";
            this.lblLitresNeeded.Size = new System.Drawing.Size(109, 18);
            this.lblLitresNeeded.TabIndex = 0;
            this.lblLitresNeeded.Text = "lblLitresNeeded";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(123, 237);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(132, 23);
            this.btnCalculate.TabIndex = 21;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtCostLitre
            // 
            this.txtCostLitre.Location = new System.Drawing.Point(212, 187);
            this.txtCostLitre.Name = "txtCostLitre";
            this.txtCostLitre.Size = new System.Drawing.Size(100, 20);
            this.txtCostLitre.TabIndex = 19;
            // 
            // txtKmPerLItre
            // 
            this.txtKmPerLItre.Location = new System.Drawing.Point(212, 165);
            this.txtKmPerLItre.Name = "txtKmPerLItre";
            this.txtKmPerLItre.Size = new System.Drawing.Size(100, 20);
            this.txtKmPerLItre.TabIndex = 18;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(212, 142);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 17;
            // 
            // lblCostLitre
            // 
            this.lblCostLitre.AutoSize = true;
            this.lblCostLitre.Location = new System.Drawing.Point(41, 190);
            this.lblCostLitre.Name = "lblCostLitre";
            this.lblCostLitre.Size = new System.Drawing.Size(139, 13);
            this.lblCostLitre.TabIndex = 16;
            this.lblCostLitre.Text = "Average Cost of 1 Lt of Fuel";
            // 
            // lblKilometre
            // 
            this.lblKilometre.AutoSize = true;
            this.lblKilometre.Location = new System.Drawing.Point(41, 168);
            this.lblKilometre.Name = "lblKilometre";
            this.lblKilometre.Size = new System.Drawing.Size(104, 13);
            this.lblKilometre.TabIndex = 14;
            this.lblKilometre.Text = "Km per litre estimate:";
            this.lblKilometre.Click += new System.EventHandler(this.LblX2_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(41, 145);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(113, 13);
            this.lblDistance.TabIndex = 13;
            this.lblDistance.Text = "Distance of Trip in km:";
            // 
            // lblTrip
            // 
            this.lblTrip.AutoSize = true;
            this.lblTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrip.Location = new System.Drawing.Point(20, 108);
            this.lblTrip.Name = "lblTrip";
            this.lblTrip.Size = new System.Drawing.Size(179, 18);
            this.lblTrip.TabIndex = 12;
            this.lblTrip.Text = "Enter the following details:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(100, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 25);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Cost of a Trip";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(286, 399);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmFuel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtCostLitre);
            this.Controls.Add(this.txtKmPerLItre);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblCostLitre);
            this.Controls.Add(this.lblKilometre);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblTrip);
            this.Name = "frmFuel";
            this.Text = "Fuel";
            this.Load += new System.EventHandler(this.FrmFuel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEstimatedCost;
        private System.Windows.Forms.Label lblLitresNeeded;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtCostLitre;
        private System.Windows.Forms.TextBox txtKmPerLItre;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblCostLitre;
        private System.Windows.Forms.Label lblKilometre;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblTrip;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
    }
}