﻿using System.Web;
using System.Web.Mvc;

namespace Weblite_Api_Trial
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
