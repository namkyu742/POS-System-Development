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
    public partial class _01_Main_Window : Form
    {
        public string rest_name;        // 가게 이름
        public string password;         // 관리자 모드 비밀번호
        public int tablenum;            // 테이블 개수
        public int amount;              // 총 매출액
        int temp_switch = 0;

        // ------------------------ 식재료 구조체 ------------------------
        public struct material {
            public string name;             // 식재료 이름
            public int value;               // 식재료 재고량
        }
        public material[] materials = new material[10];
        public int index_m = 0;

        // ------------------------ 상품 구조체 --------------------------
        public struct product {
            public string name;             // 상품 이름
            public int value;               // 상품 가격
            public string material1;        // 필요 재료1
            public string material2;        // 필요 재료2
            public string material3;        // 필요 재료3
            public int order_volume;        // 통계 주문량
        }
        public product[] products = new product[10];
        public int index_p = 0;

        // ------------------------ 주문서 구조체 --------------------------
        public struct order
        {
            public string[] name_p;         // 주문한 상품 이름
            public int[] value_p;           // 주문한 상품 개수
            public int index_o;             // 상품 주문 개수
        }
        public int index_O = 0;
        public order[] orders;// = new order[10];
        
        // ---------------------------------------------------------------
        public _01_Main_Window()
        {
            InitializeComponent();
        }
        
        private void _01_Main_Window_Activated(object sender, EventArgs e)
        {
            // 식재료 none의 재고 초기화
            for(int i = 0; i < index_m; i++)
            {
                if (materials[i].name.Equals("none"))
                {
                    materials[i].value = 1000;
                }
            }

            label1.Text = rest_name;

            for (int i = 0; i < 10; i++)        // 테이블 초기화
                listBox1.Items.Remove(i + 1);
            for (int i = 0; i < tablenum; i++)  // 테이블 번호 작성
                listBox1.Items.Add(i + 1);

            // 재고 알람 - 식재료별로 재고가 5개 이하이면 경고알림을 표시
            textBox1.Text = "";
            for (int i = 0; i < index_m; i++) {
                if(materials[i].value < 5) {
                    textBox1.AppendText("※ 경고 : ");
                    textBox1.AppendText(this.materials[i].name);
                    textBox1.AppendText("의 재고가 5개 미만입니다. \r\n");
                }
            }
            // ------------ 주문서 초기 생성 ---------------
            if(temp_switch == 0)
            {
                orders = new order[tablenum];
                for (int i = 0; i < tablenum; i++)
                {
                    orders[i].name_p = new string[10];
                    orders[i].value_p = new int[10];
                    orders[i].index_o = 0;
                }
                temp_switch++;
            }
            // -------------------- 주문 내역 표시 ------------------------
            textBox2.Text = "";
            for(int i = 0; i < tablenum; i++)
            {
                if (orders[i].index_o > 0)
                {
                    textBox2.AppendText("테이블");
                    textBox2.AppendText((i + 1).ToString());
                    textBox2.AppendText("의 주문현황\r\n");
                    for (int j = 0; j < orders[i].index_o; j++)
                    {
                        textBox2.AppendText("   이름 : ");
                        textBox2.AppendText(orders[i].name_p[j]);
                        textBox2.AppendText("\r\n   개수 : ");
                        textBox2.AppendText(orders[i].value_p[j].ToString());
                        textBox2.AppendText("\r\n \r\n");
                    }
                    textBox2.AppendText("-------------------------------------------------------------------\r\n");
                }
            }
        }

        private void 주문추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _16_Order_Add order_add = new _16_Order_Add();
            order_add.Indicator_WM = this;
            order_add.ShowDialog();
        }

        private void 주문변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           _17_Order_Alter order_alter = new _17_Order_Alter();
            order_alter.Indicator_WM = this;
            order_alter.ShowDialog();
        }

        private void 주문삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _18_Order_Delete order_delete = new _18_Order_Delete();
            order_delete.Indicator_WM = this;
            order_delete.ShowDialog();
        }

        private void 결제ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _19_Payment payment = new _19_Payment();
            payment.Indicator_WM = this;
            payment.ShowDialog();

        }
        private void 관리자모드ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _09_Input_Password input_password = new _09_Input_Password();
            input_password.indicator_MW = this;
            input_password.ShowDialog();
        }

        private void _01_Main_Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            // << 종료 전 파일로 저장 >>

            // ----------------------- 식재료 저장 -----------------------
            string savePath_m = System.IO.Path.Combine(Application.StartupPath, "data_material.txt");// 경로
            System.IO.File.WriteAllText(savePath_m, "", Encoding.Default);                    // 파일 새로 생성
            System.IO.File.AppendAllText(savePath_m, index_m + "\r\n", Encoding.Default);     // 식재료 개수 저장
            for (int i = 0; i < index_m; i++)
            {
                System.IO.File.AppendAllText(savePath_m, materials[i].name + "\r\n", Encoding.Default);
                System.IO.File.AppendAllText(savePath_m, materials[i].value + "\r\n", Encoding.Default);
            }

            // ----------------------- 상품 저장 -----------------------
            string savePath_p = System.IO.Path.Combine(Application.StartupPath, "data_product.txt");// 경로
            System.IO.File.WriteAllText(savePath_p, "", Encoding.Default);                    // 파일 새로 생성
            System.IO.File.AppendAllText(savePath_p, index_p + "\r\n", Encoding.Default);     // 상품 개수 저장
            for (int i = 0; i < index_p; i++)
            {
                System.IO.File.AppendAllText(savePath_p, products[i].name + "\r\n", Encoding.Default);
                System.IO.File.AppendAllText(savePath_p, products[i].value + "\r\n", Encoding.Default);
                System.IO.File.AppendAllText(savePath_p, products[i].material1 + "\r\n", Encoding.Default);
                System.IO.File.AppendAllText(savePath_p, products[i].material2 + "\r\n", Encoding.Default);
                System.IO.File.AppendAllText(savePath_p, products[i].material3 + "\r\n", Encoding.Default);
                System.IO.File.AppendAllText(savePath_p, products[i].order_volume + "\r\n", Encoding.Default);
            }

            // ----------------------- 옵션 저장 -----------------------
            string savePath = System.IO.Path.Combine(Application.StartupPath, "data_option.txt");// 경로
            System.IO.File.WriteAllText(savePath, "", Encoding.Default);                    // 파일 새로 생성
            System.IO.File.AppendAllText(savePath, rest_name + "\r\n", Encoding.Default);     // 가게 이름
            System.IO.File.AppendAllText(savePath, password + "\r\n", Encoding.Default);     // 비밀번호
            System.IO.File.AppendAllText(savePath, tablenum + "\r\n", Encoding.Default);     // 테이블 개수
            System.IO.File.AppendAllText(savePath, amount + "\r\n", Encoding.Default);     // 총매출액
        }

        private void _01_Main_Window_Load(object sender, EventArgs e)
        {
            // << 시작 시 파일 불러오기 >>

            // ----------------------- 식재료 불러오기 -----------------------
            string loadPath_m = System.IO.Path.Combine(Application.StartupPath, "data_material.txt");// 경로
            string[] textValue_m = System.IO.File.ReadAllLines(loadPath_m);                   // 파일 새로 생성
            index_m = Convert.ToInt32(textValue_m[0]);                                      // 식재료 개수 불러오기
            int j = 1;
            for(int i = 0; i<index_m; i++)
            {
                materials[i].name = textValue_m[j++];
                materials[i].value = Convert.ToInt32(textValue_m[j++]);
            }

            // ----------------------- 상품 불러오기 -----------------------
            string loadPath_p = System.IO.Path.Combine(Application.StartupPath, "data_product.txt");// 경로
            string[] textValue_p = System.IO.File.ReadAllLines(loadPath_p);                   // 파일 새로 생성
            index_p = Convert.ToInt32(textValue_p[0]);                                      // 상품 개수 불러오기
            int k = 1;
            for (int i = 0; i < index_p; i++)
            {
                products[i].name = textValue_p[k++];
                products[i].value = Convert.ToInt32(textValue_p[k++]);
                products[i].material1 = textValue_p[k++];
                products[i].material2 = textValue_p[k++];
                products[i].material3 = textValue_p[k++];
                products[i].order_volume = Convert.ToInt32(textValue_p[k++]);
            }

            // ----------------------- 옵션 불러오기 -----------------------
            string loadPath = System.IO.Path.Combine(Application.StartupPath, "data_option.txt");// 경로
            string[] textValue = System.IO.File.ReadAllLines(loadPath);                   // 파일 새로 생성
            rest_name = textValue[0];                                                     // 가게 이름
            password = textValue[1];                                                        // 비밀번호
            tablenum = Convert.ToInt32(textValue[2]);                                      // 테이블 개수
            amount = Convert.ToInt32(textValue[3]);                                        // 총 매출액
        }
    }
}
