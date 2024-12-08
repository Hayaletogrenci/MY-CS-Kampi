using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System.Collections.Generic;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
	public class ProductManager : IProductService
	{
		private readonly IProductDal _productDal;
		public ProductManager(IProductDal productDal)
		{
			_productDal = productDal;
		}
		public void TDelete(Product t)
		{
			_productDal.Delete(t);
		}
		public Product TGetById(int id)
		{
			return _productDal.GetById(id);
		}
		public List<Product> TGetAll()
		{
			return _productDal.GetAll();
		}
		public void TInsert(Product t)
		{
			_productDal.Insert(t);
		}
		public void TUpdate(Product t)
		{
			_productDal.Update(t);
		}
	}
}