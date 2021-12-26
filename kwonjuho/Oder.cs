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
    public partial class Oder : Form
    {
        // 입고 완료 후 추가 된 재고 값
        public int HospitalMoResult = 0;
        public int HospitalHwaResult = 0;
        public int HospitalJanResult = 0;
        public int HospitalAstResult = 0;

        // 초기 업체 백신 재고 값
        public int CompanyMoResult = 1000;
        public int CompanyHwaResult = 2000;
        public int CompanyJanResult = 3000;
        public int CompanyAstResult = 4000;

        public Oder()
        {
            InitializeComponent();
        }

        // 콤보박스 초기 아이템 리스트
        string[] SList = new string[] { "모더나", "화이자" };

        // 주문 정보 값
        string strName, strNum, strDay, strEtc, strPhone, strAdr;

        // 선택 제품명 : 저장
        string NameStr = "";
        string NameStr2 = "";
        string ExpStr = "";
        string NumStr = "";
        string NumStr2 = "";

        // 문자열 컨버트 정수
        int iMo;
        int iHwa;
        int iJan;
        int iAst;

        // 이미지 번호
        int ImgCount = 0;

        private void Oder_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SList.Length; i++)
            {
                this.Cblist.Items.Add(SList[i]);
                this.cblist2.Items.Add(SList[i]);
            }

            // 제품명 출력
            NameStr = this.Namelbl.Text;
            NameStr2 = this.Namelbl2.Text;
            ExpStr = this.Explbl.Text;
            NumStr = this.Numlbl.Text;
            NumStr2 = this.Numlbl.Text;

            // 콤보 선택
            Cblist.SelectedIndex = 0;
            cblist2.SelectedIndex = 0;
        }

        // 백신 주문 정보 출력
        private void cblist_SelectedIndexChanged(object sender, EventArgs e)
        {

            // 콤보박스의 텍스트를 텍스트로 인식
            if (Cblist.Text == "모더나")
            {
                // 이미지 리스트 0번째 사진
                this.pictureBox1.Image = (Image)this.imageList1.Images[0];
                ImgCount = this.imageList1.Images.Count;

                // 재고 값 표시
                this.Namelbl.Text = NameStr + " " + this.Cblist.Text;
                this.Namelbl3.Text = NameStr + " " + this.Cblist.Text;

                // 백신 상세설명
                this.Explbl.Text = ExpStr +
                    "\n\n백신 제품명 : mRNA - 1273" +
                    "\n백신 유형 : mRNA" +
                    "\n제조국 : 미국" +
                    "\n제조사 : 모더나" +
                    "\n예방효과 : 94.1%" +
                    "\n접종대상 : 18세 이상" +
                    "\n접종횟수 : 28일 간격으로 2회" +
                    "\n예정 물량 : 2000만명분";
                
                // 백신 재고
                this.Numlbl.Text = NumStr + " " + CompanyMoResult + " " + "개";

            }
            else if (Cblist.Text == "화이자")
            {

                this.pictureBox1.Image = (Image)this.imageList1.Images[1];
                ImgCount = this.imageList1.Images.Count;

                this.Namelbl.Text = NameStr + " " + this.Cblist.Text;
                this.Namelbl3.Text = NameStr + " " + this.Cblist.Text;

                this.Explbl.Text = ExpStr +
                    "\n\n백신 제품명 : BNT162" +
                    "\n백신 유형 : mRNA" +
                    "\n제조국 : 미국" +
                    "\n제조사 : 화이자, 바이오엔테크" +
                    "\n예방효과 : 95%" +
                    "\n접종대상 : 16세 이상" +
                    "\n접종횟수 : 21일 간격으로 2회" +
                    "\n예정 물량 : 3300만명분";

                // 백신 재고
                this.Numlbl.Text = NumStr + " " + CompanyHwaResult + " " + "개";
            }

            else if (Cblist.Text == "얀센")
            {

                this.pictureBox1.Image = (Image)this.imageList1.Images[2];
                ImgCount = this.imageList1.Images.Count;

                this.Namelbl.Text = NameStr + " " + this.Cblist.Text;
                this.Namelbl3.Text = NameStr + " " + this.Cblist.Text;

                this.Explbl.Text = ExpStr +
                    "\n\n백신 제품명 : Ad26.COV2-S" +
                    "\n백신 유형 : 비복제바이러스벡터" +
                    "\n제조국 : 미국, 벨기에" +
                    "\n제조사 : 존슨앤드존슨, 얀센" +
                    "\n예방효과 : 95%" +
                    "\n접종대상 : 16세 이상" +
                    "\n접종횟수 : 1회" +
                    "\n예정 물량 : 1800만명분";

                // 백신 재고
                this.Numlbl.Text = NumStr + " " + CompanyJanResult + " " + "개";

            }

            else if (Cblist.Text == "아스트라제네카")
            {
                this.pictureBox1.Image = (Image)this.imageList1.Images[3];
                ImgCount = this.imageList1.Images.Count;

                this.Namelbl.Text = NameStr + " " + this.Cblist.Text;
                this.Namelbl3.Text = NameStr + " " + this.Cblist.Text;

                this.Explbl.Text = ExpStr +
                    "\n\n백신 제품명 : AZD1222" +
                    "\n백신 유형 : 비복제바이러스벡터" +
                    "\n제조국 : 영국, 스웨덴" +
                    "\n제조사 : 아스트라제네카, 옥스퍼드 대학교" +
                    "\n예방효과 : 90.2%" +
                    "\n접종대상 : 18세 이상" +
                    "\n접종횟수 : 2회" +
                    "\n예정 물량 : 600만명분";

                // 백신 재고
                this.Numlbl.Text = NumStr + " " + CompanyAstResult + " " + "개";

            }
        }

        // 백신 재고 정보 출력
        private void cblist2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 입고 후 병원 백신 재고 결과 값

            if (cblist2.Text == "모더나")
            {

                this.pictureBox2.Image = (Image)this.imageList1.Images[0];
                ImgCount = this.imageList1.Images.Count;

                // 백신 재고
                this.Numlbl2.Text = NumStr + " " + HospitalMoResult + " " + "개";

            }

            else if (cblist2.Text == "화이자")
            {

                this.pictureBox2.Image = (Image)this.imageList1.Images[1];
                ImgCount = this.imageList1.Images.Count;

                // 백신 재고
                this.Numlbl2.Text = NumStr + " " + HospitalHwaResult + " " + "개";

            }

            else if (cblist2.Text == "얀센")
            {

                this.pictureBox2.Image = (Image)this.imageList1.Images[2];
                ImgCount = this.imageList1.Images.Count;

                // 백신 재고
                this.Numlbl2.Text = NumStr + " " + HospitalJanResult + " " + "개";

            }

            else if (cblist2.Text == "아스트라제네카")
            {

                this.pictureBox2.Image = (Image)this.imageList1.Images[3];
                ImgCount = this.imageList1.Images.Count;

                // 백신 재고
                this.Numlbl2.Text = NumStr + " " + HospitalAstResult + " " + "개";

            }

            if (this.cblist2.Text != "")

                this.Namelbl2.Text = NameStr2 + this.cblist2.Text;
        }

        // 주문 버튼
        private void Cinbtn_Click(object sender, EventArgs e)
        {

            if (TextCheck() == true)
            {

                // 출력할 정보 값
                strName = this.Cblist.Text;
                strNum = this.odertxt.Text;
                strDay = this.dateTimePicker1.Text;
                strEtc = this.etctxt.Text;
                strPhone = this.Phonetxt.Text;
                strAdr = this.Adrtxt.Text;

                this.Cblist.Text = "";
                this.odertxt.Text = "";
                this.dateTimePicker1.Text = "";

            }
            else return;
            ListViewItem lvi = new ListViewItem(new string[] { strName, strNum, strDay, strEtc, strPhone, strAdr });
            this.listView2.Items.Add(lvi);

            // 주문 텍스트 빈 문자 출력
            odertxt.Text = string.Empty;

        }

        // 텍스트 유무 확인
        private bool TextCheck()
        {
            if (this.Cblist.Text != "" && // 조건 AND
                this.odertxt.Text != "" && // 조건 AND
                this.dateTimePicker1.Text != "" | // or
                this.etctxt.Text != "")
            {
                return true;
            }
            else

                return false;
        }

        // 입고 버튼
        private void Addbtn2_Click(object sender, EventArgs e)
        {
            if (this.listView2.SelectedItems.Count == 1)
            {

                DialogResult call = MessageBox.Show("제품이 입고 되었습니까?", "알림",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                {
                    if (call == DialogResult.OK)
                    {

                        // 두 번째 칼럼 백신수량 문자를 문자열 a 값으로
                        String a = listView2.Items[listView2.FocusedItem.Index].SubItems[1].Text;

                        // 칼럼 0번째 아이템의 텍스트가 "모더나" 이면
                        if (listView2.Items[listView2.FocusedItem.Index].SubItems[0].Text == "모더나")
                        {
                            // 문자열 a 정수로 컨버트하고 정수 iMo 값에 넣고
                            iMo = Convert.ToInt32(a);

                            if (iMo > CompanyMoResult)
                            {
                                MessageBox.Show("모더나 백신 재고가 없습니다." + "\n", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                                listView2.Items.Clear();

                                return;
                            }
                            else
                            {
                                // 백신 재고 정수 연산
                                HospitalMoResult = HospitalMoResult + iMo;
                                CompanyMoResult = CompanyMoResult - iMo;
                            }
                        }
                        else if (listView2.Items[listView2.FocusedItem.Index].SubItems[0].Text == "화이자")
                        {
                            iHwa = Convert.ToInt32(a);

                            if (iHwa > CompanyHwaResult)
                            {
                                MessageBox.Show("화이자 백신 재고가 없습니다." + "\n", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                                listView2.Items.Clear();

                                return;
                            }
                            else
                            {
                                HospitalHwaResult = HospitalHwaResult + iHwa;
                                CompanyHwaResult = CompanyHwaResult - iHwa;
                            }
                        }
                        else if (listView2.Items[listView2.FocusedItem.Index].SubItems[0].Text == "얀센")
                        {
                            iJan = Convert.ToInt32(a);

                            if (iJan > CompanyJanResult)
                            {
                                MessageBox.Show("얀센 백신 재고가 없습니다." + "\n", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                                listView2.Items.Clear();

                                return;
                            }
                            else
                            {
                                HospitalJanResult = HospitalJanResult + iJan;
                                CompanyJanResult = CompanyJanResult - iJan;
                            }
                        }
                        else if (listView2.Items[listView2.FocusedItem.Index].SubItems[0].Text == "아스트라제네카")
                        {
                            iAst = Convert.ToInt32(a);

                            if (iAst > CompanyAstResult)
                            {
                                MessageBox.Show("아스트라제네카 백신 재고가 없습니다." + "\n", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                                listView2.Items.Clear();

                                return;
                            }
                            else
                            {
                                HospitalAstResult = HospitalAstResult + iAst;
                                CompanyAstResult = CompanyAstResult - iAst;
                            }
                        }

                        MessageBox.Show("입고완료" + "\n", "입고",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    // 리스트뷰 주문 목록 지우기
                    listView2.Items.Clear();
                }
            }
            else
            {
                // 리스트 뷰 아이템 선택X 알림
                if (this.listView2.SelectedItems.Count == 0)
                    MessageBox.Show("주문 목록을 선택하세요.", "알림",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 폐기 버튼
        private void Delbtn3_Click(object sender, EventArgs e)
        {
            if (this.Deltxt.Text != "")
            {
                DialogResult call = MessageBox.Show("백신을 폐기 하려면 확인을 눌러주세요.", "알림",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                {

                    if (call == DialogResult.OK)
                    {
                        if (cblist2.Text == "모더나")
                        {
                            iMo = Convert.ToInt32(Deltxt.Text);

                            if (iMo < HospitalMoResult + 1)
                            {
                                HospitalMoResult = HospitalMoResult - iMo;

                                MessageBox.Show("폐기 완료" + "\n", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("모더나 백신 폐기량 재고와 불일치", "알림",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (cblist2.Text == "화이자")
                        {
                            iHwa = Convert.ToInt32(Deltxt.Text);

                            if (iHwa < HospitalHwaResult + 1)
                            {
                                HospitalHwaResult = HospitalHwaResult - iHwa;

                                MessageBox.Show("폐기 완료" + "\n", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("화이자 백신 폐기량 재고와 불일치", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (cblist2.Text == "얀센")
                        {
                            iJan = Convert.ToInt32(Deltxt.Text);

                            if (iJan < HospitalHwaResult + 1)
                            {
                                HospitalJanResult = HospitalJanResult - iJan;

                                MessageBox.Show("폐기 완료" + "\n", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("얀센 백신 폐기량 재고와 불일치", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else if (cblist2.Text == "아스트라제네카")
                        {
                            iAst = Convert.ToInt32(Deltxt.Text);

                            if (iAst < HospitalAstResult + 1)
                            {
                                HospitalAstResult = HospitalAstResult - iAst;

                                MessageBox.Show("폐기 완료" + "\n", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("아스트라제네카 백신 폐기량 재고와 불일치", "알림",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        // 백신 사용 버튼
        private void Usingbtn_Click(object sender, EventArgs e)
        {

            if (this.Deltxt.Text != "")
            {
                DialogResult call = MessageBox.Show("백신을 사용 했습니까?", "알림",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                {
                    if (call == DialogResult.OK)
                    {
                        if (cblist2.Text == "모더나")
                        {
                            iMo = Convert.ToInt32(Deltxt.Text);

                            if (iMo < HospitalMoResult + 1) // 딜리트 값이 0부터 카운트 되어 재고값에 +1을 해서 숫자 맞춤
                            {
                                HospitalMoResult = HospitalMoResult - iMo;

                                MessageBox.Show("사용 완료" + "\n", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("모더나 백신 사용량 재고와 불일치", "알림",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (cblist2.Text == "화이자")
                        {
                            iHwa = Convert.ToInt32(Deltxt.Text);

                            if (iHwa < HospitalHwaResult)
                            {
                                HospitalHwaResult = HospitalHwaResult - iHwa;

                                MessageBox.Show("사용 완료" + "\n", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("화이자 백신 사용량 재고와 불일치", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else if (cblist2.Text == "얀센")
                        {
                            iJan = Convert.ToInt32(Deltxt.Text);

                            if (iJan < HospitalHwaResult + 1)
                            {
                                HospitalJanResult = HospitalJanResult - iJan;

                                MessageBox.Show("사용 완료" + "\n", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("얀센 백신 사용량 재고와 불일치", "알림",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (cblist2.Text == "아스트라제네카")
                        {
                            iAst = Convert.ToInt32(Deltxt.Text);

                            if (iAst < HospitalAstResult + 1)
                            {
                                HospitalAstResult = HospitalAstResult - iAst;
                                MessageBox.Show("사용 완료" + "\n", "알림",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                                MessageBox.Show("아스트라제네카 백신 사용량 재고와 불일치", "알림",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        // 리스트 뷰 주문 정보 출력

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            if (this.listView2.SelectedItems.Count == 0)

                MessageBox.Show("주문 목록을 선택하세요.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {

                MessageBox.Show("제품명 : " + this.listView2.SelectedItems[0].SubItems[0].Text + "\n"
                    + "\n수량 : " + this.listView2.SelectedItems[0].SubItems[1].Text + "\n"
                    + "\n주문일자 : " + this.listView2.SelectedItems[0].SubItems[2].Text + "\n"
                    + "\n주문사항 : " + this.listView2.SelectedItems[0].SubItems[3].Text + "\n"
                    + "\n연락처 : " + this.listView2.SelectedItems[0].SubItems[4].Text + "\n"
                    + "\n배송지 : " + this.listView2.SelectedItems[0].SubItems[5].Text + "\n", "주문 정보",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        // 주문 삭제 버튼 알림
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                if (listView2.SelectedItems.Count > 0)

                    if (MessageBox.Show("주문 목록을 삭제 하시겠습니까?", "알림",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        // 리스트뷰 환자 정보 인덱스 삭제
                        listView2.Items.Clear();

                        MessageBox.Show("주문목록 완료", "알림",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            else
            {
                MessageBox.Show("목록을 선택해주세요.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // 백신 추가 버튼 알림
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (this.Addtxt.Text != "")
            {

                this.Cblist.Items.Add(this.Addtxt.Text);
                this.cblist2.Items.Add(this.Addtxt.Text);
                MessageBox.Show("백신을 추가하였습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                this.Addtxt.Focus();
            this.Addtxt.Text = "";
        }

        // 백신 주문 콤보 삭제 알림
        private void Delbtn_Click(object sender, EventArgs e)
        {
            if (Cblist.SelectedIndex > -1)
            {

                Cblist.Items.RemoveAt(Cblist.SelectedIndex);
                MessageBox.Show("제품을 삭제하였습니다..", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        // 백신 재고 콤보 삭제 알림
        private void delbtn2_Click(object sender, EventArgs e)
        {
            if (cblist2.SelectedIndex > -1)
            {
                cblist2.Items.RemoveAt(cblist2.SelectedIndex);
                MessageBox.Show("제품을 삭제하였습니다..", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void roombtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Room Main = new Room();
            Main.Show();

        }

        // 긴급호출 버튼
        private void callbtn_Click(object sender, EventArgs e)
        {

            Call Main = new Call();
            Main.Show();

        }

        // 주문 업로드 버튼
        private void button2_Click(object sender, EventArgs e)
        {

            Loading Loading = new Loading();
            Loading.Show();

        }

        // 백신 추가 엔터
        private void Addtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Addbtn_Click(sender, e);
            }
        }

        // 주문 엔터
        private void odertxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cinbtn_Click(sender, e);
            }
        }

        // 비고 엔터
        private void etctxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Cinbtn_Click(sender, e);
            }
        }

        // 리스트 뷰 엔터
        private void listView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Addbtn2_Click(sender, e);
            }
        }

        // 종료 버튼
        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
