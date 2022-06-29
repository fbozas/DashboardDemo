using System.Web;
using System.Web.Mvc;

namespace DashboardDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new AuthorizeAttribute()); // This will lock the app completelly
        }
    }
}
