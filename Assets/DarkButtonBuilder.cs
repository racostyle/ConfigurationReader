using ConfigurationReader.Utilities;

namespace ConfigurationReader.Assets
{
    internal class DarkButtonBuilder
    {
        private readonly int _buttonWidth;
        private readonly int _buttonHeight;

        public DarkButtonBuilder(int buttonWidth, int buttonHeight)
        {
            // -20 for scrollable bar
            _buttonWidth = buttonWidth - 20;
            _buttonHeight = buttonHeight;
        }

        internal DarkButton Create(SConfigData sConfgData, int index, Panel panel)
        {
            DarkButton some = new DarkButton();
            some.Location = new Point(0, index * (_buttonHeight + 5));
            some.Width = _buttonWidth;
            some.Height = _buttonHeight;
            some.Text = FilterButtonName(sConfgData.FullName, 3);
            some.BackColor = Color.Black;
            some.BackgroundImageLayout = ImageLayout.None;
            some.ForeColor = SystemColors.HighlightText;
            some.Font = new Font(some.Font.FontFamily, 8, FontStyle.Regular);
            some.TextAlign = ContentAlignment.MiddleCenter;

            if (panel != null)
                some.Left = (panel.Width - some.Width) / 2;

            some.Click += new EventHandler((sndr, evt) =>
            {

            });

            return some;
        }

        private string FilterButtonName(string fullName, int depth = 2)
        {
            var parts = fullName.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);

            if (depth > parts.Length)
                depth = parts.Length;

            var selectedParts = parts.Skip(parts.Length - depth).ToArray();
            if (selectedParts.Length > 0)
            {
                int last = selectedParts.Length - 1;
                selectedParts[last] = selectedParts[last].Replace(".Json", string.Empty, StringComparison.CurrentCultureIgnoreCase).Trim();
            }

            return string.Join("\\", selectedParts);
        }
    }
}
