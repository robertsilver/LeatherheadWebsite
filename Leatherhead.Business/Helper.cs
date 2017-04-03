
namespace Leatherhead.Business
{
    public static class Helper
    {
        public static string OrdinalValue(int day)
        {
            string ordinal;
            if (day % 100 == 11 || day % 100 == 12 || day % 100 == 13)
                ordinal = day + "th";
            else
            {
                switch (day % 10)
                {
                    case 1:
                        ordinal = day + "st";
                        break;
                    case 2:
                        ordinal = day + "nd";
                        break;
                    case 3:
                        ordinal = day + "rd";
                        break;
                    default:
                        ordinal = day + "th";
                        break;
                }
            }

            return ordinal;
        }
    }
}
