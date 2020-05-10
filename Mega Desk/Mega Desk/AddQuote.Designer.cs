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
            this.depthBox = new System.Windows.Forms.NumericUpDown();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.materialGroup = new System.Windows.Forms.GroupBox();
            this.radioMaterial2 = new System.Windows.Forms.RadioButton();
            this.radioMaterial4 = new System.Windows.Forms.RadioButton();
            this.radioMaterial3 = new System.Windows.Forms.RadioButton();
            this.radioMaterial1 = new System.Windows.Forms.RadioButton();
            this.radioMaterial0 = new System.Windows.Forms.RadioButton();
            this.orderOptionsGroup = new System.Windows.Forms.GroupBox();
            this.standardOrderLabel = new System.Windows.Forms.Label();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.radioRush7 = new System.Windows.Forms.RadioButton();
            this.radioRush5 = new System.Windows.Forms.RadioButton();
            this.radioRush3 = new System.Windows.Forms.RadioButton();
            this.tableName = new System.Windows.Forms.Label();
            this.dimensionGroup = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.firstNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lastNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.widthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.depthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.numDrawersErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.numDrawersLabel = new System.Windows.Forms.Label();
            this.numDrawersUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).BeginInit();
            this.materialGroup.SuspendLayout();
            this.orderOptionsGroup.SuspendLayout();
            this.dimensionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameBox
            // 
            this.firstNameErrorProvider.SetIconPadding(this.firstNameBox, 2);
            this.firstNameBox.Location = new System.Drawing.Point(59, 85);
            this.firstNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(164, 22);
            this.firstNameBox.TabIndex = 0;
            // 
            // lastNameBox
            // 
            this.lastNameErrorProvider.SetIconPadding(this.lastNameBox, 2);
            this.lastNameBox.Location = new System.Drawing.Point(245, 83);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(163, 22);
            this.lastNameBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(56, 62);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(140, 17);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "Customer First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(242, 62);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(140, 17);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Customer Last Name";
            // 
            // widthBox
            // 
            this.widthErrorProvider.SetIconPadding(this.widthBox, 2);
            this.widthBox.Location = new System.Drawing.Point(74, 27);
            this.widthBox.Margin = new System.Windows.Forms.Padding(4);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(47, 22);
            this.widthBox.TabIndex = 4;
            // 
            // depthBox
            // 
            this.depthErrorProvider.SetIconPadding(this.depthBox, 2);
            this.depthBox.Location = new System.Drawing.Point(74, 62);
            this.depthBox.Margin = new System.Windows.Forms.Padding(4);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(47, 22);
            this.depthBox.TabIndex = 5;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(22, 32);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(44, 17);
            this.widthLabel.TabIndex = 6;
            this.widthLabel.Text = "Width";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Location = new System.Drawing.Point(20, 66);
            this.depthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(46, 17);
            this.depthLabel.TabIndex = 7;
            this.depthLabel.Text = "Depth";
            // 
            // materialGroup
            // 
            this.materialGroup.Controls.Add(this.radioMaterial2);
            this.materialGroup.Controls.Add(this.radioMaterial4);
            this.materialGroup.Controls.Add(this.radioMaterial3);
            this.materialGroup.Controls.Add(this.radioMaterial1);
            this.materialGroup.Controls.Add(this.radioMaterial0);
            this.materialGroup.Location = new System.Drawing.Point(60, 115);
            this.materialGroup.Margin = new System.Windows.Forms.Padding(4);
            this.materialGroup.Name = "materialGroup";
            this.materialGroup.Padding = new System.Windows.Forms.Padding(4);
            this.materialGroup.Size = new System.Drawing.Size(163, 161);
            this.materialGroup.TabIndex = 8;
            this.materialGroup.TabStop = false;
            this.materialGroup.Text = "Surface Material";
            // 
            // radioMaterial2
            // 
            this.radioMaterial2.AutoSize = true;
            this.radioMaterial2.Location = new System.Drawing.Point(8, 81);
            this.radioMaterial2.Margin = new System.Windows.Forms.Padding(4);
            this.radioMaterial2.Name = "radioMaterial2";
            this.radioMaterial2.Size = new System.Drawing.Size(17, 16);
            this.radioMaterial2.TabIndex = 4;
            this.radioMaterial2.UseVisualStyleBackColor = true;
            // 
            // radioMaterial4
            // 
            this.radioMaterial4.AutoSize = true;
            this.radioMaterial4.Location = new System.Drawing.Point(8, 136);
            this.radioMaterial4.Margin = new System.Windows.Forms.Padding(4);
            this.radioMaterial4.Name = "radioMaterial4";
            this.radioMaterial4.Size = new System.Drawing.Size(17, 16);
            this.radioMaterial4.TabIndex = 3;
            this.radioMaterial4.UseVisualStyleBackColor = true;
            // 
            // radioMaterial3
            // 
            this.radioMaterial3.AutoSize = true;
            this.radioMaterial3.Location = new System.Drawing.Point(8, 108);
            this.radioMaterial3.Margin = new System.Windows.Forms.Padding(4);
            this.radioMaterial3.Name = "radioMaterial3";
            this.radioMaterial3.Size = new System.Drawing.Size(17, 16);
            this.radioMaterial3.TabIndex = 2;
            this.radioMaterial3.UseVisualStyleBackColor = true;
            // 
            // radioMaterial1
            // 
            this.radioMaterial1.AutoSize = true;
            this.radioMaterial1.Location = new System.Drawing.Point(8, 52);
            this.radioMaterial1.Margin = new System.Windows.Forms.Padding(4);
            this.radioMaterial1.Name = "radioMaterial1";
            this.radioMaterial1.Size = new System.Drawing.Size(17, 16);
            this.radioMaterial1.TabIndex = 1;
            this.radioMaterial1.UseVisualStyleBackColor = true;
            // 
            // radioMaterial0
            // 
            this.radioMaterial0.AutoSize = true;
            this.radioMaterial0.Checked = true;
            this.radioMaterial0.Location = new System.Drawing.Point(8, 23);
            this.radioMaterial0.Margin = new System.Windows.Forms.Padding(4);
            this.radioMaterial0.Name = "radioMaterial0";
            this.radioMaterial0.Size = new System.Drawing.Size(17, 16);
            this.radioMaterial0.TabIndex = 0;
            this.radioMaterial0.TabStop = true;
            this.radioMaterial0.UseVisualStyleBackColor = true;
            // 
            // orderOptionsGroup
            // 
            this.orderOptionsGroup.Controls.Add(this.standardOrderLabel);
            this.orderOptionsGroup.Controls.Add(this.radioStandard);
            this.orderOptionsGroup.Controls.Add(this.radioRush7);
            this.orderOptionsGroup.Controls.Add(this.radioRush5);
            this.orderOptionsGroup.Controls.Add(this.radioRush3);
            this.orderOptionsGroup.Location = new System.Drawing.Point(60, 284);
            this.orderOptionsGroup.Margin = new System.Windows.Forms.Padding(4);
            this.orderOptionsGroup.Name = "orderOptionsGroup";
            this.orderOptionsGroup.Padding = new System.Windows.Forms.Padding(4);
            this.orderOptionsGroup.Size = new System.Drawing.Size(163, 151);
            this.orderOptionsGroup.TabIndex = 9;
            this.orderOptionsGroup.TabStop = false;
            this.orderOptionsGroup.Text = "Rush Order Options";
            // 
            // standardOrderLabel
            // 
            this.standardOrderLabel.AutoSize = true;
            this.standardOrderLabel.Location = new System.Drawing.Point(8, 105);
            this.standardOrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.standardOrderLabel.Name = "standardOrderLabel";
            this.standardOrderLabel.Size = new System.Drawing.Size(138, 17);
            this.standardOrderLabel.TabIndex = 10;
            this.standardOrderLabel.Text = "Standard Production";
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Checked = true;
            this.radioStandard.Location = new System.Drawing.Point(8, 123);
            this.radioStandard.Margin = new System.Windows.Forms.Padding(4);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(79, 21);
            this.radioStandard.TabIndex = 10;
            this.radioStandard.TabStop = true;
            this.radioStandard.Text = "14 days";
            this.radioStandard.UseVisualStyleBackColor = true;
            // 
            // radioRush7
            // 
            this.radioRush7.AutoSize = true;
            this.radioRush7.Location = new System.Drawing.Point(8, 80);
            this.radioRush7.Margin = new System.Windows.Forms.Padding(4);
            this.radioRush7.Name = "radioRush7";
            this.radioRush7.Size = new System.Drawing.Size(71, 21);
            this.radioRush7.TabIndex = 2;
            this.radioRush7.Text = "7 days";
            this.radioRush7.UseVisualStyleBackColor = true;
            // 
            // radioRush5
            // 
            this.radioRush5.AutoSize = true;
            this.radioRush5.Location = new System.Drawing.Point(8, 52);
            this.radioRush5.Margin = new System.Windows.Forms.Padding(4);
            this.radioRush5.Name = "radioRush5";
            this.radioRush5.Size = new System.Drawing.Size(71, 21);
            this.radioRush5.TabIndex = 1;
            this.radioRush5.Text = "5 days";
            this.radioRush5.UseVisualStyleBackColor = true;
            // 
            // radioRush3
            // 
            this.radioRush3.AutoSize = true;
            this.radioRush3.Location = new System.Drawing.Point(8, 23);
            this.radioRush3.Margin = new System.Windows.Forms.Padding(4);
            this.radioRush3.Name = "radioRush3";
            this.radioRush3.Size = new System.Drawing.Size(71, 21);
            this.radioRush3.TabIndex = 0;
            this.radioRush3.Text = "3 days";
            this.radioRush3.UseVisualStyleBackColor = true;
            // 
            // tableName
            // 
            this.tableName.AutoSize = true;
            this.tableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableName.Location = new System.Drawing.Point(143, 9);
            this.tableName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableName.Name = "tableName";
            this.tableName.Size = new System.Drawing.Size(168, 31);
            this.tableName.TabIndex = 12;
            this.tableName.Text = "Add A Quote";
            // 
            // dimensionGroup
            // 
            this.dimensionGroup.Controls.Add(this.widthLabel);
            this.dimensionGroup.Controls.Add(this.widthBox);
            this.dimensionGroup.Controls.Add(this.depthBox);
            this.dimensionGroup.Controls.Add(this.depthLabel);
            this.dimensionGroup.Location = new System.Drawing.Point(245, 116);
            this.dimensionGroup.Margin = new System.Windows.Forms.Padding(4);
            this.dimensionGroup.Name = "dimensionGroup";
            this.dimensionGroup.Padding = new System.Windows.Forms.Padding(4);
            this.dimensionGroup.Size = new System.Drawing.Size(163, 107);
            this.dimensionGroup.TabIndex = 15;
            this.dimensionGroup.TabStop = false;
            this.dimensionGroup.Text = "Dimensions";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(239, 353);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(173, 75);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(239, 272);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(173, 75);
            this.calculateButton.TabIndex = 17;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
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
            // numDrawersLabel
            // 
            this.numDrawersLabel.AutoSize = true;
            this.numDrawersLabel.Location = new System.Drawing.Point(236, 236);
            this.numDrawersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numDrawersLabel.Name = "numDrawersLabel";
            this.numDrawersLabel.Size = new System.Drawing.Size(130, 17);
            this.numDrawersLabel.TabIndex = 13;
            this.numDrawersLabel.Text = "Number of Drawers";
            // 
            // numDrawersUpDown
            // 
            this.numDrawersUpDown.Location = new System.Drawing.Point(368, 234);
            this.numDrawersUpDown.Name = "numDrawersUpDown";
            this.numDrawersUpDown.Size = new System.Drawing.Size(44, 22);
            this.numDrawersUpDown.TabIndex = 18;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 463);
            this.ControlBox = false;
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
            this.Controls.Add(this.orderOptionsGroup);
            this.Controls.Add(this.materialGroup);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddQuote";
            this.Text = "Mega Desk: Project Quote Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthBox)).EndInit();
            this.materialGroup.ResumeLayout(false);
            this.materialGroup.PerformLayout();
            this.orderOptionsGroup.ResumeLayout(false);
            this.orderOptionsGroup.PerformLayout();
            this.dimensionGroup.ResumeLayout(false);
            this.dimensionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawersUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.NumericUpDown widthBox;
        private System.Windows.Forms.NumericUpDown depthBox;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.GroupBox materialGroup;
        private System.Windows.Forms.RadioButton radioMaterial0;
        private System.Windows.Forms.RadioButton radioMaterial2;
        private System.Windows.Forms.RadioButton radioMaterial4;
        private System.Windows.Forms.RadioButton radioMaterial3;
        private System.Windows.Forms.RadioButton radioMaterial1;
        private System.Windows.Forms.GroupBox orderOptionsGroup;
        private System.Windows.Forms.Label standardOrderLabel;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.RadioButton radioRush7;
        private System.Windows.Forms.RadioButton radioRush5;
        private System.Windows.Forms.RadioButton radioRush3;
        private System.Windows.Forms.Label tableName;
        private System.Windows.Forms.GroupBox dimensionGroup;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button calculateButton;
        private Label numDrawersLabel;
        private NumericUpDown numDrawersUpDown;
    }
}