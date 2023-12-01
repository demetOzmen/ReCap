using Entities.Concrete;

namespace Business.Abstract;

public interface ICarService
{
    List<Car> GetAll();
    List<Car> GetAllById(int id);
    List<Car> GetAllByDailyPrice(decimal min, decimal max);
    List<Car> GetCarsByBrandId(int id);
    List<Car> GetCarsByColorId(int id);
    bool Add(Car car );
    bool Update(Car car);
    bool Delete(Car car);

}
