﻿using System.Web;
using System.Web.Mvc;

namespace TDTD_Lab04_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
