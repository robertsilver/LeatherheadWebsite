using System;
using System.Collections.Generic;

namespace Leatherhead.DataAccess
{
    public class ResultsData
    {
        public DateTime CompetitionDate { get; set; }
        public string CompetitionName { get; set; }
        public string CompetitorList { get; set; }
        public string JuniorJuvenilleList { get; set; }
        public string AdultLatin { get; set; }
        public string AdultBallroom { get; set; }

        public static List<ResultsData> GetAll(string url)
        {
            return ReadJson.ReadTheJson<ResultsData>(url);
        }
    }
}
