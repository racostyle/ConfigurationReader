namespace ConfigurationReader
{
    partial class ClipboardForm
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
            pnlValues = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // pnlValues
            // 
            pnlValues.AllowDrop = true;
            pnlValues.AutoScroll = true;
            pnlValues.BackColor = SystemColors.WindowFrame;
            pnlValues.BorderStyle = BorderStyle.FixedSingle;
            pnlValues.FlowDirection = FlowDirection.TopDown;
            pnlValues.ForeColor = Color.Transparent;
            pnlValues.Location = new Point(12, 12);
            pnlValues.Name = "pnlValues";
            pnlValues.Size = new Size(578, 438);
            pnlValues.TabIndex = 46;
            pnlValues.WrapContents = false;
            // 
            // ClipboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 462);
            Controls.Add(pnlValues);
            Name = "ClipboardForm";
            Text = "Clipboard";
            ResumeLayout(false);
        }

        #endregion

        internal FlowLayoutPanel pnlValues;
    }
}