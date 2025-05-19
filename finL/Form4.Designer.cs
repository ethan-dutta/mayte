namespace finL
{
    partial class Form4
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
            this.menu = new System.Windows.Forms.Button();
            this.lesson2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.functions = new System.Windows.Forms.Button();
            this.mainscope = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Location = new System.Drawing.Point(3, 3);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(128, 29);
            this.menu.TabIndex = 0;
            this.menu.Tag = "menu";
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // lesson2
            // 
            this.lesson2.AutoSize = true;
            this.lesson2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lesson2.Location = new System.Drawing.Point(150, 10);
            this.lesson2.Name = "lesson2";
            this.lesson2.Size = new System.Drawing.Size(465, 55);
            this.lesson2.TabIndex = 2;
            this.lesson2.Tag = "lesson2";
            this.lesson2.Text = "Lesson 2: Variables";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.functions, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mainscope, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menu, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(629, 235);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(134, 105);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // functions
            // 
            this.functions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functions.Location = new System.Drawing.Point(3, 74);
            this.functions.Name = "functions";
            this.functions.Size = new System.Drawing.Size(128, 28);
            this.functions.TabIndex = 3;
            this.functions.Tag = "functions";
            this.functions.Text = "Functions";
            this.functions.UseVisualStyleBackColor = true;
            this.functions.Click += new System.EventHandler(this.functions_Click);
            // 
            // mainscope
            // 
            this.mainscope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainscope.Location = new System.Drawing.Point(3, 39);
            this.mainscope.Name = "mainscope";
            this.mainscope.Size = new System.Drawing.Size(128, 29);
            this.mainscope.TabIndex = 0;
            this.mainscope.Tag = "mainscope";
            this.mainscope.Text = "Main Scope";
            this.mainscope.UseVisualStyleBackColor = true;
            this.mainscope.Click += new System.EventHandler(this.mainscope_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(378, 316);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 4;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lesson2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Label lesson2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button functions;
        private System.Windows.Forms.Button mainscope;
        private System.Windows.Forms.Button test;
    }
}