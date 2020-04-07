namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numberBox = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.deleteAll = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.squared = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.solution = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.changeSymbol = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDouble = new System.Windows.Forms.Button();
            this.numberBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // numberBox
            // 
            this.numberBox.AcceptsReturn = true;
            this.numberBox.BackColor = System.Drawing.SystemColors.Window;
            this.numberBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberBox.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.numberBox.Font = new System.Drawing.Font("Maiandra GD", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numberBox.Location = new System.Drawing.Point(156, 24);
            this.numberBox.Name = "numberBox";
            this.numberBox.ReadOnly = true;
            this.numberBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numberBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.numberBox.Size = new System.Drawing.Size(313, 45);
            this.numberBox.TabIndex = 0;
            this.numberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.delete.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(12, 83);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(112, 94);
            this.delete.TabIndex = 1;
            this.delete.Text = "CE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.deleteAll.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAll.Location = new System.Drawing.Point(130, 83);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(112, 94);
            this.deleteAll.TabIndex = 3;
            this.deleteAll.Text = "C";
            this.deleteAll.UseVisualStyleBackColor = false;
            this.deleteAll.Click += new System.EventHandler(this.Form1_Load);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.divide.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide.Location = new System.Drawing.Point(366, 83);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(112, 94);
            this.divide.TabIndex = 4;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // squared
            // 
            this.squared.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.squared.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squared.Location = new System.Drawing.Point(248, 83);
            this.squared.Name = "squared";
            this.squared.Size = new System.Drawing.Size(112, 94);
            this.squared.TabIndex = 17;
            this.squared.Text = " x²";
            this.squared.UseVisualStyleBackColor = false;
            this.squared.Click += new System.EventHandler(this.squared_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.multiply.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(366, 183);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(112, 94);
            this.multiply.TabIndex = 21;
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.minus.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus.Location = new System.Drawing.Point(366, 283);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(112, 94);
            this.minus.TabIndex = 22;
            this.minus.Text = "–";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.plus.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.Location = new System.Drawing.Point(366, 383);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(112, 94);
            this.plus.TabIndex = 23;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // solution
            // 
            this.solution.BackColor = System.Drawing.SystemColors.ControlDark;
            this.solution.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solution.Location = new System.Drawing.Point(366, 483);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(112, 94);
            this.solution.TabIndex = 24;
            this.solution.Text = "=";
            this.solution.UseVisualStyleBackColor = false;
            this.solution.Click += new System.EventHandler(this.solution_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button7.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(12, 183);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 94);
            this.button7.TabIndex = 25;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button8.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(130, 183);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(112, 94);
            this.button8.TabIndex = 26;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button9.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(248, 183);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 94);
            this.button9.TabIndex = 27;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button6.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(248, 283);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 94);
            this.button6.TabIndex = 28;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button5.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(130, 283);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 94);
            this.button5.TabIndex = 29;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button4.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 94);
            this.button4.TabIndex = 30;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button1.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 94);
            this.button1.TabIndex = 31;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(130, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 94);
            this.button2.TabIndex = 32;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button3.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(248, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 94);
            this.button3.TabIndex = 33;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // changeSymbol
            // 
            this.changeSymbol.BackColor = System.Drawing.SystemColors.MenuBar;
            this.changeSymbol.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeSymbol.Location = new System.Drawing.Point(12, 483);
            this.changeSymbol.Name = "changeSymbol";
            this.changeSymbol.Size = new System.Drawing.Size(112, 94);
            this.changeSymbol.TabIndex = 34;
            this.changeSymbol.Text = "+/-";
            this.changeSymbol.UseVisualStyleBackColor = false;
            this.changeSymbol.Click += new System.EventHandler(this.changeSymbol_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button0.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(130, 483);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(112, 94);
            this.button0.TabIndex = 35;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonDouble
            // 
            this.buttonDouble.BackColor = System.Drawing.SystemColors.MenuBar;
            this.buttonDouble.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDouble.Location = new System.Drawing.Point(248, 483);
            this.buttonDouble.Name = "buttonDouble";
            this.buttonDouble.Size = new System.Drawing.Size(112, 94);
            this.buttonDouble.TabIndex = 36;
            this.buttonDouble.Text = ",";
            this.buttonDouble.UseVisualStyleBackColor = false;
            this.buttonDouble.Click += new System.EventHandler(this.buttonDouble_Click);
            // 
            // numberBox2
            // 
            this.numberBox2.AcceptsReturn = true;
            this.numberBox2.AcceptsTab = true;
            this.numberBox2.AllowDrop = true;
            this.numberBox2.BackColor = System.Drawing.SystemColors.Window;
            this.numberBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberBox2.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.numberBox2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numberBox2.Location = new System.Drawing.Point(21, 49);
            this.numberBox2.Name = "numberBox2";
            this.numberBox2.ReadOnly = true;
            this.numberBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numberBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.numberBox2.Size = new System.Drawing.Size(129, 20);
            this.numberBox2.TabIndex = 37;
            this.numberBox2.WordWrap = false;
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(464, 65);
            this.textBox1.TabIndex = 38;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(492, 591);
            this.Controls.Add(this.numberBox2);
            this.Controls.Add(this.numberBox);
            this.Controls.Add(this.buttonDouble);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.changeSymbol);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.squared);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberBox;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button deleteAll;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button squared;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button solution;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button changeSymbol;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDouble;
        private System.Windows.Forms.TextBox numberBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

