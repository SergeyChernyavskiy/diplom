using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip123
{
    public class Column
    {
        public string Name;
        public List<string> Rows;

        public Column(string name, List<string> rows)
        {
            Name = name;
            Rows = rows;
        }
    }
}
