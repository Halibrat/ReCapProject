using Core.Utilities.Results;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
   public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Delete(Customer customer );
        IResult Update(Customer customer);
        IDataResult<List<Customer>> GetAll();
        IDataResult<List<Customer>> GetById(int id);
    }
}
