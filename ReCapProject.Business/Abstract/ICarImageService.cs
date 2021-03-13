using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
   public interface ICarImageService
    {
        IResult Add(CarImage carImage,List<IFormFile> files);
        IResult Delete(CarImage carImage);
        IResult Update(CarImage carImage);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetById(int id);
    }
}
