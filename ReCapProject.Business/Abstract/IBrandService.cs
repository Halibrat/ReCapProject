using Core.Utilities.Results;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
   public interface IBrandService
    {
        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetById(int id);
    }
}
