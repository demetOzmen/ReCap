using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CarManager : ICarService
{
    private ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public void Add(Car car)
    {
        bool carResult = _carDal.Add(car);
        if (carResult == true)
        {
            Console.WriteLine();
        }
    }

    public void Delete(Car car)
    {
        throw new NotImplementedException();
    }

    public List<Car> GetAll()
    {
        throw new NotImplementedException();
    }

    public void Update(Car car)
    {
        throw new NotImplementedException();
    }
}
