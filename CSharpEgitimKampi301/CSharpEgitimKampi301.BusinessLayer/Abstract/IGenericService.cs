using System.Collections.Generic;

namespace CSharpEgitimKampi301.BusinessLayer.Abstract
{
	public interface IGenericService<T> where T : class
	{
		void TInsert(T t);
		void TDelete(T t);
		void TUpdate(T t);
		List<T> TGetAll();
		T TGetById(int id);
	}
}