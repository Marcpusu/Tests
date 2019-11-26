using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    class DataGridViewDecimalsCell : DataGridViewTextBoxCell
    {
        #region Dades

        public int NumDecimals { get; set; } = 4;

        bool omplir = true;

        #endregion

        //protected override void OnEnter(int rowIndex, bool throughMouseClick)
        //{
        //    this.Value = this.Value.ToString().Replace(Dades.Culture.NumberFormat.NumberGroupSeparator, "");

        //    base.OnEnter(rowIndex, throughMouseClick);
        //}

        public void TunejarNumero()
        {
            if (omplir)
            {
                omplir = false;
                string FinalText = string.Empty;

                if (this.Value != null)
                    FinalText = this.Value.ToString();

                if (!string.IsNullOrEmpty(FinalText))
                {
                    
                    FinalText = FinalText.ToString().Replace(Dades.Culture.NumberFormat.NumberGroupSeparator, Dades.Culture.NumberFormat.NumberDecimalSeparator);

                    //Controlem si hi hagués més d'una coma decimal
                    int index = FinalText.IndexOf(Dades.Culture.NumberFormat.NumberDecimalSeparator); //Obtenim on està la primera coma
                    if (index > -1)
                    {
                        FinalText = FinalText.Replace(Dades.Culture.NumberFormat.NumberDecimalSeparator, "");//Borrem totes les comes
                        FinalText = FinalText.Substring(0, index) + Dades.Culture.NumberFormat.NumberDecimalSeparator + FinalText.Substring(index);//Tornem a posar la primera coma al seu lloc
                    }

                    if (double.TryParse(FinalText, out double d))
                    {
                        //Convertim als decimals demanats controlant si te notació scientífica
                        //if (FinalText.Contains("E"))
                        //    FinalText = string.Format("{0:F" + (Convert.ToInt32(FinalText.Substring(FinalText.Length - 2, 2)) + 2) + "}", Convert.ToDouble(FinalText));

                        FinalText = AfegirPuntMilers(FinalText);
                    }
                    else
                    {
                        FinalText = Regex.Replace(FinalText, @"[^\-" + Dades.Culture.NumberFormat.NumberDecimalSeparator + "0-9]", "");

                        FinalText = AfegirPuntMilers(FinalText);

                        if (!double.TryParse(FinalText, out d))
                            FinalText = string.Empty;
                    }

                    this.Value = FinalText;

                    //Funcions.RestaurarCultura(cultureTmp);
                }

                omplir = true;
            }
        }

        public string AfegirPuntMilers(object Num)
        {
            string Decimals = "";

            #region Mirem el numero de zeros que hi ha com a decimals (seguits) i els sumem al numDecimals
            bool bDecimal = false;
            char cAnterior = ' ';
            int iNumZeros = 0;
            foreach (char c in Num.ToString())
            {
                if (bDecimal)
                {
                    if (cAnterior == ' ') cAnterior = c;
                    else if (cAnterior == '0')
                    {
                        cAnterior = c;
                        iNumZeros += 1;
                    }
                    else break;
                }

                if (c == ',')
                    bDecimal = true;
            }
            #endregion

            Decimals = new StringBuilder().Append('#', NumDecimals + iNumZeros).ToString();

            string Numero = Num.ToString();
            if (decimal.TryParse(Numero, out decimal result))
                Numero = result.ToString("###,###." + Decimals);

            if (Num.ToString().Substring(0, 1) == "0") Numero = "0" + Numero;
            else if (Num.ToString().Substring(0, 1) == Dades.Culture.NumberFormat.NegativeSign)
            {
                if (Num.ToString().Substring(1, 1) == "0")
                    Numero = Dades.Culture.NumberFormat.NegativeSign + "0" + Numero.Substring(1);
            }

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
