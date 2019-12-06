using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Globalization;

namespace Test
{
    public partial class extDateTimePicker : DateTimePicker
    {

        [Browsable(false), Bindable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden), ]
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
            Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            CalendarFont = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            MinDate = new DateTime(1900, 01, 01);
        }

        public extDateTimePicker(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            Format = DateTimePickerFormat.Custom;
            Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            CalendarFont = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            MinDate = new DateTime(1900, 01, 01);
        }

        public void SetCustomFormat()
        {
            CustomFormat = Dades.Culture.DateTimeFormat.ShortDatePattern;
        }
    }
}
