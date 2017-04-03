using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace Leatherhead.DataAccess
{
    public static class ReadJson
    {
        public static List<T> ReadTheJson<T>(string url) where T : class, new()
        {
            string json;

            using (var wc = new WebClient())
            {
                json = wc.DownloadString(url);
            }

            var result = JsonConvert.DeserializeObject<List<T>>(json);

            return result;
        }
    }
}
