﻿using System.Web;
using System.Web.Mvc;

namespace MyEgitimAkademi_Portfolio1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
