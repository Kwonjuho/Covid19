using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kwonjuho
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        // 로그인 버튼
        private void logbtn_Click(object sender, EventArgs e)
        {
            // 데이터베이스 연결 경로
            SqlConnection con = new SqlConnection
                (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
                C:\Users\ffpp1\Desktop\Covid\kwonjuho\data\Login\data.mdf;Integrated Security=True;Connect Timeout=30");

            // 데이터베이스 내용 == sda
            SqlDataAdapter sda = new SqlDataAdapter
                ("Select Count(*) from USERINFO where id='"+Idtxt.Text+"' and pw='"+Pwtxt.Text+"'" ,con);

            // USERINFO 값을 newTable
            DataTable newTable = new DataTable();

            // sda 내용을 neTable에 채움
            sda.Fill(newTable);

            // 데이터 베이스의 열 값이 맞으면 성공
            if (newTable.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main Main = new Main();
                Main.Show();

                Schedule Main2 = new Schedule();
                Main2.Show();
            }
            // 로그인 실패
            else
            {
                MessageBox.Show("아이디와 비밀번호를 입력해주세요.", "로그인 실패",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // pw 엔터 실행
        private void pwtxt_KeyDown(object sender, KeyEventArgs e)
        {
            // 엔터 == 로그인
            if (e.KeyCode == Keys.Enter)
            {
                logbtn_Click(sender, e);
            }
        }

        // id 엔터 실행
        private void idtxt_KeyDown(object sender, KeyEventArgs e)
        {
            // 엔터 == 로그인
            if (e.KeyCode == Keys.Enter)
            {
                logbtn_Click(sender, e);
            }
        }

        // 로고 클릭 == 홈페이지
        private void Logoimage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.hanhsp.co.kr/");
        }
    }
}
