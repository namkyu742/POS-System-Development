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
    public partial class _13_Material_Add : Form
    {
        public _06_Material_Management Indicator_MAM;   // 상위 윈도우 지정
        public _13_Material_Add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 설정을 변경하고 식재료 관리 메뉴로 돌아감
            Indicator_MAM.Indicator_MM.indicator_MW.materials[Indicator_MAM.Indicator_MM.indicator_MW.index_m].name = this.textBox1.Text;
            Indicator_MAM.Indicator_MM.indicator_MW.materials[Indicator_MAM.Indicator_MM.indicator_MW.index_m].value = (int)this.numericUpDown1.Value;
            Indicator_MAM.Indicator_MM.indicator_MW.index_m++;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 설정을 변경하지 않고 식재료 관리 메뉴로 돌아감
            this.Close();
        }
    }
}
