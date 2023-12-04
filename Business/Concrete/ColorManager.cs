using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ColorManager : IColorService
{
    IColorDal _colorDal;
    public ColorManager(IColorDal colorDal)
    {
        _colorDal = colorDal;
    }

    public IResult Add(Color color)
    {
        bool colorResult = _colorDal.Add(color);
        if (colorResult == false)
        {
            return new ErrorResult(Messages.ColorNotAdded);
        }
        return new SuccessResult(Messages.ColorAdded);
    }

    public IResult Delete(Color color)
    {
        bool colorResult = _colorDal.Delete(color);
        if (colorResult == false)
        {
            return new ErrorResult(Messages.ColorNotDeleted);
        }
        return new SuccessResult(Messages.ColorDeleted);

    }

    public IDataResult<List<Color>> GetAll()
    {
        return (IDataResult<List<Color>>)_colorDal.GetAll();
    }

    public IResult Update(Color color)
    {
        bool colorResult = _colorDal.Update(color);
        if (colorResult == false)
        {
            return new ErrorResult(Messages.ColorNotUpdated);

        }
        return new SuccessResult(Messages.ColorUpdated);

    }
}
