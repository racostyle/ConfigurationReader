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
            label7 = new Label();
            btnSaveAll = new DarkButton();
            notifySavingPannel = new Panel();
            btnSaveCurrent = new DarkButton();
            btnFindFolder = new DarkButton();
            btnLoadConfigs = new DarkButton();
            tbSelectedKey = new DarkTextBox();
            label6 = new Label();
            cbSavedValues = new DarkComboBox();
            btnExportSetting = new DarkButton();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnImportSetting = new DarkButton();
            label5 = new Label();
            label4 = new Label();
            pnlConfigKeys = new FlowLayoutPanel();
            label3 = new Label();
            pnlConfigurations = new FlowLayoutPanel();
            tbKeyValue = new DarkTextBox();
            label2 = new Label();
            label1 = new Label();
            tbBaseFolder = new DarkTextBox();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(12, 506);
            label7.Name = "label7";
            label7.Size = new Size(80, 20);
            label7.TabIndex = 57;
            label7.Text = "Clipboard:";
            // 
            // btnSaveAll
            // 
            btnSaveAll.BackColor = SystemColors.MenuText;
            btnSaveAll.BorderColor = Color.FromArgb(70, 70, 70);
            btnSaveAll.FlatAppearance.BorderSize = 0;
            btnSaveAll.FlatStyle = FlatStyle.Flat;
            btnSaveAll.Font = new Font("Arial", 8F);
            btnSaveAll.ForeColor = Color.Transparent;
            btnSaveAll.Location = new Point(769, 48);
            btnSaveAll.Margin = new Padding(3, 4, 3, 4);
            btnSaveAll.Name = "btnSaveAll";
            btnSaveAll.Size = new Size(123, 31);
            btnSaveAll.TabIndex = 54;
            btnSaveAll.Text = "SAVE ALL";
            btnSaveAll.UseVisualStyleBackColor = false;
            // 
            // notifySavingPannel
            // 
            notifySavingPannel.Location = new Point(644, 83);
            notifySavingPannel.Name = "notifySavingPannel";
            notifySavingPannel.Size = new Size(250, 7);
            notifySavingPannel.TabIndex = 60;
            // 
            // btnSaveCurrent
            // 
            btnSaveCurrent.BackColor = SystemColors.MenuText;
            btnSaveCurrent.BorderColor = Color.FromArgb(70, 70, 70);
            btnSaveCurrent.FlatAppearance.BorderSize = 0;
            btnSaveCurrent.FlatStyle = FlatStyle.Flat;
            btnSaveCurrent.Font = new Font("Arial", 8F);
            btnSaveCurrent.ForeColor = Color.Transparent;
            btnSaveCurrent.Location = new Point(643, 48);
            btnSaveCurrent.Margin = new Padding(3, 4, 3, 4);
            btnSaveCurrent.Name = "btnSaveCurrent";
            btnSaveCurrent.Size = new Size(121, 31);
            btnSaveCurrent.TabIndex = 53;
            btnSaveCurrent.Text = "SAVE";
            btnSaveCurrent.UseVisualStyleBackColor = false;
            // 
            // btnFindFolder
            // 
            btnFindFolder.BackColor = SystemColors.MenuText;
            btnFindFolder.BorderColor = Color.FromArgb(70, 70, 70);
            btnFindFolder.FlatAppearance.BorderSize = 0;
            btnFindFolder.FlatStyle = FlatStyle.Flat;
            btnFindFolder.Font = new Font("Arial", 8F);
            btnFindFolder.ForeColor = Color.Transparent;
            btnFindFolder.Location = new Point(643, 11);
            btnFindFolder.Margin = new Padding(3, 4, 3, 4);
            btnFindFolder.Name = "btnFindFolder";
            btnFindFolder.Size = new Size(121, 31);
            btnFindFolder.TabIndex = 48;
            btnFindFolder.Text = "Find Folder";
            btnFindFolder.UseVisualStyleBackColor = false;
            // 
            // btnLoadConfigs
            // 
            btnLoadConfigs.BackColor = SystemColors.MenuText;
            btnLoadConfigs.BorderColor = Color.FromArgb(70, 70, 70);
            btnLoadConfigs.FlatAppearance.BorderSize = 0;
            btnLoadConfigs.FlatStyle = FlatStyle.Flat;
            btnLoadConfigs.Font = new Font("Arial", 8F);
            btnLoadConfigs.ForeColor = Color.Transparent;
            btnLoadConfigs.Location = new Point(769, 11);
            btnLoadConfigs.Margin = new Padding(3, 4, 3, 4);
            btnLoadConfigs.Name = "btnLoadConfigs";
            btnLoadConfigs.Size = new Size(123, 31);
            btnLoadConfigs.TabIndex = 49;
            btnLoadConfigs.Text = "Load Configs";
            btnLoadConfigs.UseVisualStyleBackColor = false;
            // 
            // tbSelectedKey
            // 
            tbSelectedKey.BackColor = SystemColors.WindowFrame;
            tbSelectedKey.BorderColor = Color.FromArgb(70, 70, 70);
            tbSelectedKey.BorderStyle = BorderStyle.FixedSingle;
            tbSelectedKey.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            tbSelectedKey.ForeColor = SystemColors.HighlightText;
            tbSelectedKey.Location = new Point(575, 115);
            tbSelectedKey.Name = "tbSelectedKey";
            tbSelectedKey.ReadOnly = true;
            tbSelectedKey.Size = new Size(319, 25);
            tbSelectedKey.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(576, 92);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 58;
            label6.Text = "Selected Key";
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
            cbSavedValues.Location = new Point(98, 505);
            cbSavedValues.Margin = new Padding(3, 4, 3, 4);
            cbSavedValues.Name = "cbSavedValues";
            cbSavedValues.Size = new Size(799, 25);
            cbSavedValues.TabIndex = 61;
            // 
            // btnExportSetting
            // 
            btnExportSetting.BackColor = SystemColors.MenuText;
            btnExportSetting.BorderColor = Color.FromArgb(70, 70, 70);
            btnExportSetting.FlatAppearance.BorderSize = 0;
            btnExportSetting.FlatStyle = FlatStyle.Flat;
            btnExportSetting.Font = new Font("Arial", 9F);
            btnExportSetting.ForeColor = Color.Transparent;
            btnExportSetting.Location = new Point(576, 468);
            btnExportSetting.Margin = new Padding(3, 4, 3, 4);
            btnExportSetting.Name = "btnExportSetting";
            btnExportSetting.Size = new Size(153, 31);
            btnExportSetting.TabIndex = 56;
            btnExportSetting.Text = "To Clipboard ↓";
            btnExportSetting.UseVisualStyleBackColor = false;
            // 
            // btnImportSetting
            // 
            btnImportSetting.BackColor = SystemColors.MenuText;
            btnImportSetting.BorderColor = Color.FromArgb(70, 70, 70);
            btnImportSetting.FlatAppearance.BorderSize = 0;
            btnImportSetting.FlatStyle = FlatStyle.Flat;
            btnImportSetting.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btnImportSetting.ForeColor = Color.Transparent;
            btnImportSetting.Location = new Point(736, 468);
            btnImportSetting.Margin = new Padding(3, 4, 3, 4);
            btnImportSetting.Name = "btnImportSetting";
            btnImportSetting.Size = new Size(158, 31);
            btnImportSetting.TabIndex = 55;
            btnImportSetting.Text = "From Clipboard ↑";
            btnImportSetting.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(576, 147);
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
            label4.Location = new Point(286, 70);
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
            pnlConfigKeys.Location = new Point(286, 93);
            pnlConfigKeys.Name = "pnlConfigKeys";
            pnlConfigKeys.Size = new Size(284, 405);
            pnlConfigKeys.TabIndex = 47;
            pnlConfigKeys.WrapContents = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(10, 70);
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
            pnlConfigurations.Location = new Point(10, 93);
            pnlConfigurations.Name = "pnlConfigurations";
            pnlConfigurations.Size = new Size(270, 405);
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
            tbKeyValue.Location = new Point(576, 168);
            tbKeyValue.Multiline = true;
            tbKeyValue.Name = "tbKeyValue";
            tbKeyValue.ScrollBars = ScrollBars.Vertical;
            tbKeyValue.Size = new Size(317, 294);
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
            tbBaseFolder.Size = new Size(520, 25);
            tbBaseFolder.TabIndex = 43;
            tbBaseFolder.Text = "A:\\\\AAAAAAAAAA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(909, 539);
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

        private Label label7;
        private DarkButton btnSaveAll;
        private Panel notifySavingPannel;
        private DarkButton btnSaveCurrent;
        private DarkButton btnFindFolder;
        private DarkButton btnLoadConfigs;
        private DarkTextBox tbSelectedKey;
        private Label label6;
        private DarkComboBox cbSavedValues;
        private DarkButton btnExportSetting;
        private FolderBrowserDialog folderBrowserDialog1;
        private DarkButton btnImportSetting;
        private Label label5;
        private Label label4;
        private FlowLayoutPanel pnlConfigKeys;
        private Label label3;
        private FlowLayoutPanel pnlConfigurations;
        private DarkTextBox tbKeyValue;
        private Label label2;
        private Label label1;
        private DarkTextBox tbBaseFolder;
    }
}
