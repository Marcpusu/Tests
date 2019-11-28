using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace Test
{
    public partial class extDateTimePicker : DateTimePicker
    {
        public DateTime? Valor
        {
            get
            {
                if (Value == MinDate)
                    return null;
                else
                    return Value;
            }
            set
            {
                if (value != null)
                    Value = (DateTime)value;
                else
                    Value = MinDate;
            }
        }

        public extDateTimePicker()
        {
            InitializeComponent();

            Format = DateTimePickerFormat.Custom;
            CustomFormat = Dades.Culture.DateTimeFormat.ShortDatePattern;
            Font = new Font("Calibri", 9, FontStyle.Regular);
            MinDate = new DateTime(1900, 01, 01);
        }

        public extDateTimePicker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            Format = DateTimePickerFormat.Custom;
            CustomFormat = Dades.Culture.DateTimeFormat.ShortDatePattern;
            Font = new Font("Calibri", 9, FontStyle.Regular);
            MinDate = new DateTime(1900, 01, 01);
            Value = MinDate;
        }
    }
}
