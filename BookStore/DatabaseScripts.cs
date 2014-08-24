
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace BookStore
{
    public static class DatabaseScripts
    {

        public static void FireScript()
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.schoolStoreConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            try
            {
                con.Open();

                if (CheckViewExists("v_student"))
                {
                    cmd.CommandText = DropObject("v_student");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = v_student;
                cmd.ExecuteNonQuery();

                if (CheckProcedureExists("sp_StudentBooksRequests"))
                {
                    cmd.CommandText = DropObjectPROCEDURE("sp_StudentBooksRequests");
                    cmd.ExecuteNonQuery();
                }
                cmd.CommandText = sp_StudentBooksRequests;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                //Program.Logger.LogThis(FXFW.SqlDB.CheckExp(ex), "Fire Scripting", FXFW.Logger.OpType.success, null, ex, null);
            }
            con.Close();
        }

        public static bool CheckViewExists(string viewName)
        {
            bool exist = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.schoolStoreConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandText = string.Format(@"IF EXISTS(select * FROM sys.views where name = '{0}')
                                            SELECT 1
                                            ELSE
                                            SELECT 0", viewName);
            try
            {
                con.Open();
                if (cmd.ExecuteScalar().ToString() == "1")
                    exist = true;
                else
                    exist = false;
            }
            catch (SqlException ex)
            {
                //Program.Logger.LogThis(FXFW.SqlDB.CheckExp(ex), "Fire Scripting", FXFW.Logger.OpType.success, null, ex, null);
            }
            con.Close();
            return exist;
        }
        public static bool CheckProcedureExists(string viewName)
        {
            bool exist = false;
            SqlConnection con = new SqlConnection(Properties.Settings.Default.schoolStoreConnectionString);
            SqlCommand cmd = new SqlCommand("", con);
            cmd.CommandText = string.Format(@"IF EXISTS(select * FROM sys.procedures where name = '{0}')
                                            SELECT 1
                                            ELSE
                                            SELECT 0", viewName);
            try
            {
                con.Open();
                if (cmd.ExecuteScalar().ToString() == "1")
                    exist = true;
                else
                    exist = false;
            }
            catch (SqlException ex)
            {
                //Program.Logger.LogThis(FXFW.SqlDB.CheckExp(ex), "Fire Scripting", FXFW.Logger.OpType.success, null, ex, null);
            }
            con.Close();
            return exist;
        }
        private static string DropObject(string objName)
        {
            return string.Format(@"DROP VIEW [dbo].[{0}]", objName);
        }
        private static string DropObjectPROCEDURE(string objName)
        {
            return string.Format(@"DROP PROCEDURE [dbo].[{0}]", objName);
        }

        public static string v_student
        {
            get
            {
                return @"
                CREATE VIEW [dbo].[v_student]
                AS
                SELECT        dbo.student_t.stu_code, dbo.student_t.asase_code, dbo.student_t.alsofof_code, dbo.student_t.fasl_code, dbo.student.stu_name, dbo.student.waleaalkamr_mobile, dbo.CD_Asase.asase_year, 
                         dbo.CDalsofof.alsofof_NAME, dbo.CDEFASL.fasl_name
                FROM            dbo.CDEFASL RIGHT OUTER JOIN
                         dbo.student_t ON dbo.CDEFASL.fasl_code = dbo.student_t.fasl_code LEFT OUTER JOIN
                         dbo.CDalsofof ON dbo.student_t.alsofof_code = dbo.CDalsofof.alsofof_code LEFT OUTER JOIN
                         dbo.CD_Asase ON dbo.student_t.asase_code = dbo.CD_Asase.asase_code LEFT OUTER JOIN
                         dbo.student ON dbo.student_t.stu_code = dbo.student.stu_code";
            }
        }
        public static string sp_StudentBooksRequests
        {
            get
            {
                return @"
                CREATE PROCEDURE [dbo].[sp_StudentBooksRequests]
	                @asase_code INT
                AS
                BEGIN
	                SET NOCOUNT ON;
                DECLARE @MasterTbl TABLE(stu_code int, alsofof_code int, fasl_code int, stu_name nvarchar(100), waleaalkamr_mobile nvarchar(100), alsofof_NAME nvarchar(100), fasl_name nvarchar(100)
                , SanfID int, SanfName nvarchar(100), Request nvarchar(100), UNIQUE CLUSTERED(stu_code, SanfID))

                INSERT INTO @MasterTbl
                SELECT        v_student.stu_code, v_student.alsofof_code, v_student.fasl_code, v_student.stu_name, v_student.waleaalkamr_mobile, v_student.alsofof_NAME, v_student.fasl_name, CDASNAF.SanfID, 
							                CDASNAF.SanfName, 'لم يصرف'
                FROM            v_student INNER JOIN
							                CDCategories ON v_student.alsofof_code = CDCategories.alsofof_code RIGHT OUTER JOIN
							                CDASNAF ON CDCategories.CategoryId = CDASNAF.CategoryID
                WHERE        (v_student.asase_code = @asase_code)

                DECLARE @TransactionTbl TABLE(SanfID INT, PERSONID INT, UNIQUE CLUSTERED(SanfID, PERSONID))
                INSERT INTO @TransactionTbl
                SELECT        StoreTransactionDetailes.SanfID, TBLStoreTransaction.PERSONID
                FROM            TBLStoreTransaction INNER JOIN
                                        StoreTransactionDetailes ON TBLStoreTransaction.StoreTrID = StoreTransactionDetailes.StoreTrID
                WHERE        (TBLStoreTransaction.STTRANSTYPEID = 2) AND (TBLStoreTransaction.asase_code = @asase_code)
                GROUP BY StoreTransactionDetailes.SanfID, TBLStoreTransaction.PERSONID

                UPDATE @MasterTbl
                SET Request = 'صرف'
                FROM @MasterTbl MasterTbl INNER JOIN @TransactionTbl TransactionTbl
                ON MasterTbl.stu_code = TransactionTbl.PERSONID AND MasterTbl.SanfID = TransactionTbl.SanfID
                SELECT * FROM @MasterTbl
                END";
            }
        }

    }
}
