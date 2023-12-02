using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete;

public class CarManager : ICarService
{
    ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public bool Add(Car car)
    {
        bool carResult = _carDal.Add(car);
        if (carResult == true)
        {
            Console.WriteLine();
        }
        return carResult;
    }

    public bool Delete(Car car)
    {
        bool carResult = _carDal.Delete(car);
        if (carResult == true)
        {
            Console.WriteLine();
        }
        return carResult;
    }


    public List<Car> GetAllById(int id)
    {
        return _carDal.GetAll(p => p.Id == id);

    }

    public List<Car> GetAllByDailyPrice(decimal min, decimal max)
    {
        return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
    }

    public bool Update(Car car)
    {
        bool carResult = _carDal.Update(car);
        if (carResult == true)
        {
            Console.WriteLine();
        }
        return carResult;
    }

    public List<Car> GetAll()
    {
        return _carDal.GetAll();
    }

    public List<Car> GetCarsByBrandId(int brandId)
    {
        return _carDal.GetAll(p => p.BrandId == brandId);
    }

    public List<Car> GetCarsByColorId(int colorId)
    {
        return _carDal.GetAll(p => p.ColorId == colorId);
    }

    public List<CarDetailDto> GetCarDetails()
    {
        return _carDal.GetCarDetails();
    }
}