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
    public partial class _17_Order_Alter : Form
    {
        public _01_Main_Window Indicator_WM;   // 상위 윈도우 지정
        public _17_Order_Alter()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // 변경하고 메인 메뉴로 돌아감

            // 식재료 증가
            for (int i = 0; i < Indicator_WM.index_p; i++)
                if (Indicator_WM.products[i].name.Equals(this.comboBox2.SelectedItem.ToString()))
                {
                    int order_volume = 0;
                    for (int j = 0; j < Indicator_WM.orders[this.comboBox1.SelectedIndex].index_o; j++)
                    {
                        if (Indicator_WM.orders[this.comboBox1.SelectedIndex].name_p[j].Equals(Indicator_WM.products[i].name))
                        {
                            order_volume = Indicator_WM.orders[this.comboBox1.SelectedIndex].value_p[j];
                            Indicator_WM.products[i].order_volume -= Indicator_WM.orders[this.comboBox1.SelectedIndex].value_p[j];  // 중요
                        }
                            
                    }
                    for (int j = 0; j < Indicator_WM.index_m; j++)
                    {
                        if (Indicator_WM.materials[j].name.Equals(Indicator_WM.products[i].material1))
                            Indicator_WM.materials[j].value += order_volume;
                        if (Indicator_WM.materials[j].name.Equals(Indicator_WM.products[i].material2))
                            Indicator_WM.materials[j].value += order_volume;
                        if (Indicator_WM.materials[j].name.Equals(Indicator_WM.products[i].material3))
                            Indicator_WM.materials[j].value += order_volume;
                    }
                    
                    Indicator_WM.amount -= order_volume * Indicator_WM.products[i].value;
                }
            Indicator_WM.orders[comboBox1.SelectedIndex].index_o--;

            // 식재료 감소
            for (int i = 0; i < Indicator_WM.index_p; i++)
                if (Indicator_WM.products[i].name.Equals(this.comboBox2.SelectedItem.ToString()))
                {
                    for (int j = 0; j < Indicator_WM.index_m; j++)
                    {
                        if (Indicator_WM.materials[j].name.Equals(Indicator_WM.products[i].material1))
                        {
                            int temp = Indicator_WM.materials[j].value - (int)this.numericUpDown1.Value;
                            if (temp < 0) return;
                            Indicator_WM.materials[j].value = temp;
                        }
                        if (Indicator_WM.materials[j].name.Equals(Indicator_WM.products[i].material2))
                        {
                            int temp = Indicator_WM.materials[j].value - (int)this.numericUpDown1.Value;
                            if (temp < 0) return;
                            Indicator_WM.materials[j].value = temp;
                        }
                        if (Indicator_WM.materials[j].name.Equals(Indicator_WM.products[i].material3))
                        {
                            int temp = Indicator_WM.materials[j].value - (int)this.numericUpDown1.Value;
                            if (temp < 0) return;
                            Indicator_WM.materials[j].value = temp;
                        }
                    }
                    // 통계자료 수정
                    Indicator_WM.products[i].order_volume += (int)this.numericUpDown1.Value;
                    Indicator_WM.amount += (int)this.numericUpDown1.Value * Indicator_WM.products[i].value;
                    // ------------
                }

            Indicator_WM.orders[comboBox1.SelectedIndex].name_p[Indicator_WM.orders[comboBox1.SelectedIndex].index_o] = this.comboBox2.SelectedItem.ToString();
            Indicator_WM.orders[comboBox1.SelectedIndex].value_p[Indicator_WM.orders[comboBox1.SelectedIndex].index_o] = (int)this.numericUpDown1.Value;
            Indicator_WM.orders[comboBox1.SelectedIndex].index_o++;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 변경하지 않고 메인 메뉴로 돌아감
            this.Close();
        }

        private void _17_Order_Alter_Load(object sender, EventArgs e)
        {
            // 값 불러오기
            // 테이블 불러오기--------------------------
            for (int i = 0; i < 10; i++)        // 테이블 초기화
                comboBox1.Items.Remove(i + 1);
            for (int i = 0; i < Indicator_WM.tablenum; i++)  // 테이블 작성
                comboBox1.Items.Add(i + 1);
           
            // 상품 메뉴 표시
            textBox1.Text = "";
            this.textBox1.AppendText("이   름 : 가   격\r\n");
            this.textBox1.AppendText("=================================\r\n");
            for (int i = 0; i < Indicator_WM.index_p; i++)
            {

                this.textBox1.AppendText(Indicator_WM.products[i].name);
                this.textBox1.AppendText(" ------------- ");
                this.textBox1.AppendText(Indicator_WM.products[i].value.ToString());
                this.textBox1.AppendText("\r\n");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 상품 불러오기 --------------------------------
            for (int j = 0; j < Indicator_WM.orders[this.comboBox1.SelectedIndex].index_o; j++)
            {
                this.comboBox2.Items.Add(Indicator_WM.orders[this.comboBox1.SelectedIndex].name_p[j]);
            }
        }
    }
}
