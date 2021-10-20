using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hung_ha.Models.DbSet
{
    public class Pagtion
    {
        public Pagtion(int currentPage, int pageSize, int totalPage)
        {
            this.currentPage = currentPage;
            this.pageSize = pageSize;
            this.totalPage = totalPage;
        }

        public int currentPage { get; set; }
        public int pageSize { get; set; }
        public int totalPage { get; set; }
    }
}