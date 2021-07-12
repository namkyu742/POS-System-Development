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
    public partial class _05_Product_Management : Form
    {
        public _02_Management_mode Indicator_MM;   // 상위 윈도우 지정
        public _05_Product_Management()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 상품 추가
            _10_Product_Add product_add = new _10_Product_Add();
            product_add.Indicator_PM = this;
            product_add.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // 상품 변경
            _11_Product_Alter product_alter = new _11_Product_Alter();
            product_alter.Indicator_PM = this;
            product_alter.ShowDialog();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // 상품 제거
            _12_Product_Delete product_delete = new _12_Product_Delete();
            product_delete.Indicator_PM = this;
            product_delete.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // 관리자 모드로 돌아감
            this.Close();
        }
        private void _05_Product_Management_Activated(object sender, EventArgs e)
        {
            // 저장된 상품들 출력
            this.textBox1.Text = "";
            for (int i = 0; i < Indicator_MM.indicator_MW.index_p; i++)
            {
                this.textBox1.AppendText("이   름 : ");
                this.textBox1.AppendText(Indicator_MM.indicator_MW.products[i].name);
                this.textBox1.AppendText("\r\n가   격 : ");
                this.textBox1.AppendText(Indicator_MM.indicator_MW.products[i].value.ToString());
                this.textBox1.AppendText("\r\n식재료 : ");

                if (Indicator_MM.indicator_MW.products[i].material1 != null)
                    this.textBox1.AppendText(Indicator_MM.indicator_MW.products[i].material1);
                this.textBox1.AppendText("\r\n            ");
                if (Indicator_MM.indicator_MW.products[i].material2 != null)
                    this.textBox1.AppendText(Indicator_MM.indicator_MW.products[i].material2);
                this.textBox1.AppendText("\r\n            ");
                if (Indicator_MM.indicator_MW.products[i].material3 != null)
                    this.textBox1.AppendText(Indicator_MM.indicator_MW.products[i].material3);

                this.textBox1.AppendText("\r\n---------------------\r\n");
            }
        }
    }
}
