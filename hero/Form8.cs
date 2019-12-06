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
using Renci.SshNet;
using MetroFramework.Forms;

namespace hero
{
    public partial class Form8 : MetroForm
    {
        string student_id = "", db_name = "";

        public Form8()
        {
            InitializeComponent();
        }

        public string setdbname(string data)
        {
            return db_name = data;
        }

        public string setdata(string data)
        {
            return student_id = data;
        }


        private void Form8_Load(object sender, EventArgs e)
        {
            textBox1.Text = student_id;

            // 지각
            String check = "select count(*) from hero_work where user_student_no = '"+student_id+"' and DILI_GUBUN = '2' and user_table = '"+db_name+"'";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);
            if(sqlc.Read())
            {
                textBox2.Text = sqlc[0].ToString();
            }

            // 결근
            String check2 = "select count(*) from hero_work where user_student_no = '" + student_id + "' and DILI_GUBUN = '1' and user_table = '" + db_name + "'";
            var sqlc2 = ha.getRecord(check2);
            if (sqlc2.Read())
            {
                textBox4.Text = sqlc2[0].ToString();
            }

            // 조퇴
            String check3 = "select count(*) from hero_work where user_student_no = '" + student_id + "' and DILI_GUBUN = '3' and user_table = '" + db_name + "'";
            var sqlc3 = ha.getRecord(check3);
            if (sqlc3.Read())
            {
                textBox3.Text = sqlc3[0].ToString();
            }

            // 지각 + 조퇴
            String check4 = "select count(*) from hero_work where user_student_no = '" + student_id + "' and DILI_GUBUN = '4' and user_table = '" + db_name + "'";
            var sqlc4 = ha.getRecord(check4);
            if (sqlc4.Read())
            {

                int plus = int.Parse(sqlc4[0].ToString());
                int tb3 = int.Parse(textBox3.Text) + plus;
                int tb2 = int.Parse(textBox2.Text) + plus;
                textBox3.Text = tb3.ToString();
                textBox2.Text = tb2.ToString();
            }

            // 지각 시간 합치기
            String check5 = "select SUM(DILI_TARDY) from hero_work where user_student_no = '"+student_id+"' and USER_TABLE = '"+db_name+"'";
            var sqlc5 = ha.getRecord(check5);
            if (sqlc5.Read())
            {
                textBox5.Text = sqlc5[0].ToString() + "시간";
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
        
        }
    }
}
