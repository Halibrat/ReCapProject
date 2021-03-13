using Core.Entities.Concrete;
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
            Console.WriteLine(carManager.Add(new Car {BrandId=5,ColorId=3,Description="Lada Jeep",DailyPrice=1500,ModelYear=new DateTime(2021,01,01) }).Message);
          
            // UserTest();

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
        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            Console.WriteLine(userManager.Add(new User { FirstName = "Alex", LastName = "Ferguson", Email = "sir@sir.com" }).Message);
        }
    }
}
