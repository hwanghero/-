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
using Microsoft.Win32;
using MetroFramework.Forms;

namespace hero
{
    // 암호화를 해야함 레지스트리에 적용할 비밀번호.

    public partial class Form1 : MetroForm
    {
        private static string mysql_str = "server=l.bsks.ac.kr; port=3306; Database=p201606010; Uid=p201606010; Pwd=pp201606010; Charset=utf8";
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlDataReader reader;
        MySqlCommand cmd;
        RegistryKey reg;

        public Form1()
        {
            InitializeComponent();
            conn.Open();
        }
        private void Button1_MouseClick(object sender, MouseEventArgs e)
        {
            login();
        }

        public void login()
        {
            String idcheck_sql = "select * from hero_admin where admin_ID='" + textBox1.Text + "'";
            cmd = new MySqlCommand(idcheck_sql, conn);
            reader = cmd.ExecuteReader();
            if (!reader.Read())
            {
                MessageBox.Show("등록되지 않은 아이디입니다.");
                reader.Close();
            }
            else
            {
                if (textBox2.Text != "")
                {
                    reader.Close();
                    String pwcheck_sql = "select admin_pw from hero_admin where admin_ID='" + textBox1.Text + "'";
                    hero_api ha = new hero_api();
                    var pwsql = ha.getRecord(pwcheck_sql);

                    while (pwsql.Read())
                    {
                        if (textBox2.Text == pwsql["admin_pw"].ToString())
                        {
                            this.Opacity = 0.0;
                            this.Enabled = false;
                            this.ShowInTaskbar = false;

                            Form6 f = new Form6();
                            f.Show();

                            hero_api.setadmin_id(textBox1.Text);
                            MessageBox.Show("로그인 성공");

                            reg.SetValue("autologin_id", textBox1.Text);
                            reg.SetValue("autologin_pw", textBox2.Text);

                            reader.Close();
                        }
                        else
                        {
                            MessageBox.Show("비밀번호가 틀렸습니다.");
                            reader.Close();
                        }
                    }
                    reader.Close();
                }
                else
                {
                    MessageBox.Show("비밀번호를 입력해주세요");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reg = Registry.CurrentUser.CreateSubKey("hero");
            string getlogin = reg.GetValue("autologin").ToString();
            if (getlogin == "off")
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
                textBox1.Text = reg.GetValue("autologin_id").ToString();
                textBox2.Text = reg.GetValue("autologin_pw").ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            reg = Registry.CurrentUser.CreateSubKey("hero");
            string getlogin = reg.GetValue("autologin").ToString();
            if(checkBox1.Checked == true)
            {
                reg.SetValue("autologin", "on");
            }
            else
            {
                reg.SetValue("autologin", "off");
                reg.SetValue("autologin_id", "");
                reg.SetValue("autologin_pw", "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }
    }
}
