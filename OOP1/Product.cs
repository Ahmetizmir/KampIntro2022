using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }  //hangi kategriye ait mesela 1 numaralı Id Bilgisayar 2 numaralı Id Tekstil
        public string ProductName { get; set; } //adı
        public double UnitPrice { get; set; } //fiyatı
        public int UnitsInStock { get; set; }  //stok adedi
    }
}
