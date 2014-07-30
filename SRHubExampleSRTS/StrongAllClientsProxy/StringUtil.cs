namespace SRHubsTT.StrongAllClientsProxy
{
    public static class StringUtil
    {
        public static string FirstLower(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }
            else
            {
                return name.Substring(0, 1).ToLower() + name.Substring(1);
            }
        }
    }
}