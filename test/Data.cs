using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using ExcelDataReader;
using System.IO;

namespace test
{
    class Data : IEnumerable
    {
        private List<Product> productEnumerable = new List<Product>();

        public Data(string filename)
        {
            DataTable datatable;
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(filename, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    datatable = reader.AsDataSet().Tables[0];
                }
            }

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
