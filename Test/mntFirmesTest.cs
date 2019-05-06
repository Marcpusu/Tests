using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Presentacio
{
    public partial class mntFirmesTest : Form
    {
        //string PathDoc = @"C:\Test\985147-100.pdf";
        string UsuariActiu = "Jordi Gatell";

        public mntFirmesTest()
        {
            InitializeComponent();

            this.Visible = false;
            //MessageBox.Show(this.Name);

            //int width = 100;
            //int height = 100;

            //PrintDocument printDocument = new PrintDocument();
            //printDocument.PrinterSettings.PrinterName = "";
            //printDocument.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("Primer tamaño personalizado", width, height);
            //printDocument.PrintPage += new PrintPageEventHandler(this.pr_PrintPage);
            //printDocument.Print();

            //Inicialitza();
        }

        private void pr_PrintPage(object sender, PrintPageEventArgs e)
        {


        }

        private void Inicialitza()
        {
            List<string> lstUsers = new List<string>();
            lstUsers.Add("Jordi Gatell");
            lstUsers.Add("Julià Sastre");
            lstUsers.Add("José Manuel Candal");
            lstUsers.Add("Ricard Brandao");

            int posY = 0;
            int posX = 0;

            pnlSignatures.Controls.Clear();

            foreach (string dr in lstUsers)
            {
                ctrlFirma ctrl = new ctrlFirma();

                ctrl.Nom = dr.ToString();

                if (ctrl.Nom == "Julià Sastre")
                {
                    ctrl.Firma = true;
                    ctrl.Imatge = @"Firmas\Firma1.png";
                }
                if (ctrl.Nom == "Ricard Brandao")
                {
                    ctrl.Firma = true;
                    ctrl.Imatge = @"Firmas\firma2.jpeg";
                }

                ctrl.Enabled = false;

                if (ctrl.Nom == UsuariActiu)
                    ctrl.Enabled = true;

                ctrl.Location = new Point(posX, posY);
                posX += ctrl.Width;

                ctrl.chkFirma.CheckedChanged += new EventHandler(chkFirma_CheckedChanged);

                pnlSignatures.Controls.Add(ctrl);
            }
        }

        private void chkFirma_CheckedChanged(object sender, EventArgs e)
        {
            string sPin = string.Empty;
            if (((CheckBox)sender).Checked)
            {
                sPin = Microsoft.VisualBasic.Interaction.InputBox("Introduzca el PIN:", "Verificar");

                if (UsuariActiu == "Jordi Gatell")
                {
                    if (sPin != "1234")
                    {
                        MessageBox.Show("PIN incorrecte!");
                        ((CheckBox)sender).Checked = false;
                    }
                    else
                    {
                        foreach (ctrlFirma ctrl in pnlSignatures.Controls)
                        {
                            if (ctrl.Nom == UsuariActiu)
                            {
                                ctrl.Data = "Data firma: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                                ctrl.lblData.Visible = true;
                                ctrl.Imatge = @"Firmas\firma3.jpeg";
                                break;
                            }
                        }
                    }
                        
                }
            }
            else
            {
                foreach (ctrlFirma ctrl in pnlSignatures.Controls)
                {
                    if (ctrl.Nom == UsuariActiu)
                    {
                        ctrl.lblData.Visible = false;
                        ctrl.pctbFirma.Image = null;
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(textBox1.Text))
            {
                if (textBox1.Text.EndsWith(".pdf"))
                {
                    wbrPDF.Visible = true;
                    wbrPDF.BringToFront();
                    wbDocument.Visible = false;
                    wbrPDF.Navigate("file:///" + textBox1.Text);
                }
                else if (textBox1.Text.EndsWith(".docx"))
                {
                    wbrPDF.Visible = false;
                    wbDocument.Visible = true;
                    wbDocument.BringToFront();
                    wbDocument.LoadDocument(textBox1.Text);
                }
            }
        }

        private void mntFirmesTest_Load(object sender, EventArgs e)
        {
            while (true)
            {
                FormulariMovible frm = new FormulariMovible();
                frm.ShowDialog();
            }
        }
    }
}
