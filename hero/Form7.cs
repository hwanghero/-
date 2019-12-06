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
    public partial class Form7 : MetroForm
    {
        public Form7()
        {
            InitializeComponent();
        }

        public void show_select()
        {
            String selectsql = "select * from hero_admin";
            hero_api ha2 = new hero_api();
            var ss_sql = ha2.getRecord(selectsql);
            dataGridView1.Rows.Clear();
            while (ss_sql.Read())
            {
                string[] row = { ss_sql["admin_name"].ToString(), ss_sql["admin_id"].ToString(), ss_sql["admin_pw"].ToString(), ss_sql["admin_level"].ToString() };
                dataGridView1.Rows.Add(row);
            }
        }

        public void SetupDataGridView()
        {
            this.Controls.Add(dataGridView1);
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "이름";
            dataGridView1.Columns[1].Name = "아이디";
            dataGridView1.Columns[2].Name = "비밀번호";
            dataGridView1.Columns[3].Name = "권한";
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            String check_sql = "select * from hero_admin where admin_id='" + hero_api.getadmin_id() + "'";
            hero_api ha = new hero_api();
            var pwsql = ha.getRecord(check_sql);
            SetupDataGridView();
            show_select();

            while (pwsql.Read())
            {
                mylevel.Text = pwsql["admin_level"].ToString();
            }

            if(mylevel.Text != "최고관리자")
            {
                delete_b.Enabled = false;
                level_b.Enabled = false;
                MessageBox.Show("최고관리자가 아니여서 권한이 제한됩니다.");
            }
        }

        private void 출석부관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.Show();
        }


        private void 학생ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form = new Form6();
            form.Show();
        }

        private void 오픈ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form = new Form4();
            form.Show();
        }

        private void 관리ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form = new Form5();
            form.Show();
        }

        private void 출석부관리ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.Show();
        }

        private void 학생관리ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            form.Show();
        }

        public bool admin_check(string std_id)
        {
            String check = "select * from hero_admin where admin_id ='" + std_id + "'";
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

        private void level_b_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 권한을 수정하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (admin_check(idbox.Text))
                {
                    String check = "update hero_admin set admin_level='" + comboBox1.Text + "' where admin_id='" + idbox.Text + "'";
                    hero_api ha = new hero_api();
                    var sqlc = ha.getRecord(check);
                    MessageBox.Show("수정 됐습니다.");
                    show_select();
                    boxreset();
                }
                else
                {
                    MessageBox.Show("없는 관리자입니다");
                }
            }
            else
            {
                MessageBox.Show("취소 됐습니다.");
            }
        }

        private void delete_b_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 "+idbox.Text+" 관리자를 삭제하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (admin_check(idbox.Text))
                {
                    String check = "delete from hero_admin where admin_id = '"+idbox.Text+"'";
                    hero_api ha = new hero_api();
                    var sqlc = ha.getRecord(check);
                    MessageBox.Show("삭제 됐습니다.");
                    show_select();
                    boxreset();
                }
                else
                {
                    MessageBox.Show("없는 관리자입니다");
                }
            }
            else
            {
                MessageBox.Show("취소 됐습니다.");
            }
        }

        private void insert_b_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 " + idbox.Text + " 관리자를 생성하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(idbox.Text == "" || pwbox.Text == "" || comboBox1.Text == "" || namebox.Text == "")
                {
                    MessageBox.Show("빈칸을 확인해주세요.");
                    return;
                }

                String check = "insert into hero_admin(admin_id, admin_pw, admin_level, admin_name) values('"+idbox.Text+"','"+pwbox.Text+"','"+comboBox1.Text+"','"+namebox.Text+"')";
                hero_api ha = new hero_api();
                var sqlc = ha.getRecord(check);
                MessageBox.Show("생성 됐습니다.");
                show_select();
                boxreset();
            }
            else
            {
                MessageBox.Show("취소 됐습니다.");
            }
        }

        public void boxreset()
        {
            idbox.Text = "";
            comboBox1.Text = "";
            pwbox.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            namebox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            idbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            pwbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
        }
    }
}
