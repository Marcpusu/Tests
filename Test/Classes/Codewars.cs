using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test.Classes
{
    public class Codewars
    {
        #region Codewars

        public static void FindTheParityOutlier()
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

        public static void PredictYourAge()
        {
            // https://www.codewars.com/kata/5aff237c578a14752d0035ae

            double iRes = Math.Floor((Math.Sqrt(Math.Pow(65, 2) + Math.Pow(60, 2) + Math.Pow(75, 2) + Math.Pow(55, 2) + Math.Pow(60, 2) + Math.Pow(63, 2) + Math.Pow(64, 2) + Math.Pow(45, 2))) / 2);
            MessageBox.Show(iRes.ToString());
        }

        public static void ReplaceWithAlphabetPosition()
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

        public static void GetMiddleCharacter()
        {
            // https://www.codewars.com/kata/56747fd5cb988479af000028

            string s = "testing";
            string ret = (s.Length % 2 == 0) ? s.Substring((s.Length / 2) - 1, 2) : s.Substring(Convert.ToInt16(Math.Floor((decimal)s.Length / 2)), 1);

            MessageBox.Show(ret);
        }

        public static void YourOrderPlease()
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

        public static void CountingDuplicates()
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

        public static void ExesAndOhs()
        {
            // https://www.codewars.com/kata/55908aad6620c066bc00002a

            string input = "zzoo";

            bool b = (input.ToLower().Count(x => x.Equals('o')) == input.ToLower().Count(x => x.Equals('x')));

            MessageBox.Show(b.ToString());
        }

        public static void ComplementaryDNA()
        {
            // https://www.codewars.com/kata/554e4a2f232cdd87d9000038

            string dna = "ATTGC";

            MessageBox.Show(dna.Replace('A', 't').Replace('T', 'a').Replace('C', 'g').Replace('G', 'c').ToUpper());
        }

        public static void DetectPangram()
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

        public static void SumOfTheFirstNthTermOfSeries()
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

        public static void ArrayDiff()
        {
            // https://www.codewars.com/kata/523f5d21c841566fde000009

            int[] a = { 1, 2, 2 };
            int[] b = { 2 };

            int[] res = a.Where(x => !b.Contains(x)).ToArray();
        }

        public static void OnesAndZeros()
        {
            // https://www.codewars.com/kata/578553c3a1b8d5c40300037c

            int[] binarr = { 1, 1, 1, 1 };
            int i = Convert.ToInt32(string.Join("", binarr), 2);

            MessageBox.Show(i.ToString());
        }

        public static void MostDigits()
        {
            // https://www.codewars.com/kata/58daa7617332e59593000006

            int[] number = { 1, 500, 900 };

            int res = number.OrderByDescending(x => x.ToString().Length).First();
        }

        public static void HighestProfitWins()
        {
            // https://www.codewars.com/kata/559590633066759614000063

            int[] lst = { 1, 2, 3, 4, 5 };

            int[] res = new int[] { lst.Min(), lst.Max() };
        }

        public static void BreakCamelCase()
        {
            // https://www.codewars.com/kata/5208f99aee097e6552000148

            string str = "camelCasingTest";
            string res = "";

            str.ToList().ForEach(delegate (char c)
            {
                res += char.IsUpper(c) ? (" " + c).ToString() : c.ToString();
            });
        }

        public static void GiveMeDiamond()
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

        public static void WriteNumberInExpandedForm()
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

        public static void FindTheOddInt()
        {
            // https://www.codewars.com/kata/54da5a58ea159efa38000836

            var iAr = new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 };

            MessageBox.Show(iAr.ToList().Find(x => iAr.ToList().Count(y => x == y) % 2 == 1).ToString());
        }

        public static void FindUniqueNumber()
        {
            // https://www.codewars.com/kata/585d7d5adb20cf33cb000235

            IEnumerable<int> numbers = new List<int>() { 1, 1, 1, 2, 1, 1 };

            int number = numbers.ToList().First(x => numbers.Count(y => y == x) == 1);

            MessageBox.Show(number.ToString());
        }

        public static void TribonacciSequence()
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

        public static void BuildTower()
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

        public static void SortingByBits()
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

        public static void ProductOfConsecutiveFibNumbers()
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

        public static void Root13()
        {
            // https://www.codewars.com/kata/530e15517bc88ac656000716

            string message = "Test";

            string sRes = "";
            char[] abc = "abcdefghijklmnopqrstuvwxyz".ToArray();

            message.ToArray().ToList().ForEach(x =>
            {
                int i = abc.ToList().IndexOf(Char.ToLower(x)) - 13;
                if (i < 0) i += abc.Length;
                if (Char.IsLetter(x))
                    sRes += Char.IsUpper(x) ? Char.ToUpper(abc[i]) : abc[i];
                else
                    sRes += x;
            });

            MessageBox.Show(sRes);
        }

        public static void WhitespaceNumber()
        {
            // https://www.codewars.com/kata/55b350026cc02ac1a7000032

            int n = -1;
            string sRes = "";

            if (n > 0) sRes += ' ';
            else if (n < 0)
            {
                sRes += '\t';
                n *= -1;
            }

            Convert.ToString(n, 2).ToList().ForEach(x =>
            {
                sRes += x == '0' ? ' ' : '\t';
            });
            sRes += '\n';

            MessageBox.Show(sRes.Replace(" ", "[space]").Replace("\t", "[tab]").Replace("\n", "[LF]"));
        }

        public static void WhoLikesIt()
        {
            // https://www.codewars.com/kata/5266876b8f4bf2da9b000362

            string sRes = "";

            string[] name = { "Marc", "Lola", "Mento", "Tomas" };

            if (name.Length == 0)
                sRes = "no one likes this";
            else if (name.Length == 1)
                sRes = name[0] + " likes this";
            else if (name.Length == 2)
                sRes = name[0] + " and " + name[1] + " like this";
            else if (name.Length == 3)
                sRes = name[0] + ", " + name[1] + " and " + name[2] + " like this";
            else
                sRes = name[0] + ", " + name[1] + " and " + (name.Length - 2).ToString() + " others like this";

            MessageBox.Show(sRes);
        }

        public static void MaximumSubarraySum()
        {
            // https://www.codewars.com/kata/54521e9ec8e60bc4de000d6c

            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            int max = 0;
            int current = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                current = current + arr[i];
                if (current < 0)
                    current = 0;
                if (max < current)
                    max = current;
            }

            MessageBox.Show(max.ToString());
        }

        public static bool TakeTenMinutesWalk()
        {
            // https://www.codewars.com/kata/54da539698b8a2ad76000228

            string[] walk = new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }; //{"n","n","n","s","n","s","n","s","n","s"}

            if (walk.Length != 10)
                return false;

            int h = 0, v = 0;

            walk.ToList().ForEach(x =>
            {
                switch (x)
                {
                    case "n":
                        v++;
                        break;
                    case "s":
                        v--;
                        break;
                    case "e":
                        h++;
                        break;
                    case "w":
                        h--;
                        break;
                    default:
                        break;
                }
            });

            return v == 0 && h == 0;
        }

        public static int CountSheeps()
        {
            // https://www.codewars.com/kata/54edbc7200b811e956000556

            bool[] sheeps = new bool[] { true, false, true };

            return sheeps.Where(x => x == true).Count();
        }

        public static int GetVoewlCount()
        {
            // https://www.codewars.com/kata/54ff3102c1bad923760001f3

            string str = "abracadabra";

            return str.Count(x => x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u');
        }

        public static int MakeNegative()
        {
            // https://www.codewars.com/kata/55685cd7ad70877c23000102

            int number = -1;

            if (number < 0) return number;
            else return number * -1;
        }

        public static int SquareSum()
        {
            // https://www.codewars.com/kata/515e271a311df0350d00000f

            int[] numbers = new int[] { 1, 2, 2 };

            return numbers.Sum(x => x * x);
        }

        public static int SquareDigits()
        {
            // https://www.codewars.com/kata/546e2562b03326a88e000020

            int n = 9119;

            return Convert.ToInt32(n.ToString().ToList().Aggregate("", (x, y) => x + (Char.GetNumericValue(y) * Char.GetNumericValue(y)).ToString()));
        }

        public static int СenturyFromYear()
        {
            // https://www.codewars.com/kata/5a3fe3dde1ce0e8ed6000097

            int year = 1705;
            return (int)((year - 1) / 100) + 1;
        }

        public static int DescendingOrder()
        {
            // https://www.codewars.com/kata/5467e4d82edf8bbf40000155

            int num = 42145;

            return Convert.ToInt32(num.ToString().ToList().OrderByDescending(x => x).Aggregate("",(x,y) => x + y));
        }
        #endregion
    }
}
