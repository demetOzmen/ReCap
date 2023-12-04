using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class BrandManager : IBrandService
{
    IBrandDal _brandDal;
    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

    public IResult Add(Brand brand)
    {
        bool brandResult = _brandDal.Add(brand);
        if (brandResult == false)
        {
            return new ErrorResult(Messages.BrandNotAdded);
        }
        return new SuccessResult(Messages.BrandAdded);
    }

    public IResult Delete(Brand brand)
    {
        bool brandResult = _brandDal.Delete(brand);
        if (brandResult == false)
        {
            return new ErrorResult(Messages.BrandNotDeleted);
        }
        return new SuccessResult(Messages.BrandDeleted);
    }

    public IDataResult<List<Brand>> GetAll()
    {
        return (IDataResult<List<Brand>>)_brandDal.GetAll();
    }


    public IResult Update(Brand brand)
    {
        bool brandResult = _brandDal.Update(brand);
        if (brandResult == false)
        {
            return new ErrorResult(Messages.BrandNotUpdated);
        }
        return new SuccessResult(Messages.BrandUpdated);
    }
}
