using App.Business.Abstract;
using App.DataAccess.Abstract;
using App.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
