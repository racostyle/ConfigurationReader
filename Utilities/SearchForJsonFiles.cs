namespace ConfigurationReader.Utilities
{
    internal class SearchForJsonFiles
    {
        internal string[] Search(string rootPath)
        {
            if (!Directory.Exists(rootPath))
                return ["Wrong base file path"];

            var jsonFiles = GetAllJsonFiles(rootPath);

            if (jsonFiles.Length == 0)
                return ["No configuration files found"];
            return jsonFiles;
        }

        public static string[] GetAllJsonFiles(string rootPath)
        {
            try
            {
                string[] files = Directory.GetFiles(rootPath, "*.json", SearchOption.AllDirectories);
                return files;
            }
            catch (Exception ex)
            {
                return ["An error occurred: " + ex.Message];
            }
        }
    }
}
