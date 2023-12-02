using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class OrderManager : IOrderService
{
    IOrderDal _orderDal;

    public OrderManager(IOrderDal orderDal)
    {
        _orderDal = orderDal;
    }

    public List<Order> GetAll()
    {
        //iş kodları
        return _orderDal.GetAll();
    }

    public Order GetById(int id)
    {
        return _orderDal.Get(o => o.Id == id);
    }
}
