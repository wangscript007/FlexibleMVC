﻿/*
 * 用户： zxs
 * 日期: 2018/5/18
 * 时间: 10:13
 */
using FlexibleMVC.Base.Mvc;
using FlexibleMVC.Base.Mvc.AcResult;
using FlexibleMVC.Base.Mvc.Ctrller;
using FlexibleMVC.LessBase.Config;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FlexibleMVC.Web
{

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            RouteTable.Routes.Ignore("{resource}.axd/{*pathInfo}");
            RouteTable.Routes.IgnoreRoute("{*favicon}",
                new { favicon = @"(.*/)?favicon.ico(/.*)?" }
            );

            ControllerBuilder.Current.SetControllerFactory(new FolderControllerFactory());
            AreaRegistration.RegisterAllAreas();

            //自定义视图引擎，如改名默认视图路径
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new MvcViewEngine());

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ViewMapConfig.RegisterViewMaps(ExecuteViewResult.ViewMaps);

            log4net.Config.XmlConfigurator.ConfigureAndWatch(new System.IO.FileInfo(Server.MapPath("Log4net.config")));

            //注册组件
            AutofacConfig.Register();
        }
    }


}
