using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class DataGridViewEntersColumn : DataGridViewColumn
    {
        public DataGridViewEntersColumn()
        {
            this.CellTemplate = new DataGridViewEntersCell();
        }
    }
}
