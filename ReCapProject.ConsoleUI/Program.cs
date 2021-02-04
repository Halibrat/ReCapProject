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
            //carManager.Add(new Car { Id = 2, BrandId = 2, ColorId = 2, ModelYear = DateTime.Today, Description = "Ferrari" ,DailyPrice=885000});
            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
