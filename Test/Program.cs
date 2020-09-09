using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Data;
using System.Globalization;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Test
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ChargeExceptionControl();

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
            //Application.Run(/*new NotifyIconTest()*/);
        }

        private static void Fibonacci()
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            for (int i = 0; i < 20; i++)
            {
                var previous = fibonacciNumbers[i + 1];
                var previous2 = fibonacciNumbers[i];

                fibonacciNumbers.Add(previous + previous2);
            }

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
        }

        private static void ScientificAnotationsOut()
        {
            //Result = "712577413488402631964821329"
            string a = "712569312664357328695151392";
            string b = "8100824045303269669937";

            double d1 = 0.0185;
            double d2 = 385;

            int i = 5;

            string r = (Convert.ToDouble(a) + Convert.ToDouble(b)).ToString();

            double d = 0;
            string re = (d1 / d2).ToString();

            //string res = string.Format("{0:F" + i + "}", Convert.ToDouble(re));
            string res = string.Format("{0:0#}", Convert.ToDouble(r));

            double.TryParse((d1 / d2).ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out d);

            //string res = d.ToString();
        }

        private static void RoundToBottomNearestMultiple()
        {
            int iNum = 50000;
            int iMultiple = 600;

            int iSol = 0;

            if (iMultiple > iNum)
                iSol = iMultiple;
            else
            {
                iNum = iNum + iMultiple / 2;
                iNum = iNum - (iNum % iMultiple);
                iSol = iNum;
            }
        }

        private static void RoundToTopNearestMultiple()
        {
            int iNum = 50000;
            int iMultiple = 600 * 24;

            int iSol = 0;

            if (iMultiple == 0)
                iSol = iNum;
            else
            {
                int iRemainder = iNum % iMultiple;
                if (iRemainder == 0)
                    iSol = iNum;
                else
                    iSol = iNum + iMultiple - iRemainder;
            }
        }

        #region Codewars

        private static void FindTheParityOutlier()
        {
            // https://www.codewars.com/kata/5526fc09a1bbd946250002dc

            int[] integers = { 2, 4, 6, 8, 10, 12, 13, 14, 16, 18 };
            int iRes = 0;

            if (integers.Where(x => (x % 2) == 0).ToList().Count == 1)
            {
                iRes = integers.Where(x => (x % 2) == 0).ToList()[0];
            }
            else if (integers.Where(x => (x % 2) == 1).ToList().Count == 1)
            {
                iRes = integers.Where(x => (x % 2) == 1).ToList()[0];
            }

            MessageBox.Show(iRes.ToString());
        }

        private static void PredictYourAge()
        {
            // https://www.codewars.com/kata/5aff237c578a14752d0035ae

            double iRes = Math.Floor((Math.Sqrt(Math.Pow(65, 2) + Math.Pow(60, 2) + Math.Pow(75, 2) + Math.Pow(55, 2) + Math.Pow(60, 2) + Math.Pow(63, 2) + Math.Pow(64, 2) + Math.Pow(45, 2))) / 2);
            MessageBox.Show(iRes.ToString());
        }

        private static void ReplaceWithAlphabetPosition()
        {
            // https://www.codewars.com/kata/546f922b54af40e1e90001da

            string text = "The sunset sets at twelve o' clock.";
            char[] abc = "abcdefghijklmnopqrstuvwxyz".ToArray();

            string ret = "";
            text.ToLower().ToList().ForEach(delegate (char c)
            {
                if (abc.Contains(c))
                    ret += (Array.IndexOf(abc, c) + 1).ToString() + " ";
            });
            ret = ret.Substring(0, ret.Length - 1);
            MessageBox.Show(ret);
        }

        private static void GetMiddleCharacter()
        {
            // https://www.codewars.com/kata/56747fd5cb988479af000028

            string s = "testing";
            string ret = (s.Length % 2 == 0) ? s.Substring((s.Length / 2) - 1, 2) : s.Substring(Convert.ToInt16(Math.Floor((decimal)s.Length / 2)), 1);

            MessageBox.Show(ret);
        }

        private static void YourOrderPlease()
        {
            // https://www.codewars.com/kata/55c45be3b2079eccff00010f

            string words = "is2 Thi1s T4est 3a";
            string ret = "";
            int cont = 1;
            if (string.IsNullOrEmpty(words)) ret = "";

            List<string> lst = new List<string>();
            while (cont <= words.Split(' ').Count())
            {
                foreach (string s in words.Split(' '))
                {
                    if (s.Contains(cont.ToString()))
                    {
                        ret += s + " ";
                        cont++;
                    }
                }
            }

            ret = ret.Substring(0, ret.Length - 1);
        }

        private static void CountingDuplicates()
        {
            // https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1

            string str = "Indivisibilities";

            int countRep = 0;
            List<char> rep = new List<char>();
            str.ToLower().ToList().ForEach(delegate (char c)
            {
                if (str.ToLower().ToList().Count(x => x.Equals(c)) > 1 && !rep.Contains(c))
                {
                    rep.Add(c);
                    countRep++;
                }
            });

            MessageBox.Show(countRep.ToString());
        }

        private static void ExesAndOhs()
        {
            // https://www.codewars.com/kata/55908aad6620c066bc00002a

            string input = "zzoo";

            bool b = (input.ToLower().Count(x => x.Equals('o')) == input.ToLower().Count(x => x.Equals('x')));

            MessageBox.Show(b.ToString());
        }

        private static void ComplementaryDNA()
        {
            // https://www.codewars.com/kata/554e4a2f232cdd87d9000038

            string dna = "ATTGC";

            MessageBox.Show(dna.Replace('A', 't').Replace('T', 'a').Replace('C', 'g').Replace('G', 'c').ToUpper());
        }

        private static void DetectPangram()
        {
            // https://www.codewars.com/kata/545cedaa9943f7fe7b000048

            string str = "The quick brown fox jumps over the lay dog.12354";
            List<char> abc = "abcdefghijklmnopqrstuvwxyz".ToList();
            str.ToList().ForEach(delegate (char c)
            {
                if (abc.Contains(c)) abc.Remove(c);
            });

            MessageBox.Show((abc.Count == 0).ToString());
        }

        private static void SumOfTheFirstNthTermOfSeries()
        {
            // https://www.codewars.com/kata/555eded1ad94b00403000071

            int n = 0;
            int nm = 1;
            float d = 0;
            for (int i = 0; i < n; i++)
            {
                d += ((float)1 / (float)nm);
                nm += 3;
            }
            MessageBox.Show(d.ToString("N2"));
        }

        private static void ArrayDiff()
        {
            // https://www.codewars.com/kata/523f5d21c841566fde000009

            int[] a = { 1, 2, 2 };
            int[] b = { 2 };

            int[] res = a.Where(x => !b.Contains(x)).ToArray();
        }

        private static void OnesAndZeros()
        {
            // https://www.codewars.com/kata/578553c3a1b8d5c40300037c

            int[] binarr = { 1, 1, 1, 1 };
            int i = Convert.ToInt32(string.Join("", binarr), 2);

            MessageBox.Show(i.ToString());
        }

        private static void MostDigits()
        {
            // https://www.codewars.com/kata/58daa7617332e59593000006

            int[] number = { 1, 500, 900 };

            int res = number.OrderByDescending(x => x.ToString().Length).First();
        }

        private static void HighestProfitWins()
        {
            // https://www.codewars.com/kata/559590633066759614000063

            int[] lst = { 1, 2, 3, 4, 5 };

            int[] res = new int[] { lst.Min(), lst.Max() };
        }

        private static void BreakCamelCase()
        {
            // https://www.codewars.com/kata/5208f99aee097e6552000148

            string str = "camelCasingTest";
            string res = "";

            str.ToList().ForEach(delegate (char c)
            {
                res += char.IsUpper(c) ? (" " + c).ToString() : c.ToString();
            });
        }

        private static void GiveMeDiamond()
        {
            // https://www.codewars.com/kata/5503013e34137eeeaa001648

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
            int n = 15;

            if (n < 0 || (n % 2) == 0) return;

            StringBuilder str = new StringBuilder();

            List<int> lNumbers = new List<int>();
            for (int i = n; i > 0; i = i - 2)
            {
                lNumbers.Add(i);
            }

            List<int> lNum = new List<int>();
            lNum.AddRange(lNumbers.OrderBy(x => x).ToList());
            lNumbers = lNumbers.OrderByDescending(x => x).ToList();
            lNumbers.RemoveAt(0);
            lNum.AddRange(lNumbers);

            foreach (int i in lNum)
            {
                str.Append(' ', (n - i) / 2);
                str.Append('*', i);
                str.Append('\n');
            }

            MessageBox.Show(str.ToString());
        }

        private static void WriteNumberInExpandedForm()
        {
            // https://www.codewars.com/kata/5842df8ccbd22792a4000245
            long n = 70304;

            if (n < 0) return;

            StringBuilder sRes = new StringBuilder();

            while (n > 0)
            {
                StringBuilder str = new StringBuilder().Append(n.ToString()[0]).Append('0', n.ToString().Length - 1);

                long iNum = Convert.ToInt64(str.ToString());

                sRes.Append(str.ToString());
                sRes.Append(" + ");

                n -= Convert.ToInt32(iNum);
            }

            MessageBox.Show(sRes.ToString().Substring(0, sRes.Length - " + ".Length));
        }

        private static void FindTheOddInt()
        {
            // https://www.codewars.com/kata/54da5a58ea159efa38000836

            var iAr = new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };

            MessageBox.Show(iAr.ToList().Find(x => iAr.ToList().Count(y => x == y) % 2 == 1).ToString());
        }

        private static void FindUniqueNumber()
        {
            // https://www.codewars.com/kata/585d7d5adb20cf33cb000235

            IEnumerable<int> numbers = new List<int>() { 1, 1, 1, 2, 1, 1 };

            int number = numbers.ToList().First(x => numbers.Count(y => y == x) == 1);

            MessageBox.Show(number.ToString());
        }

        private static void TribonacciSequence()
        {
            // https://www.codewars.com/kata/556deca17c58da83c00002db

            double[] d = new double[] { 1, 1, 1 };
            int n = 10;

            double[] res = new double[n];
            for (int i = 0; i < n; i++)
            {
                if (i >= d.Length)
                {
                    res[i] = res[i - 3] + res[i - 2] + res[i - 1];
                }
                else
                {
                    res[i] = d[i];
                }
            }

            MessageBox.Show(res.Length.ToString());
        }

        private static void BuildTower()
        {
            // https://www.codewars.com/kata/576757b1df89ecf5bd00073b

            int nFloors = 12;

            string[] sRet = new string[nFloors];
            int l = (nFloors * 2) - 1;
            for (int i = nFloors; i > 0; i--)
            {
                sRet[i - 1] = (l > ((i * 2) - 1) ? new string(' ', (l - ((i * 2) - 2)) / 2) : "") + new string('*', (i * 2) - 1) + (l > ((i * 2) - 1) ? new string(' ', (l - ((i * 2) - 2)) / 2) : "");
            }

            Console.WriteLine(string.Join("\n", sRet));
        }

        private static void SortingByBits()
        {
            // https://www.codewars.com/kata/59fa8e2646d8433ee200003f

            int[] array = new int[] { 3, 8, 3, 6, 5, 7, 9, 1 };
            List<int> lst = new List<int>();
            array.ToList().ForEach(x =>
            {
                if (lst.Count == 0)
                    lst.Add(x);
                else
                {
                    bool bIns = false;
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (Convert.ToString(lst[i], 2).Count(y => y == '1') > Convert.ToString(x, 2).Count(y => y == '1'))
                        {
                            lst.Insert(i, x);
                            bIns = true;
                            break;
                        }
                        else if (Convert.ToString(lst[i], 2).Count(y => y == '1') == Convert.ToString(x, 2).Count(y => y == '1'))
                        {
                            if (lst[i] > x)
                            {
                                lst.Insert(i, x);
                                bIns = true;
                                break;
                            }

                            //else
                            //    lst.Insert(i + 1, x);

                        }
                    }
                    if (!bIns)
                        lst.Add(x);
                }
            });

            lst.ToArray();

            //Solution

            array.OrderBy(x => Convert.ToString(x, 2).Count(c => c == '1')).ThenBy(x => x).ToArray();
        }

        private static void ProductOfConsecutiveFibNumbers()
        {
            // https://www.codewars.com/kata/5541f58a944b85ce6d00006a

            ulong prod = 714;
            ulong[] ret = new ulong[3];

            ulong iNumber = 1;
            ulong iPrev = 1;

            while (true)
            {
                ulong res = iPrev + iNumber;

                if ((ulong)(iPrev * iNumber) >= prod)
                {
                    ret[0] = (ulong)iPrev;
                    ret[1] = (ulong)iNumber;
                    ret[2] = Convert.ToUInt64(iPrev * iNumber == prod);
                    break;
                }
                iPrev = iNumber;
                iNumber = res;
            }
        }

        #endregion

        #region GeneralExceptionManagement

        private static void ChargeExceptionControl()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(UIThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }

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

        #endregion

        #region SearchContact_Ex

        static string strContacts = "/+1-541-754-3010 156 Alphand_St. <J Steeve>\n 133, Green, Rd. <E Kustur> NY-56423 ;+1-541-914-3010\n"
                        + "+1-541-984-3012 <P Reed> /PO Box 530; Pollocksville, NC-28573\n :+1-321-512-2222 <Paul Dive> Sequoia Alley PQ-67209\n"
                        + "+1-741-984-3090 <Peter Reedgrave> _Chicago\n :+1-921-333-2222 <Anna Stevens> Haramburu_Street AA-67209\n"
                        + "+1-111-544-8973 <Peter Pan> LA\n +1-921-512-2222 <Wilfrid Stevens> Wild Street AA-67209\n"
                        + "<Peter Gone> LA ?+1-121-544-8974 \n <R Steell> Quora Street AB-47209 +1-481-512-2222\n"
                        + "<Arthur Clarke> San Antonio $+1-121-504-8974 TT-45120\n <Ray Chandler> Teliman Pk. !+1-681-512-2222! AB-47209,\n"
                        + "<Sophia Loren> +1-421-674-8974 Bern TP-46017\n <Peter O'Brien> High Street +1-908-512-2222; CC-47209\n"
                        + "<Anastasia> +48-421-674-8974 Via Quirinal Roma\n <P Salinger> Main Street, +1-098-512-2222, Denver\n"
                        + "<C Powel> *+19-421-674-8974 Chateau des Fosses Strasbourg F-68000\n <Bernard Deltheil> +1-498-512-2222; Mount Av.  Eldorado\n"
                        + "+1-099-500-8000 <Peter Crush> Labrador Bd.\n +1-931-512-4855 <William Saurin> Bison Street CQ-23071\n"
                        + "<P Salinge> Main Street, +1-098-512-2222, Denve\n" + "<P Salinge> Main Street, +1-098-512-2222, Denve\n";

        private static string Phone(string strng, string num)
        {
            //Phone => 48-421-674-8974, Name => Anastasia, Address => Via Quirinal Roma
            List<string> lst = strng.Split(new string[] { "\n" }, StringSplitOptions.None).ToList();

            if (lst.Count(x => Regex.Match(x, @"(\" + num + ")").Success) > 1)
                return "Error => Too many people: " + num;

            if (lst.Count(x => Regex.Match(x, @"(\" + num + ")").Success) == 0)
                return "Error => Not found: " + num;

            string str = lst.First(x => Regex.Match(x, @"(\" + num + ")").Success);

            StringBuilder sb = new StringBuilder();
            str.Replace(num, "").Replace(str.Substring(str.IndexOf('<'), str.IndexOf('>') - str.IndexOf('<') + 1), "").Replace('_', ' ').ToList().ForEach(c =>
            {
                if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == ' ' || c == '-')
                {
                    sb.Append(c);
                }
            });

            return "Phone => " + num + ", Name => " + str.Substring(str.IndexOf('<') + 1, str.IndexOf('>') - str.IndexOf('<') - 1) + ", Address => " + sb.ToString().Replace("  ", " ").Trim();
        }

        private static void testing(string actual, string expected)
        {
            if (!expected.Equals(actual))
            {
                MessageBox.Show(actual + '\n' + expected);
            }
        }

        public static void SearchContact()
        {
            Console.WriteLine("Phone");
            testing(Phone(strContacts, "48-421-674-8974"), "Phone => 48-421-674-8974, Name => Anastasia, Address => Via Quirinal Roma");
            testing(Phone(strContacts, "1-921-512-2222"), "Phone => 1-921-512-2222, Name => Wilfrid Stevens, Address => Wild Street AA-67209");
            testing(Phone(strContacts, "1-908-512-2222"), "Phone => 1-908-512-2222, Name => Peter O'Brien, Address => High Street CC-47209");
            testing(Phone(strContacts, "1-541-754-3010"), "Phone => 1-541-754-3010, Name => J Steeve, Address => 156 Alphand St.");
            testing(Phone(strContacts, "1-121-504-8974"), "Phone => 1-121-504-8974, Name => Arthur Clarke, Address => San Antonio TT-45120");
            testing(Phone(strContacts, "1-498-512-2222"), "Phone => 1-498-512-2222, Name => Bernard Deltheil, Address => Mount Av. Eldorado");
            testing(Phone(strContacts, "1-098-512-2222"), "Error => Too many people: 1-098-512-2222");
            testing(Phone(strContacts, "5-555-555-5555"), "Error => Not found: 5-555-555-5555");

        }

        #endregion
    }
}
