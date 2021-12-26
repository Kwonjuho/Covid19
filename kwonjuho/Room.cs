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
    public partial class Room : Form
    {
        public Room()
        {
            InitializeComponent();
        }

        // 호실 정보
        string[] SList = new string[] { "200호" };

        // 선택 결과 : 저장
        string roomStr = "";
        string orgStr = "";

        private void Room_Load(object sender, EventArgs e)
        {
            // SList 불러오기
            for (int i = 0; i < SList.Length; i++)
            {
                this.roomcb.Items.Add(SList[i]);
            }

            // 호실, 명수 텍스트 값
            roomStr = this.roomlblResult.Text;
            orgStr = this.countlbl.Text;

            // 콤보박스 0 인덱스 미리 선택
            roomcb.SelectedIndex = 0;
        }

        // 콤보박스 결과 창
        private void roomcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.roomcb.Text != "")
                this.roomlblResult.Text = roomStr + " " + this.roomcb.Text;
        }

        // 환자 정보 값
        string strName, strAge, strSex, strPhone, strSp, strSp2, strday, strone, strtwo;

        // 텍스트박스 텍스트 확인
        private bool TextCheck()
        {
            // 환자정보 : 조건 AND / 추가증상 : OR
            if (this.nametxt.Text != "" &&
                this.agetxt.Text != "" &&
                this.sextxt.Text != "" &&
                this.sptxt.Text != "" &&
                this.phonetxt.Text != "" &&
                this.sp2txt.Text != "" |
                this.dateTimePicker1.Text != "")
            {
                // 참 == 반환
                return true;
            }
            else
                MessageBox.Show("환자 정보를 입력해주세요.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // 거짓 == 반환
            return false;
        }

        // 환자 정보 추가 버튼
        int i;

        private void Cinbtn_Click(object sender, EventArgs e)
        {
            strName = this.nametxt.Text;
            strAge = this.agetxt.Text;
            strSex = this.sextxt.Text;
            strPhone = this.phonetxt.Text;
            strSp = this.sptxt.Text;
            strSp2 = this.sp2txt.Text;
            strday = this.dateTimePicker1.Text;

            if ((this.nametxt.Text != "" &&
                this.agetxt.Text != "" &&
                this.sextxt.Text != "" &&
                this.sptxt.Text != "" &&
                this.phonetxt.Text != "" &&
                this.sp2txt.Text != "" |
                this.dateTimePicker1.Text != ""))
            {
                // 메시지박스 == call
                DialogResult call = MessageBox.Show("환자 정보를 추가하시겠습니?", "알림",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                {
                    // 확인 클릭 시 수행
                    if (call == DialogResult.OK)
                    {
                        i++;
                        MessageBox.Show("환자 정보가 추가 되었습니다.", "알림",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.countlbl.Text = orgStr + " " + this.i + "명";
                    }

                    // 취소 클릭 시 리턴
                    else return;
                }
            }

            // 백신 접종 체크박스
            if (TextCheck() == true)
            {
                if (mocbtn.Checked == true)
                {
                    strone = "모더나";
                }
                else if (hwacbtn.Checked == true)
                {
                    strone = "화이자";
                }
                else
                    strone = "미접종";
                {
                    if (mocbtn2.Checked == true)
                    {
                        strtwo = "모더나";
                    }
                    else if (hwacbtn2.Checked == true)
                    {
                        strtwo = "화이자";
                    }
                    else
                        strtwo = "미접종";
                }
            }
            else return;

            ListViewItem lvi = new ListViewItem(new string[] 
            { strName, strAge, strSex, strPhone, strSp, strSp2, strone, strtwo, strday });

            this.lvView.Items.Add(lvi);

            // 텍스트 박스 초기화
            nametxt.Text = string.Empty;
            agetxt.Text = string.Empty;
            sextxt.Text = string.Empty;
            phonetxt.Text = string.Empty;
            sptxt.Text = string.Empty;
            sp2txt.Text = string.Empty;

            // 백신 접종 버튼 초기화
            mocbtn.Checked = false;
            hwacbtn.Checked = false;
            mocbtn2.Checked = false;
            hwacbtn2.Checked = false;
        }

        // 호실 추가 버튼
        private void roomaddbtn_Click(object sender, EventArgs e)
        {
            if (this.roomtxt.Text != "")
            {
                this.roomcb.Items.Add(this.roomtxt.Text);
                MessageBox.Show("호실을 추가하였습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 추가 후 텍스트박스 = 빈 문자열
                roomtxt.Text = string.Empty;
            }
        }

        // 엔터 호실 추가
        private void roomtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                roomaddbtn_Click(sender, e);
            }
        }

        // 호실 삭제 버튼
        private void button3_Click(object sender, EventArgs e)
        {
            if (roomcb.SelectedIndex > -1)
                {
                roomcb.Items.RemoveAt(roomcb.SelectedIndex);
                MessageBox.Show("호실을 삭제하였습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 환자 정보 출력
        private void lvView_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvView.SelectedItems.Count == 0)
                MessageBox.Show("환자를 선택하세요.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("이름 : " + this.lvView.SelectedItems[0].SubItems[0].Text + "\n"
                    + "\n나이 : " + this.lvView.SelectedItems[0].SubItems[1].Text + "\n"
                    + "\n성별 : " + this.lvView.SelectedItems[0].SubItems[2].Text + "\n"
                    + "\n연락처 : " + this.lvView.SelectedItems[0].SubItems[3].Text + "\n"
                    + "\n증상 : " + this.lvView.SelectedItems[0].SubItems[4].Text + "\n"
                    + "\n추가 증상 : " + this.lvView.SelectedItems[0].SubItems[5].Text + "\n"
                    + "\n1차 접종 : " + this.lvView.SelectedItems[0].SubItems[6].Text + "\n"
                    + "\n2차 접종 : " + this.lvView.SelectedItems[0].SubItems[7].Text + "\n"
                    + "\n입실 일자 : " + this.lvView.SelectedItems[0].SubItems[8].Text, "환자 정보",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        // 엔터 == 입실버튼
        private void nametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cinbtn_Click(sender, e);
            }
        }

        private void agetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cinbtn_Click(sender, e);
            }
        }

        private void sextxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cinbtn_Click(sender, e);
            }
        }

        private void phonetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cinbtn_Click(sender, e);
            }
        }

        private void sptxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cinbtn_Click(sender, e);
            }
        }

        private void sp2txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cinbtn_Click(sender, e);
            }
        }

        // 환자 퇴실 버튼
        private void exbtn_Click(object sender, EventArgs e)
        {
            if (lvView.SelectedItems.Count > 0)
            {
                if (lvView.SelectedItems.Count > 0)

                    if (MessageBox.Show("환자가 퇴실 했습니까?", "알림",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                    {
                        // 리스트뷰 환자 정보 인덱스 삭제
                        int index = lvView.FocusedItem.Index;
                        lvView.Items.RemoveAt(index);

                        i--;
                        MessageBox.Show("퇴실 완료", "알림",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.countlbl.Text = orgStr + " " + this.i + "명";
                    }
            }
            else
            {
                MessageBox.Show("환자를 선택해주세요.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 환자 정보 서버 업로드 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            Loading Loading = new Loading();
            Loading.Show();
        }

        private void lvView_Click(object sender, EventArgs e)
        {

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
        }

        // 로고 클릭 == 홈페이지
        private void Logoimage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.hanhsp.co.kr/");
        }

        // 메인화면 버튼
        private void Mainbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Main Main = new Main();
            Main.Show();
        }

        // 입 / 퇴실 버튼
        private void oderbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Oder Main = new Oder();
            Main.Show();
        }

        // 종료 버튼
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
