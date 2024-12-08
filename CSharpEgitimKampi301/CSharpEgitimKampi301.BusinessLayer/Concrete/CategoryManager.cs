using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System.Collections.Generic;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;
		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}
		public void TDelete(Category t)
		{
			_categoryDal.Delete(t);
		}
		public Category TGetById(int id)
		{
			return _categoryDal.GetById(id);
		}
		public List<Category> TGetAll()
		{
			return _categoryDal.GetAll();
		}
		public void TInsert(Category t)
		{
			_categoryDal.Insert(t);
		}
		public void TUpdate(Category t)
		{
			_categoryDal.Update(t);
		}
	}
}