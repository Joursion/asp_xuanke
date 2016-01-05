using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data;

namespace student
{
    public class BaseClass
    {
        String strConn ;//
        public BaseClass()
        {
            strConn = "server=localhost;user id=root;password=7723;database=collect_course; pooling=true;";
        }

        public DataTable ReadTable(String strSql)
        {
            DataTable dt = new DataTable();
            MySqlConnection Conn = new MySqlConnection(strConn);
            Conn.Open();
            MySqlDataAdapter Cmd = new MySqlDataAdapter(strSql, Conn);
            Cmd.Fill(dt);
            Conn.Close();
            return dt;
        }

        public DataSet ReadDataSer(String strSql)
        {
            DataSet ds = new DataSet();
            MySqlConnection Conn = new MySqlConnection(strConn);
            Conn.Open();
            MySqlDataAdapter Cmd = new MySqlDataAdapter(strSql, Conn);
            Cmd.Fill(ds);
            Conn.Close();
            return ds;
        }

        public DataSet GetDataSet(String strSql, String tableName)
        {
            DataSet ds = new DataSet();
            MySqlConnection Conn = new MySqlConnection(strConn);

            Conn.Open();
            MySqlDataAdapter Cmd = new MySqlDataAdapter(strSql, Conn);

            Cmd.Fill(ds, tableName);
            Conn.Close();
            return ds;
        }

        public MySqlDataReader readrow(String sql)
        {
            MySqlConnection Conn = new MySqlConnection(strConn);
            Conn.Open();
            MySqlCommand Comm = new MySqlCommand(sql, Conn);
            MySqlDataReader Reader = Comm.ExecuteReader();

            if(Reader.Read())
            {
                Comm.Dispose();
                return Reader;
            }
            else
            {
                Comm.Dispose();
                return null;
            }
        }

        public string Reader(String strSql, int flag)
        {
            DataSet ds = new DataSet();
            String str;
            MySqlConnection Conn = new MySqlConnection(strConn);
            Conn.Open();
            MySqlDataAdapter Cmd = new MySqlDataAdapter(strSql, Conn);
            Cmd.Fill(ds);
            str = ds.Tables[0].Rows[0].ItemArray[flag].ToString();
            Conn.Close();
            return str;
        }

        public void execsql(String strSql)
        {
            MySqlConnection Conn = new MySqlConnection(strConn);
            MySqlCommand Comm = new MySqlCommand(strSql, Conn);
            Conn.Open();
            Comm.ExecuteNonQuery();
            Conn.Close();
        }
    }
}