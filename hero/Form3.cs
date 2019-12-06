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
    public partial class Form3 : MetroForm
    {
        /*
            날짜 별로 검색 기능 추가하기
            출근이 있는데 안찍고 갔을경우 정상퇴근으로 처리: 관리자 수정 시스템
        */

        private static string mysql_str = "server=l.bsks.ac.kr; port=3306; Database=p201606010; Uid=p201606010; Pwd=pp201606010; Charset=utf8; allow user variables=true;";
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand cmd;
        MySqlDataReader reader;
        string db_nickname, db_name;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            conn.Open();
            SetupDataGridView();

            String check = "select * from hero_table_nickname";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);
            comboBox1.Items.Clear();
            while (sqlc.Read())
            {
                comboBox1.Items.Add(sqlc[1].ToString());
            }

            if(comboBox1.Text == "")
            {
                groupBox2.Enabled = false;
            }
        }

        public void SetupDataGridView()
        {
            this.Controls.Add(dataGridView1);
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "근무일자";
            dataGridView1.Columns[1].Name = "학번";
            dataGridView1.Columns[2].Name = "출근시간";
            dataGridView1.Columns[3].Name = "퇴근시간";
            dataGridView1.Columns[4].Name = "구분";
            dataGridView1.Columns[5].Name = "지각한 시간";
        }

        /*************************
       
            출근

        ************************/

        private void button2_Click_1(object sender, EventArgs e)
        {
            int yyyy = int.Parse(DateTime.Now.ToString("yyyy"));
            int mm = int.Parse(DateTime.Now.ToString("MM"));
            int dd = int.Parse(DateTime.Now.ToString("dd"));

            String check = "select * from hero_work where USER_STUDENT_NO ='" + studentbox.Text + "' and DILI_DATE = '"+ yyyy.ToString() + "-" + mm.ToString() + "-" + dd.ToString()+"'";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);

            String admincheck = "select * from hero_"+db_name+" where USER_STUDENT_NO ='" + studentbox.Text + "' and ADMIN_CHECK = 1";
            var admin_sqlc = ha.getRecord(admincheck);

            cmd = new MySqlCommand();
            cmd.Connection = conn;

            if (admin_sqlc.Read())
            {
                if (!sqlc.Read())
                {
                    cmd.CommandText = "insert into hero_work(DILI_DATE, USER_STUDENT_NO, DILI_FTIME, USER_TABLE) values(@a1, @a2, @a3, @a4)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@a1", yyyy.ToString() + "-" + mm.ToString() + "-" + dd.ToString());
                    cmd.Parameters.AddWithValue("@a2", studentbox.Text);
                    cmd.Parameters.AddWithValue("@a3", DateTime.Now.ToString("HH-mm-ss"));
                    cmd.Parameters.AddWithValue("@a4", db_name);
                    cmd.ExecuteNonQuery();

                    // 9시가 지났는지 확인 -> 지각체크
                    DateTime nowtime = DateTime.Now;
                    DateTime timecheck = new DateTime(yyyy, mm, dd, 9, 0, 0);
                    int timeresult = DateTime.Compare(nowtime, timecheck);
                    String gubunupdate;

                    // 지각 체크
                    if (timeresult > 0)
                    {
                        TimeSpan result = nowtime - timecheck;
                        gubunupdate = "update hero_work set DILI_gubun = '2', DILI_tardy = '"+ result.ToString(@"hh\:mm\:ss")+ "' where USER_STUDENT_NO='" + studentbox.Text + "' and DILI_DATE = '" + yyyy.ToString() + "-" + mm.ToString() + "-" + dd.ToString() + "'";
                        MessageBox.Show("9시 지났다. (지각: "+ result.ToString(@"hh\:mm\:ss")+ ")");
                    }
                    else
                    {
                        gubunupdate = "update hero_work set DILI_gubun=0 where USER_STUDENT_NO='" + studentbox.Text + "'";
                        MessageBox.Show("9시 안지났다.");
                    }
                    hero_api ha2 = new hero_api();
                    var gubunsql = ha.getRecord(gubunupdate);
                    outcheck(); // 전날 결근 확인
                    MessageBox.Show("출근완료");
                    selectupdate();
                }
                else
                {
                    MessageBox.Show("이미 출근하였습니다.\n일자: " + sqlc["DILI_DATE"].ToString() + "\n학번: " + sqlc["USER_STUDENT_NO"].ToString() + "\n출근일자: " + sqlc["DILI_FTIME"].ToString() + "\n출근상태: " + sqlc["DILI_GUBUN"].ToString());

                }
                return;
            }
            else
            {
                MessageBox.Show("admin check no or not find student id");
            }

        }

        public string yyyymmdd()
        {
            int yyyy = int.Parse(DateTime.Now.ToString("yyyy"));
            int mm = int.Parse(DateTime.Now.ToString("MM"));
            int dd = int.Parse(DateTime.Now.ToString("dd"));
            string ymd = yyyy.ToString() + "-" + mm.ToString() + "-" + dd.ToString();
            return ymd;
        }

        private string GetDay(DateTime dt)
        {
            String strday = "";
            switch (dt.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    strday = "월";
                    break;
                case DayOfWeek.Tuesday:
                    strday = "화";
                    break;
                case DayOfWeek.Wednesday:
                    strday = "수";
                    break;
                case DayOfWeek.Thursday:
                    strday = "목";
                    break;
                case DayOfWeek.Friday:
                    strday = "금";
                    break;
                case DayOfWeek.Saturday:
                    strday = "토";
                    break;
                case DayOfWeek.Sunday:
                    strday = "일";
                    break;
            }
            return strday;
        }

        /*************************
         
            퇴근

         ************************/

        private void button3_Click(object sender, EventArgs e)
        {
            string now = yyyymmdd();

            String check = "select * from hero_work where DILI_DATE = '" + now + "' and USER_STUDENT_NO='" + studentbox.Text + "'";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);

            cmd = new MySqlCommand();
            cmd.Connection = conn;

            string hourt = DateTime.Now.ToString("HH-mm-ss");

            if (sqlc.Read())
            {
                if(sqlc["DILI_TTIME"].ToString() == "")
                {
                    String runhome = "update hero_work set DILI_TTIME='" + hourt + "' where DILI_DATE = '" + now + "' and USER_STUDENT_NO='" + studentbox.Text + "'";
                    var runhomecheck = ha.getRecord(runhome);
                    int yyyy = int.Parse(DateTime.Now.ToString("yyyy"));
                    int mm = int.Parse(DateTime.Now.ToString("MM"));
                    int dd = int.Parse(DateTime.Now.ToString("dd"));

                    // 18시가 지났는지 확인 -> 조퇴체크
                    DateTime nowtime = DateTime.Now;
                    DateTime timecheck = new DateTime(yyyy, mm, dd, 18, 0, 0);
                    int timeresult = DateTime.Compare(nowtime, timecheck);

                    // 조퇴 체크
                    if (timeresult < 0)
                    {
                        String gubunupdate;
                        if (sqlc["DILI_GUBUN"].ToString() == "2")
                        {
                            MessageBox.Show("지각도 하고 조퇴도함");
                            String gubunupdate2 = "update hero_work set DILI_GUBUN=4 where DILI_DATE = '" + now + "' and USER_STUDENT_NO='" + studentbox.Text + "'";
                            var runhomecheck3 = ha.getRecord(gubunupdate2);
                        }
                        else
                        {
                            gubunupdate = "update hero_work set DILI_GUBUN=3 where DILI_DATE = '" + now + "' and USER_STUDENT_NO='" + studentbox.Text + "'";
                            MessageBox.Show("18시 안지났다.");
                            var runhomecheck2 = ha.getRecord(gubunupdate);
                        }

                    }
                    MessageBox.Show("퇴근");
                    selectupdate();
                }
                else
                {
                    MessageBox.Show("이미 퇴근하였습니다.\n일자: " + sqlc["DILI_DATE"].ToString() + "\n학번: " + sqlc["USER_STUDENT_NO"].ToString() + "\n퇴근일자: " + sqlc["DILI_TTIME"].ToString() + "\n출근상태: " + sqlc["DILI_GUBUN"].ToString());
                }
            }
        }

        /*************************
         
            특정학생 전날 결근체크
            (바코드를 찍었을경우)

         ************************/
        
        public void outcheck()
        {
            int yyyy = int.Parse(DateTime.Now.ToString("yyyy"));
            int mm = int.Parse(DateTime.Now.ToString("MM"));
            int dd = int.Parse(DateTime.Now.ToString("dd")) - 1;
            int hh = int.Parse(DateTime.Now.ToString("HH"));
            int mm2 = int.Parse(DateTime.Now.ToString("mm"));
            int ss = int.Parse(DateTime.Now.ToString("ss"));
            string now_m = yyyy.ToString() + "-" + mm.ToString() + "-" + dd.ToString();

            String check = "select * from hero_work where DILI_DATE = '" + now_m + "' and USER_STUDENT_NO='" + studentbox.Text + "'";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);

            MessageBox.Show(now_m);

            if (sqlc.Read())
            {
                MessageBox.Show("이미 결근을 확인했습니다.");
            }
            else
            {
                String idcheck_sql = "select * from hero_"+ db_name + " where USER_STUDENT_NO='" + studentbox.Text + "'";
                cmd = new MySqlCommand(idcheck_sql, conn);
                reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    MessageBox.Show("없는 학생입니다");
                    reader.Close();
                    return;
                }
                else
                {
                    reader.Close();
                    cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    
                    String daycheck = GetDay(DateTime.Now);
                    if (daycheck == "일" || daycheck == "토")
                    {
                        MessageBox.Show("주말");
                        return;
                    }
                    cmd.CommandText = "insert into hero_work(DILI_DATE, USER_STUDENT_NO, DILI_GUBUN, USER_TABLE) values(@a1, @a2, @a3, @a4)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@a1", now_m);
                    cmd.Parameters.AddWithValue("@a2", studentbox.Text);
                    cmd.Parameters.AddWithValue("@a3", 1);
                    cmd.Parameters.AddWithValue("@a4", db_name);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("전날 결근 확인");
                }
            }
        }
   
        public void selectupdate()
        {
            dataGridView1.Rows.Clear();
            String sql1 = "select * from hero_work where USER_TABLE='"+db_name+"'";
            cmd = new MySqlCommand(sql1, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] row = { reader["DILI_DATE"].ToString(), reader["USER_STUDENT_NO"].ToString(), reader["DILI_FTIME"].ToString(), reader["DILI_TTIME"].ToString(), reader["DILI_GUBUN"].ToString(), reader["DILI_TARDY"].ToString() };
                dataGridView1.Rows.Add(row);
            }
            reader.Close();
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            selectupdate();
        }

        /*************************
         
            날짜 결근 체크
            >> 오늘날짜 기준으로 전만 결근체크

         ************************/

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime dt_daycheck = dateTimePicker1.Value;
            DateTime dt = dateTimePicker1.Value;
            DateTime dt2 = dateTimePicker2.Value;
            int yy = int.Parse(dt.Year.ToString());
            int mm = int.Parse(dt.Month.ToString());
            int dd = int.Parse(dt.Day.ToString());
            int dd2 = int.Parse(dt2.Day.ToString());

            int ddcheck = 0, ddbox = 0;

            if (dd2 == dd)
            {
                ddcheck = 1;
                MessageBox.Show("=");
            }
            else if (dd2 > dd)
            {
                ddcheck = dd2 - dd + 1;
            }
            else
            {
                MessageBox.Show("제대로");
            }

            listBox1.Items.Clear();

            for (int i = 0; i < ddcheck; i++)
            {
                int ddfor = int.Parse(dt.Day.ToString()) + ddbox;
                string yymmdd = yy + "-" + mm + "-" + ddfor;
                DateTime answer = dt_daycheck.AddDays(ddbox);
                String daycheck = GetDay(answer);
                ddbox++;

                if (daycheck == "일" || daycheck == "토")
                {
                    MessageBox.Show("주말 " + answer.ToString());
                }
                else
                {
                    String check = "select * from hero_" + db_name + " hero left join hero_work on hero.USER_STUDENT_NO = hero_work.USER_STUDENT_NO and DILI_DATE like '" + yymmdd + "'";
                    hero_api ha = new hero_api();
                    var sqlc = ha.getRecord(check);
                    while (sqlc.Read())
                    {
                        if (sqlc["DILI_DATE"].ToString() == "")
                        {
                            listBox1.Items.Add(yymmdd + " ID: " + sqlc[0].ToString());

                            cmd = new MySqlCommand();
                            cmd.Connection = conn;
                            cmd.CommandText = "insert into hero_work(DILI_DATE, USER_STUDENT_NO, DILI_GUBUN, USER_TABLE) values(@a1, @a2, @a3, @a4)";
                            cmd.Prepare();
                            cmd.Parameters.AddWithValue("@a1", yymmdd);
                            cmd.Parameters.AddWithValue("@a2", sqlc[0].ToString());
                            cmd.Parameters.AddWithValue("@a3", 1);
                            cmd.Parameters.AddWithValue("@a4", db_name);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String sql1 = "select * from hero_work where USER_STUDENT_NO = '" + studentbox.Text+"'";
            cmd = new MySqlCommand(sql1, conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] row = { reader["DILI_DATE"].ToString(), reader["USER_STUDENT_NO"].ToString(), reader["DILI_FTIME"].ToString(), reader["DILI_TTIME"].ToString(), reader["DILI_GUBUN"].ToString() };
                dataGridView1.Rows.Add(row);
            }
            reader.Close();
        }

        private void 학생ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form = new Form6();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        /*************************

           월별검색

        ************************/

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string getmonth = dateTimePicker3.Value.ToString("MM");
            String check = "select * from hero_work where USER_TABLE='" + db_name + "'";
            hero_api ha = new hero_api();
            var sqlc = ha.getRecord(check);
            while (sqlc.Read())
            {
                string[] month = sqlc["DILI_DATE"].ToString().Split('-');
                if (getmonth.Contains(month[1]))
                {
                    string[] row = { sqlc["DILI_DATE"].ToString(), sqlc["USER_STUDENT_NO"].ToString(), sqlc["DILI_FTIME"].ToString(), sqlc["DILI_TTIME"].ToString(), sqlc["DILI_GUBUN"].ToString(), sqlc["DILI_TARDY"].ToString() };
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void 학생관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.Show();
        }

        private void 출석부ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form = new Form7();
            form.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            //폼 중복 열기 방지
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm.Name == "Form8") // 열린 폼의 이름 검사
                {
                    if (openForm.WindowState == FormWindowState.Minimized)
                    {  // 폼을 최소화시켜 하단에 내려놓았는지 검사
                        openForm.WindowState = FormWindowState.Normal;

                        openForm.Location = new Point(this.Location.X + this.Width, this.Location.Y);

                    }
                    openForm.Activate();
                    return;
                }
            }
            Form8 wb = new Form8();  // 폼이 실행되지 않았으면 New Form 객체 생성
            wb.setdata(dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
            wb.setdbname(db_name);
            wb.StartPosition = FormStartPosition.Manual;  // 원하는 위치를 직접 지정해서 띄우기 위해
            wb.Location = new Point(this.Location.X + this.Width, this.Location.Y); // 메인폼의 오른쪽에 위치토록
            wb.Show();
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
            if(comboBox1.Text != "")
            {
                groupBox2.Enabled = true;
            }
        }
    }
}
