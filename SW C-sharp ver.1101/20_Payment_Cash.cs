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
    public partial class _20_Payment_Cash : Form
    {
        public _19_Payment Indicator_P;   // 상위 윈도우 지정
        public _20_Payment_Cash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(this.textBox2.Text) <= Indicator_P.sum)) return;
            int temp = Convert.ToInt32(this.textBox2.Text) - Indicator_P.sum;
            MessageBox.Show("결제완료\r\n거스름돈 : " + temp.ToString());
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _20_Payment_Cash_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = Indicator_P.sum.ToString();
        }
    }
}
