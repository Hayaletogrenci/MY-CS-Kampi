using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System.Collections.Generic;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
	public class CustomerManager : ICustomerService
	{
		private readonly ICustomerDal _customerDal;
		public CustomerManager(ICustomerDal customerDal)
		{
			_customerDal = customerDal;
		}
		public void TDelete(Customer t)
		{
			_customerDal.Delete(t);
		}
		public Customer TGetById(int id)
		{
			return _customerDal.GetById(id);
		}
		public List<Customer> TGetAll()
		{
			return _customerDal.GetAll();
		}
		public void TInsert(Customer t)
		{
			_customerDal.Insert(t);
		}
		public void TUpdate(Customer t)
		{
			_customerDal.Update(t);
		}
	}
}