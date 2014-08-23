
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
        private static string DropObject(string objName)
        {
            return string.Format(@"DROP VIEW [dbo].[{0}]", objName);
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
    }
}
