﻿namespace PSXPrev.Forms
{
    partial class LauncherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LauncherForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.SelectISOButton = new System.Windows.Forms.Button();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.FilenameText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FilterText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PMDCheckBox = new System.Windows.Forms.CheckBox();
            this.HMDModelsCheckBox = new System.Windows.Forms.CheckBox();
            this.TODCheckBox = new System.Windows.Forms.CheckBox();
            this.TIMAltCheckBox = new System.Windows.Forms.CheckBox();
            this.TIMCheckBox = new System.Windows.Forms.CheckBox();
            this.TMDAltCheckBox = new System.Windows.Forms.CheckBox();
            this.TMDCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DebugCheckBox = new System.Windows.Forms.CheckBox();
            this.NoVerboseCheckBox = new System.Windows.Forms.CheckBox();
            this.LogCheckBox = new System.Windows.Forms.CheckBox();
            this.ScanButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectFolderButton);
            this.groupBox1.Controls.Add(this.SelectISOButton);
            this.groupBox1.Controls.Add(this.SelectFileButton);
            this.groupBox1.Controls.Add(this.FilenameText);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filename";
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.Location = new System.Drawing.Point(167, 45);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(79, 23);
            this.SelectFolderButton.TabIndex = 3;
            this.SelectFolderButton.Text = "Select Folder";
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // SelectISOButton
            // 
            this.SelectISOButton.Location = new System.Drawing.Point(86, 45);
            this.SelectISOButton.Name = "SelectISOButton";
            this.SelectISOButton.Size = new System.Drawing.Size(75, 23);
            this.SelectISOButton.TabIndex = 2;
            this.SelectISOButton.Text = "Select ISO";
            this.SelectISOButton.UseVisualStyleBackColor = true;
            this.SelectISOButton.Click += new System.EventHandler(this.SelectISOButton_Click);
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(12, 45);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(68, 23);
            this.SelectFileButton.TabIndex = 1;
            this.SelectFileButton.Text = "Select File";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // FilenameText
            // 
            this.FilenameText.Location = new System.Drawing.Point(12, 19);
            this.FilenameText.Name = "FilenameText";
            this.FilenameText.Size = new System.Drawing.Size(360, 20);
            this.FilenameText.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FilterText);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 58);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // FilterText
            // 
            this.FilterText.Location = new System.Drawing.Point(12, 21);
            this.FilterText.Name = "FilterText";
            this.FilterText.Size = new System.Drawing.Size(75, 20);
            this.FilterText.TabIndex = 1;
            this.FilterText.Text = "*.*";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.PMDCheckBox);
            this.groupBox3.Controls.Add(this.HMDModelsCheckBox);
            this.groupBox3.Controls.Add(this.TODCheckBox);
            this.groupBox3.Controls.Add(this.TIMAltCheckBox);
            this.groupBox3.Controls.Add(this.TIMCheckBox);
            this.groupBox3.Controls.Add(this.TMDAltCheckBox);
            this.groupBox3.Controls.Add(this.TMDCheckBox);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 93);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Scanners";
            // 
            // PMDCheckBox
            // 
            this.PMDCheckBox.AutoSize = true;
            this.PMDCheckBox.Location = new System.Drawing.Point(110, 65);
            this.PMDCheckBox.Name = "PMDCheckBox";
            this.PMDCheckBox.Size = new System.Drawing.Size(93, 17);
            this.PMDCheckBox.TabIndex = 6;
            this.PMDCheckBox.Text = "Scan for PMD";
            this.PMDCheckBox.UseVisualStyleBackColor = true;
            // 
            // HMDModelsCheckBox
            // 
            this.HMDModelsCheckBox.AutoSize = true;
            this.HMDModelsCheckBox.Location = new System.Drawing.Point(209, 65);
            this.HMDModelsCheckBox.Name = "HMDModelsCheckBox";
            this.HMDModelsCheckBox.Size = new System.Drawing.Size(131, 17);
            this.HMDModelsCheckBox.TabIndex = 5;
            this.HMDModelsCheckBox.Text = "Scan for HMD Models";
            this.HMDModelsCheckBox.UseVisualStyleBackColor = true;
            // 
            // TODCheckBox
            // 
            this.TODCheckBox.AutoSize = true;
            this.TODCheckBox.Location = new System.Drawing.Point(12, 65);
            this.TODCheckBox.Name = "TODCheckBox";
            this.TODCheckBox.Size = new System.Drawing.Size(92, 17);
            this.TODCheckBox.TabIndex = 4;
            this.TODCheckBox.Text = "Scan for TOD";
            this.TODCheckBox.UseVisualStyleBackColor = true;
            // 
            // TIMAltCheckBox
            // 
            this.TIMAltCheckBox.AutoSize = true;
            this.TIMAltCheckBox.Location = new System.Drawing.Point(111, 42);
            this.TIMAltCheckBox.Name = "TIMAltCheckBox";
            this.TIMAltCheckBox.Size = new System.Drawing.Size(146, 17);
            this.TIMAltCheckBox.TabIndex = 3;
            this.TIMAltCheckBox.Text = "Scan for TIM (alternative)";
            this.TIMAltCheckBox.UseVisualStyleBackColor = true;
            // 
            // TIMCheckBox
            // 
            this.TIMCheckBox.AutoSize = true;
            this.TIMCheckBox.Location = new System.Drawing.Point(12, 42);
            this.TIMCheckBox.Name = "TIMCheckBox";
            this.TIMCheckBox.Size = new System.Drawing.Size(88, 17);
            this.TIMCheckBox.TabIndex = 2;
            this.TIMCheckBox.Text = "Scan for TIM";
            this.TIMCheckBox.UseVisualStyleBackColor = true;
            // 
            // TMDAltCheckBox
            // 
            this.TMDAltCheckBox.AutoSize = true;
            this.TMDAltCheckBox.Location = new System.Drawing.Point(111, 19);
            this.TMDAltCheckBox.Name = "TMDAltCheckBox";
            this.TMDAltCheckBox.Size = new System.Drawing.Size(151, 17);
            this.TMDAltCheckBox.TabIndex = 1;
            this.TMDAltCheckBox.Text = "Scan for TMD (alternative)";
            this.TMDAltCheckBox.UseVisualStyleBackColor = true;
            // 
            // TMDCheckBox
            // 
            this.TMDCheckBox.AutoSize = true;
            this.TMDCheckBox.Location = new System.Drawing.Point(12, 19);
            this.TMDCheckBox.Name = "TMDCheckBox";
            this.TMDCheckBox.Size = new System.Drawing.Size(93, 17);
            this.TMDCheckBox.TabIndex = 0;
            this.TMDCheckBox.Text = "Scan for TMD";
            this.TMDCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DebugCheckBox);
            this.groupBox4.Controls.Add(this.NoVerboseCheckBox);
            this.groupBox4.Controls.Add(this.LogCheckBox);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 228);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(384, 46);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Options";
            // 
            // DebugCheckBox
            // 
            this.DebugCheckBox.AutoSize = true;
            this.DebugCheckBox.Location = new System.Drawing.Point(197, 19);
            this.DebugCheckBox.Name = "DebugCheckBox";
            this.DebugCheckBox.Size = new System.Drawing.Size(58, 17);
            this.DebugCheckBox.TabIndex = 3;
            this.DebugCheckBox.Text = "Debug";
            this.DebugCheckBox.UseVisualStyleBackColor = true;
            // 
            // NoVerboseCheckBox
            // 
            this.NoVerboseCheckBox.AutoSize = true;
            this.NoVerboseCheckBox.Location = new System.Drawing.Point(109, 19);
            this.NoVerboseCheckBox.Name = "NoVerboseCheckBox";
            this.NoVerboseCheckBox.Size = new System.Drawing.Size(82, 17);
            this.NoVerboseCheckBox.TabIndex = 2;
            this.NoVerboseCheckBox.Text = "No-Verbose";
            this.NoVerboseCheckBox.UseVisualStyleBackColor = true;
            // 
            // LogCheckBox
            // 
            this.LogCheckBox.AutoSize = true;
            this.LogCheckBox.Location = new System.Drawing.Point(12, 19);
            this.LogCheckBox.Name = "LogCheckBox";
            this.LogCheckBox.Size = new System.Drawing.Size(91, 17);
            this.LogCheckBox.TabIndex = 1;
            this.LogCheckBox.Text = "Generate Log";
            this.LogCheckBox.UseVisualStyleBackColor = true;
            // 
            // ScanButton
            // 
            this.ScanButton.Location = new System.Drawing.Point(297, 280);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(75, 23);
            this.ScanButton.TabIndex = 4;
            this.ScanButton.Text = "Scan";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // LauncherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 310);
            this.Controls.Add(this.ScanButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LauncherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSXPrev Launcher";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SelectFolderButton;
        private System.Windows.Forms.Button SelectISOButton;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.TextBox FilenameText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox FilterText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox HMDModelsCheckBox;
        private System.Windows.Forms.CheckBox TODCheckBox;
        private System.Windows.Forms.CheckBox TIMAltCheckBox;
        private System.Windows.Forms.CheckBox TIMCheckBox;
        private System.Windows.Forms.CheckBox TMDAltCheckBox;
        private System.Windows.Forms.CheckBox TMDCheckBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox DebugCheckBox;
        private System.Windows.Forms.CheckBox NoVerboseCheckBox;
        private System.Windows.Forms.CheckBox LogCheckBox;
        private System.Windows.Forms.Button ScanButton;
        private System.Windows.Forms.CheckBox PMDCheckBox;
    }
}