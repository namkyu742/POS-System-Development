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
    public partial class _04_Change_Tablenum : Form
    {
        public _02_Management_mode Indicator_MM;    // 상위 윈도우 지정
        public _04_Change_Tablenum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 설정을 변경하고 관리자 모드로 돌아감
            Indicator_MM.indicator_MW.tablenum = (int)numericUpDown1.Value;

            // --------------------------- 주문서 생성 -------------------------------
            Indicator_MM.indicator_MW.orders = new _01_Main_Window.order[Indicator_MM.indicator_MW.tablenum];
            for (int i = 0; i < Indicator_MM.indicator_MW.tablenum; i++)
            {
                Indicator_MM.indicator_MW.orders[i].name_p = new string[10];
                Indicator_MM.indicator_MW.orders[i].value_p = new int[10];
                Indicator_MM.indicator_MW.orders[i].index_o = 0;
            }   // 설정한 테이블 개수만큼 주문서를 새로 생성
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // 설정을 변경하지 않고 관리자 모드로 돌아감
            this.Close();
        }
    }
}
