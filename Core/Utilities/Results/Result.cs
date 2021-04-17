using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
      //iki yapıyıda karşılasın.Buna overrloading deniyor, aşırı yükleme
      //this demek classın kendisi demek

        public Result(bool success, string message):this(success)
        {
            Message = message;
          
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
