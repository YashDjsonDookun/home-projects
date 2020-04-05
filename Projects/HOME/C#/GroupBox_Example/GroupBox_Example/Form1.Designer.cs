namespace GroupBox_Example
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
            this.PresidentGroup = new System.Windows.Forms.GroupBox();
            this.KennedyBtn = new System.Windows.Forms.RadioButton();
            this.NixonButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.PresidentGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // PresidentGroup
            // 
            this.PresidentGroup.Controls.Add(this.NixonButton);
            this.PresidentGroup.Controls.Add(this.KennedyBtn);
            this.PresidentGroup.Location = new System.Drawing.Point(13, 13);
            this.PresidentGroup.Name = "PresidentGroup";
            this.PresidentGroup.Size = new System.Drawing.Size(274, 123);
            this.PresidentGroup.TabIndex = 0;
            this.PresidentGroup.TabStop = false;
            this.PresidentGroup.Text = "President";
            // 
            // KennedyBtn
            // 
            this.KennedyBtn.AutoSize = true;
            this.KennedyBtn.Location = new System.Drawing.Point(92, 32);
            this.KennedyBtn.Name = "KennedyBtn";
            this.KennedyBtn.Size = new System.Drawing.Size(67, 17);
            this.KennedyBtn.TabIndex = 0;
            this.KennedyBtn.TabStop = true;
            this.KennedyBtn.Text = "Kennedy";
            this.KennedyBtn.UseVisualStyleBackColor = true;
            // 
            // NixonButton
            // 
            this.NixonButton.AutoSize = true;
            this.NixonButton.Location = new System.Drawing.Point(92, 79);
            this.NixonButton.Name = "NixonButton";
            this.NixonButton.Size = new System.Drawing.Size(52, 17);
            this.NixonButton.TabIndex = 1;
            this.NixonButton.TabStop = true;
            this.NixonButton.Text = "Nixon";
            this.NixonButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "CastVote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(13, 205);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(274, 20);
            this.output.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 237);
            this.Controls.Add(this.output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PresidentGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PresidentGroup.ResumeLayout(false);
            this.PresidentGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PresidentGroup;
        private System.Windows.Forms.RadioButton NixonButton;
        private System.Windows.Forms.RadioButton KennedyBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox output;
    }
}

