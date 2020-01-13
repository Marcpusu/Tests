using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    class DataGridViewDateTimePickerColumn : DataGridViewColumn
    {
        public DataGridViewDateTimePickerColumn()
        {
            this.CellTemplate = new DataGridViewDateTimePickerCell();
            this.ReadOnly = true;
        }
    }
}
