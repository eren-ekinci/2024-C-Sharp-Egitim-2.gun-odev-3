using _2.gun_odev_3.Business.Abstracts;
using _2.gun_odev_3.DataAccess.Abstracts;
using _2.gun_odev_3.Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.gun_odev_3.Business.Concretes;

public class InstructorManager : IInstructorService
{
	IInstructorDal _instructorDal;
	public InstructorManager(IInstructorDal instructorDal)
	{
		_instructorDal = instructorDal;
	}

	public void Add(Instructor t)
	{
		_instructorDal.Add(t);
	}

	public void Delete(Instructor t)
	{
		_instructorDal.Delete(t);
	}

	public List<Instructor> GetAll()
	{
		return _instructorDal.GetAll();
	}

	public void Update(Instructor t)
	{
		_instructorDal.Update(t);
	}
}
