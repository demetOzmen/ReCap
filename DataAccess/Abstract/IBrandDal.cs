using Entities.Concrete;

namespace DataAccess.Abstract;

public interface IBrandDal:IEntityRepository<Brand>
{
    List<Car> GetAll();
    List<Car> GetAllById(int Id);

}
