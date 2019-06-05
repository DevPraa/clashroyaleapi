using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClashRoyaleClanMonitorWF.Utils
{
    public static class DateConverter
    {
        public static DateTime ClashRoyaleDateToDateTime(this string ClashDateTime)
        {
            string[] TmpDateSplit = ClashDateTime.Split('T');
            if (TmpDateSplit.Length == 0)
            {
                throw new FormatException($"Tried parse string: \"{ClashDateTime}\" not have successfully");
            }
            int yyyy;
            int MM;
            int dd;
            int hh;
            int mm;
            int ss;
            //"20190512T114453.000Z"
            try
            {
                yyyy = int.Parse(TmpDateSplit[0].Substring(0, 4));
                MM = int.Parse(TmpDateSplit[0].Substring(4, 2));
                dd = int.Parse(TmpDateSplit[0].Substring(6, 2));

                hh = int.Parse(TmpDateSplit[1].Substring(0, 2));
                mm = int.Parse(TmpDateSplit[1].Substring(2, 2));
                ss = int.Parse(TmpDateSplit[1].Substring(4, 2));
            }
            catch
            {
                throw;
            }

            return new DateTime(yyyy, MM, dd, hh, mm, ss, 000, DateTimeKind.Utc);
        }
    }
}
