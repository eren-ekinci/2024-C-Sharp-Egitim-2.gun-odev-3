using _2.gun_odev_3.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.gun_odev_3.Entity.Concretes;

public class Instructor : IEntity
{
	public int InstructorId { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
}
