using ConfigurationReader.Assets;
using ConfigurationReader.Utilities;

namespace ConfigurationReader.Buttons
{
    internal class HandlerBuilder_ValueBtn : ButtonHandler
    {
        private DarkButton _button;
        private readonly Action<ConfigData, Form1, string> _valuePanelTextChangeHandler;
        private readonly string _localKey;

        public HandlerBuilder_ValueBtn(EventHandler? _textChangedHandler, DarkButton button, List<DarkButton> buttons, Form1 form, ConfigData sConfgData, Action<ConfigData, Form1, string> valuePanelTextChangeHandler)
        : base(button)
        {
            _button = button;
            _valuePanelTextChangeHandler = valuePanelTextChangeHandler;
            _localKey = button.Text;
            _onClickHandler = (s, e) => OnClickHandler(form, sConfgData, buttons);
            base.SubscribeHandlers();
            form.pnlConfigKeys.Controls.Add(_button);
            buttons.Add(_button);
        }

        public void OnClickHandler(Form1 form, ConfigData sConfgData, List<DarkButton> buttons)
        {
            foreach (var b in buttons)
                b.ForeColor = Color.White;
            _button.ForeColor = Color.Green;

            _valuePanelTextChangeHandler(sConfgData, form, _localKey);
        }
    }
}
