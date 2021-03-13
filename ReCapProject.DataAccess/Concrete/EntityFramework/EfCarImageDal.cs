using Core.DataAccess.EntityFramework;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.DataAccess.Concrete.EntityFramework
{
   public class EfCarImageDal:EfEntityRepositoryBase<CarImage,ReCapDbContext>,ICarImageDal
    {

    }
}
