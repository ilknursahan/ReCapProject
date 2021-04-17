using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
   public class SuccessResult:Result
    {
        public SuccessResult(string message):base(true, message)
        {

        }
        //true yu default olarak vermiş olduk./ mesajları yazmasakta kabul eder.
        public SuccessResult() : base(true)
        {

        }
    }
}
