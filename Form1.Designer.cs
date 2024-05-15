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
            tbBaseFolder = new DarkTextBox();
            label1 = new Label();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            pnlConfigurations = new FlowLayoutPanel();
            label3 = new Label();
            pnlConfigKeys = new FlowLayoutPanel();
            btnFindFolder = new DarkButton();
            btnLoadConfigs = new DarkButton();
            tbKeyValue = new DarkTextBox();
            label4 = new Label();
            label5 = new Label();
            btnSaveCurrent = new DarkButton();
            btnSaveAll = new DarkButton();
            btnImportSetting = new DarkButton();
            btnExportSetting = new DarkButton();
            cbSavedValues = new DarkComboBox();
            label6 = new Label();
            tbSelectedKey = new DarkTextBox();
            notifySavingPannel = new Panel();
            label7 = new Label();
            SuspendLayout();
            // 
            // tbBaseFolder
            // 
            tbBaseFolder.Anchor = AnchorStyles.Left;
            tbBaseFolder.BackColor = SystemColors.WindowFrame;
            tbBaseFolder.BorderColor = Color.FromArgb(70, 70, 70);
            tbBaseFolder.BorderStyle = BorderStyle.FixedSingle;
            tbBaseFolder.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            tbBaseFolder.ForeColor = SystemColors.HighlightText;
            tbBaseFolder.Location = new Point(96, 9);
            tbBaseFolder.Margin = new Padding(3, 2, 3, 2);
            tbBaseFolder.Name = "tbBaseFolder";
            tbBaseFolder.Size = new Size(455, 22);
            tbBaseFolder.TabIndex = 0;
            tbBaseFolder.Text = "A:\\\\AAAAAAAAAA";
            tbBaseFolder.TextChanged += OnTbBaseFolder_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "Base location:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 6.25F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(95, 33);
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
            pnlConfigurations.BorderStyle = BorderStyle.FixedSingle;
            pnlConfigurations.FlowDirection = FlowDirection.TopDown;
            pnlConfigurations.ForeColor = Color.Transparent;
            pnlConfigurations.Location = new Point(12, 70);
            pnlConfigurations.Margin = new Padding(3, 2, 3, 2);
            pnlConfigurations.Name = "pnlConfigurations";
            pnlConfigurations.Size = new Size(233, 304);
            pnlConfigurations.TabIndex = 5;
            pnlConfigurations.WrapContents = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(10, 52);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 6;
            label3.Text = "Configurations";
            // 
            // pnlConfigKeys
            // 
            pnlConfigKeys.AllowDrop = true;
            pnlConfigKeys.Anchor = AnchorStyles.Top;
            pnlConfigKeys.AutoScroll = true;
            pnlConfigKeys.BackColor = SystemColors.WindowFrame;
            pnlConfigKeys.BorderStyle = BorderStyle.FixedSingle;
            pnlConfigKeys.FlowDirection = FlowDirection.TopDown;
            pnlConfigKeys.ForeColor = Color.Transparent;
            pnlConfigKeys.Location = new Point(251, 70);
            pnlConfigKeys.Margin = new Padding(3, 2, 3, 2);
            pnlConfigKeys.Name = "pnlConfigKeys";
            pnlConfigKeys.Size = new Size(242, 304);
            pnlConfigKeys.TabIndex = 6;
            pnlConfigKeys.WrapContents = false;
            // 
            // btnFindFolder
            // 
            btnFindFolder.BackColor = SystemColors.MenuText;
            btnFindFolder.BorderColor = Color.FromArgb(70, 70, 70);
            btnFindFolder.FlatAppearance.BorderSize = 0;
            btnFindFolder.FlatStyle = FlatStyle.Flat;
            btnFindFolder.Font = new Font("Arial", 8F);
            btnFindFolder.ForeColor = Color.Transparent;
            btnFindFolder.Location = new Point(557, 8);
            btnFindFolder.Name = "btnFindFolder";
            btnFindFolder.Size = new Size(106, 23);
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
            btnLoadConfigs.Font = new Font("Arial", 8F);
            btnLoadConfigs.ForeColor = Color.Transparent;
            btnLoadConfigs.Location = new Point(669, 8);
            btnLoadConfigs.Name = "btnLoadConfigs";
            btnLoadConfigs.Size = new Size(108, 23);
            btnLoadConfigs.TabIndex = 9;
            btnLoadConfigs.Text = "Load Configs";
            btnLoadConfigs.UseVisualStyleBackColor = false;
            btnLoadConfigs.Click += OnLoadConfigurations_Click;
            // 
            // tbKeyValue
            // 
            tbKeyValue.BackColor = SystemColors.WindowFrame;
            tbKeyValue.BorderColor = Color.FromArgb(70, 70, 70);
            tbKeyValue.BorderStyle = BorderStyle.FixedSingle;
            tbKeyValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbKeyValue.ForeColor = SystemColors.HighlightText;
            tbKeyValue.Location = new Point(499, 126);
            tbKeyValue.Margin = new Padding(3, 2, 3, 2);
            tbKeyValue.Multiline = true;
            tbKeyValue.Name = "tbKeyValue";
            tbKeyValue.ScrollBars = ScrollBars.Vertical;
            tbKeyValue.Size = new Size(278, 221);
            tbKeyValue.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(242, 53);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 11;
            label4.Text = "Keys";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(499, 110);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 12;
            label5.Text = "Value";
            // 
            // btnSaveCurrent
            // 
            btnSaveCurrent.BackColor = SystemColors.MenuText;
            btnSaveCurrent.BorderColor = Color.FromArgb(70, 70, 70);
            btnSaveCurrent.FlatAppearance.BorderSize = 0;
            btnSaveCurrent.FlatStyle = FlatStyle.Flat;
            btnSaveCurrent.Font = new Font("Arial", 8F);
            btnSaveCurrent.ForeColor = Color.Transparent;
            btnSaveCurrent.Location = new Point(557, 36);
            btnSaveCurrent.Name = "btnSaveCurrent";
            btnSaveCurrent.Size = new Size(106, 23);
            btnSaveCurrent.TabIndex = 13;
            btnSaveCurrent.Text = "SAVE";
            btnSaveCurrent.UseVisualStyleBackColor = false;
            btnSaveCurrent.Click += OnBtnSaveCurrent_Click;
            // 
            // btnSaveAll
            // 
            btnSaveAll.BackColor = SystemColors.MenuText;
            btnSaveAll.BorderColor = Color.FromArgb(70, 70, 70);
            btnSaveAll.FlatAppearance.BorderSize = 0;
            btnSaveAll.FlatStyle = FlatStyle.Flat;
            btnSaveAll.Font = new Font("Arial", 8F);
            btnSaveAll.ForeColor = Color.Transparent;
            btnSaveAll.Location = new Point(668, 36);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new Size(108, 23);
            btnSaveAll.TabIndex = 14;
            btnSaveAll.Text = "SAVE ALL";
            btnSaveAll.UseVisualStyleBackColor = false;
            btnSaveAll.Click += OnBtnSaveAll_Click;
            // 
            // btnImportSetting
            // 
            btnImportSetting.BackColor = SystemColors.MenuText;
            btnImportSetting.BorderColor = Color.FromArgb(70, 70, 70);
            btnImportSetting.FlatAppearance.BorderSize = 0;
            btnImportSetting.FlatStyle = FlatStyle.Flat;
            btnImportSetting.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnImportSetting.ForeColor = Color.Transparent;
            btnImportSetting.Location = new Point(639, 351);
            btnImportSetting.Name = "btnImportSetting";
            btnImportSetting.Size = new Size(138, 23);
            btnImportSetting.TabIndex = 15;
            btnImportSetting.Text = "From Clipboard ↑";
            btnImportSetting.UseVisualStyleBackColor = false;
            btnImportSetting.Click += OnBtnFromClipboard_Click;
            // 
            // btnExportSetting
            // 
            btnExportSetting.BackColor = SystemColors.MenuText;
            btnExportSetting.BorderColor = Color.FromArgb(70, 70, 70);
            btnExportSetting.FlatAppearance.BorderSize = 0;
            btnExportSetting.FlatStyle = FlatStyle.Flat;
            btnExportSetting.Font = new Font("Arial", 9F);
            btnExportSetting.ForeColor = Color.Transparent;
            btnExportSetting.Location = new Point(499, 351);
            btnExportSetting.Name = "btnExportSetting";
            btnExportSetting.Size = new Size(134, 23);
            btnExportSetting.TabIndex = 16;
            btnExportSetting.Text = "To Clipboard ↓";
            btnExportSetting.UseVisualStyleBackColor = false;
            btnExportSetting.Click += OnBtnToClipboard_Click;
            // 
            // cbSavedValues
            // 
            cbSavedValues.BackColor = Color.Black;
            cbSavedValues.BorderColor = Color.FromArgb(70, 70, 70);
            cbSavedValues.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSavedValues.FlatStyle = FlatStyle.Flat;
            cbSavedValues.Font = new Font("Arial", 9F);
            cbSavedValues.ForeColor = Color.White;
            cbSavedValues.FormattingEnabled = true;
            cbSavedValues.Location = new Point(87, 379);
            cbSavedValues.Name = "cbSavedValues";
            cbSavedValues.Size = new Size(689, 23);
            cbSavedValues.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(499, 69);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 18;
            label6.Text = "Selected Key";
            // 
            // tbSelectedKey
            // 
            tbSelectedKey.Anchor = AnchorStyles.Left;
            tbSelectedKey.BackColor = SystemColors.WindowFrame;
            tbSelectedKey.BorderColor = Color.FromArgb(70, 70, 70);
            tbSelectedKey.BorderStyle = BorderStyle.FixedSingle;
            tbSelectedKey.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            tbSelectedKey.ForeColor = SystemColors.HighlightText;
            tbSelectedKey.Location = new Point(498, 86);
            tbSelectedKey.Margin = new Padding(3, 2, 3, 2);
            tbSelectedKey.Name = "tbSelectedKey";
            tbSelectedKey.ReadOnly = true;
            tbSelectedKey.Size = new Size(279, 22);
            tbSelectedKey.TabIndex = 19;
            // 
            // notifySavingPannel
            // 
            notifySavingPannel.Location = new Point(558, 62);
            notifySavingPannel.Margin = new Padding(3, 2, 3, 2);
            notifySavingPannel.Name = "notifySavingPannel";
            notifySavingPannel.Size = new Size(219, 5);
            notifySavingPannel.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(12, 382);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 21;
            label7.Text = "Clipboard:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(789, 406);
            Controls.Add(label7);
            Controls.Add(btnSaveAll);
            Controls.Add(notifySavingPannel);
            Controls.Add(btnSaveCurrent);
            Controls.Add(btnFindFolder);
            Controls.Add(btnLoadConfigs);
            Controls.Add(tbSelectedKey);
            Controls.Add(label6);
            Controls.Add(cbSavedValues);
            Controls.Add(btnExportSetting);
            Controls.Add(btnImportSetting);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tbKeyValue);
            Controls.Add(pnlConfigKeys);
            Controls.Add(label3);
            Controls.Add(pnlConfigurations);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbBaseFolder);
            ForeColor = Color.Gray;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Configuration Editor";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private DarkTextBox tbBaseFolder;
        private DarkTextBox tbKeyValue;
        private DarkTextBox tbSelectedKey;
        private DarkButton btnFindFolder;
        private DarkButton btnLoadConfigs;
        private DarkButton btnSaveCurrent;
        private DarkButton btnSaveAll;
        private DarkButton btnImportSetting;
        private DarkButton btnExportSetting;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private FlowLayoutPanel pnlConfigurations;
        private FlowLayoutPanel pnlConfigKeys;
        private DarkComboBox cbSavedValues;
        private Panel notifySavingPannel;
        private Label label7;
    }
}
