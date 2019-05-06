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

namespace Presentacio
{
    static class Program
    {
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
        }
    }

    
}
