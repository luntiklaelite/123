using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tovari
{
    public class db
    {
        static db instance;
        MySqlConnection conn;


        public static db init()
        {
            if(instance == null)
                instance = new db();
            return instance;
        }

        public db()
        {
            string connStr = "Server=localhost;User ID=luntiklaelite;password=123456789;CharSet=utf8;database=tovari";
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка с соединением с базой данных!");
                return;
            }
        }

        private MySqlCommand genCommand(string sql, List<parami> list)
        {
            MySqlCommand comm = new MySqlCommand(sql, conn);
            foreach(parami param in list) 
            {
                comm.Parameters.AddWithValue(param.paramname, param.paramvalue);
            }
            return comm;
        }

        public bool exec(string sql, List<parami> list)
        {
            MySqlCommand comm = genCommand(sql, list);
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Проблема с выполнением запроса!");
                return false;
            }
            return true;
        }

        public bool select(string sql, List<parami> list, out DataTable table)
        {
            MySqlCommand comm = genCommand(sql, list);
            try
            {
                using (MySqlDataReader reader = comm.ExecuteReader())
                {
                    table = new DataTable();
                    table.Load(reader);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Проблема с выполнением запроса!");
                table = null;
                return false;
            }
            return true;
        }


    }
}
