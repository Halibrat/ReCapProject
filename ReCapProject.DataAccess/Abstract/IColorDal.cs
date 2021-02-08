using Core.DataAccess;
using ReCapProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ReCapProject.DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color>
    {
        
    }
}
