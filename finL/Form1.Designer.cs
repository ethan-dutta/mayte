namespace finL
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
            this.mainscope = new System.Windows.Forms.Button();
            this.csharpcoding = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.functions = new System.Windows.Forms.Button();
            this.variables = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainscope
            // 
            this.mainscope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainscope.Location = new System.Drawing.Point(3, 3);
            this.mainscope.Name = "mainscope";
            this.mainscope.Size = new System.Drawing.Size(128, 30);
            this.mainscope.TabIndex = 0;
            this.mainscope.Tag = "mainscope";
            this.mainscope.Text = "Main Scope";
            this.mainscope.UseVisualStyleBackColor = true;
            this.mainscope.Click += new System.EventHandler(this.mainscope_Click);
            // 
            // csharpcoding
            // 
            this.csharpcoding.AutoSize = true;
            this.csharpcoding.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csharpcoding.Location = new System.Drawing.Point(180, 10);
            this.csharpcoding.Name = "csharpcoding";
            this.csharpcoding.Size = new System.Drawing.Size(478, 66);
            this.csharpcoding.TabIndex = 1;
            this.csharpcoding.Tag = "csharpcoding";
            this.csharpcoding.Text = "C# Coding Basics!";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.functions, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.variables, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mainscope, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(626, 224);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(134, 105);
            this.tableLayoutPanel1.TabIndex = 2;
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
            // variables
            // 
            this.variables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variables.Location = new System.Drawing.Point(3, 39);
            this.variables.Name = "variables";
            this.variables.Size = new System.Drawing.Size(128, 29);
            this.variables.TabIndex = 3;
            this.variables.Tag = "variables";
            this.variables.Text = "Variables";
            this.variables.UseVisualStyleBackColor = true;
            this.variables.Click += new System.EventHandler(this.variables_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.csharpcoding);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainscope;
        private System.Windows.Forms.Label csharpcoding;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button functions;
        private System.Windows.Forms.Button variables;
    }
}

