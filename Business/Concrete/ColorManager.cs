using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public bool Add(Color color)
        {
            bool colorResult = _colorDal.Add(color);
            if (colorResult == true)
            {
                Console.WriteLine();
            }
            return colorResult;
        }

        public bool Delete(Color color)
        {
            bool colorResult = _colorDal.Delete(color);
            if (colorResult == true)
            {
                Console.WriteLine();
            }
            return colorResult;
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public bool Update(Color color)
        {
            bool colorResult = _colorDal.Update(color);
            if (colorResult == true)
            {
                Console.WriteLine();
            }
            return colorResult;
        }
    }
}
