using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Test
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SetSubDataSource);

            DataTable dt = new DataTable();
            dt.Columns.Add("Param1");
            dt.Columns.Add("Param2");

            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());

            dt.Rows[0][0] = "Hola";
            dt.Rows[0][1] = "Adios";

            dt.Rows[1][0] = "Hola2";
            dt.Rows[1][1] = "Adios2";

            this.reportViewer1.ProcessingMode = ProcessingMode.Local;

            this.reportViewer1.LocalReport.ReportPath = @"C:\Desarrollo\Test\Test\Report.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataTable1", dt));

            List<ReportParameter> lstRP = new List<ReportParameter>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    lstRP.Add(new ReportParameter(dt.Columns[j].ColumnName, dt.Rows[i][j].ToString(), true));
                }
            }
            
            

            this.reportViewer1.LocalReport.SetParameters(lstRP);
            this.reportViewer1.RefreshReport();
        }

        public void SetSubDataSource(object sender, SubreportProcessingEventArgs e)

        {

            e.DataSources.Add(new ReportDataSource("OrdersDataSet__Orders",
                          "ObjectDataSource2"));

        }
    }
}
