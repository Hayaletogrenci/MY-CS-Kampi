using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System.Collections.Generic;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
	public class OrderManager : IOrderService
	{
		private readonly IOrderDal _orderDal;
		public OrderManager(IOrderDal orderDal)
		{
			_orderDal = orderDal;
		}
		public void TDelete(Order t)
		{
			_orderDal.Delete(t);
		}
		public Order TGetById(int id)
		{
			return _orderDal.GetById(id);
		}
		public List<Order> TGetAll()
		{
			return _orderDal.GetAll();
		}
		public void TInsert(Order t)
		{
			_orderDal.Insert(t);
		}
		public void TUpdate(Order t)
		{
			_orderDal.Update(t);
		}
	}
}