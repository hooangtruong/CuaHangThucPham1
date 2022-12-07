using System.Web;
using System.Web.Mvc;

namespace DoAn_CuaHangThucPham
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
