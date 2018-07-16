namespace AdoPart22
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductNameBox = new System.Windows.Forms.TextBox();
            this.ProductPriceBox = new System.Windows.Forms.TextBox();
            this.CategoryNameBox = new System.Windows.Forms.TextBox();
            this.ProductCategoryBox = new System.Windows.Forms.ComboBox();
            this.AddProductBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.AddCategoryBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.AddCategoryBtn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CategoryNameBox);
            this.panel1.Location = new System.Drawing.Point(407, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 426);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.AddProductBtn);
            this.panel2.Controls.Add(this.ProductCategoryBox);
            this.panel2.Controls.Add(this.ProductPriceBox);
            this.panel2.Controls.Add(this.ProductNameBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 426);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Category";
            // 
            // ProductNameBox
            // 
            this.ProductNameBox.Location = new System.Drawing.Point(122, 27);
            this.ProductNameBox.Name = "ProductNameBox";
            this.ProductNameBox.Size = new System.Drawing.Size(241, 20);
            this.ProductNameBox.TabIndex = 1;
            // 
            // ProductPriceBox
            // 
            this.ProductPriceBox.Location = new System.Drawing.Point(122, 69);
            this.ProductPriceBox.Name = "ProductPriceBox";
            this.ProductPriceBox.Size = new System.Drawing.Size(241, 20);
            this.ProductPriceBox.TabIndex = 1;
            // 
            // CategoryNameBox
            // 
            this.CategoryNameBox.Location = new System.Drawing.Point(137, 27);
            this.CategoryNameBox.Name = "CategoryNameBox";
            this.CategoryNameBox.Size = new System.Drawing.Size(231, 20);
            this.CategoryNameBox.TabIndex = 1;
            this.CategoryNameBox.TextChanged += new System.EventHandler(this.CategoryNameBox_TextChanged);
            // 
            // ProductCategoryBox
            // 
            this.ProductCategoryBox.FormattingEnabled = true;
            this.ProductCategoryBox.Location = new System.Drawing.Point(122, 115);
            this.ProductCategoryBox.Name = "ProductCategoryBox";
            this.ProductCategoryBox.Size = new System.Drawing.Size(241, 21);
            this.ProductCategoryBox.TabIndex = 2;
            // 
            // AddProductBtn
            // 
            this.AddProductBtn.Location = new System.Drawing.Point(265, 151);
            this.AddProductBtn.Name = "AddProductBtn";
            this.AddProductBtn.Size = new System.Drawing.Size(98, 22);
            this.AddProductBtn.TabIndex = 3;
            this.AddProductBtn.Text = "Add Product";
            this.AddProductBtn.UseVisualStyleBackColor = true;
            this.AddProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Category Name";
            // 
            // AddCategoryBtn
            // 
            this.AddCategoryBtn.Location = new System.Drawing.Point(249, 65);
            this.AddCategoryBtn.Name = "AddCategoryBtn";
            this.AddCategoryBtn.Size = new System.Drawing.Size(119, 26);
            this.AddCategoryBtn.TabIndex = 3;
            this.AddCategoryBtn.Text = "Add Category";
            this.AddCategoryBtn.UseVisualStyleBackColor = true;
            this.AddCategoryBtn.Click += new System.EventHandler(this.AddCategoryBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(20, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 185);
            this.panel3.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Show Product";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Show Categories";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 162);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(356, 252);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddCategoryBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CategoryNameBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddProductBtn;
        private System.Windows.Forms.ComboBox ProductCategoryBox;
        private System.Windows.Forms.TextBox ProductPriceBox;
        private System.Windows.Forms.TextBox ProductNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

