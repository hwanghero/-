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
    public partial class Form6 : MetroForm
    {
        private static string mysql_str = "server=l.bsks.ac.kr; port=3306; Database=p201606010; Uid=p201606010; Pwd=pp201606010; Charset=utf8";
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand cmd;
        MySqlDataReader reader;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            conn.Open();
            show_select();
        }

        public void show_select()
        {
            String selectsql = "select * from hero_user";
            hero_api ha2 = new hero_api();
            var ss_sql = ha2.getRecord(selectsql);
            dataGridView1.Rows.Clear();
            while (ss_sql.Read())
            {
                string[] row = { ss_sql["USER_STUDENT_NO"].ToString(), ss_sql["USER_ID"].ToString(), ss_sql["USER_PW"].ToString() };
                dataGridView1.Rows.Add(row);
            }
        }

        public void SetupDataGridView()
        {
            this.Controls.Add(dataGridView1);
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "학번";
            dataGridView1.Columns[1].Name = "아이디";
            dataGridView1.Columns[2].Name = "비밀번호";
        }


        private void 출석부관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.Show();
        }

        private void 학생관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void 오픈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.Show();
        }

        private void 관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form = new Form5();
            form.Show();
        }

        private void 출석부ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form = new Form7();
            form.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            studentbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
        }

        private void search_b_Click(object sender, EventArgs e)
        {
            String sql1 = "select * from hero_user where USER_STUDENT_NO ='" + textBox1.Text + "'";
            cmd = new MySqlCommand(sql1, conn);
            if (textBox1.Text == "") return;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Clear();
                string[] row = { reader["USER_STUDENT_NO"].ToString(), reader["USER_ID"].ToString(), reader["USER_PW"].ToString() };
                dataGridView1.Rows.Add(row);
                reader.Close();
                return;
            }
            MessageBox.Show("없는 학생입니다.");
            reader.Close();
            return;
        }

        public bool student_check(string std_id)
        {
            String check = "select * from hero_user where user_student_no ='" + std_id + "'";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);
            if (sqlc.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void delete_b_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 강제탈퇴를 하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (student_check(studentbox.Text))
                {
                    String check = "delete from hero_user where user_student_no ='" + studentbox.Text + "'";
                    hero_api ha = new hero_api();
                    var sqlc = ha.getRecord(check);
                    MessageBox.Show("탈퇴 됐습니다.");
                    show_select();
                }
                else
                {
                    MessageBox.Show("없는 학생입니다.");
                }
            }
            else
            {
                MessageBox.Show("취소 됐습니다.");
            }
        }

        private void update_b_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 수정을 하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (student_check(studentbox.Text))
                {
                    String check = "update hero_user set user_id='" + idbox.Text + "' where user_student_no='" + studentbox.Text + "'";
                    hero_api ha = new hero_api();
                    var sqlc = ha.getRecord(check);
                    MessageBox.Show("수정 됐습니다.");
                    show_select();
                }
                else
                {
                    MessageBox.Show("없는 학생입니다.");
                }
            }
            else
            {
                MessageBox.Show("취소 됐습니다.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_select();
        }
    }
}
