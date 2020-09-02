using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using ExtensionMethods;
using System.DirectoryServices.AccountManagement;
using System.DirectoryServices;
using System.Text.RegularExpressions;

namespace Test
{
    public partial class frmControlsTest : Form
    {
        Resize _form_resize;

        //private Timer t;
        public frmControlsTest()
        {
            Thread.CurrentThread.CurrentCulture = Dades.Culture;
            Thread.CurrentThread.CurrentUICulture = Dades.Culture;

            InitializeComponent();

            _form_resize = new Resize(this);

            //extDateTimePicker1.Format = DateTimePickerFormat.Custom;
            //extDateTimePicker1.CustomFormat = Dades.Culture.DateTimeFormat.ShortDatePattern;

            //extDateTimePicker1.Text = "23/11/2019";

            extDataGridView1.Columns.Add(new DataGridViewEntersColumn());
            extDataGridView1.Columns.Add(new DataGridViewDecimalsColumn());
            extDataGridView1.Columns.Add(new DataGridViewDateTimePickerColumn());

            extDateTimePicker1.SetCustomFormat();
            extDateTimePicker2.SetCustomFormat();
            extDateTimePicker3.SetCustomFormat();
            extDateTimePicker4.SetCustomFormat();

            extDataGridView1.Rows.Add("6541", "68481.56", "05/12/2019");

            extDateTimePicker1.Text = "2/11/2019";
            extTextBoxEnters1.Text = "5491";

            extTextBoxDecimals1.Text = "0.000005154852";

            decimal d1 = Convert.ToDecimal(extTextBoxEnters1.Text);

            for (int i = 1; i <= 12; i++)
            {
                int iX = i;
                int iY = i;
            }

            //extDateTimePicker1.Valor = (1 == 1) ? (DateTime?)null : new DateTime(2019, 1, 1);

            //extDateTimePicker1.Valor = null;

            //DataTable dt = new DataTable();
            //using (SqlConnection con = new SqlConnection(@""))
            //{
            //    SqlCommand cmd = new SqlCommand("SELECT * FROM aaa", con);

            //    con.Open();

            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    da.Fill(dt);

            //    con.Close();
            //}

            //textBox1.Text = dt.Rows[2][1].ToString();

            //DateTime? dat = EsNull(dt.Rows[1][1]) ? new DateTime?() : Convert.ToDateTime(dt.Rows[1][1]);

            //MessageBox.Show(EsNullData(dat).ToString());

            //dataGridView1.Columns.Add();

            //textBox1.Text = Test.Properties.Settings.Default.UserName;

            //DataGridView dataGrid = new DataGridView();
            //dataGrid.Columns.Add(new DataGridViewTextBoxColumn());
            //dataGrid.Columns.Add(new DataGridViewTextBoxColumn());

            //dataGrid.Rows.Add();
            //dataGrid.Rows[0].Cells[0].Value = "3";
            //dataGrid.Rows[0].Cells[1].Value = "45,23";
            //dataGrid.Rows.Add();
            //dataGrid.Rows[1].Cells[0].Value = "3";
            //dataGrid.Rows[1].Cells[1].Value = "224,56";
            //dataGrid.Rows.Add();
            //dataGrid.Rows[2].Cells[0].Value = "3";
            //dataGrid.Rows[2].Cells[1].Value = "4,56";
            //dataGrid.Rows.Add();
            //dataGrid.Rows[3].Cells[0].Value = "4";
            //dataGrid.Rows[3].Cells[1].Value = "56,00";
            //dataGrid.Rows.Add();
            //dataGrid.Rows[4].Cells[0].Value = "5";
            //dataGrid.Rows[4].Cells[1].Value = "12,02";
            //dataGrid.Rows.Add();
            //dataGrid.Rows[5].Cells[0].Value = "6";
            //dataGrid.Rows[5].Cells[1].Value = "8,50";


            //decimal sumcol = dataGrid.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[0].Value != null && x.Cells[0].Value.ToString() == "3").ToList().Sum(y => Convert.ToDecimal(y.Cells[1].Value));

            //MessageBox.Show(sumcol.ToString());

            //this.Close();

            //string s = @"[qwertre  pvifudjibjf   oifnvjfd isfnfdjo] - [onjgfjihbg] # [fuibguibgnifd] - [ofngjfidguign # uvdfuybgsf # isudgbiffg # uisdbghbsg] # [iudbfgibfdg]";
            //string[] str = s.Split('#');

            //string e = "";
            //foreach (string st in str)
            //{
            //    e += st;
            //    if (e.Trim().EndsWith("]"))
            //    {
            //        label1.Text += e + "\n";
            //        e = "";
            //    }
            //}

            //var fibonacciNumbers = new List<long> { 1, 1 };

            //for (int i = 0; i < 50; i++)
            //{
            //    var previous = fibonacciNumbers[i + 1];
            //    var previous2 = fibonacciNumbers[i];

            //    fibonacciNumbers.Add(previous + previous2);
            //}

            //foreach (var item in fibonacciNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var item1 in fibonacciNumbers)
            //{
            //    if (fibonacciNumbers.Count < 20)
            //    {

            //        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            //        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

            //        fibonacciNumbers.Add(previous + previous2);
            //    }
            //    else
            //    {
            //        foreach (var item in fibonacciNumbers)
            //        {
            //            Console.WriteLine(item);
            //        }
            //    }
            //}

            //var conversor = new NumberFormatInfo();
            //conversor.NumberDecimalSeparator = ".";
            //conversor.NumberGroupSeparator = "";
            //conversor.NumberDecimalDigits = 2;
            //conversor.CurrencyDecimalDigits = 2;

            //MessageBox.Show(Convert.ToString((Convert.ToSingle(4) / 29) * 30.0f, conversor));

            //List<ObjetoA> lstA = new List<ObjetoA>();
            //List<ObjetoB> lstB = new List<ObjetoB>();

            //lstA.Add(new ObjetoA() { IdEstudiante = 1, Fecha = Convert.ToDateTime("13/10/2015"), NombreEstudiante = "Juan" });
            //lstA.Add(new ObjetoA() { IdEstudiante = 2, Fecha = Convert.ToDateTime("13/10/2015"), NombreEstudiante = "Alberto" });

            //lstB.Add(new ObjetoB() { IdEstudiante = 1, Nota = 9 });
            //lstB.Add(new ObjetoB() { IdEstudiante = 1, Nota = 7 });
            //lstB.Add(new ObjetoB() { IdEstudiante = 2, Nota = 3 });
            //lstB.Add(new ObjetoB() { IdEstudiante = 2, Nota = 4 });

            //lstA.Join(lstB, x => x.IdEstudiante, y => y.IdEstudiante, (x, y) => new { ObjetoA = x, ObjetoB = y }).ToList().ForEach(z =>
            //{
            //    MessageBox.Show(z.ObjetoA.IdEstudiante.ToString() + z.ObjetoA.NombreEstudiante + z.ObjetoA.Fecha.ToString() + z.ObjetoB.NombreMateria + z.ObjetoB.Nota);
            //});
            //MessageBox.Show(FirstDateOfWeekISO8601(2019, GetWeekOfMonth(2019, 09)).ToString("dd/MM/yyyy"));


        }

        // Create brush.
        Brush mybrush = new SolidBrush(Color.LightGray);
        // Create pen.
        Pen myPen = new Pen(Color.Black, 2);

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Draw
            //Draw2DArray(sender, e, myPen, mybrush);
        }

        public object EsNullData(object data)
        {
            DateTime? Data = null;
            if (!EsNull(data)) Data = Convert.ToDateTime(data);

            if (Data == null)
                return "null";
            else
                return "'" + ((DateTime)Data).ToDataBaseFormat() + "'";
        }

        public bool EsNull(object valor)
        {
            if (valor == DBNull.Value || valor == null || String.IsNullOrWhiteSpace(valor.ToString()) || valor.ToString() == "System.Data.DataRowView")
                return true;
            else
                return false;
        }

        private void Draw2DArray(object sender, PaintEventArgs e, Pen p, Brush b)
        {
            //int row = 2; //rows
            //int column = 2;//columns

            //int step = 43; //distance between the rows and columns
            //int width = (this.Size.Width / column) - (step * (column - 1)); //the width of the rectangle
            //int height = (this.Size.Height / row) - (step * (row - 1)); //the height of the rectangle
            //int locationX = 1;
            //int locationY = 1;

            //// Create rectangle Matrix.
            //Rectangle[,] rectangleMatrix = new Rectangle[row, column];

            //// Draw 
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Rectangle rect = new Rectangle(new Point(locationX, locationY), new Size(width, height));
            //        locationX += width + step;
            //        rectangleMatrix[i, j] = rect;
            //        e.Graphics.DrawRectangle(p, rect);
            //        e.Graphics.FillRectangle(b, rect);
            //    }
            //    locationX = 1;
            //    locationY += height + step;
            //}

        }

        private int GetWeekOfMonth(int year, int month)
        {
            DateTimeFormatInfo dfi = DateTimeFormatInfo.CurrentInfo;
            DateTime dt = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            //int WeekToRest = 0;
            //if (dt.DayOfWeek >= DayOfWeek.Monday && dt.DayOfWeek <= DayOfWeek.Wednesday)
            //    WeekToRest = 1;

            Calendar cal = dfi.Calendar;
            return cal.GetWeekOfYear(dt, dfi.CalendarWeekRule,
                                                dfi.FirstDayOfWeek) /*- WeekToRest*/;
        }

        public static DateTime FirstDateOfWeekISO8601(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            // Use first Monday in January to get first week of the year as
            // it will never be in Week 52/53
            DateTime firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            // As we're adding days to a date in Week 1,
            // we need to subtract 1 in order to get the right date for week #1
            if (firstWeek == 1)
            {
                weekNum -= 1;
            }

            // Using the first Thursday as starting week ensures that we are starting in the right year
            // then we add number of weeks multiplied with days
            var result = firstThursday.AddDays(weekNum * 7);

            // Subtract 3 days from Thursday to get Monday, which is the first weekday in ISO8601
            return result.AddDays(-3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int i2 = 0;
            //var i = 8 / i2;

            Test.Properties.Settings.Default.UserName = textBox1.Text;
            Test.Properties.Settings.Default.Save();
        }

        //private static void T_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    t.Stop();
        //    ///
        //    /// aqui pones el codigo para mostrar que gano
        //    ///
        //}


        private void Excepcio(object sender, ThreadExceptionEventArgs t)
        {
            MessageBox.Show(t.Exception.ToString());
            
        }

        private void Excepcio(object sender, UnhandledExceptionEventArgs t)
        {
            MessageBox.Show(t.ExceptionObject.ToString());
        }

        public string EsNullDecimal(object valor)
        {
            if (!EsNull(valor) && esNumero(valor))
                return Convert.ToDouble(valor).ToString();
            else
                return string.Empty;
        }

        public static string NormalitzarText(string Text)
        {
            //Transformem a UNICODE
            string sTextNormalitzat = Text.Normalize(NormalizationForm.FormD);
            //Reemplaçem tot o que no coincideixi al Regex per espais
            Regex reg = new Regex("[^a-zA-Z0-9 ]");
            return reg.Replace(sTextNormalitzat, "");
        }

        public bool esNumero(object numero)
        {
            string n = numero.ToString();
            double num;

            if (n != string.Empty)
            {
                if (double.TryParse(n, out num))
                    return true;
                else
                    return false;
            }
            else return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Thread.CurrentThread.CurrentCulture = Dades.Culture;
            //Thread.CurrentThread.CurrentUICulture = Dades.Culture;
            //int i2 = 0;
            //var i = 8 / i2;
            //_form_resize._get_initial_size();
            //string s = DateTime.UtcNow.ToString("o");

            //extTextBoxDecimals1.Text = "9954651565.00000000000999";
            decimal d2 = 0.0000000000051M;

            //extMaskedTextBox1.Text = new DateTime(2019,02,03).ToString();
            extTextBoxDecimals1.Text = d2.ToString();

            extTextBoxDecimals2.Text = "1000000,5";

            extTextBoxDecimals1.Text = Convert.ToDecimal(extTextBoxDecimals2.Text).ToString();

            textBox2.Text = new DateTime(2010, 2, 15, 2, 3, 4).ToString();

            textBox1.Text = string.Join(", ", new List<string>());

            //GetActiveDirectoryUsers();

            //int io = int.Parse("4.500");
            decimal ddo = decimal.Parse("4.500");

            

            //decimal d = Convert.ToDecimal("9,25263160709654E-05");

            //string sIdUsuari = CrearIdUsuari("Marc", "Puig");

            //MessageBox.Show(sIdUsuari);

            //StringBuilder sb = new StringBuilder();
            //sb.Append('#', 4);

            //textBox1.Text = FormatearNumero("98745618,451");

            //foreach (int cultureInfo in new CultureInfo("zh-CHS").NumberFormat.NumberGroupSizes)
            //{
            //    Console.WriteLine(cultureInfo + "digits");
            //}
        }

        private string CrearIdUsuari(string Nom, string Cognom)
        {
            string sIdUsuari = string.Empty;

            if (EsNull(Nom) || EsNull(Cognom))
                return sIdUsuari;

            string[] sNom = NormalitzarText(Nom).Split(' ');
            string[] sCognom = NormalitzarText(Cognom).Split(' ');

            for (int i = 0; i < sNom[0].Length && ExisteixUsuariDomini(sIdUsuari); i++)
            {
                sIdUsuari = string.Empty;

                for (int j = 0; j < sNom.Length; j++)
                {
                    if (j == 0)
                        sIdUsuari += sNom[j].Substring(0, i +1);
                    else
                        sIdUsuari += sNom[j].Substring(0, 1);
                }
                sIdUsuari += sCognom[0];
            }

            if (ExisteixUsuariDomini(sIdUsuari)) throw new Exception("All possible usernames exist. Please contact with IT Team");

            return sIdUsuari.ToLower();
        }

        private void GetActiveDirectoryUsers()
        {
            using (var context = new PrincipalContext(ContextType.Domain, "domain.com"))
            {
                using (var searcher = new PrincipalSearcher(new UserPrincipal(context)))
                {
                    foreach (var result in searcher.FindAll())
                    {
                        DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                        Console.WriteLine("First Name: " + de.Properties["givenName"].Value);
                        Console.WriteLine("Last Name : " + de.Properties["sn"].Value);
                        Console.WriteLine("SAM account name   : " + de.Properties["samAccountName"].Value); //IdUsuari
                        Console.WriteLine("User principal name: " + de.Properties["userPrincipalName"].Value);
                        Console.WriteLine();
                    }
                }
            }
        }

        private bool ExisteixUsuariDomini(string sIdUsuari)
        {
            bool bExist = false;

            if (EsNull(sIdUsuari)) return true;

            using (var context = new PrincipalContext(ContextType.Domain, "domain.com"))
            {
                using (var searcher = new PrincipalSearcher(new UserPrincipal(context) { SamAccountName = sIdUsuari }))
                {
                    foreach (var result in searcher.FindAll())
                    {
                        DirectoryEntry de = result.GetUnderlyingObject() as DirectoryEntry;
                        if (de.Properties["samAccountName"].Value.ToString().ToLower() == sIdUsuari.ToLower())
                        {
                            bExist = true;
                            break;
                        }
                    }
                }
            }

            return bExist;
        }

        //public string FormatearNumero(object Num)
        //{
        //    CultureInfo Culture = new CultureInfo("es-ES", false);
        //    NumberStyles NStyle = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign;
        //    bool esUsuari = true;

        //    string Numero = Num.ToString();

        //    if (decimal.TryParse(Numero, NStyle, Culture, out decimal result))
        //    {
        //        if (result == 0)
        //            return Numero;

        //        if (esUsuari) //Boleano que indica si el valor se ha modificado por un usuario o no
        //        {
        //            if (Numero.Length > 2 && (Numero.Substring(0, 1) == "0" && Numero.Substring(1, 1) == Culture.NumberFormat.NumberDecimalSeparator && Num.ToString().Substring(2, 1) == "0"))
        //                return Numero;

        //            string[] str = Numero.Split(new string[] { Culture.NumberFormat.NumberDecimalSeparator }, StringSplitOptions.RemoveEmptyEntries);
        //            decimal.TryParse(str[0], NStyle, Culture, out decimal res);
        //            Numero = res.ToString("###" + Culture.NumberFormat.NumberGroupSeparator + "###" + Culture.NumberFormat.NumberGroupSeparator + "###", Culture);
        //            Numero = (str.Length > 1) ? Numero + Culture.NumberFormat.NumberDecimalSeparator + str[1] : Numero;

        //            if (Num.ToString().Substring(0, 1) == Culture.NumberFormat.NegativeSign && Num.ToString().Substring(1, 1) == "0")
        //                Numero = Culture.NumberFormat.NegativeSign + Numero;

        //            if (Num.ToString().Substring(0, 1) == "0")
        //                Numero = "0" + Numero;
        //            else if (Num.ToString().Substring(0, 1) == Culture.NumberFormat.NegativeSign)
        //            {
        //                if (Num.ToString().Substring(1, 1) == "0" && Num.ToString().Length > 2)
        //                    Numero = Culture.NumberFormat.NegativeSign + "0" + Numero.Substring(1);
        //                else
        //                    Numero = Culture.NumberFormat.NegativeSign + Numero.Substring(1);
        //            }
        //        }
        //        else
        //        {
        //            Numero = result.ToString("###,###.####", Culture);
        //            //Numero = result.ToString("N", Culture);
        //        }
        //    }
        //    return Numero;
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = FormatearNumero(textBox1.Text);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //_form_resize._resize();
        }
    }

    class ObjetoA
    {
        public int IdEstudiante { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreEstudiante { get; set; }
    }
    class ObjetoB
    {
        public int IdEstudiante { get; set; }
        public decimal Nota { get; set; }
        public string NombreMateria { get; set; }
    }
}
