﻿using Core.DataAccess.Entityframework;
using DataAccess.Abstact;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfOrderDal: EfEntityRepositoryBase<Order, NorthwindContext>,IOrderDal
    {
    }
}
