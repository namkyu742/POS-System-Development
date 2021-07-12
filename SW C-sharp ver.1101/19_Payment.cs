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
    public partial class _19_Payment : Form
    {
        public int sum = 0;
        public _01_Main_Window Indicator_WM;   // 상위 윈도우 지정
        public _19_Payment()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // 영수증에 총액만 표시
            this.textBox1.Text = "";
            this.textBox1.AppendText("\r\n                       [영수증]\r\n\r\n");
            this.textBox1.AppendText("  [매장명] "+Indicator_WM.rest_name+ "\r\n");
            this.textBox1.AppendText("  [대표자] 조남규\r\n");
            this.textBox1.AppendText("  [매출일] "+DateTime.Now.ToString("yyyy-MM-dd")+" "+DateTime.Now.ToString("HH:mm:ss")+ "\r\n");
            this.textBox1.AppendText("  [테이블] "+this.listBox1.SelectedItem+"\n");
            this.textBox1.AppendText("  ====================================\r\n");
            this.textBox1.AppendText("  상 품 명       단 가      수 량      금 액\n");
            this.textBox1.AppendText("  ------------------------------------\r\n");
            this.textBox1.AppendText("  \r\n                        생략\r\n");
            sum = 0;
            for (int i = 0; i < Indicator_WM.orders[this.listBox1.SelectedIndex].index_o; i++)
            {
                for (int j = 0; j < Indicator_WM.index_p; j++)
                    if (Indicator_WM.products[j].name.Equals(Indicator_WM.orders[this.listBox1.SelectedIndex].name_p[i]))
                    {
                        int value = Indicator_WM.products[j].value;
                        sum += Indicator_WM.orders[this.listBox1.SelectedIndex].value_p[i] * value;
                    }
            }
            this.textBox1.AppendText("  ------------------------------------\r\n");
            this.textBox1.AppendText("  합 계  금 액 : " + sum + "\r\n");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // 영수증에 주문 내역 표시
            this.textBox1.Text = "";
            this.textBox1.AppendText("\r\n                       [영수증]\r\n\r\n");
            this.textBox1.AppendText("  [매장명] " + Indicator_WM.rest_name + "\r\n");
            this.textBox1.AppendText("  [대표자] 조남규\r\n");
            this.textBox1.AppendText("  [매출일] " + DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToString("HH:mm:ss") + "\r\n");
            this.textBox1.AppendText("  [테이블] " + this.listBox1.SelectedItem + "\n");
            this.textBox1.AppendText("  ====================================\r\n");
            this.textBox1.AppendText("  상 품 명       단 가      수 량      금 액\n");
            this.textBox1.AppendText("  ------------------------------------\r\n");
            sum = 0;
            for(int i = 0; i < Indicator_WM.orders[this.listBox1.SelectedIndex].index_o; i++)
            {
                for(int j = 0; j < Indicator_WM.index_p; j++) 
                    if (Indicator_WM.products[j].name.Equals(Indicator_WM.orders[this.listBox1.SelectedIndex].name_p[i]))
                    {
                        this.textBox1.AppendText("  " + Indicator_WM.orders[this.listBox1.SelectedIndex].name_p[i] + "\r\n");                 // 상품명
                        this.textBox1.AppendText("                    " + Indicator_WM.products[j].value.ToString() + "       ");// 단가
                        int value = Indicator_WM.products[j].value;
                        this.textBox1.AppendText(Indicator_WM.orders[this.listBox1.SelectedIndex].value_p[i].ToString() + "       ");   // 수량
                        this.textBox1.AppendText((Indicator_WM.orders[this.listBox1.SelectedIndex].value_p[i] * value).ToString() + "\r\n");// 금액
                        sum += Indicator_WM.orders[this.listBox1.SelectedIndex].value_p[i] * value;
                    }
            }
            this.textBox1.AppendText("  ------------------------------------\r\n");
            this.textBox1.AppendText("  합 계  금 액 : " + sum + "\r\n");
        }

        private void _19_Payment_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)        // 테이블 초기화
                listBox1.Items.Remove(i + 1);
            for (int i = 0; i < Indicator_WM.tablenum; i++)  // 테이블 번호 작성
                listBox1.Items.Add(i + 1);
            this.listBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.radioButton3.Checked)  // 신용카드 결제
            {
                // pass
            }
            else if (this.radioButton4.Checked) // 현금 결제
            {
                _20_Payment_Cash payment_cash = new _20_Payment_Cash();
                payment_cash.Indicator_P = this;
                payment_cash.ShowDialog();
            }
            else return;
            // 테이블 비우기
            Indicator_WM.orders[this.listBox1.SelectedIndex].name_p = new string[10];
            Indicator_WM.orders[this.listBox1.SelectedIndex].value_p = new int[10];
            Indicator_WM.orders[this.listBox1.SelectedIndex].index_o = 0;
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
