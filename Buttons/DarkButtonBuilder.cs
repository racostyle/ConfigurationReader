﻿using ConfigurationReader.Assets;
using ConfigurationReader.Utilities;

namespace ConfigurationReader.Buttons
{
    internal class DarkButtonBuilder
    {
        private readonly int _buttonWidth;
        private readonly int _buttonHeight;
        private readonly ToolTip _toolTip;
        private readonly EventHandler _onValueTbTextChangeHandler;

        public DarkButtonBuilder(int buttonWidth, int buttonHeight, ToolTip toolTip, EventHandler _onValueTbTextChangeHandler)
        {
            _buttonWidth = buttonWidth - 20;
            _buttonHeight = buttonHeight;
            _toolTip = toolTip;
            this._onValueTbTextChangeHandler = _onValueTbTextChangeHandler;
        }
        internal DarkButton Create(ConfigData sConfgData, int index, Panel configPanel, Form1 form, List<DarkButton> mainButtons, LoadedConfigsHandler loadedConfigs)
        {
            DarkButton some = CreateButton(FilterButtonName(sConfgData.FullName, 3), index, configPanel, 1.3f);
            _ = new HandlerBuilder_ConfigBtn(sConfgData, form, mainButtons, loadedConfigs, some, this, _onValueTbTextChangeHandler);
            return some;
        }

        internal DarkButton CreateButton(string name, int index, Panel panel, float heightMulti = 1)
        {
            float height = _buttonHeight;
            float finalHeight = height * heightMulti;

            DarkButton some = new DarkButton();
            some.Location = new Point(0, index * (_buttonHeight + 5));
            some.Width = _buttonWidth;
            some.Height = (int)finalHeight;
            some.Text = name;
            some.BackgroundImageLayout = ImageLayout.None;
            some.TextAlign = ContentAlignment.MiddleCenter;
            if (panel != null)
                some.Left = (panel.Width - some.Width) / 2;

            _toolTip.SetToolTip(some, some.Text);
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
                selectedParts[last] = selectedParts[last]
                    .Replace(".Json", string.Empty, StringComparison.CurrentCultureIgnoreCase)
                    .Replace(".Secrets", ".S", StringComparison.CurrentCultureIgnoreCase)
                    .Trim();
            }

            return string.Join("\\", selectedParts);
        }
    }
}
