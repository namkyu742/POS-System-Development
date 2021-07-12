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
    public partial class _10_Product_Add : Form
    {
        public _05_Product_Management Indicator_PM;   // 상위 윈도우 지정
        public _10_Product_Add()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Indicator_PM.Indicator_MM.indicator_MW.products[Indicator_PM.Indicator_MM.indicator_MW.index_p].name = this.textBox1.Text;
            if (this.textBox1.Text == null) return;
            Indicator_PM.Indicator_MM.indicator_MW.products[Indicator_PM.Indicator_MM.indicator_MW.index_p].value = (int)this.numericUpDown1.Value;
            // ------------------------------------------------------ 식재료 추가 ------------------------------------------------------
            if (this.comboBox1.SelectedItem != null)    // 콤보박스1의 선택된 항목을 상품의 첫번째 식재료로 저장
                Indicator_PM.Indicator_MM.indicator_MW.products[Indicator_PM.Indicator_MM.indicator_MW.index_p].material1 = this.comboBox1.SelectedItem.ToString();
            else return;
            if (this.comboBox2.SelectedItem != null)    // 콤보박스2의 선택된 항목을 상품의 두번째 식재료로 저장
                Indicator_PM.Indicator_MM.indicator_MW.products[Indicator_PM.Indicator_MM.indicator_MW.index_p].material2 = this.comboBox2.SelectedItem.ToString();
            else return;
            if (this.comboBox3.SelectedItem != null)    // 콤보박스3의 선택된 항목을 상품의 세번째 식재료로 저장
                Indicator_PM.Indicator_MM.indicator_MW.products[Indicator_PM.Indicator_MM.indicator_MW.index_p].material3 = this.comboBox3.SelectedItem.ToString();
            else return;
            Indicator_PM.Indicator_MM.indicator_MW.products[Indicator_PM.Indicator_MM.indicator_MW.index_p].order_volume = 0;   // 누적 주문건수 초기화
            Indicator_PM.Indicator_MM.indicator_MW.index_p++;                                                                   // 상품 배열 인덱스 증가
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // 상품 관리 메뉴로 돌아감
            this.Close();
        }

        private void _10_Product_Add_Load(object sender, EventArgs e)
        {
            // 콤보박스에 식재료 목록 표시
            for (int i = 0; i < Indicator_PM.Indicator_MM.indicator_MW.index_m; i++)
            {
                this.comboBox1.Items.Add(Indicator_PM.Indicator_MM.indicator_MW.materials[i].name);
                this.comboBox2.Items.Add(Indicator_PM.Indicator_MM.indicator_MW.materials[i].name);
                this.comboBox3.Items.Add(Indicator_PM.Indicator_MM.indicator_MW.materials[i].name);
            }
        }
    }
}
