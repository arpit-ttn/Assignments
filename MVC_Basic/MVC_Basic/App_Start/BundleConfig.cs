using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVC_Basic.App_Start
{
    public class BundleConfig

        // Bundle Config is a file which is used to register bundles of the style sheets and the script sheets as
        // implemented below.
        // These are registered so that we can use them througout our code. 
        // These bundles are used at the Main_Layout.cshtml page to render these styles.
    {
        public static void RegisterBundle(BundleCollection bundelCollection)
        {
            bundelCollection.Add(new ScriptBundle("~/bundle/script")
                 .Include("~/Scripts/jquery-3.0.0.js",
                   "~/Scripts/bootstrap.js"
                   ));
            bundelCollection.Add(new StyleBundle("~/bundle/css")
                    .Include("~/Content/bootstrap.css",
                        "~/Content/style.css"
                  ));
        }
    }
}