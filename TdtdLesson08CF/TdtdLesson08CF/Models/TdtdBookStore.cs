using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TdtdLesson08CF.Models
{
    public class TdtdBookStore : DbContext
    {
        public TdtdBookStore() : base("TDTDManager")
        {

        }
        //tao bang
        public DbSet<TdtdCategory> TdtdCategories { get; set; }
        public DbSet<TdtdBook> TdtdBooks { get; set; }
    }
}