using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraEditors;
using System.Data;
using DevExpress.XtraReports.Parameters;
using DevExpress.XtraEditors.Controls;

namespace BookStore.XRep
{
    public partial class XRep03 : DevExpress.XtraReports.UI.XtraReport
    {
        int _studentCode = 0;
        int _StoreTrID = 0;
        public XRep03()
        {
            InitializeComponent();
        }
        public XRep03(int StudentCode, int StoreTrID, string Cat)
        {
            InitializeComponent();

            _studentCode = StudentCode;
            _StoreTrID = StoreTrID;
            pramPERSONID.Visible = false;
            pramPERSONID.Value = StudentCode;
            XRep02_ParametersRequestSubmit(new object(), null);
            xrlCategory.Text = Cat;

        }
        private void XRep02_ParametersRequestSubmit(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            int studentCode = 0;
            if (_studentCode != 0)
            {
                studentCode = _studentCode;
            }
            else
            {
                studentCode = Convert.ToInt32(e.ParametersInformation[0].Parameter.Value);
            }
            cDCompanyTableAdapter.Fill(dsBookStoreQueries.CDCompany);
            xRep03TableAdapter.Fill(dsBookStoreQueries.XRep03, studentCode, Program.asase_code, _StoreTrID);
            DataSources.dsBookStoreQueries.v_studentRow row = v_studentTableAdapter.GetDataBystu_code(studentCode, Program.asase_code)[0];

            xrlStudent.Text = row.stu_name;
            xrlSaf.Text = row.alsofof_NAME;
            xrlFasl.Text = row.fasl_name;
            xrlAsaseName.Text = new DataSources.dsBookStoreQueriesTableAdapters.QueriesTableAdapter().Getasase_year(Program.asase_code);
            if (!FXFW.SqlDB.IsNullOrEmpty(dsBookStoreQueries.CDCompany.Rows[0]["Logo"]))
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])dsBookStoreQueries.CDCompany.Rows[0]["Logo"]);
                xrPicLogo.Image = Image.FromStream(ms);
            }
            
        }
        private void XRep02_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            foreach (ParameterInfo info in e.ParametersInformation)
            {
                if (info.Parameter.Name == "pramPERSONID")
                {
                    DataSources.dsBookStoreQueriesTableAdapters.studentTableAdapter adp = new DataSources.dsBookStoreQueriesTableAdapters.studentTableAdapter();
                    adp.FillByasase_code_Detail1(dsBookStoreQueries.student, Program.asase_code);

                    LookUpEdit LUE = new LookUpEdit();
                    LUE.Properties.DataSource = dsBookStoreQueries.student;
                    LUE.Properties.DisplayMember = "stu_name";
                    LUE.Properties.ValueMember = "stu_code";
                    LUE.Properties.Columns.Add(new LookUpColumnInfo("stu_name", 0, "الاسماء"));
                    LUE.Properties.BestFit();
                    LUE.Properties.NullText = string.Empty;
                    LUE.Properties.TextEditStyle = TextEditStyles.Standard;
                    //LUE.Properties.NullText = "<اختر فرعيه>";
                    info.Editor = LUE;
                    info.Parameter.Value = DBNull.Value;
                    continue;
                }

            }
        }
        private void XRep03_DataSourceDemanded(object sender, EventArgs e)
        {
            
            if (_studentCode != 0)
            {
                Parameters[0].Value = _studentCode;
                
            }
        }

    }
}
