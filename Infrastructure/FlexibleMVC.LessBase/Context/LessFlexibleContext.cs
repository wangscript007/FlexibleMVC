﻿using FlexibleMVC.Base.Context;
using FlexibleMVC.LessBase.Config;
using FlexibleMVC.LessBase.Infrastructure;
using FluentData;

namespace FlexibleMVC.LessBase.Context
{
    public class LessFlexibleContext : FlexibleContext
    {
        public IDbContext db = new DbContext().ConnectionString(LessConfig.db1, new MySqlProvider());
    }
}
