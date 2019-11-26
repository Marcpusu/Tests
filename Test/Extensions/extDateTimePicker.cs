using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace Test
{
    public partial class extDateTimePicker : DateTimePicker
    {
        public extDateTimePicker()
        {
            InitializeComponent();

            this.Format = DateTimePickerFormat.Custom;
            this.CustomFormat = Dades.Culture.DateTimeFormat.ShortDatePattern;
            this.Font = new Font("Calibri", 9, FontStyle.Regular);
        }

        public extDateTimePicker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
