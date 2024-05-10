namespace ConfigurationReader.Utilities
{
    internal class NotificationObject
    {
        private readonly Action<string> _setSelectedKeyText;

        public NotificationObject(Action<string> setSelectedKeyText)
        {
            _setSelectedKeyText = setSelectedKeyText;
        }

        internal void ShowResultBox(bool succes, string message = "")
        {
            if (succes)
            {
                if (string.IsNullOrEmpty(message))
                    message = "Operation completed successfully";
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (string.IsNullOrEmpty(message))
                    message = "Operation failed!";
                MessageBox.Show(message, "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void LogSelectedKey(string message)
        {
            _setSelectedKeyText(message);
        }
    }
}
