using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace Presentacio
{
    public partial class Form1 : Form
    {
        //private Timer t;
        public Form1()
        {

            

            InitializeComponent();

            DataGridView dataGrid = new DataGridView();
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn());
            dataGrid.Columns.Add(new DataGridViewTextBoxColumn());

            dataGrid.Rows.Add();
            dataGrid.Rows[0].Cells[0].Value = "3";
            dataGrid.Rows[0].Cells[1].Value = "45,23";
            dataGrid.Rows.Add();
            dataGrid.Rows[1].Cells[0].Value = "3";
            dataGrid.Rows[1].Cells[1].Value = "224,56";
            dataGrid.Rows.Add();
            dataGrid.Rows[2].Cells[0].Value = "3";
            dataGrid.Rows[2].Cells[1].Value = "4,56";
            dataGrid.Rows.Add();
            dataGrid.Rows[3].Cells[0].Value = "4";
            dataGrid.Rows[3].Cells[1].Value = "56,00";
            dataGrid.Rows.Add();
            dataGrid.Rows[4].Cells[0].Value = "5";
            dataGrid.Rows[4].Cells[1].Value = "12,02";
            dataGrid.Rows.Add();
            dataGrid.Rows[5].Cells[0].Value = "6";
            dataGrid.Rows[5].Cells[1].Value = "8,50";


            decimal sumcol = dataGrid.Rows.Cast<DataGridViewRow>().Where(x => x.Cells[0].Value != null && x.Cells[0].Value.ToString() == "3").ToList().Sum(y => Convert.ToDecimal(y.Cells[1].Value));

            MessageBox.Show(sumcol.ToString());

            this.Close();
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
            int i2 = 0;
            var i = 8 / i2;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            //int i2 = 0;
            //var i = 8 / i2;

            //string s = DateTime.UtcNow.ToString("o");
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
