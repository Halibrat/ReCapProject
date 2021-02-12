using Core.DataAccess.EntityFramework;
using Microsoft.EntityFrameworkCore;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using ReCapProject.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ReCapProject.DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapDbContext reCapDb=new ReCapDbContext())
            {
                var result = from c in reCapDb.Cars
                             join b in reCapDb.Brands
                             on c.BrandId equals b.Id
                             join cl in reCapDb.Colors
                             on c.ColorId equals cl.Id
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 BrandName=b.BrandName,
                                 ColorName=cl.ColorName,
                                 DailyPrice=c.DailyPrice,
                                 Description=c.Description,
                                 
                                 
                                 
                             };
                return result.ToList();
            }
        }
    }
}
