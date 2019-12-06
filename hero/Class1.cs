using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// mysql using
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
// IO
using System.IO;

namespace hero
{
    class hero_api
    {
        private static string mysql_str = "server=l.bsks.ac.kr; port=3306; Database=p201606010; Uid=p201606010; Pwd=pp201606010; Charset=utf8";
        MySqlDataReader reader;
        public IDataReader getRecord(string query)
        {
            using (var connection = new MySqlConnection(mysql_str))
            {
                connection.Open();
                using (var cmd = new MySqlCommand(query, connection))
                {
                    reader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(reader);
                    return dt.CreateDataReader();
                }
            }
        }

        static string admin_id = "";
        public static string getadmin_id()
        {
            return admin_id;
        }
        public static string setadmin_id(string admin)
        {
            return admin_id = admin;
        }
    }
}
