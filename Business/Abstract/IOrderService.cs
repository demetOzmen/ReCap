﻿using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface IOrderService
{
    IDataResult<List<Order>> GetAll();
    IDataResult<Order> GetById(int id);
    IResult Add(Order order);
    IResult Update(Order order);
    IResult Delete(int id);
}
