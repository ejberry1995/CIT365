using System.Drawing;

namespace Mega_Desk
{
    partial class ViewAllQuotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.label1 = new System.Windows.Forms.Label();
            this.quoteDataGrid = new System.Windows.Forms.DataGridView();
            this.closeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.megaDeskLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.quoteDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.megaDeskLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell Extra Bold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(146, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Quotes";
            // 
            // quoteDataGrid
            // 
            this.quoteDataGrid.AllowUserToAddRows = false;
            this.quoteDataGrid.AllowUserToDeleteRows = false;
            this.quoteDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.quoteDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.quoteDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.quoteDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.quoteDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.quoteDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quoteDataGrid.Location = new System.Drawing.Point(38, 91);
            this.quoteDataGrid.Name = "quoteDataGrid";
            this.quoteDataGrid.ReadOnly = true;
            this.quoteDataGrid.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(126)))), ((int)(((byte)(137)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.quoteDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.quoteDataGrid.RowTemplate.Height = 24;
            this.quoteDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.quoteDataGrid.Size = new System.Drawing.Size(950, 518);
            this.quoteDataGrid.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(835, 35);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(153, 50);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(517, 35);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(153, 50);
            this.searchButton.TabIndex = 18;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold);
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(676, 35);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(153, 50);
            this.resetButton.TabIndex = 19;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // megaDeskLogo
            // 
            this.megaDeskLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.megaDeskLogo.Image = ((System.Drawing.Image)(resources.GetObject("megaDeskLogo.Image")));
            this.megaDeskLogo.Location = new System.Drawing.Point(48, -10);
            this.megaDeskLogo.Name = "megaDeskLogo";
            this.megaDeskLogo.Size = new System.Drawing.Size(101, 95);
            this.megaDeskLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.megaDeskLogo.TabIndex = 20;
            this.megaDeskLogo.TabStop = false;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(126)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(1029, 621);
            this.ControlBox = false;
            this.Controls.Add(this.megaDeskLogo);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.quoteDataGrid);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewAllQuotes";
            this.Text = "Mega Desk: Project Quote Calculator - View All Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.quoteDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.megaDeskLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView quoteDataGrid;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.PictureBox megaDeskLogo;
    }
}