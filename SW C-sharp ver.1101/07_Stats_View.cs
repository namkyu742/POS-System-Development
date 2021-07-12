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
    public partial class _07_Stats_View : Form
    {
        public _02_Management_mode Indicator_MM;   // 상위 윈도우 지정
        public _07_Stats_View()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //관리자 메뉴로
            this.Close();
        }

        private void _07_Stats_View_Load(object sender, EventArgs e)
        {
            // 윈도우 로드 시 통계자료 출력
            this.textBox1.Text = Indicator_MM.indicator_MW.amount.ToString();       // 총 매출액 출력

            this.textBox2.Text = "";                                        
            for(int i = 0; i< Indicator_MM.indicator_MW.index_p; i++)               // 상품별 매출량, 매출액 출력
            {
                this.textBox2.AppendText(Indicator_MM.indicator_MW.products[i].name);
                this.textBox2.AppendText("의 판매량 : ");
                this.textBox2.AppendText(Indicator_MM.indicator_MW.products[i].order_volume.ToString());
                this.textBox2.AppendText(" / 매출액 : ");
                this.textBox2.AppendText((Indicator_MM.indicator_MW.products[i].order_volume* Indicator_MM.indicator_MW.products[i].value).ToString());
                this.textBox2.AppendText("\r\n");
            }
        }
    }
}
