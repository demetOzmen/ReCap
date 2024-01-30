using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework;

public class EfBrandDal : EFEntityRepositoryBase<Brand, ReCapContext>, IBrandDal
{

}
