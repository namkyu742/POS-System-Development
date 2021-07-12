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
    public partial class _08_Change_Password : Form
    {
        public _02_Management_mode Indicator_MM;   // 상위 윈도우 지정
        public _08_Change_Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 변경 완료하고 관리자 모드로 돌아감
            Indicator_MM.indicator_MW.password = this.textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 설정을 변경하지 않고 관리자 모드로 돌아감
            this.Close();
        }
    }
}
