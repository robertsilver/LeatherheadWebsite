using System;
using System.Collections.Generic;

namespace Leatherhead.Business
{
    public class ResultsPoco
    {
        public DateTime CompetitionDate { get; set; }
        public string CompetitionName { get; set; }
        public string CompetitorList { get; set; }
        public List<string> JuniorJuvenilleList { get; set; }
        public List<string> Solos { get; set; }
        public List<string> Under10s { get; set; }
        public List<string> AdultLatin { get; set; }
        public List<string> AdultBallroom { get; set; }
        public string CompetitionDateFormatted { get; set; }
        public DateTime? ResultsRequested { get; set; }
    }
}
