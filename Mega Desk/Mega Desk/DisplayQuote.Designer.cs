namespace Mega_Desk
{
    partial class DisplayQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.drawersLabel = new System.Windows.Forms.Label();
            this.daysLabel = new System.Windows.Forms.Label();
            this.quoteLable = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Quote";
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(34, 58);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(208, 17);
            this.customerLabel.TabIndex = 1;
            this.customerLabel.Text = "Customer: FirstName LastName";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(34, 91);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(88, 17);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Desk Width: ";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(34, 154);
            this.materialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(119, 17);
            this.materialLabel.TabIndex = 4;
            this.materialLabel.Text = "Surface Material: ";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(152, 91);
            this.depthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(90, 17);
            this.depthLabel.TabIndex = 6;
            this.depthLabel.Text = "Desk Depth: ";
            // 
            // drawersLabel
            // 
            this.drawersLabel.AutoSize = true;
            this.drawersLabel.Location = new System.Drawing.Point(34, 122);
            this.drawersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drawersLabel.Name = "drawersLabel";
            this.drawersLabel.Size = new System.Drawing.Size(134, 17);
            this.drawersLabel.TabIndex = 7;
            this.drawersLabel.Text = "Number of Drawers:";
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(34, 186);
            this.daysLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(136, 17);
            this.daysLabel.TabIndex = 8;
            this.daysLabel.Text = "Days for production:";
            // 
            // quoteLable
            // 
            this.quoteLable.AutoSize = true;
            this.quoteLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteLable.Location = new System.Drawing.Point(37, 219);
            this.quoteLable.Name = "quoteLable";
            this.quoteLable.Size = new System.Drawing.Size(106, 31);
            this.quoteLable.TabIndex = 9;
            this.quoteLable.Text = "Price: $";
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(89, 264);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(180, 55);
            this.continueButton.TabIndex = 10;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 344);
            this.ControlBox = false;
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.quoteLable);
            this.Controls.Add(this.daysLabel);
            this.Controls.Add(this.drawersLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DisplayQuote";
            this.Text = "Mega Desk: Project Quotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label drawersLabel;
        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label quoteLable;
        private System.Windows.Forms.Button continueButton;
    }
}