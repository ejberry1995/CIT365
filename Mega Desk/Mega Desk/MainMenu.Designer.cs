namespace Mega_Desk
{
    partial class MainMenu
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
            this.newQuoteButton = new System.Windows.Forms.Button();
            this.viewQuotesButton = new System.Windows.Forms.Button();
            this.searchQuotesButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newQuoteButton
            // 
            this.newQuoteButton.Location = new System.Drawing.Point(49, 73);
            this.newQuoteButton.Margin = new System.Windows.Forms.Padding(4);
            this.newQuoteButton.Name = "newQuoteButton";
            this.newQuoteButton.Size = new System.Drawing.Size(327, 73);
            this.newQuoteButton.TabIndex = 0;
            this.newQuoteButton.Text = "Add New Quote";
            this.newQuoteButton.UseVisualStyleBackColor = true;
            this.newQuoteButton.Click += new System.EventHandler(this.newQuoteButton_Click);
            // 
            // viewQuotesButton
            // 
            this.viewQuotesButton.Location = new System.Drawing.Point(49, 178);
            this.viewQuotesButton.Margin = new System.Windows.Forms.Padding(4);
            this.viewQuotesButton.Name = "viewQuotesButton";
            this.viewQuotesButton.Size = new System.Drawing.Size(327, 73);
            this.viewQuotesButton.TabIndex = 1;
            this.viewQuotesButton.Text = "View All Quotes";
            this.viewQuotesButton.UseVisualStyleBackColor = true;
            // 
            // searchQuotesButton
            // 
            this.searchQuotesButton.Location = new System.Drawing.Point(49, 288);
            this.searchQuotesButton.Margin = new System.Windows.Forms.Padding(4);
            this.searchQuotesButton.Name = "searchQuotesButton";
            this.searchQuotesButton.Size = new System.Drawing.Size(327, 73);
            this.searchQuotesButton.TabIndex = 2;
            this.searchQuotesButton.Text = "Search Quotes";
            this.searchQuotesButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(49, 395);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(327, 73);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Main Menu";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchQuotesButton);
            this.Controls.Add(this.viewQuotesButton);
            this.Controls.Add(this.newQuoteButton);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "Mega Desk: Project Quotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newQuoteButton;
        private System.Windows.Forms.Button viewQuotesButton;
        private System.Windows.Forms.Button searchQuotesButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}

