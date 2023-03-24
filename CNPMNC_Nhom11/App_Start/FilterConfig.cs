using System.Web;
using System.Web.Mvc;

namespace CNPMNC_Nhom11
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
