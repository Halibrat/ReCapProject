using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class ErrorDataSuccess<T>:DataResult<T>
    {
        public ErrorDataSuccess(T data, string message) : base(data, false, message)    
        {

        }
        public ErrorDataSuccess(T data):base(data,false)
        {
                
        }
        public ErrorDataSuccess(string message):base(default,false,message)
        {

        }
        public ErrorDataSuccess():base(default,false)
        {

        }
    }
}
