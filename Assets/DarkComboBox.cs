namespace ConfigurationReader.Assets
{
    internal class DarkComboBox : ComboBox
    {
        private Color borderColor = CustomColors.BORDER_COLOR;

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); }
        }

        public DarkComboBox()
        {
            this.Font = new Font("Arial", 8, FontStyle.Regular);
            this.FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            int thickness = 2;
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(borderColor, thickness))
            {
                e.Graphics.DrawRectangle(p, new Rectangle(halfThickness, halfThickness,
                    ClientSize.Width - thickness, ClientSize.Height - thickness));
            }
        }
    }
}
