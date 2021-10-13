using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hung_ha.helpers
{
    public class TimeHelper
    {
        public static int getTimeUnix()
        {
            DateTime foo = DateTime.UtcNow;
            int unixTime = (int)((DateTimeOffset)foo).ToUnixTimeSeconds();
            return unixTime;
        }
    }
}