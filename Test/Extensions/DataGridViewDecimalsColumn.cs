﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class DataGridViewDecimalsColumn : DataGridViewColumn
    {
        public DataGridViewDecimalsColumn()
        {
            this.CellTemplate = new DataGridViewDecimalsCell();
        }
    }
}
