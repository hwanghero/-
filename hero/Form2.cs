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

    public partial class Form2 : MetroForm
    {
        private static string mysql_str = "server=l.bsks.ac.kr; port=3306; Database=p201606010; Uid=p201606010; Pwd=pp201606010; Charset=utf8";
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand cmd;
        MySqlDataReader reader;
        String modecheck = "null";
        String db_name, db_nickname;

        public void sftp_upload(string filename)
        {
            // 폴더가 없을경우 no such file
            // 폴더 있는데 업로드 할경우 권한 에러

            var connectionInfo_pw = new Renci.SshNet.PasswordConnectionInfo("l.bsks.ac.kr", "p201606010", "pp201606010");
            var client = new SftpClient(connectionInfo_pw);
            client.Connect();
            string serverPath = string.Format(@"/home/p201606010/public_html/hero_php/img/"+db_name+"/"+filename);
            Stream stream = new MemoryStream(File.ReadAllBytes(filename));
            client.UploadFile(stream, serverPath);
            client.Disconnect();
        }

        public Form2()
        {
            InitializeComponent();
            conn.Open();
            SetupDataGridView();
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
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (textboxcheck() == 0)
            {
                if(modecheck == "insert")
                {
                   // reader.Close();
                    String idcheck = "select USER_STUDENT_NO from hero_" + db_name + " where USER_STUDENT_NO='" + numberbox.Text + "'";
                    hero_api ha = new hero_api();
                    var idsql = ha.getRecord(idcheck);
                    while (idsql.Read())
                    {
                        MessageBox.Show("이미 있는 학번입니다.");
                        return;
                    }
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "insert into hero_"+db_name+"(USER_STUDENT_NO, USER_NAME, USER_BIRTH, USER_SEX, USER_PHONE, USER_MAIL, USER_ADDR, USER_IMAGE) values(@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@a1", numberbox.Text);
                    cmd.Parameters.AddWithValue("@a2", namebox.Text);
                    cmd.Parameters.AddWithValue("@a3", birthbox.Text);
                    cmd.Parameters.AddWithValue("@a4", sexbox.Text);
                    cmd.Parameters.AddWithValue("@a5", phonebox.Text);
                    cmd.Parameters.AddWithValue("@a6", mailbox.Text);
                    cmd.Parameters.AddWithValue("@a7", addrbox.Text);
                    cmd.Parameters.AddWithValue("@a8", pickbox.Text);
                    cmd.ExecuteNonQuery();

                    if (pictureBox1.Image == null || pickbox.Text == "")
                    {
                        MessageBox.Show("이미지가 없습니다.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("저장 되었습니다.");
                    }
                }
                else if(modecheck == "update")
                {
                    if (sql_index_check() == true)
                    {
                        cmd = new MySqlCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = "update hero_" + db_name + " set USER_STUDENT_NO=@a1, USER_NAME=@a2, USER_BIRTH=@a3, USER_SEX=@a4, USER_PHONE=@a5, USER_MAIL=@a6, USER_ADDR=@a7, USER_IMAGE=@a8 where USER_STUDENT_NO = '" + numberbox.Text+"'";
                        cmd.Prepare();
                        cmd.Parameters.AddWithValue("@a1", numberbox.Text);
                        cmd.Parameters.AddWithValue("@a2", namebox.Text);
                        cmd.Parameters.AddWithValue("@a3", birthbox.Text);
                        cmd.Parameters.AddWithValue("@a4", sexbox.Text);
                        cmd.Parameters.AddWithValue("@a5", phonebox.Text);
                        cmd.Parameters.AddWithValue("@a6", mailbox.Text);
                        cmd.Parameters.AddWithValue("@a7", addrbox.Text);
                        cmd.Parameters.AddWithValue("@a8", pickbox.Text);
                        cmd.ExecuteNonQuery();
                        if (pictureBox1.Image == null) return;
                        MessageBox.Show("수정에 성공하였습니다.");
                    }
                    else
                    {
                        MessageBox.Show("없는 학번입니다.");
                    }
                }
                else if(modecheck == "delete")
                {
                    if(sql_index_check() == true)
                    {
                        String delete_sql = "delete from hero_" + db_name + " where USER_STUDENT_NO='" + numberbox.Text + "'";
                        hero_api ha = new hero_api();
                        var deletesql = ha.getRecord(delete_sql);
                        MessageBox.Show("삭제에 성공하였습니다.");
                    }
                    else
                    {
                        MessageBox.Show("없는 학번입니다.");
                    }
                    textboxON();
                }
                resetTextbox();
                disablebutton(true);
                selectupdate();
                pictureBox1.Image = null;
            }
            modecheck = "null";
        }
        public bool sql_index_check()
        {
            String selectsql = "select USER_STUDENT_NO from hero_" + db_name + " where USER_STUDENT_NO='" + numberbox.Text + "'";
            hero_api ha2 = new hero_api();
            var ss_sql = ha2.getRecord(selectsql);

            if (ss_sql.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            disablebutton(false);
            modecheck = "insert";
        }
        public void resetTextbox()
        {
            numberbox.Text = "";
            namebox.Text = "";
            birthbox.Text = "";
            sexbox.Text = "";
            phonebox.Text = "";
            mailbox.Text = "";
            addrbox.Text = "";
        }

        public void disablebutton(bool check)
        {
            if (!groupBox1.Enabled == false)
            {
                insertbutton.Enabled = check;
                updatebutton.Enabled = check;
                deletebutton.Enabled = check;
                if (check == false)
                {
                    savebutton.Enabled = true;
                    cancelbutton.Enabled = true;
                    sexbox.Text = "1"; // 입력이 안됨;
                    if(modecheck == "delete")
                    {
                        namebox.Enabled = false;
                        birthbox.Enabled = false;
                        man.Enabled = false;
                        girl.Enabled = false;
                        phonebox.Enabled = false;
                        mailbox.Enabled = false;
                        addrbox.Enabled = false;
                    }
                    else
                    {
                        namebox.Enabled = true;
                        birthbox.Enabled = true;
                        man.Enabled = true;
                        girl.Enabled = true;
                        phonebox.Enabled = true;
                        mailbox.Enabled = true;
                        addrbox.Enabled = true;
                    }
                }
                else
                {
                    savebutton.Enabled = false;
                    cancelbutton.Enabled = false;
                }
            }
            else
            {
                groupBox1.Enabled = true;
            }
            label9.Text = modecheck;
        }

        public int textboxcheck()
        {
            if(modecheck != "delete")
            {
                if (numberbox.Text == "")
                {
                    MessageBox.Show("학번을 입력해주세요");
                    return 1;
                }
                else if (namebox.Text == "")
                {
                    MessageBox.Show("이름을 입력해주세요");
                    return 1;
                }
                else if (birthbox.Text == "")
                {
                    MessageBox.Show("생일을 입력해주세요");
                    return 1;
                }
                else if (sexbox.Text == "")
                {
                    MessageBox.Show("성별을 입력해주세요");
                    return 1;
                }
                else if (phonebox.Text == "")
                {
                    MessageBox.Show("휴대폰 번호를 입력해주세요");
                    return 1;
                }
                else if (addrbox.Text == "")
                {
                    MessageBox.Show("주소를 입력해주세요");
                    return 1;
                }
                else if (pickbox.Text == "")
                {
                    MessageBox.Show("이미지를 삽입해주세요");
                    return 1;
                }
            }

            return 0;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            savebutton.Enabled = false;
            cancelbutton.Enabled = false;
            SetupDataGridView();

            String check = "select * from hero_table_nickname";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);
            comboBox1.Items.Clear();
            while (sqlc.Read())
            {
                comboBox1.Items.Add(sqlc[1].ToString());
            }
            if (comboBox1.Text == "")
            {
                groupBox2.Enabled = false;
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            disablebutton(true);
            resetTextbox();
            modecheck = "null";
            textboxON();
            pictureBox1.Image = null;
        }

        public void textboxON()
        {
            namebox.Enabled = true;
            birthbox.Enabled = true;
            man.Enabled = true;
            girl.Enabled = true;
            phonebox.Enabled = true;
            mailbox.Enabled = true;
            addrbox.Enabled = true;
        }
        private void Updatebutton_Click(object sender, EventArgs e)
        {
            disablebutton(false);
            modecheck = "update";
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            disablebutton(false);
            modecheck = "delete";
        }

        private void Insertbutton_MouseClick(object sender, MouseEventArgs e)
        {
            disablebutton(false);
        }

        private void Man_CheckedChanged(object sender, EventArgs e)
        {
            sexbox.Text = "1";
        }

        private void Girl_CheckedChanged(object sender, EventArgs e)
        {
            sexbox.Text = "2";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog f1 = new OpenFileDialog();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                if(pictureBox1.Image != null) pictureBox1.Image.Dispose();

                String fname;
                imgname.Text = f1.FileName;
                pictureBox1.Image = System.Drawing.Image.FromFile(f1.FileName);
                fname = Path.GetFileName(f1.FileName);
                fname = numberbox.Text + fname.Substring(fname.LastIndexOf('.'));
                pickbox.Text = fname;

                pictureBox1.Image.Save(pickbox.Text);
                sftp_upload(pickbox.Text);
            }
        }

        private void Deletebutton_MouseClick(object sender, MouseEventArgs e)
        {
            disablebutton(false);
            modecheck = "delete";
        }

        private void Updatebutton_MouseClick(object sender, MouseEventArgs e)
        {
            disablebutton(false);
            modecheck = "update";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String sql1 = "select * from hero_"+db_name+" where USER_STUDENT_NO ='" + searchbox.Text+"'";
            cmd = new MySqlCommand(sql1, conn);
            if (searchbox.Text == "") return;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] row = { reader["USER_STUDENT_NO"].ToString(), reader["USER_NAME"].ToString(), reader["USER_BIRTH"].ToString(), reader["USER_SEX"].ToString(), reader["USER_PHONE"].ToString(), reader["USER_MAIL"].ToString(), reader["USER_ADDR"].ToString(), reader["USER_IMAGE"].ToString(), reader["USER_SYS"].ToString() };
                dataGridView1.Rows.Add(row);
            }
            reader.Close();
        }

        public void selectupdate()
        {
            String selectsql = "select * from hero_table_nickname";
            hero_api ha2 = new hero_api();
            var ss_sql = ha2.getRecord(selectsql);

            if (comboBox1.Text == "" || db_name == "" || db_nickname == "")
            {
                MessageBox.Show("테이블을 정해주세요");
                return;
            }
            else
            {
                dataGridView1.Rows.Clear();
                String sql1 = "select * from hero_" + db_name;
                cmd = new MySqlCommand(sql1, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] row = { reader["USER_STUDENT_NO"].ToString(), reader["USER_NAME"].ToString(), reader["USER_BIRTH"].ToString(), reader["USER_SEX"].ToString(), reader["USER_PHONE"].ToString(), reader["USER_MAIL"].ToString(), reader["USER_ADDR"].ToString(), reader["USER_IMAGE"].ToString(), reader["USER_SYS"].ToString() };
                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            selectupdate();
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int asd = int.Parse(e.RowIndex.ToString());
            if (asd < 0) return;
            numberbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            namebox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            birthbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            if (sexbox.Text == "1")
            {
                man.Checked = true;
            }
            else
            {
                girl.Checked = true;
            }
            sexbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            phonebox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            mailbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
            addrbox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].FormattedValue.ToString();
            pickbox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].FormattedValue.ToString();

            // ftp 주소로 불러와서 로컬에 다운로드 후 불러오는건데
            // 비효율적인거 같음 바로 불러올수는 없나? sftp에서

            var connectionInfo_pw = new Renci.SshNet.PasswordConnectionInfo("l.bsks.ac.kr", "p201606010", "pp201606010");
            var client = new SftpClient(connectionInfo_pw);
            client.Connect();
            string serverPath = string.Format(@"/home/p201606010/public_html/hero_php/img/"+db_name+"/"+pickbox.Text);
            using (var file = File.OpenWrite(pickbox.Text))
            {
                client.DownloadFile(serverPath, file);
            }
            
            pictureBox1.Image = System.Drawing.Image.FromFile(pickbox.Text);
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

        private void 관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form = new Form5();
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            db_nickname = comboBox1.Text;
            String check = "select tablename from hero_table_nickname where tablenickname='" + comboBox1.Text + "'";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);
            while (sqlc.Read())
            {
                db_name = sqlc["tablename"].ToString();
            }
            if (comboBox1.Text != "")
            {
                groupBox2.Enabled = true;
            }
            selectupdate();
        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            /*
            string s2 = "@", s1 = "#";
            bool a, b;
            a = searchbox.Text.Contains(s1);
            b = searchbox.Text.Contains(s2);

            if (b || a)
            {
               MessageBox.Show("금지된 단어가 있습니다.");
                searchbox.Text = "";
                return;
            }
            */
        }

        private void 학생관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 학생ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form = new Form6();
            form.Show();
        }

        private void 출석부관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
