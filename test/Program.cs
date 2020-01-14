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

            using (StreamWriter sw = File.CreateText(@"out.txt"))
            {
                foreach (Product product in data)
                {
                    sw.WriteLine($"Код: {product.Code}, Артикул: {product.Articul}, Наименование: {product.Name}, Производитель: {product.Manufacture}, Единица измерения: {product.Price}");
                    Console.WriteLine($"Код: {product.Code}, Артикул: {product.Articul}, Наименование: {product.Name}, Производитель: {product.Manufacture}, Единица измерения: {product.Price}");
                }
            }
        }
    }
}