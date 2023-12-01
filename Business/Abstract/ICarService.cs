using Entities.Concrete;

namespace Business.Abstract;

public interface ICarService
{
    List<Car> GetAll();
    List<Car> GetAllByCategoryId(int id);
    List<Car> GetAllByDailyPrice(decimal min, decimal max);
    bool Add(Car car );
    bool Update(Car car);
    bool Delete(Car car);

}
