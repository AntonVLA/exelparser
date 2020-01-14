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
            for(int i =0; i< datatable.Rows.Count; i++) {
                var row = datatable.Rows[i];
                if (int.TryParse(row[0].ToString(), out _))
                {
                    for (int j = 0; j<row.ItemArray.Length; j++)
                    {
                        productEnumerable.Add(new Product(row));
                    }
                }
            }
        }
        
        public IEnumerator GetEnumerator()
        {
            return productEnumerable.GetEnumerator();
        }
    }
}
