using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            bool isCarAvailable = !(_rentalDal.GetAll(r => r.CarId == rental.CarId && r.ReturnDate == null).Any());
            if (isCarAvailable == false)
            {
                return new ErrorResult(Messages.CarIsNotAvailable);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public IResult Delete(Rental rental)
        {
            bool rentalResult = _rentalDal.Delete(rental);
            if (rentalResult == false)
            {
                return new ErrorResult(Messages.RentalNotDeleted);
            }
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return (IDataResult<List<Rental>>)_rentalDal.GetAll();
        }

        public IDataResult<Rental> GetById(int id)
        {
            var rental = _rentalDal.Get(b => b.Id == id);
            if (rental != null)
            {
                return new SuccessDataResult<Rental>(rental);
            }
            else
            {
                return new ErrorDataResult<Rental>("Rental not found");
            }
        }

        public IResult Update(Rental rental)
        {
            bool rentalResult = _rentalDal.Update(rental);
            if (rentalResult == false)
            {
                return new ErrorResult(Messages.RentalNotUpdated);
            }
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}