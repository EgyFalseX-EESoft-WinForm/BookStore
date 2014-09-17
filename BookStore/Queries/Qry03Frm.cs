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
    public partial class Qry03Frm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable TblSells = new DataTable("FalseX2010-11");
        #endregion
        #region -   Functions   -
        public Qry03Frm()
        {
            InitializeComponent();
        }
        private void LoadGridTbl()
        {
            // TODO: This line of code loads data into the 'dsBookStoreQueries.Qry03' table. You can move, or remove it, as needed.
            this.qry03TableAdapter.Fill(this.dsBookStoreQueries.Qry03);
        }
        #endregion
        #region -   Event Handlers   -
        private void QryPartnerStaffFrm_Load(object sender, EventArgs e)
        {
            LoadGridTbl();
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadGridTbl();
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridControlMain.ShowRibbonPrintPreview();
        }
        #endregion

        
    }
}