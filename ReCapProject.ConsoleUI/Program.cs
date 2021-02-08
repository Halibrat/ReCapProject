using ReCapProject.Business.Concrete;
using ReCapProject.DataAccess.Concrete.EntityFramework;
using ReCapProject.DataAccess.Concrete.InMemory;
using ReCapProject.Entities.Concrete;
using System;

namespace ReCapProject.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            // colorManager.Add(new Color { Id = 4, ColorName = "Sarı" });
            //colorManager.Add(new Color { Id = 5, ColorName = "Mor" });
            //colorManager.Delete(new Color {Id = 5, ColorName = "Mor" });
            //brandManager.Add(new Brand { Id = 3, BrandName = "Opel" });
           // brandManager.Add(new Brand { Id = 4, BrandName = "Nissan" });
            //brandManager.Update(new Brand { Id = 3, BrandName = "Honda" });
        

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarId+"|"+car.BrandName+"|"+car.ColorName+"|"+car.DailyPrice+"|"+car.Description);
            }
        }
    }
}
