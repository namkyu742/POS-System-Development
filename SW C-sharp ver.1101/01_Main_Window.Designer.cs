namespace SW_C_sharp_ver._1101
{
    partial class _01_Main_Window
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.사용자모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.결제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.관리자모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사용자모드ToolStripMenuItem,
            this.관리자모드ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(517, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 사용자모드ToolStripMenuItem
            // 
            this.사용자모드ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주문추가ToolStripMenuItem,
            this.주문변경ToolStripMenuItem,
            this.주문삭제ToolStripMenuItem,
            this.결제ToolStripMenuItem});
            this.사용자모드ToolStripMenuItem.Name = "사용자모드ToolStripMenuItem";
            this.사용자모드ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.사용자모드ToolStripMenuItem.Text = "사용자 모드";
            // 
            // 주문추가ToolStripMenuItem
            // 
            this.주문추가ToolStripMenuItem.Name = "주문추가ToolStripMenuItem";
            this.주문추가ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.주문추가ToolStripMenuItem.Text = "주문 추가";
            this.주문추가ToolStripMenuItem.Click += new System.EventHandler(this.주문추가ToolStripMenuItem_Click);
            // 
            // 주문변경ToolStripMenuItem
            // 
            this.주문변경ToolStripMenuItem.Name = "주문변경ToolStripMenuItem";
            this.주문변경ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.주문변경ToolStripMenuItem.Text = "주문 변경";
            this.주문변경ToolStripMenuItem.Click += new System.EventHandler(this.주문변경ToolStripMenuItem_Click);
            // 
            // 주문삭제ToolStripMenuItem
            // 
            this.주문삭제ToolStripMenuItem.Name = "주문삭제ToolStripMenuItem";
            this.주문삭제ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.주문삭제ToolStripMenuItem.Text = "주문 삭제";
            this.주문삭제ToolStripMenuItem.Click += new System.EventHandler(this.주문삭제ToolStripMenuItem_Click);
            // 
            // 결제ToolStripMenuItem
            // 
            this.결제ToolStripMenuItem.Name = "결제ToolStripMenuItem";
            this.결제ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.결제ToolStripMenuItem.Text = "결제";
            this.결제ToolStripMenuItem.Click += new System.EventHandler(this.결제ToolStripMenuItem_Click);
            // 
            // 관리자모드ToolStripMenuItem
            // 
            this.관리자모드ToolStripMenuItem.Name = "관리자모드ToolStripMenuItem";
            this.관리자모드ToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.관리자모드ToolStripMenuItem.Text = "관리자 모드";
            this.관리자모드ToolStripMenuItem.Click += new System.EventHandler(this.관리자모드ToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 256);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(465, 165);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(465, 109);
            this.textBox1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(279, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "테이블 번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(21, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "주문 내역 보기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "알림창";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jo\'s Restaurant";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(370, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(120, 52);
            this.listBox1.TabIndex = 1;
            // 
            // _01_Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "_01_Main_Window";
            this.Text = "POS";
            this.Activated += new System.EventHandler(this._01_Main_Window_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this._01_Main_Window_FormClosing);
            this.Load += new System.EventHandler(this._01_Main_Window_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 사용자모드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문변경ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 결제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 관리자모드ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox listBox1;
    }
}

