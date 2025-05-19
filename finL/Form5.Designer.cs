namespace finL
{
    partial class Form5
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
            this.lesson3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.variables = new System.Windows.Forms.Button();
            this.mainscope = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lesson3
            // 
            this.lesson3.AutoSize = true;
            this.lesson3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lesson3.Location = new System.Drawing.Point(150, 10);
            this.lesson3.Name = "lesson3";
            this.lesson3.Size = new System.Drawing.Size(473, 55);
            this.lesson3.TabIndex = 2;
            this.lesson3.Tag = "lesson3";
            this.lesson3.Text = "Lesson 3: Functions";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.variables, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mainscope, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menu, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(629, 235);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(134, 105);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // variables
            // 
            this.variables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variables.Location = new System.Drawing.Point(3, 74);
            this.variables.Name = "variables";
            this.variables.Size = new System.Drawing.Size(128, 28);
            this.variables.TabIndex = 3;
            this.variables.Tag = "variables";
            this.variables.Text = "Variables";
            this.variables.UseVisualStyleBackColor = true;
            this.variables.Click += new System.EventHandler(this.variables_Click);
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
            // test
            // 
            this.test.Location = new System.Drawing.Point(373, 316);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 5;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lesson3);
            this.Name = "Form5";
            this.Text = "Form5";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lesson3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button variables;
        private System.Windows.Forms.Button mainscope;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button test;
    }
}