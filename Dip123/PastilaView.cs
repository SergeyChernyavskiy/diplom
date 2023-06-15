using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dip123
{
    public partial class PastilaView : Form
    {
        public PastilaView()
        {
            InitializeComponent();
        }

        private void ShowData(List<Worksheet> worksheets)
        {
            DataGridView dataGridView = new DataGridView();
            dataGridView.SetDataGrid(worksheets);
            dataGridView.ShowDialog();
        }

        private Worksheet CreateDataModes(int sheet, List<KeyValuePair<string, string>> columnRanges)
        {
            List<Column> columns = new List<Column>();
            foreach (var columnRange in columnRanges)
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Workbook wb = excel.Workbooks.Open(System.IO.Directory.GetCurrentDirectory() + "\\database.xlsx");
                Microsoft.Office.Interop.Excel.Worksheet ws = wb.Worksheets[sheet];
                var name = ws.Range[columnRange.Key];

                List<string> rows = new List<string>();

                var rangesValues = ws.Range[columnRange.Value].Value;
                foreach (var value in rangesValues)
                {
                    if (value is double)
                    {
                        rows.Add(Math.Round((double)value, 2).ToString());
                    }
                    else
                    {
                        rows.Add((string)value);
                    }
                }

                columns.Add(new Column(name.Value as string, rows));
            }
            return new Worksheet(sheet, columns);
        }

        private void DvuhsloinayaBtnClick(object sender, EventArgs e)
        {
            List<Worksheet> worksheets = new List<Worksheet>();
            worksheets.Add(CreateDataModes(4, new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("A22","A24:A38"),
                new KeyValuePair<string, string>("B23","B24:B38")
            }));
            worksheets.Add(CreateDataModes(6, new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("A4","A6:A16"),
                new KeyValuePair<string, string>("B2","C6:C16")
            }));
            worksheets.Add(CreateDataModes(7, new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("A2","A6:A13"),
                new KeyValuePair<string, string>("B2","D6:D13")
            }));
            ShowData(worksheets);
        }

        private void MalinaBtnClick(object sender, EventArgs e)
        {
            List<Worksheet> worksheets = new List<Worksheet>();
            worksheets.Add(CreateDataModes(4, new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("A22","A24:A38"),
                new KeyValuePair<string, string>("C23","C24:C38")
            }));
            worksheets.Add(CreateDataModes(6, new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("A4","A6:A16"),
                new KeyValuePair<string, string>("B2","C6:C16")
            }));
            worksheets.Add(CreateDataModes(7, new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("A2","A6:A13"),
                new KeyValuePair<string, string>("B2","C6:C13")
            }));
            ShowData(worksheets);
        }

        private void KlukvaBtnClick(object sender, EventArgs e)
        {
            List<Worksheet> worksheets = new List<Worksheet>();
            worksheets.Add(CreateDataModes(4, new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("A22","A24:A38"),
                new KeyValuePair<string, string>("B23","D24:D38")
            }));
            worksheets.Add(CreateDataModes(6, new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("A4","A6:A16"),
                new KeyValuePair<string, string>("B2","D6:D16")
            }));
            worksheets.Add(CreateDataModes(7, new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("A2","A6:A13"),
                new KeyValuePair<string, string>("B2","D6:D13")
            }));
            ShowData(worksheets);
        }

        private void BackPastilaBtnClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
