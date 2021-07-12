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
    public partial class _12_Product_Delete : Form
    {
        public _05_Product_Management Indicator_PM;   // 상위 윈도우 지정
        public _12_Product_Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 상품 관리 메뉴로 돌아감
            for(int i = 0; i < Indicator_PM.Indicator_MM.indicator_MW.index_p; i++)
            {
                if (Indicator_PM.Indicator_MM.indicator_MW.products[i].name.Equals(this.comboBox1.SelectedItem))
                {
                    for(int j = i; j < Indicator_PM.Indicator_MM.indicator_MW.index_p - 1; j++)
                    {
                        Indicator_PM.Indicator_MM.indicator_MW.products[j].name = Indicator_PM.Indicator_MM.indicator_MW.products[j + 1].name;
                        Indicator_PM.Indicator_MM.indicator_MW.products[j].value = Indicator_PM.Indicator_MM.indicator_MW.products[j + 1].value;
                        Indicator_PM.Indicator_MM.indicator_MW.products[j].material1 = Indicator_PM.Indicator_MM.indicator_MW.products[j + 1].material1;
                        Indicator_PM.Indicator_MM.indicator_MW.products[j].material2 = Indicator_PM.Indicator_MM.indicator_MW.products[j + 1].material2;
                        Indicator_PM.Indicator_MM.indicator_MW.products[j].material3 = Indicator_PM.Indicator_MM.indicator_MW.products[j + 1].material3;
                    }
                    Indicator_PM.Indicator_MM.indicator_MW.index_p--;
                }
            }
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // 상품 관리 메뉴로 돌아감
            this.Close();
        }
        private void _12_Product_Delete_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Indicator_PM.Indicator_MM.indicator_MW.index_p; i++)
            {
                this.comboBox1.Items.Add(Indicator_PM.Indicator_MM.indicator_MW.products[i].name);
            }
        }
    }
}
