using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class DataGridViewEntersCell : DataGridViewTextBoxCell
    {
        #region [ Dades]

        public bool PuntMilers { get; set; } = true;

        bool omplir = true;

        #endregion

        public void TunejarNumero()
        {
            if (omplir)
            {
                omplir = false;
                string FinalText = string.Empty;

                if (this.Value != null)
                    FinalText = this.Value.ToString();

                if (!string.IsNullOrEmpty(FinalText.ToString()))
                {
                    if (FinalText.ToString().Contains(Dades.Culture.NumberFormat.NumberGroupSeparator) || FinalText.ToString().Contains(Dades.Culture.NumberFormat.NumberDecimalSeparator))
                    {
                        //Si coma treiem el que hi ha darrera / Si punt el treiem a seques(pq pot ser q ja vingui d'un mil amb punt)
                        string[] s = FinalText.ToString().Contains(Dades.Culture.NumberFormat.NumberGroupSeparator) ? FinalText.ToString().Split(new string[] { Dades.Culture.NumberFormat.NumberGroupSeparator }, StringSplitOptions.RemoveEmptyEntries) : FinalText.ToString().Split(new string[] { Dades.Culture.NumberFormat.NumberDecimalSeparator }, StringSplitOptions.RemoveEmptyEntries);
                        if (s.Length > 0)
                            FinalText = s[0];
                        else
                            FinalText = string.Empty;
                    }

                    FinalText = AfegirPuntMilers(Regex.Replace(FinalText.ToString(), @"[^\-0-9]", ""));
                }

                this.Value = FinalText;

                omplir = true;
            }
        }

        public string AfegirPuntMilers(object Num)
        {
            decimal result = 0;
            string Numero = Num.ToString();
            if (decimal.TryParse(Numero, out result))
                Numero = result.ToString("###,###,###");

            return Numero;
        }

        public void NumeroSenseSeparadorsMilers()
        {
            if (omplir)
            {
                omplir = false;
                string FinalNum = this.Value.ToString();

                FinalNum = FinalNum.Replace(Dades.Culture.NumberFormat.NumberGroupSeparator, "");

                this.Value = FinalNum;
                omplir = true;
            }
        }
    }
}
