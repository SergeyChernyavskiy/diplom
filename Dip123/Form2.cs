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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void SetDataGrid(object[,] data)
        {
            DataTable table = ArraytoDatatable(data);
            dataGridView1.DataSource = table;
        }

        public static DataTable ArraytoDatatable(Object[,] data)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < data.GetLength(1); i++)
            {
                dt.Columns.Add("Column" + (i + 1));
            }

            for (var i = 0; i < data.GetLength(0); ++i)
            {
                DataRow row = dt.NewRow();
                for (var j = 0; j < data.GetLength(1); ++j)
                {
                    row[j] = data[i+1, j+1];
                }
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
