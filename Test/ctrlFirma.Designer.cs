namespace Presentacio
{
    partial class ctrlFirma
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNom = new System.Windows.Forms.Label();
            this.chkFirma = new System.Windows.Forms.CheckBox();
            this.pctbFirma = new System.Windows.Forms.PictureBox();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctbFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(14, 12);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Usuari";
            // 
            // chkFirma
            // 
            this.chkFirma.AutoSize = true;
            this.chkFirma.Location = new System.Drawing.Point(139, 11);
            this.chkFirma.Name = "chkFirma";
            this.chkFirma.Size = new System.Drawing.Size(51, 17);
            this.chkFirma.TabIndex = 1;
            this.chkFirma.Text = "Firma";
            this.chkFirma.UseVisualStyleBackColor = true;
            // 
            // pctbFirma
            // 
            this.pctbFirma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctbFirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctbFirma.Location = new System.Drawing.Point(3, 34);
            this.pctbFirma.Name = "pctbFirma";
            this.pctbFirma.Size = new System.Drawing.Size(199, 93);
            this.pctbFirma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbFirma.TabIndex = 2;
            this.pctbFirma.TabStop = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(7, 132);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(119, 13);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data firma: 01/01/2018";
            this.lblData.Visible = false;
            // 
            // ctrlFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.pctbFirma);
            this.Controls.Add(this.chkFirma);
            this.Controls.Add(this.lblNom);
            this.Name = "ctrlFirma";
            this.Size = new System.Drawing.Size(205, 150);
            ((System.ComponentModel.ISupportInitialize)(this.pctbFirma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblNom;
        public System.Windows.Forms.CheckBox chkFirma;
        public System.Windows.Forms.PictureBox pctbFirma;
        public System.Windows.Forms.Label lblData;
    }
}
