using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip123
{
    public class Worksheet
    {
        public int Sheet;
        public List<Column> Columns;

        public Worksheet(int sheet, List<Column> columns)
        {
            Sheet = sheet;
            Columns = columns;
        }
    }
}
