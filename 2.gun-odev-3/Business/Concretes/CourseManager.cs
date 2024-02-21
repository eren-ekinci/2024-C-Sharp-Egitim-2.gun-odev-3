using _2.gun_odev_3.Business.Abstracts;
using _2.gun_odev_3.DataAccess.Abstracts;
using _2.gun_odev_3.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.gun_odev_3.Business.Concretes;

public class CourseManager : ICourseService
{
	ICourseDal _courseDal;

	public CourseManager(ICourseDal courseDal)
	{
		_courseDal = courseDal;
	}

	public void Add(Course t)
	{
		_courseDal.Add(t);
	}

	public void Delete(Course t)
	{
		_courseDal.Delete(t);
	}

	public List<Course> GetAll()
	{
		return _courseDal.GetAll();
	}

	public void Update(Course t)
	{
		_courseDal.Update(t);
	}
}
