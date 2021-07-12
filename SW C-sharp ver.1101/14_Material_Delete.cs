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
    public partial class _14_Material_Delete : Form
    {
        public _06_Material_Management Indicator_MAM;   // 상위 윈도우 지정
        public _14_Material_Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //설정을 변경하고 식재료 관리 메뉴로 돌아감
            if (this.listBox1.SelectedItem != null)
            {
                if (Indicator_MAM.Indicator_MM.indicator_MW.materials != null)
                {
                    for (int i = 0; i < 10; i++)
                        if (Indicator_MAM.Indicator_MM.indicator_MW.materials[i].name.Equals(this.listBox1.SelectedItem.ToString()))
                        {
                            for (int j = i; j < 10 - 1; j++)
                            {
                                // 인덱스 값을 하나 줄이고 해당 인덱스 이후의 값들을 한칸씩 당김
                                Indicator_MAM.Indicator_MM.indicator_MW.materials[j].name = Indicator_MAM.Indicator_MM.indicator_MW.materials[j + 1].name;
                                Indicator_MAM.Indicator_MM.indicator_MW.materials[j].value = Indicator_MAM.Indicator_MM.indicator_MW.materials[j + 1].value;
                            }
                            Indicator_MAM.Indicator_MM.indicator_MW.index_m--;
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

        private void _14_Material_Delete_Load(object sender, EventArgs e)
        {
            // 리스트박스에 식재료 목록 표시
            for(int i = 0; i<Indicator_MAM.Indicator_MM.indicator_MW.index_m; i++)
                if (Indicator_MAM.Indicator_MM.indicator_MW.materials != null)
                    this.listBox1.Items.Add(Indicator_MAM.Indicator_MM.indicator_MW.materials[i].name);
        }
    }
}
