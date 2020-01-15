using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace test
{
    class Product
    {
        public int Code { get; set; }

        public int? Articul { get; set; }

        public string Name { get; set; }

        public string Manufacture { get; set; }

        public string MeasurementUnit { get; set; }

        public int? Price { get; set; }

        public Product(DataRow row)
        {
            Code = int.Parse(row[0].ToString());

            if (int.TryParse(row[1].ToString(), out _)) Articul = int.Parse(row[1].ToString());

            Name = row[2].ToString();
            Manufacture = row[3].ToString();
            MeasurementUnit = row[4].ToString();
            if (int.TryParse(row[5].ToString(), out _)) Price = int.Parse(row[5].ToString());
        }

        public override string ToString()
        {
            return $"Код: {Code}, Артикул: {Articul}, Наименование: {Name}, Производитель: {Manufacture}, Единица измерения: {MeasurementUnit}, Розничная цена: {Price}.";
        }
    }
}
