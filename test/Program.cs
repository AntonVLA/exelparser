using System;
using System.Collections.Generic;
using System.Data.Common;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "Price_Kompjuternaja_perifеrija_2018_07_10.xlsx";
            Data data = new Data(filepath);
            foreach(Product product in data)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}