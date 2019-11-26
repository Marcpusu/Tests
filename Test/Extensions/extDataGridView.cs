using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace Test
{
    public partial class extDataGridView : DataGridView
    {
        bool omplir = true;
        bool esUsuari = false;

        public extDataGridView()
        {
            InitializeComponent();

            InicialitzarDades();
        }

        public extDataGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            InicialitzarDades();
        }

        private void InicialitzarDades()
        {
            this.DefaultCellStyle.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.ColumnHeadersDefaultCellStyle.Font = new Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.RowHeadersDefaultCellStyle.Font = new Font("Berlin Sans FB", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue;
            this.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.RowHeadersDefaultCellStyle.BackColor = Color.GhostWhite;
            this.RowHeadersDefaultCellStyle.ForeColor = Color.Black;

            this.AllowUserToDeleteRows = true;
            this.AllowUserToAddRows = false;

            this.BackgroundColor = Color.GhostWhite;
            this.GridColor = Color.GhostWhite;
            this.EnableHeadersVisualStyles = false;
            this.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            this.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.ColumnHeadersHeight = 35;

            this.ReadOnly = false;

            foreach (DataGridViewColumn column in this.Columns)
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        /// <summary>
        /// Aplica el disseny a les cel.les
        /// </summary>
        /// <param name="e"></param>
        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = this.Rows[e.RowIndex];

            Color color = new Color();
            if (e.RowIndex % 2 == 0)
                color = ColorTranslator.FromHtml("#E0EBFE");
            else
                color = Color.White;

            row.DefaultCellStyle.BackColor = color;

            base.OnCellFormatting(e);
        }

        /// <summary>
        /// Si la columna es de tipus enter o decimal es crida a l'extensió pertinent per donar format al número
        /// </summary>
        /// <param name="e"></param>
        protected override void OnCellValueChanged(DataGridViewCellEventArgs e)
        {
            if (!esUsuari)
            {
                TunejarNumero(e.RowIndex, e.ColumnIndex);
            }

            base.OnCellValueChanged(e);
        }

        protected override void OnRowsAdded(DataGridViewRowsAddedEventArgs e)
        {
            for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
            {
                foreach (DataGridViewColumn col in this.Columns)
                {
                    TunejarNumero(e.RowIndex, col.Index);
                }
            }

            base.OnRowsAdded(e);
        }

        protected override void OnCellBeginEdit(DataGridViewCellCancelEventArgs e)
        {
            esUsuari = true;

            if (this.Columns[e.ColumnIndex].GetType() == typeof(DataGridViewDecimalsColumn))
                ((DataGridViewDecimalsCell)this.Rows[e.RowIndex].Cells[e.ColumnIndex]).NumeroSenseSeparadorsMilers();
            else if (this.Columns[e.ColumnIndex].GetType() == typeof(DataGridViewEntersColumn))
                ((DataGridViewEntersCell)this.Rows[e.RowIndex].Cells[e.ColumnIndex]).NumeroSenseSeparadorsMilers();

            base.OnCellBeginEdit(e);
        }

        protected override void OnCellEndEdit(DataGridViewCellEventArgs e)
        {
            TunejarNumero(e.RowIndex, e.ColumnIndex);
                
            base.OnCellEndEdit(e);

            esUsuari = false;
        }

        private void TunejarNumero(int iRowIndex, int iColIndex)
        {
            if (omplir)
            {
                if (iColIndex == -1 || iRowIndex == -1) return;

                omplir = false;

                if (this.Columns[iColIndex].GetType() == typeof(DataGridViewDecimalsColumn))
                    ((DataGridViewDecimalsCell)this.Rows[iRowIndex].Cells[iColIndex]).TunejarNumero();
                else if (this.Columns[iColIndex].GetType() == typeof(DataGridViewEntersColumn))
                    ((DataGridViewEntersCell)this.Rows[iRowIndex].Cells[iColIndex]).TunejarNumero();

                omplir = true;
            }
        }
    }
}
