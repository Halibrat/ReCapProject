using Core.Utilities.Results;
using ReCapProject.Business.Abstract;
using ReCapProject.Business.Constans;
using ReCapProject.DataAccess.Abstract;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ReCapProject.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdd);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult();
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<List<User>> GetById(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.Id == id));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}