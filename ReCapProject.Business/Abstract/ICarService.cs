using Core.Utilities.Results;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
   public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetById(int id);
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
       
    }
}
