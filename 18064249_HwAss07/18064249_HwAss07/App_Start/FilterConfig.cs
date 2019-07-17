using System.Web;
using System.Web.Mvc;

namespace _18064249_HwAss07
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
