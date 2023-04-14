using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Test.Classes
{
    class Exercices
    {
        public static void Fibonacci()
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

        public static void ScientificAnotationsOut()
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

        public static void RoundToBottomNearestMultiple()
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

        public static void RoundToTopNearestMultiple()
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
