using Core.Utilities.Results;
using ReCapProject.Business.Abstract;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult();
        }

        public IDataResult<List<Color>> GetAll()
        {
          return new SuccessDataResult<List<Color>> ( _colorDal.GetAll());
        }

        public IDataResult< List<Color>> GetById(int id)
        {
            return new SuccessDataResult<List<Color>>( _colorDal.GetAll(c => c.Id == id));
        }

        public IResult Update(Color color)
        {
            _colorDal.Update(color);
            return new SuccessResult();
        }
    }
}
