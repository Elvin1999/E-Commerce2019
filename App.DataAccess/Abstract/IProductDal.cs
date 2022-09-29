using App.Core.DataAccess;
using App.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //custom operations
    }
}
