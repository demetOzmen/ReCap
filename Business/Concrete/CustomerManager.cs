using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        IUserService _userService;

        public CustomerManager(ICustomerDal customerDal, IUserService userService)
        {
            _customerDal = customerDal;
            _userService = userService;
        }

        public IResult Add(CustomerAddDto customerAddDto)
        {
            Customer customerToAdd = new Customer
            {
                CompanyName = customerAddDto.CustomerCompanyName
            };

            User userToAdd = new User
            {
                FirstName = customerAddDto.UserFirstName,
                LastName = customerAddDto.UserLastName,
                Email = customerAddDto.UserEmail,
                Password = customerAddDto.UserPassword
            };
            var dbUserResult = _userService.Add(userToAdd);

            if (dbUserResult.Success == false)
            {
                var newUserResult = _userService.GetByEmail(customerAddDto.UserEmail);
                if (newUserResult.Data == null)
                {
                    return new ErrorResult(Messages.UserNotAdded);
                }

                customerToAdd.UserId = newUserResult.Data.Id;
            }

            bool customerResult = _customerDal.Add(customerToAdd);

            if (customerResult == false)
            {
                return new ErrorResult(Messages.CustomerNotAdded);
            }

            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(int id)
        {
            var customerToDelete = _customerDal.Get(c => c.Id == id);

            bool deleteResult = _customerDal.Delete(customerToDelete);
            if (deleteResult)
            {
                return new SuccessResult(Messages.CustomerDeleted);
            }
            else
            {
                return new ErrorResult(Messages.CustomerNotDeleted);
            }

        }

        public IDataResult<List<Customer>> GetAll()
        {
            return (IDataResult<List<Customer>>)_customerDal.GetAll();
        }

        public IDataResult<Customer> GetById(int Id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(c => c.Id == Id));
        }

        public IResult Update(Customer customer)
        {
            bool customerResult = _customerDal.Update(customer);
            if (!customerResult)
            {
                return new ErrorResult(Messages.CustomerNotUpdate);
            }
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
