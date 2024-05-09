namespace ConfigurationReader.Assets
{
    internal class DarkButton : Button
    {
        private Color borderColor = CustomColors.BORDER_COLOR;

        public Color BorderColor
        {
            get { return borderColor; }
            set { borderColor = value; Invalidate(); } 
        }

        public DarkButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0; 
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            int thickness = 2; 
            int halfThickness = thickness / 2;
            using (Pen p = new Pen(borderColor, thickness))
            {
                pevent.Graphics.DrawRectangle(p, new Rectangle(halfThickness, halfThickness,
                    ClientSize.Width - thickness, ClientSize.Height - thickness));
            }
        }
    }
}
