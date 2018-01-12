using System.Web;
using System.Web.Mvc;

namespace Projekt_Applikationssicherheit
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
