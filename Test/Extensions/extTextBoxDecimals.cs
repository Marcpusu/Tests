using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Globalization;
using System.Text;

namespace Test
{
    public partial class extTextBoxDecimals : TextBox
    {
        #region Dades

        public int NumDecimals { get; set; } = 4;

        bool esUsuari = true;//flag que ens diu si està escrivint l'usuari o el programa
        bool bSkipTextChanged = false;
        int LastIndexSelection = 0;
        Keys key;

        #endregion

        public extTextBoxDecimals()
        {
            InitializeComponent();
        }

        public extTextBoxDecimals(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary>
        /// Sobreescrivim la propietat Text per poder saber si ho omple l'usuari o el programa
        /// </summary>
        public override string Text
        {
            set
            {
                esUsuari = false;
                base.Text = value;
            }
            get
            {
                return base.Text/*.Replace(Dades.Culture.NumberFormat.NumberGroupSeparator, "")*/;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            string InitialText = this.Text;
            int InitialLength = InitialText.Length;
            string FinalText = InitialText;
            if (!bSkipTextChanged)
            {
                bSkipTextChanged = true;
                LastIndexSelection = SelectionStart;

                if (!string.IsNullOrEmpty(FinalText))
                {
                    //Comprovem que el primer carácter sigui el caracter de negatius i que només estigui aquest carácter
                    if (!(FinalText.StartsWith(Dades.Culture.NumberFormat.NegativeSign) && FinalText.Length == 1))
                    {
                        //Eliminem últim caràcter si no funciona el parse
                        if (!double.TryParse(FinalText, Dades.NStyle, Dades.Culture, out double Num) ||
                            FinalText.Count(x => x == Convert.ToChar(Dades.Culture.NumberFormat.NumberDecimalSeparator)) > 1)
                        {
                            if (LastIndexSelection > 0)
                            {
                                FinalText = FinalText.Remove(LastIndexSelection - 1, 1);
                                LastIndexSelection--;
                            }
                        }
                                
                        InitialLength = FinalText.Length;

                        if (!esUsuari)
                        {
                            FinalText = FinalText.Replace(CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator, Dades.Culture.NumberFormat.NumberDecimalSeparator);
                        }

                        if (!string.IsNullOrEmpty(FinalText))
                        {
                            //Substituim el punt per la coma
                            string s = FinalText.Substring((LastIndexSelection <= 0) ? 0 : LastIndexSelection - 1, 1);
                            if ((s == Dades.Culture.NumberFormat.NumberDecimalSeparator || s == Dades.Culture.NumberFormat.NumberGroupSeparator) && (key != Keys.Delete && key != Keys.Back) )
                            {
                                string str = FinalText.Remove(LastIndexSelection - 1, 1);
                                FinalText = str.Insert(LastIndexSelection - 1, Dades.Culture.NumberFormat.NumberDecimalSeparator);
                            }
                            else
                                FinalText = AfegirPuntMilers(FinalText);

                            if (FinalText.StartsWith(Dades.Culture.NumberFormat.NumberGroupSeparator)) FinalText = FinalText.Remove(0, 1);
                        }
                    }
                }
                
                this.Text = FinalText;

                if (FinalText.Length == InitialLength + 1)
                    SelectionStart = LastIndexSelection + 1;
                else if (FinalText.Length == InitialLength)
                    SelectionStart = LastIndexSelection;
                else
                    SelectionStart = LastIndexSelection;

                bSkipTextChanged = false;
            }

            base.OnTextChanged(e);
        }

        public string AfegirPuntMilers(object Num)
        {
            string Decimals = string.Empty;

            bool bDecimal = false;
            char cAnterior = ' ';
            int iNumZeros = 0;
            //Mirem el numero de zeros que hi ha com a decimals (seguits)
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

                if (c.ToString() == Dades.Culture.NumberFormat.NumberDecimalSeparator)
                    bDecimal = true;
            }

            //Específiquem quants decimals hi haura sumant el valor per defecte dels decimals mes el númeo de 0 consecutius que hi ha després del separador de decimals
            Decimals = new StringBuilder().Append('#', NumDecimals + iNumZeros).ToString();

            string Numero = Num.ToString();

            if (decimal.TryParse(Numero, Dades.NStyle, Dades.Culture, out decimal result))
            {
                if (result == 0)
                    return Numero;

                if (esUsuari)
                {
                    //Si el numero mes gran de 3 carácters i es igual a 0 + Separador_Decimals + 0 el retornem per a no perdre-ho
                    if (Numero.Length > 2 && (Numero.Substring(0, 1) == "0" && Numero.Substring(1, 1) == Dades.Culture.NumberFormat.NumberDecimalSeparator && Num.ToString().Substring(2, 1) == "0"))
                        return Numero;

                    //Partim el numero per el separador de decimals i convertim la primera part amb separador de milers de la cultura i li afegim la 2a part del número amb decimals
                    string[] str = Numero.Split(new string[] { Dades.Culture.NumberFormat.NumberDecimalSeparator }, StringSplitOptions.RemoveEmptyEntries);
                    decimal.TryParse(str[0], Dades.NStyle, Dades.Culture, out decimal res);
                    Numero = res.ToString("###,###", Dades.Culture);
                    Numero = (str.Length > 1) ? Numero + Dades.Culture.NumberFormat.NumberDecimalSeparator + str[1] : Numero;
                    
                    //Si el número comença amb símbol negatiu, li afegim
                    if (Num.ToString().Substring(0, 1) == Dades.Culture.NumberFormat.NegativeSign && Num.ToString().Substring(1, 1) == "0" && Num.ToString().Substring(2, 1) == Dades.Culture.NumberFormat.NumberDecimalSeparator) Numero = Dades.Culture.NumberFormat.NegativeSign + Numero;
                }
                else
                {
                    //Convertim el número a la cultura especifica amb separador de milers i decimals
                    Numero = result.ToString("###,###." + Decimals, Dades.Culture);
                }

                //if (Num.ToString().Substring(0, 1) == "0" && Num.ToString().Substring(1,1) == Dades.Culture.NumberFormat.NumberDecimalSeparator) Numero = "0" + Numero;
                //else if (Num.ToString().Substring(0, 1) == Dades.Culture.NumberFormat.NegativeSign && Num.ToString().Substring(1, 1) == Dades.Culture.NumberFormat.NumberDecimalSeparator)
                //{
                //    //if (Num.ToString().Substring(1, 1) == "0" && Num.ToString().Substring(2, 1) == Dades.Culture.NumberFormat.NumberDecimalSeparator)
                //        Numero = Dades.Culture.NumberFormat.NegativeSign + "0" + Numero.Substring(1);
                //    //else
                //    //    Numero = Dades.Culture.NumberFormat.NegativeSign + Numero.Substring(1);
                //}

                ////Si el número comença amb 0 el ToString li ha tret el primer 0 al passar-lo a la cultura específica, se li afegeix el 0
                if (Numero.ToString().Substring(0, 1) == Dades.Culture.NumberFormat.NumberDecimalSeparator)
                    Numero = "0" + Numero;
                else if (Numero.ToString().Substring(0, 1) == Dades.Culture.NumberFormat.NegativeSign && Numero.ToString().Substring(1, 1) == Dades.Culture.NumberFormat.NumberDecimalSeparator)
                    Numero = Dades.Culture.NumberFormat.NegativeSign + "0" + Numero.Substring(1);
            }

            return Numero;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            key = e.KeyCode;
            esUsuari = true;
            base.OnKeyDown(e);
        }
    }
}
