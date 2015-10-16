namespace Calculator
{
    partial class Calculator
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
        /// 
        private void InitializeComponent()
        {
            this.Input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.ClearC = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Mod = new System.Windows.Forms.Button();
            this.Reciprocal = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.Comma = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.AcceptsReturn = true;
            this.Input.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Input.Enabled = false;
            this.Input.Font = new System.Drawing.Font("Liberation Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Input.Location = new System.Drawing.Point(12, 12);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Input.Size = new System.Drawing.Size(200, 38);
            this.Input.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "MC";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(52, 57);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "MR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(94, 57);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "MS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(134, 57);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "M+";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(175, 57);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(37, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "M-";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 90);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(37, 29);
            this.Back.TabIndex = 6;
            this.Back.Text = "<-";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 123);
            this.b7.Margin = new System.Windows.Forms.Padding(2);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(37, 29);
            this.b7.TabIndex = 7;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.NumberClicked);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 156);
            this.b4.Margin = new System.Windows.Forms.Padding(2);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(37, 29);
            this.b4.TabIndex = 8;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.NumberClicked);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 189);
            this.b1.Margin = new System.Windows.Forms.Padding(2);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(37, 29);
            this.b1.TabIndex = 9;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.NumberClicked);
            // 
            // ClearC
            // 
            this.ClearC.Location = new System.Drawing.Point(53, 90);
            this.ClearC.Margin = new System.Windows.Forms.Padding(2);
            this.ClearC.Name = "ClearC";
            this.ClearC.Size = new System.Drawing.Size(37, 29);
            this.ClearC.TabIndex = 10;
            this.ClearC.Text = "CE";
            this.ClearC.UseVisualStyleBackColor = true;
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(53, 123);
            this.b8.Margin = new System.Windows.Forms.Padding(2);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(37, 29);
            this.b8.TabIndex = 11;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.NumberClicked);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(52, 156);
            this.b5.Margin = new System.Windows.Forms.Padding(2);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(37, 29);
            this.b5.TabIndex = 12;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.NumberClicked);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(53, 189);
            this.b2.Margin = new System.Windows.Forms.Padding(2);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(37, 29);
            this.b2.TabIndex = 13;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.NumberClicked);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(94, 90);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(37, 29);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(94, 123);
            this.b9.Margin = new System.Windows.Forms.Padding(2);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(37, 29);
            this.b9.TabIndex = 15;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.NumberClicked);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(94, 156);
            this.b6.Margin = new System.Windows.Forms.Padding(2);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(37, 29);
            this.b6.TabIndex = 16;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.NumberClicked);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(94, 189);
            this.b3.Margin = new System.Windows.Forms.Padding(2);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(37, 29);
            this.b3.TabIndex = 17;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.NumberClicked);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(134, 90);
            this.Info.Margin = new System.Windows.Forms.Padding(2);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(37, 29);
            this.Info.TabIndex = 18;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(134, 123);
            this.Divide.Margin = new System.Windows.Forms.Padding(2);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(37, 29);
            this.Divide.TabIndex = 19;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Operate);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(134, 156);
            this.Multiply.Margin = new System.Windows.Forms.Padding(2);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(37, 29);
            this.Multiply.TabIndex = 20;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Operate);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(134, 189);
            this.Minus.Margin = new System.Windows.Forms.Padding(2);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(37, 29);
            this.Minus.TabIndex = 21;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Operate);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(175, 90);
            this.Sqrt.Margin = new System.Windows.Forms.Padding(2);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(37, 29);
            this.Sqrt.TabIndex = 22;
            this.Sqrt.Text = "sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.Operate);
            // 
            // Mod
            // 
            this.Mod.Location = new System.Drawing.Point(175, 123);
            this.Mod.Margin = new System.Windows.Forms.Padding(2);
            this.Mod.Name = "Mod";
            this.Mod.Size = new System.Drawing.Size(37, 29);
            this.Mod.TabIndex = 23;
            this.Mod.Text = "%";
            this.Mod.UseVisualStyleBackColor = true;
            this.Mod.Click += new System.EventHandler(this.Operate);
            // 
            // Reciprocal
            // 
            this.Reciprocal.Location = new System.Drawing.Point(175, 156);
            this.Reciprocal.Margin = new System.Windows.Forms.Padding(2);
            this.Reciprocal.Name = "Reciprocal";
            this.Reciprocal.Size = new System.Drawing.Size(37, 29);
            this.Reciprocal.TabIndex = 24;
            this.Reciprocal.Text = "1/x";
            this.Reciprocal.UseVisualStyleBackColor = true;
            this.Reciprocal.Click += new System.EventHandler(this.Operate);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(134, 222);
            this.Plus.Margin = new System.Windows.Forms.Padding(2);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(37, 29);
            this.Plus.TabIndex = 26;
            this.Plus.Text = " +";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Operate);
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(175, 189);
            this.Result.Margin = new System.Windows.Forms.Padding(2);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(37, 62);
            this.Result.TabIndex = 27;
            this.Result.Text = "=";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Comma
            // 
            this.Comma.Location = new System.Drawing.Point(94, 222);
            this.Comma.Margin = new System.Windows.Forms.Padding(2);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(37, 29);
            this.Comma.TabIndex = 28;
            this.Comma.Text = ",";
            this.Comma.UseVisualStyleBackColor = true;
            this.Comma.Click += new System.EventHandler(this.Comma_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(12, 222);
            this.b0.Margin = new System.Windows.Forms.Padding(2);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(77, 29);
            this.b0.TabIndex = 29;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.NumberClicked);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 286);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.Comma);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Reciprocal);
            this.Controls.Add(this.Mod);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.ClearC);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Input);
            this.Name = "Calculator";
            this.Text = "MyCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button ClearC;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Mod;
        private System.Windows.Forms.Button Reciprocal;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Result;
        private System.Windows.Forms.Button Comma;
        private System.Windows.Forms.Button b0;
        public bool CommaClicked { set; get; }
    }
}

