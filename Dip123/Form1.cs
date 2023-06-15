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

        private static void ShowData(int worksheet, string tableRange)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = excel.Workbooks.Open(System.IO.Directory.GetCurrentDirectory() + "\\database.xlsx");
            Worksheet ws = wb.Worksheets[worksheet];
            Range range = ws.Range[tableRange];
            Form2 form = new Form2();
            form.SetDataGrid(range.Value);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData(4, "B23:B38");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowData(4, "C23:C38");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowData(4, "D23:D38");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowData(4, "E23:E38");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowData(4, "F23:F38");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowData(4, "G23:G38");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowData(4, "H23:H38");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowData(4, "I23:I38");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShowData(4, "J23:J38");
        }
    }
}