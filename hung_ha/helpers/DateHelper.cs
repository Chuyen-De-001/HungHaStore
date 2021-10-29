using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hung_ha.helpers
{
    public class DateHelper
    {
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        public static int DateTimeToTimUnix(DateTime date)
        {
            int unixTimestamp = (int)(DateTime.UtcNow.Subtract(new DateTime(date.Year, date.Month, date.Day))).TotalSeconds;
            return unixTimestamp;
        }
    }
}