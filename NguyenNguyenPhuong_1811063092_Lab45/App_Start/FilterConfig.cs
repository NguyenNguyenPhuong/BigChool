using System.Web;
using System.Web.Mvc;

namespace NguyenNguyenPhuong_1811063092_Lab45
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
