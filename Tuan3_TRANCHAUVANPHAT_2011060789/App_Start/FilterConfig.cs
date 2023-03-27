using System.Web;
using System.Web.Mvc;

namespace Tuan3_TRANCHAUVANPHAT_2011060789
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
