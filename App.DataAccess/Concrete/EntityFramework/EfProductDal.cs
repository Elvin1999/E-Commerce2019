using App.Core.DataAccess;
using App.Core.DataAccess.EntityFramework;
using App.DataAccess.Abstract;
using App.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
    }
}
