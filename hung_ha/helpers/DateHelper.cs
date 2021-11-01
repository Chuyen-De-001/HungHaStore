using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hung_ha.helpers
{
    public class DateHelper
    {

        /*
         * Convert timeunix to datetime
         */
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
        }

        /*
         * Convert datetime to time unix
         */
        public static int DateTimeToTimeUnix(DateTime date)
        {
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(date)).TotalSeconds;
            return unixTimestamp;
        }
    }
}