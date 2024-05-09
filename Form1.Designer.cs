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
            btnFindFolder = new Button();
            label2 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            btnLoadConfigs = new Button();
            SuspendLayout();
            // 
            // tbBaseFolder
            // 
            tbBaseFolder.BackColor = SystemColors.ScrollBar;
            tbBaseFolder.Location = new Point(116, 11);
            tbBaseFolder.Name = "tbBaseFolder";
            tbBaseFolder.Size = new Size(439, 27);
            tbBaseFolder.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(8, 14);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 1;
            label1.Text = "Base location";
            // 
            // btnFindFolder
            // 
            btnFindFolder.BackColor = Color.Black;
            btnFindFolder.BackgroundImageLayout = ImageLayout.None;
            btnFindFolder.ForeColor = SystemColors.HighlightText;
            btnFindFolder.Location = new Point(565, 8);
            btnFindFolder.Name = "btnFindFolder";
            btnFindFolder.Size = new Size(114, 32);
            btnFindFolder.TabIndex = 2;
            btnFindFolder.Text = "Find Folder";
            btnFindFolder.UseVisualStyleBackColor = false;
            btnFindFolder.Click += OnFindFolder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 6.25F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(116, 41);
            label2.Name = "label2";
            label2.Size = new Size(382, 13);
            label2.TabIndex = 3;
            label2.Text = "After selecting 'base location' all programs from all child directories will be loaded";
            // 
            // btnLoadConfigs
            // 
            btnLoadConfigs.BackColor = Color.Black;
            btnLoadConfigs.BackgroundImageLayout = ImageLayout.None;
            btnLoadConfigs.ForeColor = SystemColors.HighlightText;
            btnLoadConfigs.Location = new Point(685, 8);
            btnLoadConfigs.Name = "btnLoadConfigs";
            btnLoadConfigs.Size = new Size(114, 32);
            btnLoadConfigs.TabIndex = 4;
            btnLoadConfigs.Text = "Load Configs";
            btnLoadConfigs.UseVisualStyleBackColor = false;
            btnLoadConfigs.Click += OnLoadConfigurations_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(811, 450);
            Controls.Add(btnLoadConfigs);
            Controls.Add(label2);
            Controls.Add(btnFindFolder);
            Controls.Add(label1);
            Controls.Add(tbBaseFolder);
            ForeColor = Color.DimGray;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbBaseFolder;
        private Label label1;
        private Button btnFindFolder;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button btnLoadConfigs;
    }
}
