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
    public partial class FormulariMovible : Form
    {
        string[] lstStrings = new string[] { "PRINGAO", "YOU GOT HACKED", "ESPECTACULO", "DAME VENENO QUE QUIERO MORIR", "TE VOY A DEJAR EL CULO..." };
        Random random = new Random();
        public FormulariMovible()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MoverVentana();
            //this.DialogResult = DialogResult.Yes;
            //this.Close();
        }

        private void MoverVentana()
        {
            int randomX = random.Next(0, Screen.PrimaryScreen.Bounds.Width);
            int randomY = random.Next(0, Screen.PrimaryScreen.Bounds.Height);

            this.Location = new Point(randomX > Screen.PrimaryScreen.Bounds.Width - this.Size.Width ? randomX - this.Size.Width : randomX, randomY > Screen.PrimaryScreen.Bounds.Height - this.Size.Height ? randomY - this.Size.Height : randomY);
            this.label1.Text = lstStrings[random.Next(0, lstStrings.Length - 1)];
        }

        private void FormulariMovible_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void FormulariMovible_Load(object sender, EventArgs e)
        {
            //MoverVentana();
            //timer1.Start();
        }

        private void FormulariMovible_MouseEnter(object sender, EventArgs e)
        {
            //MoverVentana();
        }
    }
}
