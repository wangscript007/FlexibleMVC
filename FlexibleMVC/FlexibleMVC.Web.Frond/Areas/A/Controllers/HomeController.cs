﻿/*
 * 用户： zxs
 * 日期: 2018/5/17
 * 时间: 10:45
 */
using FlexibleMVC.DAL;
using FlexibleMVC.LessBase.Ctrller;
using FlexibleMVC.Model;
using FluentData;
using System.Data;
using System.Dynamic;
using System.Web.Mvc;
using FlexibleMVC.LessBase.Context;
using FlexibleMVC.LessBase.Infrastructure;

namespace FlexibleMVC.Web.Frond.Areas.A.Controllers
{
    public class HomeController : LessBaseController
    {
        public HomeController(LessFlexibleContext lessContext) : base(lessContext)
        {
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult GotoB()
        {
            return RedirectToRoute("B_default", new { controller = "Home", Action = "Index", para = 1 });
        }

        public PartialViewResult Part2()
        {
            return PartialView();
        }

        public JsonResult GetJson()
        {
            dynamic obj = new ExpandoObject();
            //添加属性
            obj.name = "Li Lei";
            obj.age = 20;
            obj.color = new { color1 = "red", color2 = "green" };
            return Json(obj);
        }

        public JsonResult TestMysql()
        {
            IDbContext db = new DbContext().ConnectionStringName("testDBContext", new MySqlProvider());
            DataTable department = db.Sql(@"select * from patientbasicinfo limit 30 ").QuerySingle<DataTable>();
            return Json(department);
        }

        public ActionResult TestToJson()
        {
            var dal = new BaseDAL<ChinaFoodComposition>(flexibleContext) { Db = flexibleContext.db};
            return Content(dal.GetModel(10002).ToJson());
        }
    }
}
