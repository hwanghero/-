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
using MetroFramework.Forms;

namespace hero
{
    public partial class Form5 : MetroForm
    {
        private static string mysql_str = "server=l.bsks.ac.kr; port=3306; Database=p201606010; Uid=p201606010; Pwd=pp201606010; Charset=utf8; allow user variables=true;";
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand cmd;
        MySqlDataReader no_reader;
    
        public Form5()
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

        private void 오픈ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            conn.Open();
            SetupDataGridView();
            String check = "select tablenickname from hero_table_nickname";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);
            comboBox1.Items.Clear();
            while (sqlc.Read())
            {
                comboBox1.Items.Add(sqlc[0].ToString());
            }
            button2.Enabled = false;
            button3.Enabled = false;
        }

        public void SetupDataGridView()
        {
            this.Controls.Add(dataGridView1);
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "학번";
            dataGridView1.Columns[1].Name = "이름";
            dataGridView1.Columns[2].Name = "생일";
            dataGridView1.Columns[3].Name = "성별";
            dataGridView1.Columns[4].Name = "휴대폰";
            dataGridView1.Columns[5].Name = "이메일";
            dataGridView1.Columns[6].Name = "주소";
            dataGridView1.Columns[7].Name = "이미지";
            dataGridView1.Columns[8].Name = "가입날짜";

            this.Controls.Add(dataGridView2);
            dataGridView2.ColumnCount = 9;
            dataGridView2.Columns[0].Name = "학번";
            dataGridView2.Columns[1].Name = "이름";
            dataGridView2.Columns[2].Name = "생일";
            dataGridView2.Columns[3].Name = "성별";
            dataGridView2.Columns[4].Name = "휴대폰";
            dataGridView2.Columns[5].Name = "이메일";
            dataGridView2.Columns[6].Name = "주소";
            dataGridView2.Columns[7].Name = "이미지";
            dataGridView2.Columns[8].Name = "가입날짜";
        }


        public void updateview()
        {
            // 미승인 //
            dataGridView1.Rows.Clear();

            String sql1 = "select tablename from hero_table_nickname where tablenickname like '"+ comboBox1.SelectedItem.ToString()+"'";
            cmd = new MySqlCommand(sql1, conn);
            if (no_reader != null) no_reader.Close();
            no_reader = cmd.ExecuteReader();
            while (no_reader.Read())
            {
                String check = "select * from hero_" + no_reader["tablename"].ToString() + " where admin_check = 0";
                hero_api ha = new hero_api();
                var reader = ha.getRecord(check);
                while (reader.Read())
                {
                    string[] row = { reader["USER_STUDENT_NO"].ToString(), reader["USER_NAME"].ToString(), reader["USER_BIRTH"].ToString(), reader["USER_SEX"].ToString(), reader["USER_PHONE"].ToString(), reader["USER_MAIL"].ToString(), reader["USER_ADDR"].ToString(), reader["USER_IMAGE"].ToString(), reader["USER_SYS"].ToString() };
                    dataGridView1.Rows.Add(row);
                }
            }
            no_reader.Close();

            // 승인 //
            dataGridView2.Rows.Clear();
            no_reader = cmd.ExecuteReader();
            while (no_reader.Read())
            {
                String check = "select * from hero_" + no_reader["tablename"].ToString() + " where admin_check = 1";
                hero_api ha = new hero_api();
                var reader = ha.getRecord(check);
                while (reader.Read())
                {
                    string[] row = { reader["USER_STUDENT_NO"].ToString(), reader["USER_NAME"].ToString(), reader["USER_BIRTH"].ToString(), reader["USER_SEX"].ToString(), reader["USER_PHONE"].ToString(), reader["USER_MAIL"].ToString(), reader["USER_ADDR"].ToString(), reader["USER_IMAGE"].ToString(), reader["USER_SYS"].ToString() };
                    dataGridView2.Rows.Add(row);
                }
            }
            no_reader.Close();
        }

        public bool Student_check(string std_id)
        {
            if (search.Text == "") return false;
            String check = "select tablename from hero_table_nickname where tablenickname like '" + comboBox1.SelectedItem.ToString() + "'";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);

            while (sqlc.Read())
            {
                String check2 = "select * from hero_" + sqlc["tablename"].ToString() + " where USER_STUDENT_NO = '" + search.Text + "'";
                var reader = ha.getRecord(check2);

                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        // 검색 승인

        private void button2_Click(object sender, EventArgs e)
        {
            if (Student_check(search.Text))
            {
                String check = "select tablename from hero_table_nickname where tablenickname like '" + comboBox1.SelectedItem.ToString() + "'";
                hero_api ha = new hero_api();
                var sqlc = ha.getRecord(check);

                while (sqlc.Read())
                {
                    String check2 = "update hero_" + sqlc["tablename"].ToString() + " set admin_check = 1 where USER_STUDENT_NO = '" + search.Text + "'";
                    var reader = ha.getRecord(check2);
                    String check3 = "update hero_user set user_check = 1 where user_student_no = '" + search.Text + "'";
                    var sqlc2 = ha.getRecord(check2);
                    MessageBox.Show(search.Text + "를 승인하였습니다.");
                }
                updateview();
            }
            else
            {
                MessageBox.Show("없는 학생입니다.");
            }
        }

        // 검색 취소

        private void button3_Click(object sender, EventArgs e)
        {
            if (Student_check(search.Text))
            {
                String check = "select tablename from hero_table_nickname where tablenickname like '" + comboBox1.SelectedItem.ToString() + "'";
                hero_api ha = new hero_api();
                var sqlc = ha.getRecord(check);

                while (sqlc.Read())
                {
                    String check2 = "update hero_" + sqlc["tablename"].ToString() + " set admin_check = 0 where USER_STUDENT_NO = '" + search.Text + "'";
                    var reader = ha.getRecord(check2);
                    String check3 = "update hero_user set user_check = 0 where user_student_no = '" + search.Text + "'";
                    var sqlc2 = ha.getRecord(check2);
                    MessageBox.Show(search.Text + "를 승인취소 하였습니다.");
                }
                updateview();
            }
            else
            {
                MessageBox.Show("없는 학생입니다.");
            }
        }

        // 미승인 그리드뷰 더블 클릭 이벤트

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            no_reader.Close();

            String sql1 = "select tablename from hero_table_nickname where tablenickname like '" + comboBox1.SelectedItem.ToString() + "'";
            cmd = new MySqlCommand(sql1, conn);
            
            no_reader = cmd.ExecuteReader();

            while (no_reader.Read())
            {
                String check = "update hero_" + no_reader["tablename"].ToString() + " set admin_check = 1 where user_student_no = '" + dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString()+"'";
                hero_api ha = new hero_api();
                var sqlc = ha.getRecord(check);
                String check2 = "update hero_user set user_check = 1 where user_student_no = '"+ dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() + "'";
                var sqlc2 = ha.getRecord(check2);
                MessageBox.Show("승인 하였습니다.");
            }
            updateview();
        }

        // 승인 그리드뷰 더블 클릭 이벤트

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            no_reader.Close();
            String sql1 = "select tablename from hero_table_nickname where tablenickname like '" + comboBox1.SelectedItem.ToString() + "'";
            cmd = new MySqlCommand(sql1, conn);

            no_reader = cmd.ExecuteReader();

            while (no_reader.Read())
            {
                String check = "update hero_" + no_reader["tablename"].ToString() + " set admin_check = 0 where user_student_no = '" + dataGridView2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString()+"'";
                hero_api ha = new hero_api();
                var sqlc = ha.getRecord(check);
                String check2 = "update hero_user set user_check = 0 where user_student_no = '" + dataGridView2.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() + "'";
                var sqlc2 = ha.getRecord(check2);
                MessageBox.Show("승인을 취소하였습니다.");
            }
            updateview();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateview();
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void 학생관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        private void 출석부관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.Show();
        }
    }
}
