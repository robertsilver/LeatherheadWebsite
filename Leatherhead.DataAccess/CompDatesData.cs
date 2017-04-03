using System;
using System.Collections.Generic;

namespace Leatherhead.DataAccess
{
    public class CompDatesData
    {
         public DateTime CompetitionDate { get; set; }
        public string CompetitionName { get; set; }

        public static List<CompDatesData> Get(string url)
        {
            return ReadJson.ReadTheJson<CompDatesData>(url);
        }
    }
}
