using Core.Utilities.Results;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Abstract
{
   public interface IUserService
    {
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetById(int id);
    }
}
