using System;
using System.Collections.Generic;

namespace Leatherhead.DataAccess
{
    public class ResultsData
    {
        public DateTime CompetitionDate { get; set; }
        public string CompetitionName { get; set; }
        public string CompetitorList { get; set; }
        public List<string> JuniorJuvenilleList { get; set; }
        public List<string> Solos { get; set; }
        public List<string> Under10s { get; set; }
        public List<string> AdultLatin { get; set; }
        public List<string> AdultBallroom { get; set; }

        public static List<ResultsData> GetAll(string url)
        {
            return ReadJson.ReadTheJson<ResultsData>(url);
        }
    }
}
