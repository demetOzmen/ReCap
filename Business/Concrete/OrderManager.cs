using Business.Abstract;
using Core.Utilities.Results;
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

    public IResult Add(Order order)
    {
        throw new NotImplementedException();
    }

    public IResult Delete(int id)
    {
        throw new NotImplementedException();
    }

    public IDataResult<List<Order>> GetAll()
    {
        //iş kodları
        return new SuccessDataResult<List<Order>>(_orderDal.GetAll());
    }

    public IDataResult<Order> GetById(int id)
    {
        return new SuccessDataResult<Order>(_orderDal.Get(o => o.Id == id));
    }

    public IResult Update(Order order)
    {
        throw new NotImplementedException();
    }
}
