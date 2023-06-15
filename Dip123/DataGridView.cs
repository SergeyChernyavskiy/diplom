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
    public partial class DataGridView : Form
    {
        public DataGridView()
        {
            InitializeComponent();
        }

        public void SetDataGrid(List<Worksheet> worksheets)
        {
            DataTable table = new DataTable();
            foreach (Worksheet worksheet in worksheets)
            {
                for (int column = 0; column < worksheet.Columns.Count; column++)
                {
                    table.Columns.Add(worksheet.Columns[column].Name, typeof(string));

                    for (int row = 0; row < worksheet.Columns[column].Rows.Count; row++)
                    {
                        if (table.Rows.Count <= row)
                        {
                            var tableRow = table.NewRow();
                            tableRow[table.Columns.Count-1 + column] = worksheet.Columns[column].Rows[row];
                            table.Rows.Add(tableRow);
                        }
                        else
                        {
                            table.Rows[row][table.Columns.Count - 1] = worksheet.Columns[column].Rows[row];
                        }
                    }
                    
                }
            }
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.DataSource = table;
        }
    }
}
