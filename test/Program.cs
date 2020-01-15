using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "test.xlsx";
            Data data = new Data(filepath);

            using (StreamWriter sw = new StreamWriter(new FileStream(@"../../../out.txt", FileMode.Create, FileAccess.Write)))
            {
                foreach (Product product in data)
                {
                    string retstr = $"Код: {product.Code}, Артикул: {product.Articul}, Наименование: {product.Name}, Производитель: {product.Manufacture}, Единица измерения: {product.MeasurementUnit}, Розничная цена: {product.Price}.";
                    sw.WriteLine(retstr);
                    Console.WriteLine(retstr);
                }
            }
        }
    }
}