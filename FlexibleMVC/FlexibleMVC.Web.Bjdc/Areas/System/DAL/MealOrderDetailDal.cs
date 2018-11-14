﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlexibleMVC.LessBase.Context;
using FlexibleMVC.LessBase.Infrastructure;
using FlexibleMVC.Web.Bjdc.Areas.System.Model;

namespace FlexibleMVC.Web.Bjdc.Areas.System.DAL
{
    public class MealOrderDetailDal : BaseDAL<MealOrderDetail>
    {
        public MealOrderDetailDal(LessFlexibleContext lessContext) : base(lessContext)
        {
            Db = lessContext.db;
        }
    }
}