using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.gun_odev_3.Business.Abstracts;

public interface IGenericService<T>
{
	List<T> GetAll();
	void Add(T t);
	void Update(T t);
	void Delete(T t);
}
