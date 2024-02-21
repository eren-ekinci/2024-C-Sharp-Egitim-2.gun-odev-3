using _2.gun_odev_3.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.gun_odev_3.DataAccess.Abstracts;

public interface IEntityRepository<T> where T : class, IEntity, new()
{
	List<T> GetAll();
	T Get(int id);
	void Add(T entity);
	void Update(T entity);
	void Delete(T entity);
}
