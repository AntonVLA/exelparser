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
        Product[] productEnumerable;
        WorkBook workbook = WorkBook.LoadExcel("test.xlsx");

        public Data(string filename)
        {
            workbook = WorkBook.Load("test.xlsx");
            WorkSheet sheet = workbook.DefaultWorkSheet;
            IronXL.Range range = sheet["A8:H911"];
            var datatable = range.ToDataTable();
            foreach (DataRow row in datatable.Rows)
            {
                int code;
                if (int.TryParse(row[1].ToString(), out code))
                {
                    //for (int cell = 1; cell < row)
                    //{

                    //}
                }
            }
        }
        
        public IEnumerator GetEnumerator()
        {
            return productEnumerable.GetEnumerator();
        }
    }
}
