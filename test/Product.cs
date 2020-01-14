using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace test
{
    class Product
    {
        public int Code { get; set; }

        public int Articul { get; set; }

        public string Name { get; set; }

        public string Manufacture { get; set; }

        public string MeasurementUnit { get; set; }

        public string Price { get; set; }

        public Product(DataRow row)
        {
            Code = int.Parse(row[0].ToString());
            int _;
            int.TryParse(row[1].ToString(), out _);
            Articul = _;
            Name = row[2].ToString();
            Manufacture = row[3].ToString();
            MeasurementUnit = row[4].ToString();
            Price = row[5].ToString();
        }
    }
}
