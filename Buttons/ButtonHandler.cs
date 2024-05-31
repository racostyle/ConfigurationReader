using ConfigurationReader.Assets;

namespace ConfigurationReader.Buttons
{
    internal abstract class ButtonHandler
    {
        private readonly DarkButton _button;
        protected EventHandler? _onClickHandler;
        protected EventHandler? _onDisposeHandler;
        private Action? _onDisposeAction;

        protected ButtonHandler(DarkButton button)
        {
            _button = button;
        }

        protected void SubscribeHandlers()
        {
            _onDisposeHandler = (s, e) => OnDispose(s, e);
            _button.Disposed += _onDisposeHandler;
            _button.Click += _onClickHandler;
        }

        protected void OnDispose(object? sender, EventArgs e)
        {
            _onDisposeAction?.Invoke();
            _button.Click -= _onClickHandler;
            _button.Disposed -= _onDisposeHandler;
        }

        internal void AddDisposeAction(Action onDisposeAction)
        {
            _onDisposeAction = onDisposeAction;
        }
    }
}
