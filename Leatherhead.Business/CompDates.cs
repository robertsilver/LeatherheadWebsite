using System;
using System.Collections.Generic;
using System.Linq;
using Leatherhead.DataAccess;

namespace Leatherhead.Business
{
    public class CompDates
    {
        public static List<CompDatesPoco> Get(string url, DateTime fromDate)
        {
            var results = CompDatesData.Get(url);

            if (!results.Any())
                return null;

            results = results.FindAll(f => f.CompetitionDate.Date >= fromDate.Date);
            if (!results.Any())
                return null;

            var resultData = new List<CompDatesPoco>();

            foreach (var r in results)
            {
                var day = r.CompetitionDate.Day;

                resultData.Add(new CompDatesPoco()
                {
                    CompetitionDate = r.CompetitionDate,
                    CompetitionName = r.CompetitionName,
                    CompetitionDateFormatted = Helper.OrdinalValue(day) + " " + r.CompetitionDate.ToString("MMMM yyyy")
                });
            }

            return resultData.OrderBy(o => o.CompetitionDate).ToList();
        }
    }
}
