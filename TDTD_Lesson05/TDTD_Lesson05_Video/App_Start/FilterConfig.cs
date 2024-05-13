using System.Web;
using System.Web.Mvc;

namespace TDTD_Lesson05_Video
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
