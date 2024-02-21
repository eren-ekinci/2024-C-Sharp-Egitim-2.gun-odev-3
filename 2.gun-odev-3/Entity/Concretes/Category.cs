using _2.gun_odev_3.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.gun_odev_3.Entity.Concretes;

public class Category : IEntity
{
	public int CategoryId { get; set; }
	public string CategoryName { get; set; }
}
