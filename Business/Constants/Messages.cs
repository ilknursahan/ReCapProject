using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    //new lemeyelim diye tek instance oluyor, statik olarak her yerde kullanabliyoruz.
  public static  class Messages
    {
        //static olduğundan PascalCase kullanıyoruz.Baş harfi büyük olmalı.
        public static string CarAdded = "Araba eklendi";
        public static string CarPriceInvalid = "Araba fiyatı geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Araç listelendi";
        public static string CarNotAdded = "Araç teslim edilmedi";
    }
}
