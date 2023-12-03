using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class CarManager : ICarService
{
    ICarDal _carDal;
    private object CarsListed;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }


    public IResult Add(Car car)
    {
        if (car.Name.Length < 2)
        {
            return new ErrorResult(Messages.CarNameInvalid);
        }
        _carDal.Add(car);

        return new SuccessResult(Messages.CarAdded);

    }

    public IResult Delete(Car car)
    {
        bool carResult = _carDal.Delete(car);
        if (carResult == false)
        {
            return new ErrorResult(Messages.CarNotDeleted);
        }
        return new SuccessDataResult<Car>(Messages.CarDeleted);

    }

    public IDataResult<List<Car>> GetAllById(int id)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.Id == id));

    }

    public IDataResult<List<Car>> GetAllByDailyPrice(decimal min, decimal max)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max));
    }

    public IResult Update(Car car)
    {
        bool carResult = _carDal.Update(car);
        if (carResult == false)
        {
            return new ErrorResult(Messages.CarNotUpdated);
        }
        return new SuccessResult(Messages.CarUpdated);
    }

    public IDataResult<List<Car>> GetAll()
    {
        if (DateTime.Now.Hour == 21)
        {
            return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
        }
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
    }

    public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandId));
    }

    public IDataResult<List<Car>> GetCarsByColorId(int colorId)
    {
        return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == colorId));
    }

    public IDataResult<List<CarDetailDto>> GetCarDetails()
    {
        return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
    }

    public IDataResult<Car> GetById(int id)
    {
        return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == id));
    }
}