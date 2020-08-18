﻿using System.Web;
using System.Web.Optimization;

namespace apptotal
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Bundles/css")
                .Include("~/Content/css/bootstrap.css")
                .Include("~/Content/css/select2.css")
                .Include("~/Content/css/bootstrap-select.css")
                .Include("~/Content/css/datepicker3.css")
                .Include("~/Content/css/AppLeader.css")
                .Include("~/Content/css/dataTables.min.css")
                .Include("~/Content/css/font-awesome.css")
                .Include("~/Content/css/skins/skin-blue.css")
                .Include("~/Content/css/jquery.waiting.css"));
            bundles.Add(new ScriptBundle("~/Bundles/js")
                .Include("~/Content/js/plugins/jquery/jquery-2.2.4.js")
                .Include("~/Content/js/plugins/jquery/jquery.min.js")
                .Include("~/Content/js/plugins/bootstrap/bootstrap.js")
                .Include("~/Content/js/plugins/bootstrap/jquery.dataTables.min.js")
                .Include("~/Content/js/plugins/bootstrap/dataTables.bootstrap.min.js")
                .Include("~/Content/js/plugins/fastclick/fastclick.js")
                .Include("~/Content/js/plugins/slimscroll/jquery.slimscroll.js")
                .Include("~/Content/js/plugins/select2/select2.full.js")
                .Include("~/Content/js/plugins/moment/moment.js")
                .Include("~/Content/js/plugins/datepicker/bootstrap-datepicker.js")
                .Include("~/Content/js/plugins/icheck/icheck.js")
                .Include("~/Content/js/app.js")
                .Include("~/Content/js/init.js")
                .Include("~/Scripts/angular.js")
                .Include("~/Scripts/angular-route.js")
                .Include("~/app/app.js")
                .Include("~/app/routes.js")
                .Include("~/Content/js/plugins/jquery/jquery.waiting.js")
                );
           
        }
    }
}
