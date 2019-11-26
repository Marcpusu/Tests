using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Globalization;
using System.Text;

namespace Test.Extensions
{
    public partial class extTextBoxEnters : TextBox
    {
        #region Dades

        public bool PuntMilers { get; set; } = true;

        bool omplir = true;
        bool bSkipTextChanged = false;
        int LastIndexSelection = 0;

        #endregion

        public extTextBoxEnters()
        {
            InitializeComponent();
        }

        public extTextBoxEnters(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            string InitialText = this.Text;
            int InitialLength = InitialText.Length;
            string FinalText = InitialText;
            if (!bSkipTextChanged)
            {
                if (omplir)
                {
                    omplir = false;
                    bSkipTextChanged = true;
                    LastIndexSelection = SelectionStart;

                    if (!string.IsNullOrEmpty(FinalText) && FinalText != "0")
                    {
                        if (FinalText.StartsWith(Dades.Culture.NumberFormat.NumberGroupSeparator)) FinalText = FinalText.Remove(0, 1);

                        double Num;
                        if (!double.TryParse(FinalText, out Num))
                            FinalText = FinalText.Substring(0, FinalText.Length - 1);

                        if (PuntMilers) FinalText = Num.ToString("###,###,###");

                        this.SelectionStart = FinalText.Length;
                    }

                    omplir = true;
                }

                this.Text = FinalText;

                bSkipTextChanged = false;

                if (FinalText.Length == InitialLength + 1)
                    SelectionStart = LastIndexSelection + 1;
                else if (FinalText.Length == InitialLength)
                    SelectionStart = LastIndexSelection;
                else
                    SelectionStart = LastIndexSelection;
            }

            base.OnTextChanged(e);
        }
    }
}
