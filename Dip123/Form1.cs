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
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Microsoft.Office.Interop.Excel.Application excel=new Microsoft.Office.Interop.Excel.Application();
            Workbook wb=excel.Workbooks.Open("C:\\Users\\wlwil\\OneDrive\\Desktop\\Диплом.xlsx");
            Worksheet ws = wb.Worksheets[2];
            Range cell = ws.Range["B23"];
      //     Range cell = ws.Cells[2,37]; 
            MessageBox.Show(Convert.ToString(cell.Value));
        }
    }
}