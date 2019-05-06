namespace Presentacio
{
    partial class mntFirmesTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSignatures = new System.Windows.Forms.Panel();
            this.wbDocument = new Presentacio.ctrlDocBrowser();
            this.wbrPDF = new System.Windows.Forms.WebBrowser();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlSignatures
            // 
            this.pnlSignatures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSignatures.Location = new System.Drawing.Point(12, 488);
            this.pnlSignatures.Name = "pnlSignatures";
            this.pnlSignatures.Size = new System.Drawing.Size(1260, 156);
            this.pnlSignatures.TabIndex = 1;
            // 
            // wbDocument
            // 
            this.wbDocument.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbDocument.Location = new System.Drawing.Point(12, 69);
            this.wbDocument.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbDocument.Name = "wbDocument";
            this.wbDocument.Size = new System.Drawing.Size(1260, 400);
            this.wbDocument.TabIndex = 0;
            // 
            // wbrPDF
            // 
            this.wbrPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbrPDF.Location = new System.Drawing.Point(12, 69);
            this.wbrPDF.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrPDF.Name = "wbrPDF";
            this.wbrPDF.Size = new System.Drawing.Size(1260, 400);
            this.wbrPDF.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(441, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fitxer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mntFirmesTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 654);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.wbrPDF);
            this.Controls.Add(this.pnlSignatures);
            this.Controls.Add(this.wbDocument);
            this.Name = "mntFirmesTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mntFirmesTest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mntFirmesTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Presentacio.ctrlDocBrowser wbDocument;
        private System.Windows.Forms.Panel pnlSignatures;
        private System.Windows.Forms.WebBrowser wbrPDF;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}