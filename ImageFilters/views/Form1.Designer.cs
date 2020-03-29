namespace ImageFilters
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.applyQuantilizationButton = new System.Windows.Forms.Button();
            this.quantilizationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bLevelsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.gLevelsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rLevelsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.applyDitheringButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.applyFilterButton = new System.Windows.Forms.Button();
            this.openImageButton = new System.Windows.Forms.Button();
            this.FiltersComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantilizationNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLevelsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gLevelsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rLevelsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.applyQuantilizationButton);
            this.splitContainer1.Panel2.Controls.Add(this.quantilizationNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.bLevelsNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.gLevelsNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.rLevelsNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.applyDitheringButton);
            this.splitContainer1.Panel2.Controls.Add(this.restoreButton);
            this.splitContainer1.Panel2.Controls.Add(this.saveButton);
            this.splitContainer1.Panel2.Controls.Add(this.applyFilterButton);
            this.splitContainer1.Panel2.Controls.Add(this.openImageButton);
            this.splitContainer1.Panel2.Controls.Add(this.FiltersComboBox);
            this.splitContainer1.Size = new System.Drawing.Size(1578, 944);
            this.splitContainer1.SplitterDistance = 1400;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1397, 944);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // applyQuantilizationButton
            // 
            this.applyQuantilizationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyQuantilizationButton.Enabled = false;
            this.applyQuantilizationButton.Location = new System.Drawing.Point(42, 410);
            this.applyQuantilizationButton.Name = "applyQuantilizationButton";
            this.applyQuantilizationButton.Size = new System.Drawing.Size(120, 36);
            this.applyQuantilizationButton.TabIndex = 15;
            this.applyQuantilizationButton.Text = "Apply Quantilization";
            this.applyQuantilizationButton.UseVisualStyleBackColor = true;
            this.applyQuantilizationButton.Click += new System.EventHandler(this.ApplyQuantilizationButton_Click);
            // 
            // quantilizationNumericUpDown
            // 
            this.quantilizationNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantilizationNumericUpDown.Enabled = false;
            this.quantilizationNumericUpDown.Location = new System.Drawing.Point(8, 410);
            this.quantilizationNumericUpDown.Name = "quantilizationNumericUpDown";
            this.quantilizationNumericUpDown.Size = new System.Drawing.Size(28, 26);
            this.quantilizationNumericUpDown.TabIndex = 14;
            this.quantilizationNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-11, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Octree Color Quantilization";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dithering";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Simple filters";
            // 
            // bLevelsNumericUpDown
            // 
            this.bLevelsNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bLevelsNumericUpDown.Enabled = false;
            this.bLevelsNumericUpDown.Location = new System.Drawing.Point(8, 335);
            this.bLevelsNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.bLevelsNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.bLevelsNumericUpDown.Name = "bLevelsNumericUpDown";
            this.bLevelsNumericUpDown.Size = new System.Drawing.Size(28, 26);
            this.bLevelsNumericUpDown.TabIndex = 10;
            this.bLevelsNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // gLevelsNumericUpDown
            // 
            this.gLevelsNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gLevelsNumericUpDown.Enabled = false;
            this.gLevelsNumericUpDown.Location = new System.Drawing.Point(8, 303);
            this.gLevelsNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.gLevelsNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.gLevelsNumericUpDown.Name = "gLevelsNumericUpDown";
            this.gLevelsNumericUpDown.Size = new System.Drawing.Size(28, 26);
            this.gLevelsNumericUpDown.TabIndex = 9;
            this.gLevelsNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // rLevelsNumericUpDown
            // 
            this.rLevelsNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rLevelsNumericUpDown.Enabled = false;
            this.rLevelsNumericUpDown.Location = new System.Drawing.Point(8, 271);
            this.rLevelsNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.rLevelsNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.rLevelsNumericUpDown.Name = "rLevelsNumericUpDown";
            this.rLevelsNumericUpDown.Size = new System.Drawing.Size(28, 26);
            this.rLevelsNumericUpDown.TabIndex = 7;
            this.rLevelsNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // applyDitheringButton
            // 
            this.applyDitheringButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyDitheringButton.Enabled = false;
            this.applyDitheringButton.Location = new System.Drawing.Point(42, 271);
            this.applyDitheringButton.Name = "applyDitheringButton";
            this.applyDitheringButton.Size = new System.Drawing.Size(120, 90);
            this.applyDitheringButton.TabIndex = 6;
            this.applyDitheringButton.Text = "Apply Dithering ";
            this.applyDitheringButton.UseVisualStyleBackColor = true;
            this.applyDitheringButton.Click += new System.EventHandler(this.ApplyDitheringButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.restoreButton.Enabled = false;
            this.restoreButton.Location = new System.Drawing.Point(8, 95);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(154, 36);
            this.restoreButton.TabIndex = 4;
            this.restoreButton.Text = "Restore";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.RestoreButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(8, 54);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(154, 35);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // applyFilterButton
            // 
            this.applyFilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.applyFilterButton.Enabled = false;
            this.applyFilterButton.Location = new System.Drawing.Point(8, 200);
            this.applyFilterButton.Name = "applyFilterButton";
            this.applyFilterButton.Size = new System.Drawing.Size(154, 36);
            this.applyFilterButton.TabIndex = 2;
            this.applyFilterButton.Text = "Apply Filter";
            this.applyFilterButton.UseVisualStyleBackColor = true;
            this.applyFilterButton.Click += new System.EventHandler(this.ApplyFilterButton_Click);
            // 
            // openImageButton
            // 
            this.openImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openImageButton.Location = new System.Drawing.Point(8, 12);
            this.openImageButton.Name = "openImageButton";
            this.openImageButton.Size = new System.Drawing.Size(154, 36);
            this.openImageButton.TabIndex = 1;
            this.openImageButton.Text = "Open";
            this.openImageButton.UseVisualStyleBackColor = true;
            this.openImageButton.Click += new System.EventHandler(this.OpenImageButton_Click);
            // 
            // FiltersComboBox
            // 
            this.FiltersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FiltersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltersComboBox.Enabled = false;
            this.FiltersComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FiltersComboBox.FormattingEnabled = true;
            this.FiltersComboBox.Items.AddRange(new object[] {
            "Inversion",
            "Brightness Correction",
            "Contrast Enhancement",
            "Gamma Correction",
            "Box Blur",
            "Gaussian Blur",
            "Sharpen",
            "Edge Detection",
            "Emboss",
            "Median",
            "Greyscale"});
            this.FiltersComboBox.Location = new System.Drawing.Point(8, 166);
            this.FiltersComboBox.Name = "FiltersComboBox";
            this.FiltersComboBox.Size = new System.Drawing.Size(154, 28);
            this.FiltersComboBox.TabIndex = 0;
            this.FiltersComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltersComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 944);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Image Fitlers";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantilizationNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLevelsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gLevelsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rLevelsNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button openImageButton;
        private System.Windows.Forms.ComboBox FiltersComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button applyFilterButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button restoreButton;
        private System.Windows.Forms.Button applyDitheringButton;
        private System.Windows.Forms.NumericUpDown rLevelsNumericUpDown;
        private System.Windows.Forms.NumericUpDown bLevelsNumericUpDown;
        private System.Windows.Forms.NumericUpDown gLevelsNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyQuantilizationButton;
        private System.Windows.Forms.NumericUpDown quantilizationNumericUpDown;
    }
}

