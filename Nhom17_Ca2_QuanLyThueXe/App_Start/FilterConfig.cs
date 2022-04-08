using System.Web;
using System.Web.Mvc;

namespace Nhom17_Ca2_QuanLyThueXe
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
