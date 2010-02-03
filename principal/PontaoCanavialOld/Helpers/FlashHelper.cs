using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PontaoCanavial.Helpers
{
    public static class FlashHelper
    {
        public static string FlashParam(this HtmlHelper helper, string value)
        {
            return String.Format(" <param name=\"movie\" value=\"{0}\" />",value);
        }


        

    }
}
