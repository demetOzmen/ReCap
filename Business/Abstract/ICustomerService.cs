using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;

public interface ICustomerService
{
    IDataResult<List<Customer>> GetAll();
    IDataResult<Customer> GetById(int Id);
    IResult Add(CustomerAddDto customerAddDto);
    IResult Update(Customer customer);
    IResult Delete(int Id);

}
