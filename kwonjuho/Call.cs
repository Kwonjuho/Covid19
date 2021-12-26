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
    public partial class Call : Form
    {

        public Call()
        {
            InitializeComponent();
        }

        // 긴급 호출 폼 로드
        private void Call_Load(object sender, EventArgs e)
        {
            // 사진
            this.pictureBox1.Image = (Image)this.imageList1.Images[0];
            this.pictureBox2.Image = (Image)this.imageList1.Images[1];
            this.pictureBox3.Image = (Image)this.imageList1.Images[2];
            this.pictureBox4.Image = (Image)this.imageList1.Images[3];
            this.pictureBox5.Image = (Image)this.imageList1.Images[4];

            // 소속
            this.worklbl1.Text = "소속 : 흉부외과 부교수";
            this.worklbl2.Text = "소속 : 소아외과 조교수";
            this.worklbl3.Text = "소속 : 산부인과 조교수";
            this.worklbl4.Text = "소속 : 간담췌외과 조교수";
            this.worklbl5.Text = "소속 : 신경외과 조교수";

            // 연락처
            this.phonelbl1.Text = "연락처 : 010 - 2851 - 0770";
            this.phonelbl2.Text = "연락처 : 010 - 9574 - 9912";
            this.phonelbl3.Text = "연락처 : 010 - 5772 - 1784";
            this.phonelbl4.Text = "연락처 : 010 - 0809 - 4708";
            this.phonelbl5.Text = "연락처 : 010 - 6349 - 6501";

            // 이메일
            this.linklbl1.Text = "jun1234@naver.com";
            this.linklbl2.Text = "jung1234@naver.com";
            this.linklbl3.Text = "suk1234@naver.com";
            this.linklbl4.Text = "ik1234@naver.com";
            this.linklbl5.Text = "song1234@naver.com";

            // 호출 rb 버튼
            callrbtn1.CheckedChanged += callrbtn1_CheckedChanged;
            callrbtn2.CheckedChanged += callrbtn2_CheckedChanged;
            callrbtn3.CheckedChanged += callrbtn3_CheckedChanged;
            callrbtn4.CheckedChanged += callrbtn4_CheckedChanged;
            callrbtn5.CheckedChanged += callrbtn5_CheckedChanged;
        }

        // rb1 버튼
        public void callrbtn1_CheckedChanged(object sender, EventArgs e)
        {
            
            RadioButton btn = sender as RadioButton;

            if (btn.Checked == true) //라디오 버튼 컨트롤 체크 되면
            {
                MessageBox.Show("호출완료", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        // rb2 버튼
        public void callrbtn2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;

            if (btn.Checked == true) //라디오 버튼 컨트롤 체크 되면
            {
                MessageBox.Show("호출완료", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        // rb3 버튼
        public void callrbtn3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;

            if (btn.Checked == true) //라디오 버튼 컨트롤 체크 되면
            {
                MessageBox.Show("호출완료", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        // rb4 버튼
        public void callrbtn4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;

            if (btn.Checked == true) //라디오 버튼 컨트롤 체크 되면
            {
                MessageBox.Show("호출완료", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        // rb5 버튼
        public void callrbtn5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;

            if (btn.Checked == true) //라디오 버튼 컨트롤 체크 되면
            {
                MessageBox.Show("호출완료", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
