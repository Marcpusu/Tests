using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Globalization;
using System.Text;

namespace Test.Extensions
{
    public partial class extMaskedTextBox : MaskedTextBox
    {
        bool bSkipTextChanged = false;
        public extMaskedTextBox()
        {
            InitializeComponent();
        }

        public override string Text
        {
            set
            {
                base.Text = value;
            }
            get
            {
                return base.Text/*.Replace(Dades.Culture.NumberFormat.NumberGroupSeparator, "")*/;
            }
        }

        public extMaskedTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.Culture = Dades.Culture;
            this.FormatProvider = Dades.Culture;

            bSkipTextChanged = true;
            //this.Mask = Dades.DateFormatText;
            //this.Text = Dades.DateFormat;
            bSkipTextChanged = false;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (!bSkipTextChanged)
            {
                bSkipTextChanged = true;

                if (this.MaskFull)
                {
                    if (!DateTime.TryParse(this.Text, out DateTime dt))
                    {
                        this.Text = string.Empty;
                        SelectionStart = 0;
                    }
                    else if (dt < new DateTime(1900,01,01))
                    {
                        this.Text = string.Empty;
                        SelectionStart = 0;
                    }
                }

                bSkipTextChanged = false;
            }
            
            base.OnTextChanged(e);
        }
    }
}
