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
    public partial class _02_Management_mode : Form
    {
        public _01_Main_Window indicator_MW;   // 상위 윈도우 지정
        public _02_Management_mode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 메인메뉴로 이동
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 레스토랑 이름 설정
            _03_Restaurant_rename restaurant_rename = new _03_Restaurant_rename();
            restaurant_rename.Indicator_MM = this;
            restaurant_rename.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 테이블 개수 설정
            _04_Change_Tablenum change_tablenum = new _04_Change_Tablenum();
            change_tablenum.Indicator_MM = this;
            change_tablenum.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // 상품 관리
            _05_Product_Management product_Management = new _05_Product_Management();
            product_Management.Indicator_MM = this;
            product_Management.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // 식재료 관리
            _06_Material_Management material_management = new _06_Material_Management();
            material_management.Indicator_MM = this;
            material_management.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 통계 조회
            _07_Stats_View stats_view = new _07_Stats_View();
            stats_view.Indicator_MM = this;
            stats_view.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 비밀번호 재설정
            _08_Change_Password change_password = new _08_Change_Password();
            change_password.Indicator_MM = this;
            change_password.ShowDialog();
        }
    }
}
