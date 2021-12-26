using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace kwonjuho
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        int ImgCount = 0; // 이미지 번호

        private void Main_Load(object sender, EventArgs e)
        {
            this.Tttableimage.Image = (Image)this.MainimgList.Images[0];
            ImgCount = this.MainimgList.Images.Count;
        }

        // 다음 체크 버튼
        private void Imgnextbtn_CheckedChanged(object sender, EventArgs e)
        {
            ImgCount--;
            if (ImgCount < 0)
                ImgCount = this.MainimgList.Images.Count - 1;

                this.Tttableimage.Image = (Image)this.MainimgList.Images[ImgCount];

            Imgnextbtn.Checked = false;
        }

        // 입 / 퇴실 버튼
        private void roombtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Room Main = new Room();
            Main.Show();
        }

        // 백신주문 버튼
        private void oderbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Oder Main = new Oder();
            Main.Show();
        }

        // 긴급호출 버튼
        private void callbtn_Click(object sender, EventArgs e)
        {
            DialogResult call = MessageBox.Show("긴급호출을 하시겠습니까?", "알림",
                                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // 확인 클릭 시 알림
            if (call == DialogResult.OK)
            {
                Call Main = new Call();
                Main.Show();
            }
       
            // 취소 클릭 시 알림
            else if (call == DialogResult.Cancel)
            {

            }
        }

        // 예방접종 사전안내 버튼
        private void Schedulebtn_Click(object sender, EventArgs e)
        {
            Schedule Main2 = new Schedule();
            Main2.Show();
        }

        // 질병관리청 사이트 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kdca.go.kr/");
        }

        // 코로나 라이브 사이트 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://corona-live.com/");
        }

        // 로고 클릭 == 홈페이지

        private void Logoimage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.hanhsp.co.kr/");
        }

        // 알람 버튼
        private void Albtn_Click(object sender, EventArgs e)
        {
            Alram Main = new Alram();
            Main.Show();
        }

        // 현재 시간 타이머
        private void timer_Tick(object sender, EventArgs e)
        {
            this.timelbl.Text = DateTime.Now.ToString("현재 시간 : HH: mm: ss");
        }

        // 종료 버튼
        private void exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult call = MessageBox.Show("프로그램을 종료 하시겠습니까?", "알림",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            // 확인 클릭 시 종료
            if (call == DialogResult.OK)
            {
                this.Close();
            }

            // 취소 클릭 시 수행 없음
            else if (call == DialogResult.Cancel)
            {

            }
        }
    }
}
