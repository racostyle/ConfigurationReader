namespace ConfigurationReader.Utilities
{
    internal class FindAllControls
    {
        internal List<Control> GetAllControls(Control container)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control c in container.Controls)
            {
                controlList.Add(c); // Add the control to the list
                if (c.HasChildren)
                {
                    controlList.AddRange(GetAllControls(c)); // Recursively add child controls
                }
            }
            return controlList;
        }
    }
}
