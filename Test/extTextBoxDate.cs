using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public partial class extTextBoxDate : Component
    {
        public extTextBoxDate()
        {
            InitializeComponent();
        }

        public extTextBoxDate(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
