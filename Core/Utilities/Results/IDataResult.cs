using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //HANGİ TİPİ DÖNDÜRECEĞİNİ BANA SÖYLE
   public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
