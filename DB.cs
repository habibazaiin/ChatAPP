using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ChatAPP
{
    internal static class DB
    {
        private static SqlConnection con = new SqlConnection();

        private static SqlCommand cmd = new SqlCommand();

        public static int UserId;

        public static void start()
        {
            con.ConnectionString = "Server=sql1002.site4now.net;Database=db_ab2b89_chatapp;user id=db_ab2b89_chatapp_admin;password=habiba23";
            con.Open();
            cmd.Connection = con;
        }

        public static void Execute(string sql)
        {
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public static string GetValue(string sl)
        {
            string res = null;
            cmd.CommandText = sl;
            if (cmd.ExecuteScalar() != null)
            {
                res = cmd.ExecuteScalar().ToString();
            }
            return res;
        }

        public static DataTable GetTable(string sl)
        {
            cmd.CommandText = sl;
            SqlDataReader rd = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(rd);
            rd.Close();
            return dt;
        }

        public static void FillComboBox(string sl, ComboBox cmb)
        {
            DataTable dt = GetTable(sl);
            cmb.DataSource = dt;
            cmb.DisplayMember = dt.Columns[1].ColumnName;
            cmb.ValueMember = dt.Columns[0].ColumnName;
        }

        public static void FillListBox(string sl, ListBox lst)
        {
            DataTable dt = GetTable(sl);
            lst.DataSource = dt;
            lst.DisplayMember = dt.Columns[1].ColumnName;
            lst.ValueMember = dt.Columns[0].ColumnName;
        }

        public static void FillGrid(string sl, DataGridView grid)
        {
            DataTable dt = GetTable(sl);
            grid.DataSource = dt;
            grid.Refresh();
        }

        public static void clean(Form frm)
        {
            foreach (var c in frm.Controls)
            {
                if (c is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                }
                if (c is TextBox txt)
                {
                    txt.Text = "";
                }
            }
        }
    }
}
