using _2.gun_odev_3.DataAccess.Abstracts;
using _2.gun_odev_3.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.gun_odev_3.DataAccess.Concretes;

public class EfCategoryDal : ICategoryDal
{
	List<Category> _category;

	public EfCategoryDal()
	{
		_category = new List<Category>()

		{
			new Category { CategoryId = 1, CategoryName = "Yazılım" },
			new Category { CategoryId = 2, CategoryName = "Network" },
			new Category { CategoryId = 3, CategoryName = "Siber Güvenlik" }
		};
	}

	public void Add(Category entity)
	{
		_category.Add(entity);
	}

	public void Delete(Category entity)
	{
		Category categoryToDelete = _category.SingleOrDefault(c => c.CategoryId == entity.CategoryId);
		_category.Remove(categoryToDelete);
	}

	public Category Get(int id)
	{
		return _category.SingleOrDefault(x => x.CategoryId == id);
	}

	public List<Category> GetAll()
	{
		return _category.ToList();
	}

	public void Update(Category entity)
	{
		Category categoryToUpdate = _category.SingleOrDefault(c => c.CategoryId == entity.CategoryId);
		categoryToUpdate.CategoryName = entity.CategoryName;
	}
}
