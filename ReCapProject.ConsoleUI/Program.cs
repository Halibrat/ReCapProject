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
            //CustomerTest();
            //RentalTest();
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.Add(new Car {Id=7,BrandId=1,ColorId=1,Description="Mazda",DailyPrice=0,ModelYear=new DateTime(2021,01,01) }).Message);

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Console.WriteLine(rentalManager.Add(new Rental { Id = 1, CarId = 1, CustomerId = 1, RentDate = new DateTime(2021, 04, 02) }).Message);
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { Id = 1, CompanyName = "HRS" });
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.Id + "  " + customer.Id + "  " + customer.CompanyName);
            }
        }
    }
}
