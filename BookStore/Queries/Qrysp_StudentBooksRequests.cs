using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BookStore
{
    public partial class Qrysp_StudentBooksRequests : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable TblSells = new DataTable("FalseX2010-11");
        #endregion
        #region -   Functions   -
        public Qrysp_StudentBooksRequests()
        {
            InitializeComponent();
        }
        #endregion
        #region -   Event Handlers   -
        private void QryPartnerStaffFrm_Load(object sender, EventArgs e)
        {
            sp_StudentBooksRequestsTableAdapter.Fill(dsBookStoreQueries.sp_StudentBooksRequests, Program.asase_code);
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //LoadGridTbl();
        }
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControlMain.ShowPrintPreview();
        }
        private void cardViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControlMain.MainView = cardViewSells;
        }
        private void gridViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridControlMain.MainView = gridViewMain;
        }
        
        #endregion

    }
}