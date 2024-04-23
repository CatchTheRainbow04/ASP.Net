using System.Web;
using System.Web.Mvc;

namespace Lab3_BTTL_3_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
