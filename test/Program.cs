using System;
using System.Collections.Generic;
using System.Data.Common;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = "test.xlsx";
            Data data = new Data(filepath);
            foreach(Product product in data)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}