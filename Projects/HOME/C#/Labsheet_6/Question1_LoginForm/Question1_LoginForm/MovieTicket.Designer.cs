namespace Question1_LoginForm
{
    partial class MovieTicket
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
            this.childrenInput = new System.Windows.Forms.TextBox();
            this.adultInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.optEvening = new System.Windows.Forms.RadioButton();
            this.optAfternoon = new System.Windows.Forms.RadioButton();
            this.optMorning = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.TextBox();
            this.btn_Calc = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(90, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Ticket Dispenser";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.childrenInput);
            this.groupBox1.Controls.Add(this.adultInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tickets Required";
            // 
            // childrenInput
            // 
            this.childrenInput.Location = new System.Drawing.Point(100, 77);
            this.childrenInput.Name = "childrenInput";
            this.childrenInput.Size = new System.Drawing.Size(71, 22);
            this.childrenInput.TabIndex = 3;
            // 
            // adultInput
            // 
            this.adultInput.Location = new System.Drawing.Point(100, 36);
            this.adultInput.Name = "adultInput";
            this.adultInput.Size = new System.Drawing.Size(71, 22);
            this.adultInput.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Children:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adults:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.optEvening);
            this.groupBox2.Controls.Add(this.optAfternoon);
            this.groupBox2.Controls.Add(this.optMorning);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(261, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 116);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Session";
            // 
            // optEvening
            // 
            this.optEvening.AutoSize = true;
            this.optEvening.Location = new System.Drawing.Point(29, 79);
            this.optEvening.Name = "optEvening";
            this.optEvening.Size = new System.Drawing.Size(75, 20);
            this.optEvening.TabIndex = 2;
            this.optEvening.TabStop = true;
            this.optEvening.Text = "Evening";
            this.optEvening.UseVisualStyleBackColor = true;
            // 
            // optAfternoon
            // 
            this.optAfternoon.AutoSize = true;
            this.optAfternoon.Location = new System.Drawing.Point(29, 53);
            this.optAfternoon.Name = "optAfternoon";
            this.optAfternoon.Size = new System.Drawing.Size(83, 20);
            this.optAfternoon.TabIndex = 1;
            this.optAfternoon.TabStop = true;
            this.optAfternoon.Text = "Afternoon";
            this.optAfternoon.UseVisualStyleBackColor = true;
            // 
            // optMorning
            // 
            this.optMorning.AutoSize = true;
            this.optMorning.Location = new System.Drawing.Point(29, 27);
            this.optMorning.Name = "optMorning";
            this.optMorning.Size = new System.Drawing.Size(74, 20);
            this.optMorning.TabIndex = 0;
            this.optMorning.TabStop = true;
            this.optMorning.Text = "Morning";
            this.optMorning.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Due:";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(142, 261);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(92, 20);
            this.output.TabIndex = 4;
            // 
            // btn_Calc
            // 
            this.btn_Calc.Location = new System.Drawing.Point(75, 305);
            this.btn_Calc.Name = "btn_Calc";
            this.btn_Calc.Size = new System.Drawing.Size(93, 24);
            this.btn_Calc.TabIndex = 5;
            this.btn_Calc.Text = "Calculate";
            this.btn_Calc.UseVisualStyleBackColor = true;
            this.btn_Calc.Click += new System.EventHandler(this.Btn_Calc_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(191, 305);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(93, 24);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(314, 305);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(93, 24);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // MovieTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(443, 363);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calc);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MovieTicket";
            this.Text = "MovieTicket";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton optEvening;
        private System.Windows.Forms.RadioButton optAfternoon;
        private System.Windows.Forms.RadioButton optMorning;
        private System.Windows.Forms.TextBox childrenInput;
        private System.Windows.Forms.TextBox adultInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button btn_Calc;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
    }
}