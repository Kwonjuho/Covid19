using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kwonjuho
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        int Num = 0; // 진행 숫자
        string orgStr = ""; // 결과 : 저장

        // 진행상황 라벨 텍스트
        private void Loading_Load(object sender, EventArgs e)
        {
            this.lbl2.Text = "연결 상태 : ...";
            this.lbl3.Text = "진행 상태 : ...";
            this.lbl4.Text = "현재 시간 : ";
            this.timer.Enabled = true;
            orgStr = this.lblup.Text;
        }

        // 업로드 타이머
        private void timer_Tick(object sender, EventArgs e)
        {
            // 타이머에 맞춰 텍스트 출력
            Num++;

            if (Num == 2)
            {
                this.lbl2.Text = "연결 상태 : 서버에 접속을 시도하는 중...";
            }
            else if (Num == 10)
            {
                this.lbl2.Text = "연결 상태 : 접속 성공";
            }
            else if (Num == 15)
            {
                this.lbl3.Text = "진행 상태 : 데이터베이스를 검색 중 입니다.";
            }
            else if (Num == 20)
            {
                this.lbl3.Text = "진행 상태 : 데이터베이스 검색 완료";
            }
            else if (Num == 23)
            {
                this.lbl3.Text = "진행 상태 : 업로드를 진행 중입니다.";
            }
            else if (Num == 100)
            {
                this.lbl3.Text = "진행 상태 : 업로드를 완료했습니다.";
            }

            this.lbl4.Text = DateTime.Now.ToString("현재 시간 : HH:mm:ss");

            if (Num > 100)
            {
                this.timer.Enabled = false;
                return;
            }

            // 진행률 출력
            this.upbar.Value = Num;
            this.lblup.Text = orgStr + Num.ToString() + "%";

            if (Num == 100)
            {
                MessageBox.Show("업로드가 완료되었습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                timer.Stop();

                this.Close();
            }
        }

        // 종료 버튼
        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();

            DialogResult cc = MessageBox.Show("업로드를 취소하시겠습니까?", "알림", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (cc == DialogResult.OK)
            {
                MessageBox.Show("업로드가 취소되었습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                timer.Start();
            }
        }
    }
}
