using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project4
{
    public class ServerPathHelper
    {
        public static string GetPath(string pathAndFile)
        {
            return HttpContext.Current.Server.MapPath(pathAndFile);

        }
    }
}