﻿using System.Web;
using System.Web.Mvc;

namespace BTL_THU_VIEN_NHOM_18
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
