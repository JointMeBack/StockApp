using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    public class DBManager
    {
        public static NpgsqlConnection con;
        public static void DBConnection(string Login, string Pass, string DBName)
        {
            string cs = $"Host=localhost;Port=5432;Username={Login};Password={Pass};Database={DBName}";
            if (con == null)
                con = new NpgsqlConnection(cs);
            if (con.State != System.Data.ConnectionState.Open)
                con.Open();

            //var sql = "SELECT version()";

            //var version = cmd.ExecuteScalar().ToString();
            //Console.WriteLine($"PostgreSQL version: {version}");
        }
        //------------------------------------------Функции подключения добавления изменения базы данных.
        public static DataTable DBSelect(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, con);
                adapter.Fill(dt);
            }
            catch (Exception)
            {

            }
            return dt;
        }

        public static bool DBNonQuery(string query)
        {

            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static int DBScalar(string query)
        {

            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(query, con);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
