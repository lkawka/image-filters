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
            this.splitContainer1.Panel2.Controls.Add(this.restoreButton);
            this.splitContainer1.Panel2.Controls.Add(this.saveButton);
            this.splitContainer1.Panel2.Controls.Add(this.applyFilterButton);
            this.splitContainer1.Panel2.Controls.Add(this.openImageButton);
            this.splitContainer1.Panel2.Controls.Add(this.FiltersComboBox);
            this.splitContainer1.Size = new System.Drawing.Size(978, 544);
            this.splitContainer1.SplitterDistance = 800;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 544);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.applyFilterButton.Location = new System.Drawing.Point(8, 218);
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
            "Median"});
            this.FiltersComboBox.Location = new System.Drawing.Point(8, 184);
            this.FiltersComboBox.Name = "FiltersComboBox";
            this.FiltersComboBox.Size = new System.Drawing.Size(154, 28);
            this.FiltersComboBox.TabIndex = 0;
            this.FiltersComboBox.SelectedIndexChanged += new System.EventHandler(this.FiltersComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Image Fitlers";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

