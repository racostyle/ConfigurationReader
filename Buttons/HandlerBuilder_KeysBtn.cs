using ConfigurationReader.Assets;
using ConfigurationReader.Utilities;

namespace ConfigurationReader.Buttons
{
    internal class HandlerBuilder_KeysBtn : ButtonHandler
    {
        private DarkButton _button;
        private readonly LoadedConfigsHandler _loadedConfigs;
        private readonly Action<string> _changeTextWithoutTrigger;

        public HandlerBuilder_KeysBtn(DarkButton button, List<DarkButton> buttons, Form1 form, ConfigData sConfgData, LoadedConfigsHandler loadedConfigs, Action<string> changeTextWithoutTrigger)
        : base(button)
        {
            _button = button;
            _loadedConfigs = loadedConfigs;
            _changeTextWithoutTrigger = changeTextWithoutTrigger;
            _onClickHandler = (s, e) => OnClickHandler(buttons);
            base.SubscribeHandlers();
            form.pnlConfigKeys.Controls.Add(_button);
            buttons.Add(_button);
        }

        public void OnClickHandler(List<DarkButton> buttons)
        {
            foreach (var b in buttons)
                b.ForeColor = Color.White;
            _button.ForeColor = Color.Green;
            _loadedConfigs.CurrentKey = _button.Text;
            _changeTextWithoutTrigger.Invoke(_loadedConfigs.GetCurrentValueText());
        }
    }
}
