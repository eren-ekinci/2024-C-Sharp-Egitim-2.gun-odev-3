using _2.gun_odev_3.DataAccess.Abstracts;
using _2.gun_odev_3.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.gun_odev_3.DataAccess.Concretes;

public class EfInstructorDal : IInstructorDal
{
	List<Instructor> _instructor;

	public EfInstructorDal()
	{
		_instructor = new List<Instructor>()
		{
			new Instructor { InstructorId = 1, FirstName = "Engin", LastName = "Demiroğ" },
			new Instructor { InstructorId = 2, FirstName = "Halit Enes", LastName = "Kalaycı" }
		};
	}

	public void Add(Instructor entity)
	{
		_instructor.Add(entity);
	}

	public void Delete(Instructor entity)
	{
		Instructor instructorToDelete = _instructor.SingleOrDefault(i => i.InstructorId == entity.InstructorId);
		_instructor.Remove(instructorToDelete);
	}

	public Instructor Get(int id)
	{
		return _instructor.SingleOrDefault(x => x.InstructorId == id);
	}

	public List<Instructor> GetAll()
	{
		return _instructor.ToList();
	}

	public void Update(Instructor entity)
	{
		Instructor instructorToUpdate = _instructor.SingleOrDefault(i => i.InstructorId == entity.InstructorId);
		instructorToUpdate.FirstName = entity.FirstName;
		instructorToUpdate.LastName = entity.LastName;
	}
}
