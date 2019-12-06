namespace hero
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.numberbox = new System.Windows.Forms.TextBox();
            this.insertbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updatebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pickbox = new System.Windows.Forms.TextBox();
            this.sexbox = new System.Windows.Forms.TextBox();
            this.girl = new System.Windows.Forms.RadioButton();
            this.man = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addrbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mailbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phonebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.birthbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.학생ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출석부ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.현장실습ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.오픈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.학생관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출석부관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "학번";
            // 
            // numberbox
            // 
            this.numberbox.Location = new System.Drawing.Point(78, 20);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(100, 21);
            this.numberbox.TabIndex = 1;
            // 
            // insertbutton
            // 
            this.insertbutton.BackColor = System.Drawing.Color.LightGray;
            this.insertbutton.FlatAppearance.BorderSize = 0;
            this.insertbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertbutton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.insertbutton.Location = new System.Drawing.Point(418, 20);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(75, 23);
            this.insertbutton.TabIndex = 2;
            this.insertbutton.Text = "추가";
            this.insertbutton.UseVisualStyleBackColor = false;
            this.insertbutton.Click += new System.EventHandler(this.Button1_Click);
            this.insertbutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Insertbutton_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(24, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(443, 262);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseClick);
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.LightGray;
            this.updatebutton.FlatAppearance.BorderSize = 0;
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.updatebutton.Location = new System.Drawing.Point(500, 20);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 4;
            this.updatebutton.Text = "수정";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            this.updatebutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Updatebutton_MouseClick);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.LightGray;
            this.deletebutton.FlatAppearance.BorderSize = 0;
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deletebutton.Location = new System.Drawing.Point(581, 20);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 5;
            this.deletebutton.Text = "삭제";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            this.deletebutton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Deletebutton_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imgname);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pickbox);
            this.groupBox1.Controls.Add(this.sexbox);
            this.groupBox1.Controls.Add(this.girl);
            this.groupBox1.Controls.Add(this.man);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.addrbox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mailbox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.phonebox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.birthbox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.namebox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numberbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(473, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 269);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // imgname
            // 
            this.imgname.Location = new System.Drawing.Point(193, 194);
            this.imgname.Name = "imgname";
            this.imgname.ReadOnly = true;
            this.imgname.Size = new System.Drawing.Size(223, 21);
            this.imgname.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(200, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "label9";
            // 
            // pickbox
            // 
            this.pickbox.Location = new System.Drawing.Point(359, 275);
            this.pickbox.Name = "pickbox";
            this.pickbox.Size = new System.Drawing.Size(100, 21);
            this.pickbox.TabIndex = 17;
            // 
            // sexbox
            // 
            this.sexbox.Location = new System.Drawing.Point(253, 275);
            this.sexbox.Name = "sexbox";
            this.sexbox.Size = new System.Drawing.Size(100, 21);
            this.sexbox.TabIndex = 16;
            this.sexbox.Text = "성별체크";
            this.sexbox.Visible = false;
            // 
            // girl
            // 
            this.girl.AutoSize = true;
            this.girl.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.girl.Location = new System.Drawing.Point(139, 102);
            this.girl.Name = "girl";
            this.girl.Size = new System.Drawing.Size(37, 19);
            this.girl.TabIndex = 15;
            this.girl.Text = "여";
            this.girl.UseVisualStyleBackColor = true;
            this.girl.CheckedChanged += new System.EventHandler(this.Girl_CheckedChanged);
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Checked = true;
            this.man.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.man.Location = new System.Drawing.Point(78, 102);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(37, 19);
            this.man.TabIndex = 14;
            this.man.TabStop = true;
            this.man.Text = "남";
            this.man.UseVisualStyleBackColor = true;
            this.man.CheckedChanged += new System.EventHandler(this.Man_CheckedChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gainsboro;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(193, 221);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(223, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "가져오기";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(193, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // addrbox
            // 
            this.addrbox.Location = new System.Drawing.Point(78, 182);
            this.addrbox.Name = "addrbox";
            this.addrbox.Size = new System.Drawing.Size(100, 21);
            this.addrbox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(18, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "주소";
            // 
            // mailbox
            // 
            this.mailbox.Location = new System.Drawing.Point(78, 155);
            this.mailbox.Name = "mailbox";
            this.mailbox.Size = new System.Drawing.Size(100, 21);
            this.mailbox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(18, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "메일";
            // 
            // phonebox
            // 
            this.phonebox.Location = new System.Drawing.Point(78, 128);
            this.phonebox.Name = "phonebox";
            this.phonebox.Size = new System.Drawing.Size(100, 21);
            this.phonebox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(18, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "휴대폰";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(18, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "성별";
            // 
            // birthbox
            // 
            this.birthbox.Location = new System.Drawing.Point(78, 74);
            this.birthbox.Name = "birthbox";
            this.birthbox.Size = new System.Drawing.Size(100, 21);
            this.birthbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "생년월일";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(78, 47);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(100, 21);
            this.namebox.TabIndex = 3;
            this.namebox.TextChanged += new System.EventHandler(this.namebox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "이름";
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.LightGray;
            this.savebutton.FlatAppearance.BorderSize = 0;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.savebutton.ForeColor = System.Drawing.Color.Black;
            this.savebutton.Location = new System.Drawing.Point(662, 20);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 7;
            this.savebutton.Text = "저장";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // searchbox
            // 
            this.searchbox.Location = new System.Drawing.Point(232, 20);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(165, 21);
            this.searchbox.TabIndex = 15;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gainsboro;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(80, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "검색";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.BackColor = System.Drawing.Color.LightGray;
            this.cancelbutton.FlatAppearance.BorderSize = 0;
            this.cancelbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbutton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cancelbutton.ForeColor = System.Drawing.Color.Black;
            this.cancelbutton.Location = new System.Drawing.Point(743, 20);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.cancelbutton.TabIndex = 17;
            this.cancelbutton.Text = "취소";
            this.cancelbutton.UseVisualStyleBackColor = false;
            this.cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(145, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "전체 검색";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.현장실습ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.학생ToolStripMenuItem,
            this.출석부ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 20);
            this.toolStripMenuItem1.Text = "관리목록";
            // 
            // 학생ToolStripMenuItem
            // 
            this.학생ToolStripMenuItem.Name = "학생ToolStripMenuItem";
            this.학생ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.학생ToolStripMenuItem.Text = "유저관리";
            this.학생ToolStripMenuItem.Click += new System.EventHandler(this.학생ToolStripMenuItem_Click);
            // 
            // 출석부ToolStripMenuItem
            // 
            this.출석부ToolStripMenuItem.Name = "출석부ToolStripMenuItem";
            this.출석부ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.출석부ToolStripMenuItem.Text = "관리자설정";
            this.출석부ToolStripMenuItem.Click += new System.EventHandler(this.출석부ToolStripMenuItem_Click);
            // 
            // 현장실습ToolStripMenuItem
            // 
            this.현장실습ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.오픈ToolStripMenuItem,
            this.관리ToolStripMenuItem,
            this.학생관리ToolStripMenuItem,
            this.출석부관리ToolStripMenuItem});
            this.현장실습ToolStripMenuItem.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.현장실습ToolStripMenuItem.Name = "현장실습ToolStripMenuItem";
            this.현장실습ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.현장실습ToolStripMenuItem.Text = "현장실습";
            // 
            // 오픈ToolStripMenuItem
            // 
            this.오픈ToolStripMenuItem.Name = "오픈ToolStripMenuItem";
            this.오픈ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.오픈ToolStripMenuItem.Text = "생성/삭제";
            this.오픈ToolStripMenuItem.Click += new System.EventHandler(this.오픈ToolStripMenuItem_Click);
            // 
            // 관리ToolStripMenuItem
            // 
            this.관리ToolStripMenuItem.Name = "관리ToolStripMenuItem";
            this.관리ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.관리ToolStripMenuItem.Text = "승인관리";
            this.관리ToolStripMenuItem.Click += new System.EventHandler(this.관리ToolStripMenuItem_Click);
            // 
            // 학생관리ToolStripMenuItem
            // 
            this.학생관리ToolStripMenuItem.Name = "학생관리ToolStripMenuItem";
            this.학생관리ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.학생관리ToolStripMenuItem.Text = "학생관리";
            this.학생관리ToolStripMenuItem.Click += new System.EventHandler(this.학생관리ToolStripMenuItem_Click);
            // 
            // 출석부관리ToolStripMenuItem
            // 
            this.출석부관리ToolStripMenuItem.Name = "출석부관리ToolStripMenuItem";
            this.출석부관리ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.출석부관리ToolStripMenuItem.Text = "출석부관리";
            this.출석부관리ToolStripMenuItem.Click += new System.EventHandler(this.출석부관리ToolStripMenuItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBox1.Location = new System.Drawing.Point(94, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 29);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(20, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "실습 선택";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.insertbutton);
            this.groupBox2.Controls.Add(this.updatebutton);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.deletebutton);
            this.groupBox2.Controls.Add(this.cancelbutton);
            this.groupBox2.Controls.Add(this.savebutton);
            this.groupBox2.Controls.Add(this.searchbox);
            this.groupBox2.Location = new System.Drawing.Point(23, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(883, 53);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 472);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "현장실습 학생관리";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberbox;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox birthbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox addrbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mailbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phonebox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.RadioButton girl;
        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.TextBox sexbox;
        private System.Windows.Forms.TextBox pickbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox imgname;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 학생ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출석부ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 현장실습ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 오픈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관리ToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem 학생관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출석부관리ToolStripMenuItem;
    }
}