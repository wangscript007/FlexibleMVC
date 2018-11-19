﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlexibleMVC.LessBase.Context;
using FlexibleMVC.LessBase.Infrastructure;
using FlexibleMVC.Model.Admin.Permissions;

namespace FlexibleMVC.DAL.Admin.Permissions
{
    public class SysPermissionsMenuDal : BaseDAL<SysPermissionsMenu>
    {
        public SysPermissionsMenuDal(LessFlexibleContext lessContext) : base(lessContext)
        {
            Db = lessContext.db1;
        }

    }
}
