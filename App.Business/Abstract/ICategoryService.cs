using App.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
