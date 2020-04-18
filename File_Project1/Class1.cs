using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace File_Project1
{
    class Class1
    {

        string path = "";
        Workbook wb;
        Worksheet ws;
        int c = 1, r = 1;
        int sizecol = 0, sizerow = 0;

        public List<List<string>> matrix = new List<List<string>>();

        _Application _excel = new _Excel.Application();
        public Class1(string path, int sheet)
        {
            this.path = path;
            wb = _excel.Workbooks.Open(path);
            ws = wb.Worksheets[sheet];
        }

        public String[][] Readcoll()
        {
            while (true)
            {

                while (true)
                {
                    r++;

                    if (ws.Cells[c, r].Value2 == null) { break; }

                }
                sizecol = r - 1;
                r = 1;
                c++;
                if (ws.Cells[c, r].Value2 == null) { sizerow = c - 1; break; }

            }
            string[][] values = new string[sizerow][];

            for (int i = 0; i < sizerow; i++)
            {
                values[i] = new string[sizecol];
            }

            for (int i = 0; i < sizerow; i++)
            {
                for (int j = 0; j < sizecol; j++)
                {
                    values[i][j] = Convert.ToString(ws.Cells[(i + 1), (j + 1)].Value2);

                }
            }


            return values;
        }



    }
}
