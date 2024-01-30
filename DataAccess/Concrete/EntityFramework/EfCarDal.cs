using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework;

public class EfCarDal : EFEntityRepositoryBase<Car, ReCapContext>, ICarDal
{
    public List<CarDetailDto> GetCarDetails()
    {
        using (ReCapContext context = new ReCapContext())
        {
            var result = from car in context.Cars
                         join color in context.Colors on car.ColorId equals color.Id
                         join brand in context.Brands on car.BrandId equals brand.Id
                         select new CarDetailDto
                         {
                             BrandId = car.BrandId,
                             BrandName = brand.Name,
                             ColorId = car.ColorId,
                             ColorName = color.Name,
                             CarId = car.Id,
                             ModelYear = car.ModelYear,
                             CarName = car.Name
                         };
            return result.ToList();
        }
        
    }
}
