﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BookStore
{
    public partial class QryReservedsellsFrm : DevExpress.XtraEditors.XtraForm
    {
        #region -   Variables   -
        DataTable TblSells = new DataTable("FalseX2010-11");
        #endregion
        #region -   Functions   -
        public QryReservedsellsFrm()
        {
            InitializeComponent();
        }
        private void LoadGridTbl()
        {
            TblSells = new DataTable("FalseX2010-11");
//            TblSells = FXFW.SqlDB.LoadDataTable(@"SELECT Quantity, (Select SanfName From CDASNAF Where SanfID = StoreTransactionDetailes.SanfID ) AS SanfName, 
//            (SELECT stu_name FROM dbo.student WHERE stu_code = (SELECT PERSONID FROM dbo.TBLStoreTransaction WHERE StoreTrID = StoreTransactionDetailes.StoreTrID)) AS stu_name,
//            (Select  StoreTrDate From TBLStoreTransaction Where StoreTrID = StoreTransactionDetailes.StoreTrID) AS StoreTrDate, 
//            CASE DiscountTypeId WHEN 1 THEN (Price * Quantity) - Discount WHEN 2 THEN (Price * Quantity) - (Discount / 100) * (Price * Quantity) 
//            WHEN 3 THEN Price * Quantity END AS Price FROM StoreTransactionDetailes 
//            WHERE (StoreTrID = (SELECT ISNULL(StoreTrID, 0) AS Expr1
//            FROM TBLStoreTransaction AS TBLStoreTransaction_1
//            WHERE (StoreTrID = StoreTransactionDetailes.StoreTrID) AND (STTRANSTYPEID = 2)))");
            TblSells = FXFW.SqlDB.LoadDataTable(@"SELECT StoreTrDate, Quantity, Price, (Select SanfName From CDASNAF Where SanfID = v_daily_st_nosarf.SanfID ) AS SanfName,
            (Select EMPNAME FROM TBLEMP WHERE EMPID = (Select EMPID From TBLStoreTransaction Where StoreTrID = v_daily_st_nosarf.StoreTrID)) AS EMPNAME
            From v_daily_st_nosarf");
            gridControlMain.DataSource = TblSells;
            gridViewMain.BestFitColumns();
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
        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridControlMain.ShowRibbonPrintPreview();
        }
    }
}