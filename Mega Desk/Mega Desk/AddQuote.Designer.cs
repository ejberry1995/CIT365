using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace Mega_Desk
{
    partial class AddQuote
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

        /// <summary>
        /// Create error providers to assist in providing validation feedback
        /// </summary>
        private System.Windows.Forms.ErrorProvider firstNameErrorProvider;
        private System.Windows.Forms.ErrorProvider lastNameErrorProvider;
        private System.Windows.Forms.ErrorProvider widthErrorProvider;
        private System.Windows.Forms.ErrorProvider depthErrorProvider;
        private System.Windows.Forms.ErrorProvider numDrawersErrorProvider;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.widthBox = new System.Windows.Forms.NumericUpDown();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.tableName = new System.Windows.Forms.Label();
            this.dimensionGroup = new System.Windows.Forms.GroupBox();
            this.depthBox = new System.Windows.Forms.NumericUpDown();
            this.cancelButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.firstNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lastNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.widthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.depthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.numDrawersErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.numDrawersUpDown = new System.Windows.Forms.NumericUpDown();
            this.numDrawersLabel = new System.Windows.Forms.Label();
            this.materialListBox = new System.Windows.Forms.ListBox();
            this.materialBoxLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rushOptionsListBox = new System.Windows.Forms.ListBox();
            this.rushOrderRadio = new System.Windows.Forms.RadioButton();
            this.standardOrderRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            this.dimensionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstNameBox
            // 
            this.firstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.firstNameErrorProvider.SetIconPadding(this.firstNameBox, 2);
            this.firstNameBox.Location = new System.Drawing.Point(37, 82);
            this.firstNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(164, 22);
            this.firstNameBox.TabIndex = 0;
            this.firstNameBox.Leave += new System.EventHandler(this.firstNameBox_Leave);
            // 
            // lastNameBox
            // 
            this.lastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.lastNameErrorProvider.SetIconPadding(this.lastNameBox, 2);
            this.lastNameBox.Location = new System.Drawing.Point(233, 82);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(163, 22);
            this.lastNameBox.TabIndex = 1;
            this.lastNameBox.Leave += new System.EventHandler(this.lastNameBox_Leave);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.firstNameLabel.Location = new System.Drawing.Point(34, 61);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(140, 17);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "Customer First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.lastNameLabel.Location = new System.Drawing.Point(230, 61);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(140, 17);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Customer Last Name";
            // 
            // widthBox
            // 
            this.widthBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthErrorProvider.SetIconPadding(this.widthBox, 2);
            this.widthBox.Location = new System.Drawing.Point(72, 32);
            this.widthBox.Margin = new System.Windows.Forms.Padding(4);
            this.widthBox.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.widthBox.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(63, 22);
            this.widthBox.TabIndex = 4;
            this.widthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.widthBox.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.widthBox.Leave += new System.EventHandler(this.widthBox_Leave);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(20, 31);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(44, 17);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Width";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(18, 70);
            this.depthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(46, 17);
            this.depthLabel.TabIndex = 7;
            this.depthLabel.Text = "Depth";
            // 
            // tableName
            // 
            this.tableName.AutoSize = true;
            this.tableName.Font = new System.Drawing.Font("Rockwell Extra Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.tableName.Location = new System.Drawing.Point(105, 17);
            this.tableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(209, 35);
            this.tableName.TabIndex = 12;
            this.tableName.Text = "New Quote";
            // 
            // dimensionGroup
            // 
            this.dimensionGroup.Controls.Add(this.depthBox);
            this.dimensionGroup.Controls.Add(this.widthLabel);
            this.dimensionGroup.Controls.Add(this.widthBox);
            this.dimensionGroup.Controls.Add(this.depthLabel);
            this.dimensionGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.dimensionGroup.Location = new System.Drawing.Point(233, 112);
            this.dimensionGroup.Margin = new System.Windows.Forms.Padding(4);
            this.dimensionGroup.Name = "dimensionGroup";
            this.dimensionGroup.Padding = new System.Windows.Forms.Padding(4);
            this.dimensionGroup.Size = new System.Drawing.Size(163, 107);
            this.dimensionGroup.TabIndex = 15;
            this.dimensionGroup.TabStop = false;
            this.dimensionGroup.Text = "Dimensions";
            // 
            // depthBox
            // 
            this.depthBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.widthErrorProvider.SetIconPadding(this.depthBox, 2);
            this.depthBox.Location = new System.Drawing.Point(72, 70);
            this.depthBox.Margin = new System.Windows.Forms.Padding(4);
            this.depthBox.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.depthBox.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(63, 22);
            this.depthBox.TabIndex = 8;
            this.depthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.depthBox.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.depthBox.Leave += new System.EventHandler(this.depthBox_Leave);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(52)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(227, 352);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(173, 75);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(126)))), ((int)(((byte)(137)))));
            this.calculateButton.FlatAppearance.BorderSize = 0;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Rockwell", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(227, 271);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(173, 75);
            this.calculateButton.TabIndex = 17;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // firstNameErrorProvider
            // 
            this.firstNameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.firstNameErrorProvider.ContainerControl = this;
            // 
            // lastNameErrorProvider
            // 
            this.lastNameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.lastNameErrorProvider.ContainerControl = this;
            // 
            // widthErrorProvider
            // 
            this.widthErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.widthErrorProvider.ContainerControl = this;
            // 
            // depthErrorProvider
            // 
            this.depthErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.depthErrorProvider.ContainerControl = this;
            // 
            // numDrawersErrorProvider
            // 
            this.numDrawersErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.numDrawersErrorProvider.ContainerControl = this;
            // 
            // numDrawersUpDown
            // 
            this.numDrawersUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDrawersUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.numDrawersErrorProvider.SetIconPadding(this.numDrawersUpDown, 2);
            this.numDrawersUpDown.Location = new System.Drawing.Point(356, 235);
            this.numDrawersUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDrawersUpDown.Name = "numDrawersUpDown";
            this.numDrawersUpDown.Size = new System.Drawing.Size(44, 22);
            this.numDrawersUpDown.TabIndex = 18;
            this.numDrawersUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDrawersUpDown.Leave += new System.EventHandler(this.numDrawersUpDown_Leave);
            // 
            // numDrawersLabel
            // 
            this.numDrawersLabel.AutoSize = true;
            this.numDrawersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.numDrawersLabel.Location = new System.Drawing.Point(224, 235);
            this.numDrawersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numDrawersLabel.Name = "numDrawersLabel";
            this.numDrawersLabel.Size = new System.Drawing.Size(130, 17);
            this.numDrawersLabel.TabIndex = 13;
            this.numDrawersLabel.Text = "Number of Drawers";
            // 
            // materialListBox
            // 
            this.materialListBox.FormattingEnabled = true;
            this.materialListBox.ItemHeight = 16;
            this.materialListBox.Location = new System.Drawing.Point(37, 136);
            this.materialListBox.Name = "materialListBox";
            this.materialListBox.Size = new System.Drawing.Size(135, 116);
            this.materialListBox.TabIndex = 19;
            // 
            // materialBoxLabel
            // 
            this.materialBoxLabel.AutoSize = true;
            this.materialBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(65)))));
            this.materialBoxLabel.Location = new System.Drawing.Point(34, 116);
            this.materialBoxLabel.Name = "materialBoxLabel";
            this.materialBoxLabel.Size = new System.Drawing.Size(111, 17);
            this.materialBoxLabel.TabIndex = 20;
            this.materialBoxLabel.Text = "Surface Material";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rushOptionsListBox);
            this.groupBox1.Controls.Add(this.rushOrderRadio);
            this.groupBox1.Controls.Add(this.standardOrderRadio);
            this.groupBox1.Location = new System.Drawing.Point(37, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 196);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Production Time";
            // 
            // rushOptionsListBox
            // 
            this.rushOptionsListBox.Enabled = false;
            this.rushOptionsListBox.FormattingEnabled = true;
            this.rushOptionsListBox.ItemHeight = 16;
            this.rushOptionsListBox.Location = new System.Drawing.Point(29, 99);
            this.rushOptionsListBox.Name = "rushOptionsListBox";
            this.rushOptionsListBox.Size = new System.Drawing.Size(108, 68);
            this.rushOptionsListBox.TabIndex = 2;
            // 
            // rushOrderRadio
            // 
            this.rushOrderRadio.AutoSize = true;
            this.rushOrderRadio.Location = new System.Drawing.Point(6, 72);
            this.rushOrderRadio.Name = "rushOrderRadio";
            this.rushOrderRadio.Size = new System.Drawing.Size(103, 21);
            this.rushOrderRadio.TabIndex = 1;
            this.rushOrderRadio.Text = "Rush Order";
            this.rushOrderRadio.UseVisualStyleBackColor = true;
            this.rushOrderRadio.CheckedChanged += new System.EventHandler(this.rushOrderRadio_CheckedChanged);
            // 
            // standardOrderRadio
            // 
            this.standardOrderRadio.AutoSize = true;
            this.standardOrderRadio.Checked = true;
            this.standardOrderRadio.Location = new System.Drawing.Point(6, 34);
            this.standardOrderRadio.Name = "standardOrderRadio";
            this.standardOrderRadio.Size = new System.Drawing.Size(91, 21);
            this.standardOrderRadio.TabIndex = 0;
            this.standardOrderRadio.TabStop = true;
            this.standardOrderRadio.Text = "Standard ";
            this.standardOrderRadio.UseVisualStyleBackColor = true;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(208)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(449, 463);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialBoxLabel);
            this.Controls.Add(this.materialListBox);
            this.Controls.Add(this.numDrawersUpDown);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.dimensionGroup);
            this.Controls.Add(this.numDrawersLabel);
            this.Controls.Add(this.tableName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddQuote";
            this.Text = "Mega Desk: Project Quote Calculator - Add a New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
            this.dimensionGroup.ResumeLayout(false);
            this.dimensionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.NumericUpDown widthBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label tableName;
        private System.Windows.Forms.GroupBox dimensionGroup;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button calculateButton;
        private Label numDrawersLabel;
        private NumericUpDown numDrawersUpDown;
        private NumericUpDown depthBox;
        private ListBox materialListBox;
        private Label materialBoxLabel;
        private GroupBox groupBox1;
        private RadioButton standardOrderRadio;
        private ListBox rushOptionsListBox;
        private RadioButton rushOrderRadio;
    }
}