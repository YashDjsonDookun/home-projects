namespace Question1_LoginForm
{
    partial class Question10_IceCream
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.priceOut = new System.Windows.Forms.TextBox();
            this.optChoco = new System.Windows.Forms.RadioButton();
            this.optVanilla = new System.Windows.Forms.RadioButton();
            this.optStrawberry = new System.Windows.Forms.RadioButton();
            this.optSmall = new System.Windows.Forms.RadioButton();
            this.optLarge = new System.Windows.Forms.RadioButton();
            this.chkChoco = new System.Windows.Forms.CheckBox();
            this.chkCookies = new System.Windows.Forms.CheckBox();
            this.chkNuts = new System.Windows.Forms.CheckBox();
            this.chkFruits = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zimis Ice Cream";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optStrawberry);
            this.groupBox1.Controls.Add(this.optVanilla);
            this.groupBox1.Controls.Add(this.optChoco);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flavour";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optLarge);
            this.groupBox2.Controls.Add(this.optSmall);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 227);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(162, 87);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkFruits);
            this.groupBox3.Controls.Add(this.chkNuts);
            this.groupBox3.Controls.Add(this.chkCookies);
            this.groupBox3.Controls.Add(this.chkChoco);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(235, 94);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 220);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add-Ons";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price:";
            // 
            // priceOut
            // 
            this.priceOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceOut.Location = new System.Drawing.Point(135, 339);
            this.priceOut.Name = "priceOut";
            this.priceOut.ReadOnly = true;
            this.priceOut.Size = new System.Drawing.Size(176, 26);
            this.priceOut.TabIndex = 4;
            // 
            // optChoco
            // 
            this.optChoco.AutoSize = true;
            this.optChoco.Location = new System.Drawing.Point(25, 23);
            this.optChoco.Name = "optChoco";
            this.optChoco.Size = new System.Drawing.Size(94, 22);
            this.optChoco.TabIndex = 0;
            this.optChoco.TabStop = true;
            this.optChoco.Text = "Chocolate";
            this.optChoco.UseVisualStyleBackColor = true;
            this.optChoco.CheckedChanged += new System.EventHandler(this.OptChoco_CheckedChanged);
            // 
            // optVanilla
            // 
            this.optVanilla.AutoSize = true;
            this.optVanilla.Location = new System.Drawing.Point(25, 51);
            this.optVanilla.Name = "optVanilla";
            this.optVanilla.Size = new System.Drawing.Size(68, 22);
            this.optVanilla.TabIndex = 1;
            this.optVanilla.TabStop = true;
            this.optVanilla.Text = "Vanilla";
            this.optVanilla.UseVisualStyleBackColor = true;
            this.optVanilla.CheckedChanged += new System.EventHandler(this.OptVanilla_CheckedChanged);
            // 
            // optStrawberry
            // 
            this.optStrawberry.AutoSize = true;
            this.optStrawberry.Location = new System.Drawing.Point(25, 79);
            this.optStrawberry.Name = "optStrawberry";
            this.optStrawberry.Size = new System.Drawing.Size(97, 22);
            this.optStrawberry.TabIndex = 2;
            this.optStrawberry.TabStop = true;
            this.optStrawberry.Text = "Strawberry";
            this.optStrawberry.UseVisualStyleBackColor = true;
            this.optStrawberry.CheckedChanged += new System.EventHandler(this.OptStrawberry_CheckedChanged);
            // 
            // optSmall
            // 
            this.optSmall.AutoSize = true;
            this.optSmall.Location = new System.Drawing.Point(25, 23);
            this.optSmall.Name = "optSmall";
            this.optSmall.Size = new System.Drawing.Size(63, 22);
            this.optSmall.TabIndex = 3;
            this.optSmall.TabStop = true;
            this.optSmall.Text = "Small";
            this.optSmall.UseVisualStyleBackColor = true;
            this.optSmall.CheckedChanged += new System.EventHandler(this.OptSmall_CheckedChanged);
            // 
            // optLarge
            // 
            this.optLarge.AutoSize = true;
            this.optLarge.Location = new System.Drawing.Point(25, 51);
            this.optLarge.Name = "optLarge";
            this.optLarge.Size = new System.Drawing.Size(63, 22);
            this.optLarge.TabIndex = 4;
            this.optLarge.TabStop = true;
            this.optLarge.Text = "Large";
            this.optLarge.UseVisualStyleBackColor = true;
            this.optLarge.CheckedChanged += new System.EventHandler(this.OptLarge_CheckedChanged);
            // 
            // chkChoco
            // 
            this.chkChoco.AutoSize = true;
            this.chkChoco.Location = new System.Drawing.Point(37, 36);
            this.chkChoco.Name = "chkChoco";
            this.chkChoco.Size = new System.Drawing.Size(137, 22);
            this.chkChoco.TabIndex = 0;
            this.chkChoco.Text = "Chocolate Chips";
            this.chkChoco.UseVisualStyleBackColor = true;
            this.chkChoco.CheckedChanged += new System.EventHandler(this.ChkChoco_CheckedChanged);
            // 
            // chkCookies
            // 
            this.chkCookies.AutoSize = true;
            this.chkCookies.Location = new System.Drawing.Point(37, 79);
            this.chkCookies.Name = "chkCookies";
            this.chkCookies.Size = new System.Drawing.Size(149, 22);
            this.chkCookies.TabIndex = 1;
            this.chkCookies.Text = "Cookies  & Candies";
            this.chkCookies.UseVisualStyleBackColor = true;
            this.chkCookies.CheckedChanged += new System.EventHandler(this.ChkCookies_CheckedChanged);
            // 
            // chkNuts
            // 
            this.chkNuts.AutoSize = true;
            this.chkNuts.Location = new System.Drawing.Point(37, 123);
            this.chkNuts.Name = "chkNuts";
            this.chkNuts.Size = new System.Drawing.Size(58, 22);
            this.chkNuts.TabIndex = 2;
            this.chkNuts.Text = "Nuts";
            this.chkNuts.UseVisualStyleBackColor = true;
            this.chkNuts.CheckedChanged += new System.EventHandler(this.ChkNuts_CheckedChanged);
            // 
            // chkFruits
            // 
            this.chkFruits.AutoSize = true;
            this.chkFruits.Location = new System.Drawing.Point(37, 172);
            this.chkFruits.Name = "chkFruits";
            this.chkFruits.Size = new System.Drawing.Size(106, 22);
            this.chkFruits.TabIndex = 3;
            this.chkFruits.Text = "Fresh Fruits";
            this.chkFruits.UseVisualStyleBackColor = true;
            this.chkFruits.CheckedChanged += new System.EventHandler(this.ChkFruits_CheckedChanged);
            // 
            // Question10_IceCream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 394);
            this.Controls.Add(this.priceOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Question10_IceCream";
            this.Text = "Question10_IceCream";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optStrawberry;
        private System.Windows.Forms.RadioButton optVanilla;
        private System.Windows.Forms.RadioButton optChoco;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optLarge;
        private System.Windows.Forms.RadioButton optSmall;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkFruits;
        private System.Windows.Forms.CheckBox chkNuts;
        private System.Windows.Forms.CheckBox chkCookies;
        private System.Windows.Forms.CheckBox chkChoco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox priceOut;
    }
}