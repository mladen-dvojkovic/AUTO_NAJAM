using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoNajam.Klase
{
    public class SqlDb
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["autoConnectionString"].ConnectionString);
        }

        public static int Execute(SqlCommand cmd)
        {
            int rowsAffected = 0;

            if (cmd.Connection == null)
            {
                using (SqlConnection conn = GetConnection())
                {
                    cmd.Connection = conn;
                    cmd.Connection.Open();
                    rowsAffected = cmd.ExecuteNonQuery();
                }
            }
            else
            {
                rowsAffected = cmd.ExecuteNonQuery();
            }

            return rowsAffected;
        }

        public static object Scalar(SqlCommand cmd)
        {
            object scalarValue;

            if (cmd.Connection == null)
            {
                using (SqlConnection conn = GetConnection())
                {
                    cmd.Connection = conn;
                    cmd.Connection.Open();
                    scalarValue = cmd.ExecuteScalar();
                }
            }
            else
            {
                scalarValue = cmd.ExecuteScalar();
            }

            return scalarValue;
        }

        public static DataTable FillTable(SqlCommand cmd)
        {
            DataTable dt = new DataTable();

            if (cmd.Connection == null)
            {
                using (SqlConnection conn = GetConnection())
                {
                    cmd.Connection = conn;
                    cmd.Connection.Open();

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            else
            {
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}
