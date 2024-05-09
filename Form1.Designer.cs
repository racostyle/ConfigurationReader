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
            SuspendLayout();
            // 
            // tbBaseFolder
            // 
            tbBaseFolder.BackColor = SystemColors.ScrollBar;
            tbBaseFolder.Location = new Point(116, 11);
            tbBaseFolder.Name = "tbBaseFolder";
            tbBaseFolder.Size = new Size(517, 27);
            tbBaseFolder.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 1;
            label1.Text = "Base location";
            label1.Click += label1_Click;
            // 
            // btnFindFolder
            // 
            btnFindFolder.BackColor = Color.Black;
            btnFindFolder.BackgroundImageLayout = ImageLayout.None;
            btnFindFolder.ForeColor = SystemColors.Control;
            btnFindFolder.Location = new Point(639, 8);
            btnFindFolder.Name = "btnFindFolder";
            btnFindFolder.Size = new Size(149, 32);
            btnFindFolder.TabIndex = 2;
            btnFindFolder.Text = "FindFolder";
            btnFindFolder.UseVisualStyleBackColor = false;
            btnFindFolder.Click += OnFindFolder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 6.25F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(116, 41);
            label2.Name = "label2";
            label2.Size = new Size(382, 13);
            label2.TabIndex = 3;
            label2.Text = "After selecting 'base location' all programs from all child directories will be loaded";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 450);
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
    }
}
