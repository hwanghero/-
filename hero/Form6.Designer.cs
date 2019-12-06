namespace hero
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
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
            this.delete_b = new System.Windows.Forms.Button();
            this.search_b = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.update_b = new System.Windows.Forms.Button();
            this.studentbox = new System.Windows.Forms.TextBox();
            this.idbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(760, 24);
            this.menuStrip1.TabIndex = 21;
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
            this.dataGridView1.Location = new System.Drawing.Point(23, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(760, 310);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // delete_b
            // 
            this.delete_b.BackColor = System.Drawing.Color.LightGray;
            this.delete_b.FlatAppearance.BorderSize = 0;
            this.delete_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_b.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.delete_b.Location = new System.Drawing.Point(585, 126);
            this.delete_b.Name = "delete_b";
            this.delete_b.Size = new System.Drawing.Size(75, 23);
            this.delete_b.TabIndex = 23;
            this.delete_b.Text = "강제탈퇴";
            this.delete_b.UseVisualStyleBackColor = false;
            this.delete_b.Click += new System.EventHandler(this.delete_b_Click);
            // 
            // search_b
            // 
            this.search_b.BackColor = System.Drawing.Color.LightGray;
            this.search_b.FlatAppearance.BorderSize = 0;
            this.search_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_b.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search_b.Location = new System.Drawing.Point(196, 127);
            this.search_b.Name = "search_b";
            this.search_b.Size = new System.Drawing.Size(80, 23);
            this.search_b.TabIndex = 25;
            this.search_b.Text = "찾기";
            this.search_b.UseVisualStyleBackColor = false;
            this.search_b.Click += new System.EventHandler(this.search_b_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(196, 97);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 23);
            this.textBox1.TabIndex = 26;
            // 
            // update_b
            // 
            this.update_b.BackColor = System.Drawing.Color.LightGray;
            this.update_b.FlatAppearance.BorderSize = 0;
            this.update_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_b.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.update_b.Location = new System.Drawing.Point(585, 96);
            this.update_b.Name = "update_b";
            this.update_b.Size = new System.Drawing.Size(75, 23);
            this.update_b.TabIndex = 27;
            this.update_b.Text = "정보수정";
            this.update_b.UseVisualStyleBackColor = false;
            this.update_b.Click += new System.EventHandler(this.update_b_Click);
            // 
            // studentbox
            // 
            this.studentbox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.studentbox.Location = new System.Drawing.Point(438, 97);
            this.studentbox.Name = "studentbox";
            this.studentbox.ReadOnly = true;
            this.studentbox.Size = new System.Drawing.Size(141, 23);
            this.studentbox.TabIndex = 28;
            // 
            // idbox
            // 
            this.idbox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idbox.Location = new System.Drawing.Point(438, 126);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(141, 23);
            this.idbox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(405, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "학번";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(393, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "아이디";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(282, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "전체조회";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.studentbox);
            this.Controls.Add(this.update_b);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.search_b);
            this.Controls.Add(this.delete_b);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "유저관리";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form6_Load);
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
        private System.Windows.Forms.Button delete_b;
        private System.Windows.Forms.Button search_b;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button update_b;
        private System.Windows.Forms.TextBox studentbox;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}