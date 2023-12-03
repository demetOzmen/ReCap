using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract;

public interface ICarService
{
    IDataResult<List<Car>> GetAll();
    IDataResult<List<Car>> GetAllById(int id);
    IDataResult<List<Car>> GetAllByDailyPrice(decimal min, decimal max);
    IDataResult<List<Car>> GetCarsByBrandId(int id);
    IDataResult<List<Car>> GetCarsByColorId(int id);
    IDataResult<Car> GetById(int id);
    IDataResult<List<CarDetailDto>> GetCarDetails();
    IResult Add(Car car);
    IResult Update(Car car);
    IResult Delete(Car car);

}
