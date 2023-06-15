using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dip123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MainView mainView = new MainView();
            mainView.ShowDialog();
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
                    if(value is double)
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

        private void button1_Click(object sender, EventArgs e)
        {
            List<Worksheet> worksheets = new List<Worksheet>();
            worksheets.Add(CreateDataModes(4, new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("A22","A24:A38"),
                new KeyValuePair<string, string>("B1","B24:B38")
            }));
            worksheets.Add(CreateDataModes(6, new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("A4","A6:A16"),
                new KeyValuePair<string, string>("B2","B6:B16")
            }));
            worksheets.Add(CreateDataModes(7, new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("A2","A6:A13"),
                new KeyValuePair<string, string>("B2","B6:B13")
            }));
            ShowData(worksheets);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
        }
    }
}