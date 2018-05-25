﻿using System.Web.Mvc;
using System;
using System.Web.Routing;
using System.Web;
using FlexibleMVC.Base;
using FlexibleMVC.Base.Const;

namespace FlexibleMVC.Web
{
    public class RootAreaRegistration : BaseAreaRegistration
    {
        public override string Namespace
        {
            get { return "FlexibleMVC.Web"; }
        }
        public override string ModuleName
        {
            get { return ""; }
        }
        public override string AreaName
        {
            get { return MvcConst.ROOT_AREANAME; }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            base.RegisterArea(context);
            MapRoute(
                name: "default",
                url: "{controller}/{action}/{id}/{*c}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}