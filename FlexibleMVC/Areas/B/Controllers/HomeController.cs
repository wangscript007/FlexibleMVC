﻿/*
 * 用户： zxs
 * 日期: 2018/5/17
 * 时间: 10:45
 */
using FlexibleMVC.BLL;
using FlexibleMVC.LessBase.Ctrller;
using System.Web.Mvc;
using FlexibleMVC.LessBase.Context;

namespace FlexibleMVC.Web.Areas.B.Controllers
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

        public ActionResult Contact2(string hehe)
        {
            return Content("来自B模块" + hehe);
        }

        public ActionResult GotoFrondA()
        {
            var patientBll = flexibleContext.GetService<PatientBll>();
            ViewBag.name = "123";
            TempData["list"] = patientBll.patientDal.GetModels(currentPage:2,itemsPerPage:2);

            //return RedirectToAction("contact", "home", new { module = "frond", area = "a" });
            return RedirectToRoute("frond_a_default", new {module="frond", area="a", controller = "home", action = "contact"});
        }
    }
}
