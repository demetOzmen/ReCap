using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCarDal : ICarDal
{
    List<Car> _cars;
    public InMemoryCarDal()
    {
        _cars = new List<Car>
        {
        new Car { Id = 1, BrandId = 1, Name = "Volvo", ColorId = 1, DailyPrice = 1000, Description = "new", ModelYear = 2010 },
        new Car { Id = 2, BrandId = 2, Name = "Hyundai", ColorId = 3, DailyPrice = 1100, Description = "new", ModelYear = 2011 },
        new Car { Id = 3, BrandId = 1, Name = "Volvo", ColorId = 2, DailyPrice = 2000, Description = "used", ModelYear = 2000 },
        new Car { Id = 4, BrandId = 3, Name = "Mercedes", ColorId = 1, DailyPrice = 150, Description = "new", ModelYear = 1995 },
        new Car { Id = 5, BrandId = 4, Name = "Audi", ColorId = 5, DailyPrice = 2100, Description = "used", ModelYear = 2023 },
        };

    }
    public void Add(Car car)
    { _cars.Add(car); }

    public void Update(Car car)
    {
        Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
        carUpdate.Name = car.Name;
        carUpdate.ColorId = car.ColorId;
        carUpdate.Description = car.Description;
        carUpdate.BrandId = car.BrandId;
        carUpdate.DailyPrice = car.DailyPrice;
        carUpdate.ModelYear = car.ModelYear;
        carUpdate.Id = car.Id;

    }

    public void Delete(Car car)
    {
        var deleteCar = _cars.SingleOrDefault(p => p.Id == car.Id);
        _cars.Remove(deleteCar);
    }

    public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
    {
        return _cars;
    }

    bool IEntityRepository<Car>.Add(Car entity)
    {
        throw new NotImplementedException();
    }

    bool IEntityRepository<Car>.Update(Car entity)
    {
        throw new NotImplementedException();
    }

    bool IEntityRepository<Car>.Delete(Car entity)
    {
        throw new NotImplementedException();
    }

    public Car Get(Expression<Func<Car, bool>> filter)
    {
        throw new NotImplementedException();
    }
}
