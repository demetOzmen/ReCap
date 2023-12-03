using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class BrandManager : IBrandService
{
    IBrandDal _brandDal;
    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public bool Add(Brand brand)
    {
        bool brandResult = _brandDal.Add(brand);
        if (brandResult == true)
        {
            Console.WriteLine();
        }
        return brandResult;
    }

    public bool Delete(Brand brand)
    {
        bool brandResult = _brandDal.Delete(brand);
        if (brandResult == true)
        {
            Console.WriteLine();
        }
        return brandResult;
    }

    public List<Brand> GetAll()
    {
        return _brandDal.GetAll();
    }


    public bool Update(Brand brand)
    {
        bool brandResult = _brandDal.Update(brand);
        if (brandResult == true)
        {
            Console.WriteLine();
        }
        return brandResult;
    }
}
