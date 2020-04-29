namespace TimedMathQuiz
{
    partial class mathQuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mathQuizForm));
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLeftLable = new System.Windows.Forms.Label();
            this.addendLeftLabel = new System.Windows.Forms.Label();
            this.addendRightLabel = new System.Windows.Forms.Label();
            this.plusSignLabel = new System.Windows.Forms.Label();
            this.equalSignLabel1 = new System.Windows.Forms.Label();
            this.sumUpDown = new System.Windows.Forms.NumericUpDown();
            this.minuendLabel = new System.Windows.Forms.Label();
            this.minusSignLabel = new System.Windows.Forms.Label();
            this.subtrahendLabel = new System.Windows.Forms.Label();
            this.equalSignLabel2 = new System.Windows.Forms.Label();
            this.differenceUpDown = new System.Windows.Forms.NumericUpDown();
            this.dividendLabel = new System.Windows.Forms.Label();
            this.multiplicandLabel = new System.Windows.Forms.Label();
            this.timesSignLabel = new System.Windows.Forms.Label();
            this.dividedSignLabel = new System.Windows.Forms.Label();
            this.multiplierLabel = new System.Windows.Forms.Label();
            this.divisorLabel = new System.Windows.Forms.Label();
            this.equalSignLabel3 = new System.Windows.Forms.Label();
            this.equalSign4 = new System.Windows.Forms.Label();
            this.productUpDown = new System.Windows.Forms.NumericUpDown();
            this.quotientUpDown = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.quizTimer = new System.Windows.Forms.Timer(this.components);
            this.todayLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.appName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.differenceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotientUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.timeLabel.Location = new System.Drawing.Point(285, 126);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(134, 29);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = " 30 Seconds";
            // 
            // timeLeftLable
            // 
            this.timeLeftLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftLable.Location = new System.Drawing.Point(187, 126);
            this.timeLeftLable.Name = "timeLeftLable";
            this.timeLeftLable.Size = new System.Drawing.Size(110, 30);
            this.timeLeftLable.TabIndex = 1;
            this.timeLeftLable.Text = "Time Left:";
            // 
            // addendLeftLabel
            // 
            this.addendLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addendLeftLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.addendLeftLabel.Location = new System.Drawing.Point(55, 156);
            this.addendLeftLabel.Name = "addendLeftLabel";
            this.addendLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.addendLeftLabel.TabIndex = 2;
            this.addendLeftLabel.Text = "?";
            this.addendLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addendRightLabel
            // 
            this.addendRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addendRightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.addendRightLabel.Location = new System.Drawing.Point(187, 156);
            this.addendRightLabel.Name = "addendRightLabel";
            this.addendRightLabel.Size = new System.Drawing.Size(60, 50);
            this.addendRightLabel.TabIndex = 3;
            this.addendRightLabel.Text = "?";
            this.addendRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusSignLabel
            // 
            this.plusSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusSignLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.plusSignLabel.Location = new System.Drawing.Point(121, 156);
            this.plusSignLabel.Name = "plusSignLabel";
            this.plusSignLabel.Size = new System.Drawing.Size(60, 50);
            this.plusSignLabel.TabIndex = 4;
            this.plusSignLabel.Text = "+";
            this.plusSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSignLabel1
            // 
            this.equalSignLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSignLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.equalSignLabel1.Location = new System.Drawing.Point(253, 156);
            this.equalSignLabel1.Name = "equalSignLabel1";
            this.equalSignLabel1.Size = new System.Drawing.Size(60, 50);
            this.equalSignLabel1.TabIndex = 5;
            this.equalSignLabel1.Text = "=";
            this.equalSignLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sumUpDown
            // 
            this.sumUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.sumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.sumUpDown.Location = new System.Drawing.Point(319, 165);
            this.sumUpDown.Name = "sumUpDown";
            this.sumUpDown.Size = new System.Drawing.Size(100, 35);
            this.sumUpDown.TabIndex = 2;
            this.sumUpDown.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minuendLabel
            // 
            this.minuendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minuendLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.minuendLabel.Location = new System.Drawing.Point(55, 206);
            this.minuendLabel.Name = "minuendLabel";
            this.minuendLabel.Size = new System.Drawing.Size(60, 50);
            this.minuendLabel.TabIndex = 7;
            this.minuendLabel.Text = "?";
            this.minuendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusSignLabel
            // 
            this.minusSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusSignLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.minusSignLabel.Location = new System.Drawing.Point(121, 206);
            this.minusSignLabel.Name = "minusSignLabel";
            this.minusSignLabel.Size = new System.Drawing.Size(60, 50);
            this.minusSignLabel.TabIndex = 8;
            this.minusSignLabel.Text = "-";
            this.minusSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtrahendLabel
            // 
            this.subtrahendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtrahendLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.subtrahendLabel.Location = new System.Drawing.Point(187, 206);
            this.subtrahendLabel.Name = "subtrahendLabel";
            this.subtrahendLabel.Size = new System.Drawing.Size(60, 50);
            this.subtrahendLabel.TabIndex = 9;
            this.subtrahendLabel.Text = "?";
            this.subtrahendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSignLabel2
            // 
            this.equalSignLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSignLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.equalSignLabel2.Location = new System.Drawing.Point(253, 206);
            this.equalSignLabel2.Name = "equalSignLabel2";
            this.equalSignLabel2.Size = new System.Drawing.Size(60, 50);
            this.equalSignLabel2.TabIndex = 10;
            this.equalSignLabel2.Text = "=";
            this.equalSignLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // differenceUpDown
            // 
            this.differenceUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.differenceUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differenceUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.differenceUpDown.Location = new System.Drawing.Point(319, 215);
            this.differenceUpDown.Name = "differenceUpDown";
            this.differenceUpDown.Size = new System.Drawing.Size(100, 35);
            this.differenceUpDown.TabIndex = 3;
            this.differenceUpDown.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // dividendLabel
            // 
            this.dividendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividendLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.dividendLabel.Location = new System.Drawing.Point(55, 306);
            this.dividendLabel.Name = "dividendLabel";
            this.dividendLabel.Size = new System.Drawing.Size(60, 50);
            this.dividendLabel.TabIndex = 12;
            this.dividendLabel.Text = "?";
            this.dividendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiplicandLabel
            // 
            this.multiplicandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.multiplicandLabel.Location = new System.Drawing.Point(55, 256);
            this.multiplicandLabel.Name = "multiplicandLabel";
            this.multiplicandLabel.Size = new System.Drawing.Size(60, 50);
            this.multiplicandLabel.TabIndex = 13;
            this.multiplicandLabel.Text = "?";
            this.multiplicandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesSignLabel
            // 
            this.timesSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesSignLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.timesSignLabel.Location = new System.Drawing.Point(121, 256);
            this.timesSignLabel.Name = "timesSignLabel";
            this.timesSignLabel.Size = new System.Drawing.Size(60, 50);
            this.timesSignLabel.TabIndex = 14;
            this.timesSignLabel.Text = "×";
            this.timesSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedSignLabel
            // 
            this.dividedSignLabel.AutoEllipsis = true;
            this.dividedSignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividedSignLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.dividedSignLabel.Location = new System.Drawing.Point(121, 306);
            this.dividedSignLabel.Name = "dividedSignLabel";
            this.dividedSignLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedSignLabel.TabIndex = 15;
            this.dividedSignLabel.Text = " ÷ ";
            this.dividedSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiplierLabel
            // 
            this.multiplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplierLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.multiplierLabel.Location = new System.Drawing.Point(187, 256);
            this.multiplierLabel.Name = "multiplierLabel";
            this.multiplierLabel.Size = new System.Drawing.Size(60, 50);
            this.multiplierLabel.TabIndex = 16;
            this.multiplierLabel.Text = "?";
            this.multiplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divisorLabel
            // 
            this.divisorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divisorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.divisorLabel.Location = new System.Drawing.Point(187, 306);
            this.divisorLabel.Name = "divisorLabel";
            this.divisorLabel.Size = new System.Drawing.Size(60, 50);
            this.divisorLabel.TabIndex = 17;
            this.divisorLabel.Text = "?";
            this.divisorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSignLabel3
            // 
            this.equalSignLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSignLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.equalSignLabel3.Location = new System.Drawing.Point(253, 256);
            this.equalSignLabel3.Name = "equalSignLabel3";
            this.equalSignLabel3.Size = new System.Drawing.Size(60, 50);
            this.equalSignLabel3.TabIndex = 18;
            this.equalSignLabel3.Text = "=";
            this.equalSignLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSign4
            // 
            this.equalSign4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSign4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.equalSign4.Location = new System.Drawing.Point(253, 306);
            this.equalSign4.Name = "equalSign4";
            this.equalSign4.Size = new System.Drawing.Size(60, 50);
            this.equalSign4.TabIndex = 19;
            this.equalSign4.Text = "=";
            this.equalSign4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productUpDown
            // 
            this.productUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.productUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.productUpDown.Location = new System.Drawing.Point(319, 265);
            this.productUpDown.Name = "productUpDown";
            this.productUpDown.Size = new System.Drawing.Size(100, 35);
            this.productUpDown.TabIndex = 4;
            this.productUpDown.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // quotientUpDown
            // 
            this.quotientUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.quotientUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quotientUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotientUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.quotientUpDown.Location = new System.Drawing.Point(319, 315);
            this.quotientUpDown.Name = "quotientUpDown";
            this.quotientUpDown.Size = new System.Drawing.Size(100, 31);
            this.quotientUpDown.TabIndex = 5;
            this.quotientUpDown.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.startButton.Location = new System.Drawing.Point(174, 359);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(139, 38);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start The Quiz";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // quizTimer
            // 
            this.quizTimer.Interval = 1000;
            this.quizTimer.Tick += new System.EventHandler(this.quizTimer_Tick);
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.Location = new System.Drawing.Point(250, 23);
            this.todayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(169, 24);
            this.todayLabel.TabIndex = 20;
            this.todayLabel.Text = "31 December 1999";
            this.todayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Agency FB", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.appName.Location = new System.Drawing.Point(178, 41);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(255, 79);
            this.appName.TabIndex = 22;
            this.appName.Text = "Math Quiz!";
            // 
            // mathQuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(191)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(480, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotientUpDown);
            this.Controls.Add(this.productUpDown);
            this.Controls.Add(this.equalSign4);
            this.Controls.Add(this.equalSignLabel3);
            this.Controls.Add(this.divisorLabel);
            this.Controls.Add(this.multiplierLabel);
            this.Controls.Add(this.dividedSignLabel);
            this.Controls.Add(this.timesSignLabel);
            this.Controls.Add(this.multiplicandLabel);
            this.Controls.Add(this.dividendLabel);
            this.Controls.Add(this.differenceUpDown);
            this.Controls.Add(this.equalSignLabel2);
            this.Controls.Add(this.subtrahendLabel);
            this.Controls.Add(this.minusSignLabel);
            this.Controls.Add(this.minuendLabel);
            this.Controls.Add(this.sumUpDown);
            this.Controls.Add(this.equalSignLabel1);
            this.Controls.Add(this.plusSignLabel);
            this.Controls.Add(this.addendRightLabel);
            this.Controls.Add(this.addendLeftLabel);
            this.Controls.Add(this.timeLeftLable);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.appName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mathQuizForm";
            this.Text = "Elizabeth Berry\'s Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.differenceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotientUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLeftLable;
        private System.Windows.Forms.Label addendLeftLabel;
        private System.Windows.Forms.Label addendRightLabel;
        private System.Windows.Forms.Label plusSignLabel;
        private System.Windows.Forms.Label equalSignLabel1;
        private System.Windows.Forms.NumericUpDown sumUpDown;
        private System.Windows.Forms.Label minuendLabel;
        private System.Windows.Forms.Label minusSignLabel;
        private System.Windows.Forms.Label subtrahendLabel;
        private System.Windows.Forms.Label equalSignLabel2;
        private System.Windows.Forms.NumericUpDown differenceUpDown;
        private System.Windows.Forms.Label dividendLabel;
        private System.Windows.Forms.Label multiplicandLabel;
        private System.Windows.Forms.Label timesSignLabel;
        private System.Windows.Forms.Label dividedSignLabel;
        private System.Windows.Forms.Label multiplierLabel;
        private System.Windows.Forms.Label divisorLabel;
        private System.Windows.Forms.Label equalSignLabel3;
        private System.Windows.Forms.Label equalSign4;
        private System.Windows.Forms.NumericUpDown productUpDown;
        private System.Windows.Forms.NumericUpDown quotientUpDown;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer quizTimer;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label appName;
    }
}

