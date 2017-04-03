using System;

namespace Leatherhead.Business
{
    public class ResultsPoco
    {
        public DateTime CompetitionDate { get; set; }
        public string CompetitionName { get; set; }
        public string CompetitorList { get; set; }
        public string JuniorJuvenilleList { get; set; }
        public string AdultLatin { get; set; }
        public string AdultBallroom { get; set; }
        public string CompetitionDateFormatted { get; set; }
    }
}
