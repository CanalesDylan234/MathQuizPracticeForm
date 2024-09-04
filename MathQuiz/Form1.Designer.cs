namespace MathQuiz
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
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeFont = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.equalLabel1 = new System.Windows.Forms.Label();
            this.plusLabel = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.timesLabel = new System.Windows.Forms.Label();
            this.equalLabel3 = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.divideLabel = new System.Windows.Forms.Label();
            this.equalLabel4 = new System.Windows.Forms.Label();
            this.divRightLabel = new System.Windows.Forms.Label();
            this.divLeftLabel = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.minusLabel = new System.Windows.Forms.Label();
            this.equalLabel2 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(268, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // timeFont
            // 
            this.timeFont.AutoSize = true;
            this.timeFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFont.Location = new System.Drawing.Point(155, 10);
            this.timeFont.Name = "timeFont";
            this.timeFont.Size = new System.Drawing.Size(107, 25);
            this.timeFont.TabIndex = 1;
            this.timeFont.Text = "Time Left!";
            this.timeFont.Click += new System.EventHandler(this.label1_Click);
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(50, 41);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(182, 41);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.plusRightLabel.TabIndex = 3;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalLabel1
            // 
            this.equalLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalLabel1.Location = new System.Drawing.Point(248, 41);
            this.equalLabel1.Name = "equalLabel1";
            this.equalLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equalLabel1.Size = new System.Drawing.Size(60, 50);
            this.equalLabel1.TabIndex = 4;
            this.equalLabel1.Text = "=";
            this.equalLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusLabel
            // 
            this.plusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLabel.Location = new System.Drawing.Point(116, 41);
            this.plusLabel.Name = "plusLabel";
            this.plusLabel.Size = new System.Drawing.Size(60, 50);
            this.plusLabel.TabIndex = 5;
            this.plusLabel.Text = "+";
            this.plusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sum.Location = new System.Drawing.Point(314, 50);
            this.Sum.MaximumSize = new System.Drawing.Size(100, 0);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(100, 35);
            this.Sum.TabIndex = 1;
            this.Sum.ValueChanged += new System.EventHandler(this.answer_Correct);
            this.Sum.Click += new System.EventHandler(this.answer_Enter);
            this.Sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(314, 191);
            this.product.MaximumSize = new System.Drawing.Size(100, 0);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(100, 35);
            this.product.TabIndex = 3;
            this.product.ValueChanged += new System.EventHandler(this.answer_Correct);
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // timesLabel
            // 
            this.timesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLabel.Location = new System.Drawing.Point(116, 182);
            this.timesLabel.Name = "timesLabel";
            this.timesLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLabel.TabIndex = 10;
            this.timesLabel.Text = " × ";
            this.timesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalLabel3
            // 
            this.equalLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalLabel3.Location = new System.Drawing.Point(248, 182);
            this.equalLabel3.Name = "equalLabel3";
            this.equalLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equalLabel3.Size = new System.Drawing.Size(60, 50);
            this.equalLabel3.TabIndex = 9;
            this.equalLabel3.Text = "=";
            this.equalLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesRightLabel.Location = new System.Drawing.Point(182, 182);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 8;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesLeftLabel.Location = new System.Drawing.Point(50, 182);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 7;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(314, 256);
            this.quotient.MaximumSize = new System.Drawing.Size(100, 0);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(100, 35);
            this.quotient.TabIndex = 4;
            this.quotient.ValueChanged += new System.EventHandler(this.answer_Correct);
            this.quotient.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // divideLabel
            // 
            this.divideLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideLabel.Location = new System.Drawing.Point(116, 247);
            this.divideLabel.Name = "divideLabel";
            this.divideLabel.Size = new System.Drawing.Size(60, 50);
            this.divideLabel.TabIndex = 15;
            this.divideLabel.Text = "÷";
            this.divideLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalLabel4
            // 
            this.equalLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalLabel4.Location = new System.Drawing.Point(248, 247);
            this.equalLabel4.Name = "equalLabel4";
            this.equalLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equalLabel4.Size = new System.Drawing.Size(60, 50);
            this.equalLabel4.TabIndex = 14;
            this.equalLabel4.Text = "=";
            this.equalLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divRightLabel
            // 
            this.divRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divRightLabel.Location = new System.Drawing.Point(182, 247);
            this.divRightLabel.Name = "divRightLabel";
            this.divRightLabel.Size = new System.Drawing.Size(60, 50);
            this.divRightLabel.TabIndex = 13;
            this.divRightLabel.Text = "?";
            this.divRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divLeftLabel
            // 
            this.divLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divLeftLabel.Location = new System.Drawing.Point(50, 247);
            this.divLeftLabel.Name = "divLeftLabel";
            this.divLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.divLeftLabel.TabIndex = 12;
            this.divLeftLabel.Text = "?";
            this.divLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(314, 121);
            this.difference.MaximumSize = new System.Drawing.Size(100, 0);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(100, 35);
            this.difference.TabIndex = 2;
            this.difference.ValueChanged += new System.EventHandler(this.answer_Correct);
            this.difference.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minusLabel
            // 
            this.minusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLabel.Location = new System.Drawing.Point(116, 112);
            this.minusLabel.Name = "minusLabel";
            this.minusLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLabel.TabIndex = 20;
            this.minusLabel.Text = "-";
            this.minusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalLabel2
            // 
            this.equalLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalLabel2.Location = new System.Drawing.Point(248, 112);
            this.equalLabel2.Name = "equalLabel2";
            this.equalLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.equalLabel2.Size = new System.Drawing.Size(60, 50);
            this.equalLabel2.TabIndex = 19;
            this.equalLabel2.Text = "=";
            this.equalLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(182, 112);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.minusRightLabel.TabIndex = 18;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(50, 112);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.minusLeftLabel.TabIndex = 17;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(160, 311);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(136, 34);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start the Quiz!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.minusLabel);
            this.Controls.Add(this.equalLabel2);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.divideLabel);
            this.Controls.Add(this.equalLabel4);
            this.Controls.Add(this.divRightLabel);
            this.Controls.Add(this.divLeftLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.timesLabel);
            this.Controls.Add(this.equalLabel3);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.plusLabel);
            this.Controls.Add(this.equalLabel1);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeFont);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeFont;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label equalLabel1;
        private System.Windows.Forms.Label plusLabel;
        private System.Windows.Forms.NumericUpDown Sum;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label timesLabel;
        private System.Windows.Forms.Label equalLabel3;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label divideLabel;
        private System.Windows.Forms.Label equalLabel4;
        private System.Windows.Forms.Label divRightLabel;
        private System.Windows.Forms.Label divLeftLabel;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label minusLabel;
        private System.Windows.Forms.Label equalLabel2;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

