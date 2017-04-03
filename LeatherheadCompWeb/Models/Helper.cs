using System.Configuration;

namespace LeatherheadCompWeb.Models
{
    public class Helper
    {
        public static string AppSetting(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}