using System.Web;
using System.Web.Mvc;

namespace ECommerceExpress.Capa_Usuario
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
