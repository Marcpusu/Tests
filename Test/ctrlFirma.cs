using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacio
{
    public partial class ctrlFirma : UserControl
    {
        public string Nom { get { return lblNom.Text; } set { lblNom.Text = value; } }
        public bool Firma { get { return chkFirma.Checked; } set {chkFirma.Checked = value; } }
        public string Imatge { get { return ""; } set { pctbFirma.Image = Image.FromFile(value); } }
        public string Data { get { return lblData.Text; } set { lblData.Text = value; } }

        public ctrlFirma()
        {
            InitializeComponent();

        }
    }
}
