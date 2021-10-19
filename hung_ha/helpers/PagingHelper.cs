using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using hung_ha.Models.DbSet;

namespace hung_ha.helpers
{
    public class PagingHelper
    {
        public static int getPageCount(int total,int pageSize)
        {
            return (total/ pageSize) + 1;
        }

    }
}