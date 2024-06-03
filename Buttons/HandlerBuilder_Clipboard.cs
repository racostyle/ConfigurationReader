using ConfigurationReader.Assets;

namespace ConfigurationReader.Buttons
{
    internal class HandlerBuilder_Clipboard : ButtonHandler
    {
        private DarkButton _button;
        private readonly Action<string> _onClickAction;

        public HandlerBuilder_Clipboard(DarkButton button, Action<string> onClickAction)
        : base(button)
        {
            _button = button;
            _onClickAction = onClickAction;
            _onClickHandler = (s, e) => OnClickHandler();
            base.SubscribeHandlers();
        }

        public void OnClickHandler()
        {
            _onClickAction?.Invoke(_button.Text);
        }
    }
}
