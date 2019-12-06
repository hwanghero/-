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
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using Renci.SshNet;
using MetroFramework.Forms;

namespace hero
{
    public partial class Form4 : MetroForm
    {
        // 생성할 때 기본값 에러 mysql putty로 바꾸고 나서 생긴 에러임.

        // hero_table_nickname에 생성년도, 하반기인지 상반기인지 확인하는 테이블 생성

        private static string mysql_str = "server=l.bsks.ac.kr; port=3306; Database=p201606010; Uid=p201606010; Pwd=pp201606010; Charset=utf8; allow user variables=true;";
        MySqlConnection conn = new MySqlConnection(mysql_str);
        String open_msg = "";

        public Form4()
        {
            InitializeComponent();
        }

        private void 학생ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form = new Form6();
            form.Show();
        }

        private void 출석부ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form = new Form7();
            form.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("yyyy");
            String check = "select * from hero_table_nickname";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);
            listBox1.Items.Clear();
            while (sqlc.Read())
            {
                listBox1.Items.Add("DB이름: " + sqlc[0].ToString() + " 별명: "+ sqlc[1].ToString());
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            int dd = int.Parse(dt.Day.ToString());
            int dd2 = int.Parse(dt2.Day.ToString());

            if (open_msg == "")
            {
                MessageBox.Show("상반기, 하반기 체크필요");
                return;
            }
            if(dd2 < dd)
            {
                MessageBox.Show("날짜를 제대로 수정해주세요");
                return;
            }

            String check = "show tables like 'hero_"+ DateTime.Now.ToString("yyyy") + "_" + textBox2.Text + "_" + open_msg + "'";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);

            if (!sqlc.Read())
            {
                // putty sql버전이 낮기에 user_sys를 직접 넣어줘야함.
                
                // db이름을 고정 시켜야함 ex) hero_appbutton_2019_high/low

                MessageBox.Show(DateTime.Now.ToString("yyyy") + ""+textBox2.Text+"" + open_msg + " 테이블생성");
                String check_create = "CREATE TABLE hero_"+DateTime.Now.ToString("yyyy")+ "_" + textBox2.Text + "_" + open_msg+"(USER_STUDENT_NO varchar(30), USER_NAME varchar(30), USER_BIRTH varchar(10), USER_SEX char(1), USER_PHONE varchar(15), USER_MAIL varchar(255), USER_ADDR varchar(255), USER_IMAGE varchar(255), ADMIN_CHECK varchar(1), USER_SYS varchar(12), primary key(USER_STUDENT_NO));";
                var check_create_c = ha.getRecord(check_create);

                string start = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string end = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                String nickname = "insert into hero_table_nickname(tablename, tablenickname, table_start, table_bestby) values('" + DateTime.Now.ToString("yyyy") + "_" + textBox2.Text + "_" + open_msg + "', '"+nickbox.Text+ "','"+start+"', '"+end+"');";
                var nickname_c = ha.getRecord(nickname);

                /*
                
                폴더 생성 구문 (권한 에러)
                 
                var connectionInfo_pw = new Renci.SshNet.PasswordConnectionInfo("l.bsks.ac.kr", "p201606010", "pp201606010");
                var client = new SftpClient(connectionInfo_pw);
                client.Connect();
                string serverPath = string.Format(@"/home/p201606010/public_html/hero_php/img/" + DateTime.Now.ToString("yyyy") + "_" + textBox2.Text + "_" + open_msg);
                client.CreateDirectory(serverPath);
                client.Disconnect();

                */
            }
            else
            {
                MessageBox.Show("이미 생성을 하였습니다.");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            open_msg = "high";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            open_msg = "low";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (open_msg == "")
            {
                MessageBox.Show("상반기, 하반기 체크필요");
                return;
            }
            String check = "show tables like 'hero_" + DateTime.Now.ToString("yyyy") + "_" + textBox2.Text + "_" + open_msg + "'";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);

            if (!sqlc.Read())
            {
                MessageBox.Show("이미 삭제를 하였습니다.");
            }
            else
            {
                MessageBox.Show(DateTime.Now.ToString("yyyy")+""+open_msg+" 삭제");
                String check_delete = "DROP TABLE hero_" + DateTime.Now.ToString("yyyy") + "_" + textBox2.Text + "_" + open_msg;
                var check_delete_c = ha.getRecord(check_delete);
                String coulmn_delete = "DELETE FROM hero_table_nickname WHERE tablename = '"+ DateTime.Now.ToString("yyyy") + "_" + textBox2.Text + "_" + open_msg +"'";
                var coulmn_delete_c = ha.getRecord(coulmn_delete);

                /*
                    var connectionInfo_pw = new Renci.SshNet.PasswordConnectionInfo("l.bsks.ac.kr", "p201606010", "pp201606010");
                    var client = new SftpClient(connectionInfo_pw);
                    client.Connect();
                    string serverPath = string.Format(@"/home/p201606010/public_html/hero_php/img/" + DateTime.Now.ToString("yyyy") + "_" + textBox2.Text + "_" + open_msg);
                    client.DeleteDirectory(serverPath);
                    client.Disconnect();
                */
            }
        }

        private void 관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form = new Form5();
            form.Show();
        }

        // 첫번째것이 삭제가 안됨

        private void button1_Click_1(object sender, EventArgs e)
        {
            String check = "select * from hero_table_nickname";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);

            if (!sqlc.Read())
            {
                MessageBox.Show("이미 삭제를 하였습니다.");
            }
            else
            {
                while (sqlc.Read())
                {
                    MessageBox.Show(sqlc[0].ToString());
                    String check_delete = "DROP TABLE hero_"+ sqlc[0].ToString();
                    var check_delete_c = ha.getRecord(check_delete);
                    String coulmn_delete = "DELETE FROM hero_table_nickname WHERE tablename = '" + sqlc[0].ToString()+"'";
                    var coulmn_delete_c = ha.getRecord(coulmn_delete);
                }
            }
        }

        private void 오픈ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 학생관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 현장실습ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 출석부관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.Show();
        }
    }
}
