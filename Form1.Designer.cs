﻿using ConfigurationReader.Assets;

namespace ConfigurationReader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbBaseFolder = new TextBox();
            label1 = new Label();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            pnlConfigurations = new FlowLayoutPanel();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnFindFolder = new DarkButton();
            btnLoadConfigs = new DarkButton();
            SuspendLayout();
            // 
            // tbBaseFolder
            // 
            tbBaseFolder.BackColor = SystemColors.WindowFrame;
            tbBaseFolder.BorderStyle = BorderStyle.FixedSingle;
            tbBaseFolder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbBaseFolder.ForeColor = SystemColors.HighlightText;
            tbBaseFolder.Location = new Point(102, 8);
            tbBaseFolder.Margin = new Padding(3, 2, 3, 2);
            tbBaseFolder.Name = "tbBaseFolder";
            tbBaseFolder.Size = new Size(384, 23);
            tbBaseFolder.TabIndex = 0;
            tbBaseFolder.Text = "A:\\\\AAAAAAAAAA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(7, 10);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Base location";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 6.25F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(102, 31);
            label2.Name = "label2";
            label2.Size = new Size(373, 12);
            label2.TabIndex = 3;
            label2.Text = "After selecting 'Load Configs' all .json configurations from all child directories will be loaded";
            // 
            // pnlConfigurations
            // 
            pnlConfigurations.AllowDrop = true;
            pnlConfigurations.Anchor = AnchorStyles.Top;
            pnlConfigurations.AutoScroll = true;
            pnlConfigurations.BackColor = SystemColors.WindowFrame;
            pnlConfigurations.FlowDirection = FlowDirection.TopDown;
            pnlConfigurations.ForeColor = Color.Transparent;
            pnlConfigurations.Location = new Point(10, 71);
            pnlConfigurations.Margin = new Padding(3, 2, 3, 2);
            pnlConfigurations.Name = "pnlConfigurations";
            pnlConfigurations.Size = new Size(215, 257);
            pnlConfigurations.TabIndex = 5;
            pnlConfigurations.WrapContents = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(10, 54);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 6;
            label3.Text = "Configurations";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.Anchor = AnchorStyles.Top;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.WindowFrame;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.ForeColor = Color.Transparent;
            flowLayoutPanel1.Location = new Point(231, 71);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(215, 257);
            flowLayoutPanel1.TabIndex = 6;
            flowLayoutPanel1.WrapContents = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AllowDrop = true;
            flowLayoutPanel2.Anchor = AnchorStyles.Top;
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.BackColor = SystemColors.WindowFrame;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.ForeColor = Color.Transparent;
            flowLayoutPanel2.Location = new Point(452, 71);
            flowLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(215, 257);
            flowLayoutPanel2.TabIndex = 7;
            flowLayoutPanel2.WrapContents = false;
            // 
            // btnFindFolder
            // 
            btnFindFolder.BackColor = SystemColors.MenuText;
            btnFindFolder.BorderColor = Color.FromArgb(70, 70, 70);
            btnFindFolder.FlatAppearance.BorderSize = 0;
            btnFindFolder.FlatStyle = FlatStyle.Flat;
            btnFindFolder.ForeColor = Color.Transparent;
            btnFindFolder.Location = new Point(492, 8);
            btnFindFolder.Name = "btnFindFolder";
            btnFindFolder.Size = new Size(75, 23);
            btnFindFolder.TabIndex = 8;
            btnFindFolder.Text = "Find Folder";
            btnFindFolder.UseVisualStyleBackColor = false;
            btnFindFolder.Click += OnFindFolder_Click;
            // 
            // btnLoadConfigs
            // 
            btnLoadConfigs.BackColor = SystemColors.MenuText;
            btnLoadConfigs.BorderColor = Color.FromArgb(70, 70, 70);
            btnLoadConfigs.FlatAppearance.BorderSize = 0;
            btnLoadConfigs.FlatStyle = FlatStyle.Flat;
            btnLoadConfigs.ForeColor = Color.Transparent;
            btnLoadConfigs.Location = new Point(573, 8);
            btnLoadConfigs.Name = "btnLoadConfigs";
            btnLoadConfigs.Size = new Size(75, 23);
            btnLoadConfigs.TabIndex = 9;
            btnLoadConfigs.Text = "Load Configs";
            btnLoadConfigs.UseVisualStyleBackColor = false;
            btnFindFolder.Click += OnLoadConfigurations_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(710, 338);
            Controls.Add(btnFindFolder);
            Controls.Add(btnLoadConfigs);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(pnlConfigurations);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbBaseFolder);
            ForeColor = Color.Gray;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private TextBox tbBaseFolder;
        private Label label1;
        private DarkButton btnFindFolder;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private DarkButton btnLoadConfigs;
        private FlowLayoutPanel pnlConfigurations;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
