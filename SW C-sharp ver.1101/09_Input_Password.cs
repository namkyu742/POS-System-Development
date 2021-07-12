using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SW_C_sharp_ver._1101
{
    public partial class _09_Input_Password : Form
    {
        public _01_Main_Window indicator_MW;   // 상위 윈도우 지정
        public _09_Input_Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.textBox1.Text == indicator_MW.password)
            {
                this.Close();
                _02_Management_mode management_mode = new _02_Management_mode();
                management_mode.Owner = indicator_MW;               // 부모->자식
                management_mode.indicator_MW = indicator_MW;        // 자식->부모
                management_mode.Show();
            }
            else
            {
                MessageBox.Show("잘못된 비밀번호입니다.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 메인 모드로 돌아감
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 입력창에서 엔터 누를 시 버튼1 클릭 이벤트 작동
            if(e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
}
