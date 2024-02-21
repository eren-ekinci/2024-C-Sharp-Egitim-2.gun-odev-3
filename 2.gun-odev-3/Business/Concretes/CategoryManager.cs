using _2.gun_odev_3.Business.Abstracts;
using _2.gun_odev_3.DataAccess.Abstracts;
using _2.gun_odev_3.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.gun_odev_3.Business.Concretes;

public class CategoryManager : ICategoryService
{
	ICategoryDal _categoryDal;

	public CategoryManager(ICategoryDal categoryDal)
	{
		_categoryDal = categoryDal;
	}

	public void Add(Category t)
	{
		_categoryDal.Add(t);
	}

	public void Delete(Category t)
	{
		_categoryDal.Delete(t);
	}

	public List<Category> GetAll()
	{
		return _categoryDal.GetAll();
	}

	public void Update(Category t)
	{
		_categoryDal.Update(t);
	}
}
