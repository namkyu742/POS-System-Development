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
    public partial class _15_Material_Restock : Form
    {
        public _06_Material_Management Indicator_MAM;   // 상위 윈도우 지정
        public _15_Material_Restock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 설정을 변경하고 식재료 관리 메뉴로 돌아감
            if (this.comboBox1.SelectedItem != null)
            {
                if (Indicator_MAM.Indicator_MM.indicator_MW.materials != null)
                {
                    for (int i = 0; i < Indicator_MAM.Indicator_MM.indicator_MW.index_m; i++)
                        if (Indicator_MAM.Indicator_MM.indicator_MW.materials[i].name.Equals(this.comboBox1.SelectedItem.ToString()))
                        {
                            Indicator_MAM.Indicator_MM.indicator_MW.materials[i].value = (int)this.numericUpDown1.Value;
                            break;
                        }
                }
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 설정을 변경하지 않고 식재료 관리 메뉴로 돌아감
            this.Close();
        }

        private void _15_Material_Restock_Load(object sender, EventArgs e)
        {
            // 화면에 식재료 목록 표시
            for (int i = 0; i < Indicator_MAM.Indicator_MM.indicator_MW.index_m; i++)
                if (Indicator_MAM.Indicator_MM.indicator_MW.materials != null)
                    this.comboBox1.Items.Add(Indicator_MAM.Indicator_MM.indicator_MW.materials[i].name);
        }
    }
}
