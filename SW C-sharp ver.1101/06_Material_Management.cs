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
    public partial class _06_Material_Management : Form
    {
        public _02_Management_mode Indicator_MM;   // 상위 윈도우 지정
        public _06_Material_Management()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 관리자 메뉴로 돌아감
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 식재료 추가
            _13_Material_Add material_add = new _13_Material_Add();
            material_add.Indicator_MAM = this;
            material_add.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 식재료 제거
            _14_Material_Delete material_delete = new _14_Material_Delete();
            material_delete.Indicator_MAM = this;
            material_delete.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 식재료 재고 변경
            _15_Material_Restock material_restock = new _15_Material_Restock();
            material_restock.Indicator_MAM = this;
            material_restock.ShowDialog();
        }

        private void _06_Matarial_Management_Activated(object sender, EventArgs e)
        {
            // 저장되어 있는 식재료 출력
            this.textBox1.Text = "";
            for (int i = 0; i < Indicator_MM.indicator_MW.index_m; i++)
            {
                string temp = (i+1).ToString();
                this.textBox1.AppendText(temp);
                this.textBox1.AppendText(". ");
                this.textBox1.AppendText(Indicator_MM.indicator_MW.materials[i].name);
                this.textBox1.AppendText(" (");
                this.textBox1.AppendText(Indicator_MM.indicator_MW.materials[i].value.ToString());
                this.textBox1.AppendText(")\r\n");
            }
        }
    }
}
