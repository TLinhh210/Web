using System.Web;
using System.Web.Mvc;

namespace _2111858_NguyenThiThuyLinh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
