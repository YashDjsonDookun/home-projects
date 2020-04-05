namespace Question5
{
    partial class Question5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstStates = new System.Windows.Forms.ListBox();
            this.lstSorted = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lstSorted);
            this.panel1.Controls.Add(this.lstStates);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 332);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "States:";
            // 
            // lstStates
            // 
            this.lstStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStates.FormattingEnabled = true;
            this.lstStates.ItemHeight = 18;
            this.lstStates.Items.AddRange(new object[] {
            "Delaware",
            "Pennsylvania",
            "New Jersey",
            "Georgia",
            "Connecticut",
            "Massachusetts",
            "Maryland",
            "South Carolina",
            "New Hampshire",
            "Virginia",
            "New York",
            "North Carolina",
            "Rhode Island",
            "Vermont",
            "Kentucky",
            "Tennessee",
            "Ohio",
            "Louisiana",
            "Indiana",
            "Mississippi",
            "Illinois",
            "Alabama",
            "Maine",
            "Missouri",
            "Arkansas",
            "Michigan",
            "Florida",
            "Texas",
            "Iowa",
            "Wisconsin",
            "California",
            "Minnesota",
            "Oregon",
            "Kansas",
            "West Virginia",
            "Nevada",
            "Nebraska",
            "Colorado",
            "North Dakota",
            "South Dakota",
            "Montana",
            "Washington",
            "Idaho",
            "Wyoming",
            "Utah",
            "Oklahoma",
            "New Mexico",
            "Arizona",
            "Alaska",
            "Hawaii "});
            this.lstStates.Location = new System.Drawing.Point(30, 39);
            this.lstStates.Name = "lstStates";
            this.lstStates.Size = new System.Drawing.Size(149, 256);
            this.lstStates.TabIndex = 1;
            // 
            // lstSorted
            // 
            this.lstSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSorted.FormattingEnabled = true;
            this.lstSorted.ItemHeight = 18;
            this.lstSorted.Location = new System.Drawing.Point(205, 111);
            this.lstSorted.Name = "lstSorted";
            this.lstSorted.Size = new System.Drawing.Size(129, 184);
            this.lstSorted.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(205, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Display Last Ten States";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Question5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 357);
            this.Controls.Add(this.panel1);
            this.Name = "Question5";
            this.Text = "Question 5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstSorted;
        private System.Windows.Forms.ListBox lstStates;
        private System.Windows.Forms.Label label1;
    }
}

