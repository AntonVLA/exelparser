using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using IronXL;

namespace test
{
    class Data : IEnumerable
    {
        private List<Product> productEnumerable = new List<Product>();
        private WorkBook workbook;

        public Data(string filename)
        {
            workbook = WorkBook.Load(filename);
            WorkSheet sheet = workbook.DefaultWorkSheet;
            IronXL.Range range = sheet["A8:H911"];
            var datatable = range.ToDataTable();

            foreach (DataRow row in datatable.Rows)
            {
                if (int.TryParse(row[0].ToString(), out _))
                {
                    productEnumerable.Add(new Product(row));
                }
            }
        }
        
        public IEnumerator GetEnumerator()
        {
            return productEnumerable.GetEnumerator();
        }
    }
}
