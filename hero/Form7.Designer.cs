namespace hero
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.학생ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출석부ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.현장실습ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.오픈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.학생관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.출석부관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.level_b = new System.Windows.Forms.Button();
            this.idbox = new System.Windows.Forms.TextBox();
            this.delete_b = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mylevel = new System.Windows.Forms.TextBox();
            this.pwbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.insert_b = new System.Windows.Forms.Button();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.현장실습ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 24);
            this.menuStrip1.TabIndex = 22;
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
            this.학생ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.학생ToolStripMenuItem.Text = "유저관리";
            this.학생ToolStripMenuItem.Click += new System.EventHandler(this.학생ToolStripMenuItem_Click);
            // 
            // 출석부ToolStripMenuItem
            // 
            this.출석부ToolStripMenuItem.Name = "출석부ToolStripMenuItem";
            this.출석부ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.출석부ToolStripMenuItem.Text = "관리자설정";
            // 
            // 현장실습ToolStripMenuItem
            // 
            this.현장실습ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.오픈ToolStripMenuItem,
            this.관리ToolStripMenuItem,
            this.학생관리ToolStripMenuItem,
            this.출석부관리ToolStripMenuItem});
            this.현장실습ToolStripMenuItem.Name = "현장실습ToolStripMenuItem";
            this.현장실습ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.현장실습ToolStripMenuItem.Text = "현장실습";
            // 
            // 오픈ToolStripMenuItem
            // 
            this.오픈ToolStripMenuItem.Name = "오픈ToolStripMenuItem";
            this.오픈ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.오픈ToolStripMenuItem.Text = "생성/삭제";
            this.오픈ToolStripMenuItem.Click += new System.EventHandler(this.오픈ToolStripMenuItem_Click_1);
            // 
            // 관리ToolStripMenuItem
            // 
            this.관리ToolStripMenuItem.Name = "관리ToolStripMenuItem";
            this.관리ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.관리ToolStripMenuItem.Text = "승인관리";
            this.관리ToolStripMenuItem.Click += new System.EventHandler(this.관리ToolStripMenuItem_Click_1);
            // 
            // 학생관리ToolStripMenuItem
            // 
            this.학생관리ToolStripMenuItem.Name = "학생관리ToolStripMenuItem";
            this.학생관리ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.학생관리ToolStripMenuItem.Text = "학생관리";
            this.학생관리ToolStripMenuItem.Click += new System.EventHandler(this.학생관리ToolStripMenuItem_Click_1);
            // 
            // 출석부관리ToolStripMenuItem
            // 
            this.출석부관리ToolStripMenuItem.Name = "출석부관리ToolStripMenuItem";
            this.출석부관리ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.출석부관리ToolStripMenuItem.Text = "출석부관리";
            this.출석부관리ToolStripMenuItem.Click += new System.EventHandler(this.출석부관리ToolStripMenuItem_Click_1);
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
            this.dataGridView1.Location = new System.Drawing.Point(20, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 148);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // level_b
            // 
            this.level_b.BackColor = System.Drawing.Color.LightGray;
            this.level_b.FlatAppearance.BorderSize = 0;
            this.level_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.level_b.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.level_b.Location = new System.Drawing.Point(592, 124);
            this.level_b.Name = "level_b";
            this.level_b.Size = new System.Drawing.Size(75, 23);
            this.level_b.TabIndex = 24;
            this.level_b.Text = "권한설정";
            this.level_b.UseVisualStyleBackColor = false;
            this.level_b.Click += new System.EventHandler(this.level_b_Click);
            // 
            // idbox
            // 
            this.idbox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idbox.Location = new System.Drawing.Point(301, 95);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(121, 23);
            this.idbox.TabIndex = 25;
            // 
            // delete_b
            // 
            this.delete_b.BackColor = System.Drawing.Color.LightGray;
            this.delete_b.FlatAppearance.BorderSize = 0;
            this.delete_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_b.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.delete_b.Location = new System.Drawing.Point(673, 95);
            this.delete_b.Name = "delete_b";
            this.delete_b.Size = new System.Drawing.Size(75, 23);
            this.delete_b.TabIndex = 26;
            this.delete_b.Text = "삭제";
            this.delete_b.UseVisualStyleBackColor = false;
            this.delete_b.Click += new System.EventHandler(this.delete_b_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "최고관리자",
            "관리자"});
            this.comboBox1.Location = new System.Drawing.Point(465, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(428, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "권한";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(25, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "내 권한";
            // 
            // mylevel
            // 
            this.mylevel.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mylevel.Location = new System.Drawing.Point(78, 95);
            this.mylevel.Name = "mylevel";
            this.mylevel.ReadOnly = true;
            this.mylevel.Size = new System.Drawing.Size(121, 23);
            this.mylevel.TabIndex = 31;
            // 
            // pwbox
            // 
            this.pwbox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pwbox.Location = new System.Drawing.Point(301, 124);
            this.pwbox.Name = "pwbox";
            this.pwbox.Size = new System.Drawing.Size(121, 23);
            this.pwbox.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(252, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "아이디";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(240, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "비밀번호";
            // 
            // insert_b
            // 
            this.insert_b.BackColor = System.Drawing.Color.LightGray;
            this.insert_b.FlatAppearance.BorderSize = 0;
            this.insert_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insert_b.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.insert_b.Location = new System.Drawing.Point(592, 95);
            this.insert_b.Name = "insert_b";
            this.insert_b.Size = new System.Drawing.Size(75, 23);
            this.insert_b.TabIndex = 36;
            this.insert_b.Text = "생성";
            this.insert_b.UseVisualStyleBackColor = false;
            this.insert_b.Click += new System.EventHandler(this.insert_b_Click);
            // 
            // namebox
            // 
            this.namebox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.namebox.Location = new System.Drawing.Point(465, 125);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(121, 23);
            this.namebox.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(428, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "이름";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 337);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.insert_b);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pwbox);
            this.Controls.Add(this.mylevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.delete_b);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.level_b);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.Flat;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "관리자설정";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form7_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 학생ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출석부ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 현장실습ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 오픈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 학생관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 출석부관리ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button level_b;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Button delete_b;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mylevel;
        private System.Windows.Forms.TextBox pwbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button insert_b;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.Label label1;
    }
}