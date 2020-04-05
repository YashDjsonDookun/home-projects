namespace Question2ptB
{
    partial class Fruit_List
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_selectedItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addItem = new System.Windows.Forms.Button();
            this.txt_addItem = new System.Windows.Forms.TextBox();
            this.lst_fruitList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_selectedItem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.lst_fruitList);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 364);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "[To delete an Item:\r\ndouble-Click on it]";
            // 
            // txt_selectedItem
            // 
            this.txt_selectedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_selectedItem.Location = new System.Drawing.Point(25, 290);
            this.txt_selectedItem.Name = "txt_selectedItem";
            this.txt_selectedItem.Size = new System.Drawing.Size(155, 29);
            this.txt_selectedItem.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected Item:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addItem);
            this.groupBox1.Controls.Add(this.txt_addItem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(209, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 197);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Item";
            // 
            // btn_addItem
            // 
            this.btn_addItem.Location = new System.Drawing.Point(60, 105);
            this.btn_addItem.Name = "btn_addItem";
            this.btn_addItem.Size = new System.Drawing.Size(127, 60);
            this.btn_addItem.TabIndex = 1;
            this.btn_addItem.Text = "Add";
            this.btn_addItem.UseVisualStyleBackColor = true;
            this.btn_addItem.Click += Btn_addItem_Click;
            // 
            // txt_addItem
            // 
            this.txt_addItem.Location = new System.Drawing.Point(38, 48);
            this.txt_addItem.Name = "txt_addItem";
            this.txt_addItem.Size = new System.Drawing.Size(167, 29);
            this.txt_addItem.TabIndex = 0;
            // 
            // lst_fruitList
            // 
            this.lst_fruitList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst_fruitList.FormattingEnabled = true;
            this.lst_fruitList.ItemHeight = 24;
            this.lst_fruitList.Items.AddRange(new object[] {
            "guava",
            "mango",
            "orange",
            "peach",
            "pineapple"});
            this.lst_fruitList.Location = new System.Drawing.Point(25, 38);
            this.lst_fruitList.Name = "lst_fruitList";
            this.lst_fruitList.Size = new System.Drawing.Size(155, 196);
            this.lst_fruitList.TabIndex = 0;
            this.lst_fruitList.Click += DisplaySelectedItem;
            this.lst_fruitList.DoubleClick += RemoveSelectedItem;
            // 
            // Fruit_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 387);
            this.Controls.Add(this.panel1);
            this.Name = "Fruit_List";
            this.Text = "Fruit List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_selectedItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_addItem;
        private System.Windows.Forms.TextBox txt_addItem;
        private System.Windows.Forms.ListBox lst_fruitList;
    }
}

