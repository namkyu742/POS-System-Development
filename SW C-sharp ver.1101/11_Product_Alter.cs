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
    public partial class _11_Product_Alter : Form
    {
        public _05_Product_Management Indicator_PM;   // 상위 윈도우 지정
        public _11_Product_Alter()
        {
            InitializeComponent();
        }

        private void _11_Product_Alter_Load(object sender, EventArgs e)
        {
            for(int i = 0; i<Indicator_PM.Indicator_MM.indicator_MW.index_p;i++)
            {
                this.comboBox4.Items.Add(Indicator_PM.Indicator_MM.indicator_MW.products[i].name);
            }
            for (int i = 0; i < Indicator_PM.Indicator_MM.indicator_MW.index_m; i++)
            {
                this.comboBox1.Items.Add(Indicator_PM.Indicator_MM.indicator_MW.materials[i].name);
                this.comboBox2.Items.Add(Indicator_PM.Indicator_MM.indicator_MW.materials[i].name);
                this.comboBox3.Items.Add(Indicator_PM.Indicator_MM.indicator_MW.materials[i].name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Indicator_PM.Indicator_MM.indicator_MW.index_p; i++)
            {
                if (this.comboBox4.SelectedItem == null) return;

                if (this.comboBox4.SelectedItem.Equals(Indicator_PM.Indicator_MM.indicator_MW.products[i].name))
                {
                    Indicator_PM.Indicator_MM.indicator_MW.products[i].value = (int)this.numericUpDown1.Value;

                    // 식재료 추가
                    if (this.comboBox1.SelectedItem != null)
                        Indicator_PM.Indicator_MM.indicator_MW.products[i].material1 = this.comboBox1.SelectedItem.ToString();
                    else return;
                    if (this.comboBox2.SelectedItem != null)
                        Indicator_PM.Indicator_MM.indicator_MW.products[i].material2 = this.comboBox2.SelectedItem.ToString();
                    else return;
                    if (this.comboBox3.SelectedItem != null)
                        Indicator_PM.Indicator_MM.indicator_MW.products[i].material3 = this.comboBox3.SelectedItem.ToString();
                    else return;
                    this.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 상품 관리 메뉴로 돌아감
            this.Close();
        }
    }
}
