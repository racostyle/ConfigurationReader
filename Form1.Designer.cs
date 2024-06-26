using ConfigurationReader.Assets;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnSaveAll = new DarkButton();
            notifySavingPannel = new Panel();
            btnSaveCurrent = new DarkButton();
            btnFindFolder = new DarkButton();
            btnLoadConfigs = new DarkButton();
            btnExportValue = new DarkButton();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnShowClipboard = new DarkButton();
            label5 = new Label();
            label4 = new Label();
            pnlConfigKeys = new FlowLayoutPanel();
            label3 = new Label();
            pnlConfigurations = new FlowLayoutPanel();
            tbKeyValue = new DarkTextBox();
            label2 = new Label();
            label1 = new Label();
            tbBaseFolder = new DarkTextBox();
            btnEditClipboardValues = new DarkButton();
            SuspendLayout();
            // 
            // btnSaveAll
            // 
            btnSaveAll.BackColor = SystemColors.MenuText;
            btnSaveAll.BorderColor = Color.FromArgb(70, 70, 70);
            btnSaveAll.FlatAppearance.BorderSize = 0;
            btnSaveAll.FlatStyle = FlatStyle.Flat;
            btnSaveAll.Font = new Font("Arial", 8F);
            btnSaveAll.ForeColor = Color.Transparent;
            btnSaveAll.Location = new Point(945, 47);
            btnSaveAll.Margin = new Padding(3, 4, 3, 4);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new Size(149, 31);
            btnSaveAll.TabIndex = 54;
            btnSaveAll.Text = "SAVE ALL";
            btnSaveAll.UseVisualStyleBackColor = false;
            btnSaveAll.Click += OnBtnSaveAll_Click;
            // 
            // notifySavingPannel
            // 
            notifySavingPannel.Location = new Point(790, 82);
            notifySavingPannel.Name = "notifySavingPannel";
            notifySavingPannel.Size = new Size(304, 8);
            notifySavingPannel.TabIndex = 62;
            // 
            // btnSaveCurrent
            // 
            btnSaveCurrent.BackColor = SystemColors.MenuText;
            btnSaveCurrent.BorderColor = Color.FromArgb(70, 70, 70);
            btnSaveCurrent.FlatAppearance.BorderSize = 0;
            btnSaveCurrent.FlatStyle = FlatStyle.Flat;
            btnSaveCurrent.Font = new Font("Arial", 8F);
            btnSaveCurrent.ForeColor = Color.Transparent;
            btnSaveCurrent.Location = new Point(790, 47);
            btnSaveCurrent.Margin = new Padding(3, 4, 3, 4);
            btnSaveCurrent.Name = "btnSaveCurrent";
            btnSaveCurrent.Size = new Size(149, 31);
            btnSaveCurrent.TabIndex = 53;
            btnSaveCurrent.Text = "SAVE";
            btnSaveCurrent.UseVisualStyleBackColor = false;
            btnSaveCurrent.Click += OnBtnSaveCurrent_Click;
            // 
            // btnFindFolder
            // 
            btnFindFolder.BackColor = SystemColors.MenuText;
            btnFindFolder.BorderColor = Color.FromArgb(70, 70, 70);
            btnFindFolder.FlatAppearance.BorderSize = 0;
            btnFindFolder.FlatStyle = FlatStyle.Flat;
            btnFindFolder.Font = new Font("Arial", 8F);
            btnFindFolder.ForeColor = Color.Transparent;
            btnFindFolder.Location = new Point(790, 10);
            btnFindFolder.Margin = new Padding(3, 4, 3, 4);
            btnFindFolder.Name = "btnFindFolder";
            btnFindFolder.Size = new Size(149, 31);
            btnFindFolder.TabIndex = 48;
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
            btnLoadConfigs.Font = new Font("Arial", 8F);
            btnLoadConfigs.ForeColor = Color.Transparent;
            btnLoadConfigs.Location = new Point(945, 10);
            btnLoadConfigs.Margin = new Padding(3, 4, 3, 4);
            btnLoadConfigs.Name = "btnLoadConfigs";
            btnLoadConfigs.Size = new Size(149, 31);
            btnLoadConfigs.TabIndex = 49;
            btnLoadConfigs.Text = "Load Configs";
            btnLoadConfigs.UseVisualStyleBackColor = false;
            btnLoadConfigs.Click += OnLoadConfigurations_Click;
            // 
            // btnExportValue
            // 
            btnExportValue.BackColor = SystemColors.MenuText;
            btnExportValue.BorderColor = Color.FromArgb(70, 70, 70);
            btnExportValue.FlatAppearance.BorderSize = 0;
            btnExportValue.FlatStyle = FlatStyle.Flat;
            btnExportValue.Font = new Font("Arial", 9F);
            btnExportValue.ForeColor = Color.Transparent;
            btnExportValue.Location = new Point(766, 495);
            btnExportValue.Margin = new Padding(3, 4, 3, 4);
            btnExportValue.Name = "btnExportValue";
            btnExportValue.Size = new Size(153, 31);
            btnExportValue.TabIndex = 56;
            btnExportValue.Text = "Add to Clipboard";
            btnExportValue.UseVisualStyleBackColor = false;
            btnExportValue.Click += OnAddToClipboard_Click;
            // 
            // btnShowClipboard
            // 
            btnShowClipboard.BackColor = SystemColors.MenuText;
            btnShowClipboard.BorderColor = Color.FromArgb(70, 70, 70);
            btnShowClipboard.FlatAppearance.BorderSize = 0;
            btnShowClipboard.FlatStyle = FlatStyle.Flat;
            btnShowClipboard.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnShowClipboard.ForeColor = Color.Transparent;
            btnShowClipboard.Location = new Point(925, 495);
            btnShowClipboard.Margin = new Padding(3, 4, 3, 4);
            btnShowClipboard.Name = "btnShowClipboard";
            btnShowClipboard.Size = new Size(158, 31);
            btnShowClipboard.TabIndex = 55;
            btnShowClipboard.Text = "Show Clipboard";
            btnShowClipboard.UseVisualStyleBackColor = false;
            btnShowClipboard.Click += OnShowClipboard_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(757, 92);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 52;
            label5.Text = "Value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(383, 65);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 51;
            label4.Text = "Keys";
            // 
            // pnlConfigKeys
            // 
            pnlConfigKeys.AllowDrop = true;
            pnlConfigKeys.AutoScroll = true;
            pnlConfigKeys.BackColor = SystemColors.WindowFrame;
            pnlConfigKeys.BorderStyle = BorderStyle.FixedSingle;
            pnlConfigKeys.FlowDirection = FlowDirection.TopDown;
            pnlConfigKeys.ForeColor = Color.Transparent;
            pnlConfigKeys.Location = new Point(383, 88);
            pnlConfigKeys.Name = "pnlConfigKeys";
            pnlConfigKeys.Size = new Size(368, 474);
            pnlConfigKeys.TabIndex = 47;
            pnlConfigKeys.WrapContents = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 66);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 46;
            label3.Text = "Configurations";
            // 
            // pnlConfigurations
            // 
            pnlConfigurations.AllowDrop = true;
            pnlConfigurations.AutoScroll = true;
            pnlConfigurations.BackColor = SystemColors.WindowFrame;
            pnlConfigurations.BorderStyle = BorderStyle.FixedSingle;
            pnlConfigurations.FlowDirection = FlowDirection.TopDown;
            pnlConfigurations.ForeColor = Color.Transparent;
            pnlConfigurations.Location = new Point(12, 89);
            pnlConfigurations.Name = "pnlConfigurations";
            pnlConfigurations.Size = new Size(365, 473);
            pnlConfigurations.TabIndex = 45;
            pnlConfigurations.WrapContents = false;
            // 
            // tbKeyValue
            // 
            tbKeyValue.BackColor = SystemColors.WindowFrame;
            tbKeyValue.BorderColor = Color.FromArgb(70, 70, 70);
            tbKeyValue.BorderStyle = BorderStyle.FixedSingle;
            tbKeyValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbKeyValue.ForeColor = SystemColors.HighlightText;
            tbKeyValue.Location = new Point(757, 112);
            tbKeyValue.Multiline = true;
            tbKeyValue.Name = "tbKeyValue";
            tbKeyValue.ScrollBars = ScrollBars.Vertical;
            tbKeyValue.Size = new Size(337, 376);
            tbKeyValue.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 6.25F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(115, 44);
            label2.Name = "label2";
            label2.Size = new Size(429, 13);
            label2.TabIndex = 44;
            label2.Text = "After selecting 'Load Configs' all .json configurations from all child directories will be loaded";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(5, 14);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 42;
            label1.Text = "Base location:";
            // 
            // tbBaseFolder
            // 
            tbBaseFolder.BackColor = SystemColors.WindowFrame;
            tbBaseFolder.BorderColor = Color.FromArgb(70, 70, 70);
            tbBaseFolder.BorderStyle = BorderStyle.FixedSingle;
            tbBaseFolder.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            tbBaseFolder.ForeColor = SystemColors.HighlightText;
            tbBaseFolder.Location = new Point(116, 12);
            tbBaseFolder.Name = "tbBaseFolder";
            tbBaseFolder.Size = new Size(657, 25);
            tbBaseFolder.TabIndex = 43;
            tbBaseFolder.Text = "A:\\\\AAAAAAAAAA";
            // 
            // btnEditClipboardValues
            // 
            btnEditClipboardValues.BackColor = Color.Black;
            btnEditClipboardValues.BorderColor = Color.FromArgb(70, 70, 70);
            btnEditClipboardValues.FlatAppearance.BorderSize = 0;
            btnEditClipboardValues.FlatStyle = FlatStyle.Flat;
            btnEditClipboardValues.Font = new Font("Arial", 8F);
            btnEditClipboardValues.ForeColor = Color.White;
            btnEditClipboardValues.Location = new Point(766, 533);
            btnEditClipboardValues.Name = "btnEditClipboardValues";
            btnEditClipboardValues.Size = new Size(317, 29);
            btnEditClipboardValues.TabIndex = 63;
            btnEditClipboardValues.Text = "Edit clipboard values";
            btnEditClipboardValues.UseVisualStyleBackColor = false;
            btnEditClipboardValues.Click += OnChangeSavedClipboardValues_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1106, 574);
            Controls.Add(btnEditClipboardValues);
            Controls.Add(btnSaveAll);
            Controls.Add(notifySavingPannel);
            Controls.Add(btnSaveCurrent);
            Controls.Add(btnFindFolder);
            Controls.Add(btnLoadConfigs);
            Controls.Add(btnExportValue);
            Controls.Add(btnShowClipboard);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pnlConfigKeys);
            Controls.Add(label3);
            Controls.Add(pnlConfigurations);
            Controls.Add(tbKeyValue);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbBaseFolder);
            ForeColor = Color.Gray;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Configuration Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DarkButton btnSaveAll;
        private Panel notifySavingPannel;
        private DarkButton btnSaveCurrent;
        private DarkButton btnFindFolder;
        private DarkButton btnLoadConfigs;
        private DarkButton btnExportValue;
        private FolderBrowserDialog folderBrowserDialog1;
        private DarkButton btnShowClipboard;
        private Label label5;
        private Label label4;
        internal FlowLayoutPanel pnlConfigKeys;
        private Label label3;
        private FlowLayoutPanel pnlConfigurations;
        internal DarkTextBox tbKeyValue;
        private Label label2;
        private Label label1;
        private DarkTextBox tbBaseFolder;
        private DarkButton btnEditClipboardValues;
    }
}
