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
        const int iSpeed = 25;
        const int iDistance = 2;
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
        Direction prevDir;
        Direction dirPressed;
        Timer timer1 = new Timer();
        List<Panel> lstWalls = new List<Panel>();
        public Form2()
        {
            InitializeComponent();

            lstWalls.Add(panel1);
            lstWalls.Add(panel2);
            lstWalls.Add(panel3);
            lstWalls.Add(panel4);

            timer1.Interval = iSpeed;
            timer1.Tick += new EventHandler(Timer_Tick);
            timer1.Start();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            prevDir = dir;

            if (e.KeyCode == Keys.Up)
                dirPressed = Direction.Up;
            else if (e.KeyCode == Keys.Down)
                dirPressed = Direction.Down;
            else if (e.KeyCode == Keys.Left)
                dirPressed = Direction.Left;
            else if (e.KeyCode == Keys.Right)
                dirPressed = Direction.Right;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dir = dirPressed;

            if (Blocked(dir))
            {
                dir = prevDir;
                if (Blocked(prevDir))
                    return;
            }
                
            switch (dir)
            {
                case Direction.Up:
                    pnl.Top -= iDistance;
                    break;
                case Direction.Down:
                    pnl.Top += + iDistance;
                    break;
                case Direction.Left:
                    pnl.Left -= iDistance;
                    break;
                case Direction.Right:
                    pnl.Left += iDistance;
                    break;
                default:
                    break;
            }
        }

        private bool Blocked(Direction direction)
        {
            bool bBlocked = false;

            Rectangle r = new Rectangle(new Point(pnl.Location.X, pnl.Location.Y), pnl.Size);

            switch (direction)
            {
                case Direction.Up:
                    r.Location = new Point(pnl.Location.X, pnl.Location.Y - iDistance);
                    break;
                case Direction.Down:
                    r.Location = new Point(pnl.Location.X, pnl.Location.Y + iDistance);
                    break;
                case Direction.Left:
                    r.Location = new Point(pnl.Location.X - iDistance, pnl.Location.Y);
                    break;
                case Direction.Right:
                    r.Location = new Point(pnl.Location.X + iDistance, pnl.Location.Y);
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

        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            dir = prevDir;
        }
    }
}
