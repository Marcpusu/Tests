using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Common;
using System.Text;
using System.Data;
using System.Globalization;
using System.Data.SqlClient;
using System.Timers;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Presentacio
{
    static class Program
    {

    //    static string dr = "/+1-541-754-3010 156 Alphand_St. <J Steeve>\n 133, Green, Rd. <E Kustur> NY-56423 ;+1-541-914-3010\n"
    //+ "+1-541-984-3012 <P Reed> /PO Box 530; Pollocksville, NC-28573\n :+1-321-512-2222 <Paul Dive> Sequoia Alley PQ-67209\n"
    //+ "+1-741-984-3090 <Peter Reedgrave> _Chicago\n :+1-921-333-2222 <Anna Stevens> Haramburu_Street AA-67209\n"
    //+ "+1-111-544-8973 <Peter Pan> LA\n +1-921-512-2222 <Wilfrid Stevens> Wild Street AA-67209\n"
    //+ "<Peter Gone> LA ?+1-121-544-8974 \n <R Steell> Quora Street AB-47209 +1-481-512-2222\n"
    //+ "<Arthur Clarke> San Antonio $+1-121-504-8974 TT-45120\n <Ray Chandler> Teliman Pk. !+1-681-512-2222! AB-47209,\n"
    //+ "<Sophia Loren> +1-421-674-8974 Bern TP-46017\n <Peter O'Brien> High Street +1-908-512-2222; CC-47209\n"
    //+ "<Anastasia> +48-421-674-8974 Via Quirinal Roma\n <P Salinger> Main Street, +1-098-512-2222, Denver\n"
    //+ "<C Powel> *+19-421-674-8974 Chateau des Fosses Strasbourg F-68000\n <Bernard Deltheil> +1-498-512-2222; Mount Av.  Eldorado\n"
    //+ "+1-099-500-8000 <Peter Crush> Labrador Bd.\n +1-931-512-4855 <William Saurin> Bison Street CQ-23071\n"
    //+ "<P Salinge> Main Street, +1-098-512-2222, Denve\n" + "<P Salinge> Main Street, +1-098-512-2222, Denve\n";

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //CultureInfo cl = new CultureInfo("es-ES");
            //NumberFormatInfo nfi = cl.NumberFormat;

            //decimal d = 1234567;

            //MessageBox.Show(cl.NumberFormat.NumberDecimalSeparator);

            //DataTable TablaIdSig = new DataTable();
            //DataColumn dc = new DataColumn("idPregunta");
            //TablaIdSig.Columns.Add(dc);
            //DataRow dr1 = TablaIdSig.NewRow();
            //dr1[dc] = "1";
            //TablaIdSig.Rows.Add(dr1);
            //dr1 = TablaIdSig.NewRow();
            //dr1[dc] = "2";
            //TablaIdSig.Rows.Add(dr1);
            //dr1 = TablaIdSig.NewRow();
            //dr1[dc] = "3";
            //TablaIdSig.Rows.Add(dr1);

            //DataTable nuevaTablaIdSig = new DataTable();

            //DataTable pregunta = resultados.Tables[0];

            //foreach (DataColumn col in TablaIdSig.Columns)
            //{
            //    DataColumn colNew = new DataColumn(col.ColumnName, col.DataType);
            //    nuevaTablaIdSig.Columns.Add(colNew);
            //}

            //DataColumn idPregSig = new DataColumn("idPregSig");
            //nuevaTablaIdSig.Columns.Add(idPregSig);

            //for (int i = 0; i < TablaIdSig.Rows.Count -1; i++)
            //{
            //    DataRow row = nuevaTablaIdSig.NewRow();
            //    row["idPregunta"] = TablaIdSig.Rows[i]["idPregunta"];
            //    if (i == TablaIdSig.Rows.Count)
            //        row["idPregSig"] = "0";
            //    else
            //        row["idPregSig"] = TablaIdSig.Rows[i + 1]["idPregunta"];
            //    nuevaTablaIdSig.Rows.Add(row);
            //}


            //foreach (DataRow dr in TablaIdSig.Rows)
            //{

            //    DataRow row = nuevaTablaIdSig.NewRow();
            //    row["idPregunta"] = dr["idPregunta"];
            //    nuevaTablaIdSig.Rows.Add(row);

            //    var preguntaSiguiente = row["idPregunta"];

            //    if (bandera == 1)
            //    {

            //        row["idPregSig"] = preguntaSiguiente;

            //    }

            //    bandera = 1;
            //}
            //string str = "";
            //foreach (DataRow dataRow in nuevaTablaIdSig.Rows)
            //{
            //    str += dataRow[0] + @"\t" + dataRow[1] + @"\n";
            //}

            //MessageBox.Show(str);

            //var iAr = new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };

            //MessageBox.Show(iAr.ToList().Find(x => iAr.ToList().Count(y => x == y) % 2 == 1).ToString());

            //long n = 70304;

            ////if (n < 0) return null;

            //StringBuilder sRes = new StringBuilder();

            //while (n > 0)
            //{
            //    StringBuilder str = new StringBuilder().Append(n.ToString()[0]).Append('0', n.ToString().Length - 1);

            //    long iNum = Convert.ToInt64(str.ToString());

            //    sRes.Append(str.ToString());
            //    sRes.Append(" + ");

            //    n -= Convert.ToInt32(iNum);
            //}

            //MessageBox.Show(sRes.ToString().Substring(0, sRes.Length - " + ".Length));

            #region Diamonds

            //  *               
            // ***               **
            //*****             ****
            // ***               **
            //  *               
            //   *
            //  ***
            // *****
            //*******
            // *****
            //  ***
            //   *
            //int n = 15;

            ////if (n < 0 ||) return;

            //StringBuilder str = new StringBuilder();

            //List<int> lNumbers = new List<int>();
            //for (int i = n; i > 0; i = i - 2)
            //{
            //    lNumbers.Add(i);
            //}

            //List<int> lNum = new List<int>();
            //lNum.AddRange(lNumbers.OrderBy(x => x).ToList());
            //lNumbers = lNumbers.OrderByDescending(x => x).ToList();
            //lNumbers.RemoveAt(0);
            //lNum.AddRange(lNumbers);

            //foreach (int i in lNum)
            //{
            //    str.Append(' ', (n - i) / 2);
            //    str.Append('*', i);
            //    str.Append('\n');
            //}

            //MessageBox.Show(str.ToString());

            #endregion

            #region Timezones

            //DateTime dtNoVerano = Convert.ToDateTime("10/01/2019 10:00:00");
            //DateTime dtVerano = Convert.ToDateTime("10/08/2019 10:00:00");

            //DateTime dtNoVeranoUTC = dtNoVerano.ToUniversalTime();
            //DateTime dtVeranoUTC = dtVerano.ToUniversalTime();

            //TimeZoneInfo tzi = TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time");

            //TimeSpan ts = tzi.GetUtcOffset(dtNoVeranoUTC);
            //TimeSpan ts2 = tzi.GetUtcOffset(dtVerano);

            //DateTime dtActualMexico = dtNoVeranoUTC.Add(ts);

            //DateTimeOffset dto = new DateTimeOffset(dtNoVeranoUTC, TimeSpan.Zero);
            //MessageBox.Show(dto.ToOffset(tzi.GetUtcOffset(dto)).ToString());
            //DateTimeOffset dto2 = new DateTimeOffset(dtVeranoUTC, TimeSpan.Zero);
            //MessageBox.Show(dto2.ToOffset(tzi.GetUtcOffset(dto2)).ToString());

            //bool bHorarioVerano = tzi.IsDaylightSavingTime(dtNoVeranoUTC);
            //bool bHorarioVerano2 = tzi.IsDaylightSavingTime(dtVeranoUTC);

            //MessageBox.Show("Horario no verano UTC:" + TimeZoneInfo.ConvertTimeFromUtc(dtNoVeranoUTC, tzi).ToString());
            //MessageBox.Show("Horario verano UTC:" + TimeZoneInfo.ConvertTimeFromUtc(dtVeranoUTC, tzi).ToString());

            #endregion

            //List<string> listaSQL = new List<string>(); 
            //using (StreamReader rd = new StreamReader(@"C:\Desarrollo\Test\Test\SQL.txt"))
            //{
            //    string SQL = "";
            //    while (!rd.EndOfStream)
            //    {
            //        string linea = rd.ReadLine();
            //        if (string.IsNullOrEmpty(linea))
            //        {
            //            listaSQL.Add(SQL);
            //            SQL = "";
            //        }
            //        else
            //        {
            //            SQL += linea;
            //        }
            //    }
            //    listaSQL.Add(SQL);
            //}
            //string[] Array = listaSQL.ToArray();

            #region  Ex 1

            //int[] integers = { 2, 4, 6, 8, 10, 12, 13, 14, 16, 18 };

            //if (integers.Where(x => (x % 2) == 0).ToList().Count == 1)
            //{
            //    int ig =  integers.Where(x => (x % 2) == 0).ToList()[0];
            //}
            //else if (integers.Where(x => (x % 2) == 1).ToList().Count == 1)
            //{
            //    int ig = integers.Where(x => (x % 2) == 1).ToList()[0];
            //}

            //double ig = Math.Floor((Math.Sqrt(Math.Pow(65, 2) + Math.Pow(60, 2) + Math.Pow(75, 2) + Math.Pow(55, 2) + Math.Pow(60, 2) + Math.Pow(63, 2) + Math.Pow(64, 2) + Math.Pow(45, 2))) / 2);

            #endregion

            #region  Ex 2

            //string text = "The sunset sets at twelve o' clock.";
            //char[] abc = "abcdefghijklmnopqrstuvwxyz".ToArray();

            //string ret = "";
            //text.ToLower().ToList().ForEach(delegate (char c)
            //{
            //    if (abc.Contains(c))
            //        ret += (Array.IndexOf(abc, c) + 1).ToString() + " ";
            //});
            //ret = ret.Substring(0, ret.Length - 1);
            //MessageBox.Show(('t' - 'a' +1).ToString());

            //string ret = "A";
            //string s = "";
            //ret = (s.Length % 2 == 0) ? s.Substring((s.Length / 2) - 1, 2) : s.Substring(Convert.ToInt16(Math.Floor((decimal)s.Length / 2)), 1);

            //string words = "is2 Thi1s T4est 3a";
            //string ret = "";
            //int cont = 1;
            //if (string.IsNullOrEmpty(words)) ret = "";

            //List<string> lst = new List<string>();
            //while (cont <= words.Split(' ').Count())
            //{
            //    foreach (string s in words.Split(' '))
            //    {
            //        if (s.Contains(cont.ToString()))
            //        {
            //            ret += s + " ";
            //            cont++;
            //        }
            //    }
            //}

            //ret = ret.Substring(0, ret.Length - 1);

            #endregion


            //string str = "Indivisibilities";

            //int countRep = 0;
            //List<char> rep = new List<char>();
            //str.ToLower().ToList().ForEach(delegate (char c)
            //{
            //if (str.ToLower().ToList().Count(x => x.Equals(c)) > 1 && !rep.Contains(c))
            //    {
            //        rep.Add(c);
            //        countRep++;
            //    }
            //});

            //MessageBox.Show(countRep.ToString());

            //string input = "zzoo";

            //bool b = (input.ToLower().Count(x => x.Equals('o')) == input.ToLower().Count(x => x.Equals('x')));

            //MessageBox.Show(b.ToString());

            //string dna = "ATTGC";

            //MessageBox.Show(dna.Replace('A', 't').Replace('T', 'a').Replace('C', 'g').Replace('G', 'c').ToUpper());
            //string str = "The quick brown fox jumps over the lay dog.12354";
            //List<char> abc = "abcdefghijklmnopqrstuvwxyz".ToList();
            //str.ToList().ForEach(delegate (char c)
            //{
            //    if (abc.Contains(c)) abc.Remove(c);
            //});

            //MessageBox.Show((abc.Count == 0).ToString());


            //int n = 0;
            //int nm = 1;
            //float d = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    d += ((float)1/(float)nm);
            //    nm += 3;
            //}
            //MessageBox.Show(d.ToString("N2"));

            //int[] a = { 1, 2, 2 };
            //int[] b = { 2 };

            //int[] res = a.Where(x => !b.Contains(x)).ToArray();

            //int[] binarr = { 1, 1, 1, 1 };

            //int i = Convert.ToInt32(string.Join("", binarr), 2);

            //int[] number = { 1, 500, 900 };

            //int res = number.OrderByDescending(x => x.ToString().Length).First();
            //int[] res;

            //int[] lst = { 1, 2, 3, 4, 5 };

            //res = new int[]{ lst.Min() , lst.Max()};

            //string str = "camelCasingTest";
            //string res = "";

            //str.ToList().ForEach(delegate (char c)
            //{
            //    res += char.IsUpper(c) ? (" " + c).ToString() : c.ToString();
            //});

            //int[] num = { 1, 2, 3, 4 };
            //List<int> res = new List<int>();

            //(Convert.ToInt32(String.Join("", num)) + 1).ToString().ToList().ForEach(x =>
            //{
            //    res.Add(int.Parse(x.ToString()));
            //});

            //return res.ToArray();

            //StreamReader archivo = new StreamReader("");
            //while (!archivo.EndOfStream)
            //{
            //    archivo.ReadLine();
            //}

            Application.ThreadException += new ThreadExceptionEventHandler(UIThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            //Phone(dr, "48-421-674-8974");

            //IEnumerable<int> numbers = new List<int>() { 1, 1, 1, 2, 1, 1 };

            //int number = numbers.ToList().First(x => numbers.Count(y => y == x) == 1);

            //MessageBox.Show(number.ToString());

            //test1();

            //DataSet ds = new DataSet();
            //DataTable dt = ds.Tables[0];

            ////foreach (DataTable dt in ds.Tables)
            ////{
            //    foreach (DataRow dr in ds.Tables[0].Rows)
            //    {

            //    }
            //}

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            //List<Personas> lstPersonas = new List<Personas>();

            //List<Foro> lstForo = new List<Foro>();
            //List<PersonasForo> lstPersonasForo = new List<PersonasForo>();

            ////List<Personas> lst = lstPersonas.Where(x => lstPersonasForo.Where(p => p.Foro.Name == "Stack").Where(y => y.Pers.Contains(x)))

            ////List<Personas> lst1 = lstPersonasForo.Where(p => p.Foro.Name == "Stack").ToListAsync());
            //List<Personas> lst = lstPersonas.Where(x => lstPersonasForo.Any(p => p.Foro.Name == "Stack" && p.Personas == x)).ToList();

            //object IMQBT = DBNull.Value;
            //DataTable dt = new DataTable();
            //if (dt.Rows[0][""] == DBNull.Value)
            //{
            //    float.Parse(IMQBT == DBNull.Value ? "0" : IMQBT.ToString());
            //}

            //List<String> prueba = new List<String>();
            //prueba.Add("Test1");
            //prueba.Add("Test1");
            //prueba.Add("Test2");
            ////Añado los valores
            //prueba = prueba.Distinct().ToList();

            //foreach (string item in prueba)
            //{
            //    Console.WriteLine(item);
            //}

            #region Fibonacci

            //var fibonacciNumbers = new List<int> { 1, 1 };

            //for (int i = 0; i < 20; i++)
            //{
            //    var previous = fibonacciNumbers[i + 1];
            //    var previous2 = fibonacciNumbers[i];

            //    fibonacciNumbers.Add(previous + previous2);
            //}

            //foreach (var item in fibonacciNumbers)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Xbonacci

            //double [] d = new double []{ 1,1,1 };
            //int n = 10;

            //double[] res = new double[n];
            //for (int i = 0; i < n; i++)
            //{
            //    if (i >= d.Length)
            //    {
            //        res[i] = res[i - 3] + res[i - 2] + res[i - 1];
            //    }
            //    else
            //    {
            //        res[i] = d[i];
            //    }
            //}

            //MessageBox.Show(res.Length.ToString());

            #endregion

            #region TowerBuilder

            // int nFloors = 12;

            // string[] sRet = new string[nFloors];
            // int l = (nFloors * 2) - 1;
            // for (int i = nFloors; i > 0; i--)
            // {
            //     sRet[i-1] = (l > ((i * 2) - 1) ? new string(' ', (l - ((i * 2) - 2)) / 2) : "") + new string('*', (i * 2) - 1) + (l > ((i * 2) - 1) ? new string(' ', (l - ((i * 2) - 2)) / 2) : "");
            // }

            //Console.WriteLine(string.Join("\n", sRet));

            #endregion

            #region SortByBit

            //int[] array = new int[] { 3, 8, 3, 6, 5, 7, 9, 1 };
            //List<int> lst = new List<int>();
            //array.ToList().ForEach(x =>
            //{
            //    if (lst.Count == 0)
            //        lst.Add(x);
            //    else
            //    {
            //        bool bIns = false;
            //        for (int i = 0; i < lst.Count; i++)
            //        {
            //            if (Convert.ToString(lst[i], 2).Count(y => y == '1') > Convert.ToString(x, 2).Count(y => y == '1'))
            //            {
            //                lst.Insert(i, x);
            //                bIns = true;
            //                break;
            //            }
            //            else if(Convert.ToString(lst[i], 2).Count(y => y == '1') == Convert.ToString(x, 2).Count(y => y == '1'))
            //            {
            //                if (lst[i] > x)
            //                {
            //                    lst.Insert(i, x);
            //                    bIns = true;
            //                    break;
            //                }

            //                //else
            //                //    lst.Insert(i + 1, x);

            //            }
            //        }
            //        if (!bIns)
            //            lst.Add(x);
            //    }
            //});

            //lst.ToArray();

            ////Solution

            //array.OrderBy(x => Convert.ToString(x, 2).Count(c => c == '1')).ThenBy(x => x).ToArray();


            #endregion

            #region Product of Consecutive Fib numbers

            //ulong prod = 714;
            //ulong[] ret = new ulong[3];

            //ulong iNumber = 1;
            //ulong iPrev = 1;

            //while (true)
            //{
            //    ulong res = iPrev + iNumber;

            //    if ((ulong)(iPrev * iNumber) >= prod)
            //    {
            //        ret[0] = (ulong)iPrev;
            //        ret[1] = (ulong)iNumber;
            //        ret[2] = Convert.ToUInt64(iPrev * iNumber == prod);
            //        break;
            //    }
            //    iPrev = iNumber;
            //    iNumber = res;
            //}

            #endregion
        }



        //private class Personas
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public ICollection<PersonasForo> PForo { get; set; }
        //    public Personas()
        //    {

        //    }
        //}

        //private class Foro
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //    public ICollection<PersonasForo> PForo { get; set; }
        //    public Foro()
        //    {

        //    }
        //}

        //private class PersonasForo
        //{
        //    public int Personas_Id { get; set; }
        //    public Personas Personas { get; set; }
        //    public int Foro_Id { get; set; }
        //    public Foro Foro { get; set; }
        //    public PersonasForo()
        //    {

        //    }
        //}
        private static void UIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            DialogResult result = DialogResult.Cancel;
            try
            {
                result = ShowThreadExceptionDialog("Windows Forms Error", t.Exception);
            }
            catch
            {
                try
                {
                    MessageBox.Show("Fatal Windows Forms Error",
                        "Fatal Windows Forms Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }

            // Exits the program when the user clicks Abort.
            if (result == DialogResult.Abort)
                Application.Exit();
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                string errorMsg = "An application error occurred. Please contact the adminstrator " +
                    "with the following information:\n\n";

                // Since we can't prevent the app from terminating, log this to the event log.
                if (!EventLog.SourceExists("ThreadException"))
                {
                    EventLog.CreateEventSource("ThreadException", "Application");
                }

                // Create an EventLog instance and assign its source.
                EventLog myLog = new EventLog();
                myLog.Source = "ThreadException";
                myLog.WriteEntry(errorMsg + ex.Message + "\n\nStack Trace:\n" + ex.StackTrace);
            }
            catch (Exception exc)
            {
                try
                {
                    MessageBox.Show("Fatal Non-UI Error",
                        "Fatal Non-UI Error. Could not write the error to the event log. Reason: "
                        + exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                finally
                {
                    Application.Exit();
                }
            }
        }

        private static DialogResult ShowThreadExceptionDialog(string title, Exception e)
        {
            string errorMsg = "An application error occurred. Please contact the adminstrator " +
                "with the following information:\n\n";
            errorMsg = errorMsg + e.Message + "\n\nStack Trace:\n" + e.StackTrace;
            return MessageBox.Show(errorMsg, title, MessageBoxButtons.AbortRetryIgnore,
                MessageBoxIcon.Stop);
        }

        //private static string Phone(string strng, string num)
        //{
        //    //Phone => 48-421-674-8974, Name => Anastasia, Address => Via Quirinal Roma
        //    List<string> lst = strng.Split(new string[] { "\n" }, StringSplitOptions.None).ToList();

        //    if (lst.Count(x => Regex.Match(x, @"(\" + num + ")").Success) > 1)
        //        return "Error => Too many people: " + num;

        //    if (lst.Count(x => Regex.Match(x, @"(\" + num + ")").Success) == 0)
        //        return "Error => Not found: " + num;

        //    string str = lst.First(x => Regex.Match(x, @"(\" + num + ")").Success);
            
        //    StringBuilder sb = new StringBuilder();
        //    str.Replace(num, "").Replace(str.Substring(str.IndexOf('<'), str.IndexOf('>') - str.IndexOf('<') + 1), "").Replace('_', ' ').ToList().ForEach(c =>
        //    {
        //        if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == ' ' || c == '-')
        //        {
        //            sb.Append(c);
        //        }
        //    });

        //    return "Phone => " + num + ", Name => " + str.Substring(str.IndexOf('<') + 1, str.IndexOf('>') - str.IndexOf('<') - 1) + ", Address => " + sb.ToString().Replace("  ", " ").Trim();
        //}

        //private static void testing(string actual, string expected)
        //{
        //    if (!expected.Equals(actual))
        //    {
        //        MessageBox.Show(actual + '\n' + expected);
        //    }
        //}
        
        //public static void test1()
        //{
        //    Console.WriteLine("Phone");
        //    testing(Phone(dr, "48-421-674-8974"), "Phone => 48-421-674-8974, Name => Anastasia, Address => Via Quirinal Roma");
        //    testing(Phone(dr, "1-921-512-2222"), "Phone => 1-921-512-2222, Name => Wilfrid Stevens, Address => Wild Street AA-67209");
        //    testing(Phone(dr, "1-908-512-2222"), "Phone => 1-908-512-2222, Name => Peter O'Brien, Address => High Street CC-47209");
        //    testing(Phone(dr, "1-541-754-3010"), "Phone => 1-541-754-3010, Name => J Steeve, Address => 156 Alphand St.");
        //    testing(Phone(dr, "1-121-504-8974"), "Phone => 1-121-504-8974, Name => Arthur Clarke, Address => San Antonio TT-45120");
        //    testing(Phone(dr, "1-498-512-2222"), "Phone => 1-498-512-2222, Name => Bernard Deltheil, Address => Mount Av. Eldorado");
        //    testing(Phone(dr, "1-098-512-2222"), "Error => Too many people: 1-098-512-2222");
        //    testing(Phone(dr, "5-555-555-5555"), "Error => Not found: 5-555-555-5555");

        //}
    }

    
}
