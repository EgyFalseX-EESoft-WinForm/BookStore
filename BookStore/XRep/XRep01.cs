using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace BookStore.XRep
{
    public partial class XRep01 : DevExpress.XtraReports.UI.XtraReport
    {
        public XRep01()
        {
            InitializeComponent();
        }
        private void XRep01_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            cDCompanyTableAdapter.Fill(dsBookStoreQueries1.CDCompany);
            xRep01TableAdapter1.FillByStoreTrDate(dsBookStoreQueries1.XRep01, Convert.ToDateTime(e.ParametersInformation[0].Parameter.Value), Convert.ToDateTime(e.ParametersInformation[1].Parameter.Value));
            try
            {
                if (FXFW.SqlDB.IsNullOrEmpty(dsBookStoreQueries1.CDCompany.Rows[0]["Logo"]))
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])dsBookStoreQueries1.CDCompany.Rows[0]["Logo"]);
                    xrPicLogo.Image = Image.FromStream(ms);
                }
            }
            catch {            }
        }

    }
}
