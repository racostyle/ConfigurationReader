using ConfigurationReader.Assets;
using ConfigurationReader.Utilities;
using System.Windows.Forms;

namespace ConfigurationReader.Buttons
{
    internal class HandlerBuilder_ConfigBtn : ButtonHandler
    {
        private readonly DarkButtonBuilder _darkButtonBuilder;
        private readonly List<DarkButton> _buttons;
        private readonly Form1 _form;
        private readonly LoadedConfigsHandler _loadedConfigs;
        private readonly DarkButton _button;
        private readonly EventHandler _textChangedHandler;
        private readonly object _lock = new object();
        //bull

        public HandlerBuilder_ConfigBtn(ConfigData sConfgData, Form1 form, List<DarkButton> mainButtons, LoadedConfigsHandler loadedConfigs, DarkButton button, DarkButtonBuilder darkButtonBuilder, EventHandler onTbValueTextChangeHandler)
        : base(button)
        {
            _buttons = new List<DarkButton>();
            _darkButtonBuilder = darkButtonBuilder;
            _form = form;
            _loadedConfigs = loadedConfigs;
            _button = button;
            _onClickHandler = (s, e) => OnClickHandler(s, e, sConfgData, mainButtons, _loadedConfigs);
            _textChangedHandler = onTbValueTextChangeHandler;
            base.SubscribeHandlers();
        }

        private void OnClickHandler(object sender, EventArgs e, ConfigData sConfgData, List<DarkButton> mainButtons, LoadedConfigsHandler loadedConfigs)
        {
            if (_button.ForeColor == Color.Green)
                return;
            ChangeValueTextWithoutTrigger(string.Empty);
            foreach (var b in mainButtons)
                b.ForeColor = Color.White;
            _button.ForeColor = Color.Green;
            Button clickedButton = (Button)sender;

            loadedConfigs.SetCurrentConfig(sConfgData);
            _form.pnlConfigKeys.Controls.Clear();
            int i = 0;
            foreach (string key in sConfgData.Configuration.Keys)
            {
                string localKey = key;
                int localIndex = i;
                var btn = _darkButtonBuilder.CreateButton(localKey, localIndex, _form.pnlConfigKeys, 1.3f);
                _ = new HandlerBuilder_KeysBtn(btn, _buttons, _form, sConfgData, _loadedConfigs, ChangeValueTextWithoutTrigger);
                i++;
            }
            base.AddDisposeAction(OnDisposeAction);
        }

        private void ChangeValueTextWithoutTrigger(string text)
        {
            lock (_lock)
            {
                if (_textChangedHandler != null)
                {
                    _form.tbKeyValue.TextChanged -= _textChangedHandler;
                    _form.tbKeyValue.Text = text;
                    _form.tbKeyValue.Update();
                    _form.tbKeyValue.TextChanged += _textChangedHandler;
                }
            }
        }

        private void OnDisposeAction()
        {
            if (_textChangedHandler != null)
                _form.tbKeyValue.TextChanged -= _textChangedHandler;
            foreach (var button in _buttons)
                button.Dispose();
        }
    }
}
