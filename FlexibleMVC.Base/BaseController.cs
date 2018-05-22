﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace FlexibleMVC.Base
{
    public class BaseController : Controller
    {
        #region 重写JsonResult
        protected new JsonResult Json(object data)
        {
            return new BaseJsonResult { Data = data, ContentType = null, ContentEncoding = null, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        protected new JsonResult Json(object data, string contentType)
        {
            return new BaseJsonResult { Data = data, ContentType = contentType, ContentEncoding = null, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        protected new JsonResult Json(object data, JsonRequestBehavior behavior)
        {
            return new BaseJsonResult { Data = data, ContentType = null, ContentEncoding = null, JsonRequestBehavior = behavior };
        }

        protected new JsonResult Json(object data, string contentType, JsonRequestBehavior behavior)
        {
            return new BaseJsonResult { Data = data, ContentType = contentType, ContentEncoding = null, JsonRequestBehavior = behavior };
        }

        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding)
        {
            return new BaseJsonResult { Data = data, ContentType = contentType, ContentEncoding = contentEncoding, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        protected override JsonResult Json(object data, string contentType, Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new BaseJsonResult { Data = data, ContentType = contentType, ContentEncoding = contentEncoding, JsonRequestBehavior = behavior };
        }

        #endregion

        #region 重写ViewResult
        protected new ViewResult View()
        {
            return View(null, null, null);
        }

        protected new ViewResult View(object model)
        {
            return View(null, null, model);
        }

        protected new ViewResult View(string viewName)
        {
            string masterName = null;
            object model = null;
            return View(viewName, masterName, model);
        }

        protected new ViewResult View(string viewName, string masterName)
        {
            return View(viewName, masterName, null);
        }

        protected new ViewResult View(string viewName, object model)
        {
            return View(viewName, null, model);
        }

        protected override ViewResult View(string viewName, string masterName, object model)
        {
            if (model != null)
            {
                base.ViewData.Model = model;
            }
            return new BaseViewResult
            {
                ViewName = viewName,
                MasterName = masterName,
                ViewData = base.ViewData,
                TempData = base.TempData,
                ViewEngineCollection = this.ViewEngineCollection
            };

        }
        #endregion

        #region 重写PartialViewResult
        protected new PartialViewResult PartialView()
        {
            return PartialView(null, null);
        }

        protected new PartialViewResult PartialView(object model)
        {
            return PartialView(null, model);
        }

        protected new PartialViewResult PartialView(string viewName)
        {
            return PartialView(viewName, null);
        }

        protected override PartialViewResult PartialView(string viewName, object model)
        {
            if (model != null)
            {
                base.ViewData.Model = model;
            }
            return new BasePartialViewResult
            {
                ViewName = viewName,
                ViewData = base.ViewData,
                TempData = base.TempData,
                ViewEngineCollection = this.ViewEngineCollection
            };

        }
        #endregion

    }
}