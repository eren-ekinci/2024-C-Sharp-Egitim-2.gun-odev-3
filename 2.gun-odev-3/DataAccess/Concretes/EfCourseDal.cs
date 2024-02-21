using _2.gun_odev_3.DataAccess.Abstracts;
using _2.gun_odev_3.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.gun_odev_3.DataAccess.Concretes;

public class EfCourseDal : ICourseDal
{
	List<Course> _course;

	public EfCourseDal()
	{
		_course = new List<Course>()
		{
			new Course { CourseId = 1, CourseName = "C# + Angular", CourseDescription = "Yazılım Geliştirici Yetiştirici Kampı (C# + Angular)", CategoryId = 1, InstructorId = 1 },
			new Course { CourseId = 2, CourseName = "Javascript", CourseDescription = "Yazılım Geliştirici Yetiştirici Kampı (Javascript)", CategoryId = 1, InstructorId = 1 },
			new Course { CourseId = 3, CourseName = "Java + React", CourseDescription = "Yazılım Geliştirici Yetiştirici Kampı (Java + React)", CategoryId = 1, InstructorId = 1 },
			new Course { CourseId = 4, CourseName = ".Net", CourseDescription = "Senior Yazılım Geliştirici Kampı (.Net)", CategoryId = 1, InstructorId = 1 }

		};
	}

	public void Add(Course entity)
	{
		_course.Add(entity);
	}

	public void Delete(Course entity)
	{
		Course productToDelete = _course.SingleOrDefault(c => c.CourseId == entity.CourseId);
		_course.Remove(productToDelete);
	}

	public Course Get(int id)
	{
		return _course.FirstOrDefault(x => x.CourseId == id);
	}

	public List<Course> GetAll()
	{
		return _course.ToList();
	}

	public void Update(Course entity)
	{
		Course courseToUpdate = _course.SingleOrDefault(c => c.CourseId == entity.CourseId);
		courseToUpdate.CourseName = entity.CourseName;
		courseToUpdate.CourseDescription = entity.CourseDescription;
		courseToUpdate.CategoryId = entity.CategoryId;
		courseToUpdate.InstructorId = entity.InstructorId;
	}
}
