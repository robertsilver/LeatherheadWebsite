using System.Collections.Generic;
using System.Linq;
using Leatherhead.DataAccess;

namespace Leatherhead.Business
{
    public static class Results
    {
        public static List<ResultsPoco> GetAll(string url)
        {
            var results = ResultsData.GetAll(url);

            if (!results.Any())
                return null;

            var resultData = new List<ResultsPoco>();

            foreach (var r in results)
            {
                var day = r.CompetitionDate.Day;

                resultData.Add(new ResultsPoco()
                {
                    CompetitionDate = r.CompetitionDate,
                    CompetitionName = r.CompetitionName,
                    CompetitorList = r.CompetitorList,
                    JuniorJuvenilleList = r.JuniorJuvenilleList,
                    Solos = r.Solos,
                    AdultLatin = r.AdultLatin,
                    AdultBallroom = r.AdultBallroom,
                    CompetitionDateFormatted = Helper.OrdinalValue(day) + " " + r.CompetitionDate.ToString("MMMM yyyy"),
                    Under10s = r.Under10s
                });
            }

            return resultData;
        }
    }
}
