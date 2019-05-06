using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacio
{
    public partial class Form2 : Form
    {
        #region Global Vars
        int iSpeed = 5;
        #endregion

        private enum Direction
        {
            None = 0,
            Up = 1,
            Down = 2,
            Left = 3,
            Right = 4
        }

        Direction dir;
        Timer timer1 = new Timer();
        List<Panel> lstWalls = new List<Panel>();
        public Form2()
        {
            InitializeComponent();

            lstWalls.Add(panel1);
            lstWalls.Add(panel2);

            timer1.Interval = iSpeed;
            timer1.Tick += new EventHandler(Timer_Tick);
            timer1.Start();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                dir = Direction.Up;
            else if (e.KeyCode == Keys.Down)
                dir = Direction.Down;
            else if (e.KeyCode == Keys.Left)
                dir = Direction.Left;
            else if (e.KeyCode == Keys.Right)
                dir = Direction.Right;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Blocked())
                return;

            switch (dir)
            {
                case Direction.Up:
                    pnl.Location = new Point(pnl.Location.X, pnl.Location.Y - 1);
                    break;
                case Direction.Down:
                    pnl.Location = new Point(pnl.Location.X, pnl.Location.Y + 1);
                    break;
                case Direction.Left:
                    pnl.Location = new Point(pnl.Location.X - 1, pnl.Location.Y);
                    break;
                case Direction.Right:
                    pnl.Location = new Point(pnl.Location.X + 1, pnl.Location.Y);
                    break;
                default:
                    break;
            }
        }

        private bool Blocked()
        {
            bool bBlocked = false;

            Rectangle r = new Rectangle(new Point(pnl.Location.X, pnl.Location.Y), pnl.Size);

            switch (dir)
            {
                case Direction.Up:
                    r.Location = new Point(pnl.Location.X, pnl.Location.Y - 1);
                    break;
                case Direction.Down:
                    r.Location = new Point(pnl.Location.X, pnl.Location.Y + 1);
                    break;
                case Direction.Left:
                    r.Location = new Point(pnl.Location.X - 1, pnl.Location.Y);
                    break;
                case Direction.Right:
                    r.Location = new Point(pnl.Location.X + 1, pnl.Location.Y);
                    break;
                default:
                    break;
            }

            foreach (Panel x in lstWalls)
            {
                if (r.IntersectsWith(x.Bounds))
                {
                    bBlocked = true;
                    break;
                }
            }

            return bBlocked;
        }
    }
}
