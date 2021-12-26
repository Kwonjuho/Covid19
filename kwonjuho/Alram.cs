using Microsoft.VisualBasic;
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
    public partial class Alram : Form
    {
        public Alram()
        {
            InitializeComponent();
        }

        private void Alram_Load(object sender, EventArgs e)
        {

        }

        // 타이머 버튼
        int Count = 0; // 초기 카운트

        // 타이머 버튼
        private void Timerbtn_Click(object sender, EventArgs e)
        {
            if (IntCheck() == true)
            {
                Count = Convert.ToInt32(this.timertxt.Text);
                this.timertxt.ReadOnly = true;
                this.timer.Enabled = true;
            }
        }

        // 타이머 엔터
        private void timertxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Timerbtn_Click(sender, e);
            }
        }

        // 초 입력 유무
        private bool IntCheck()
        {
            if (Information.IsNumeric(this.timertxt.Text))
                return true;
            else
            {
                MessageBox.Show("숫자를 입력하세요.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // 타이머 알림
        private void timer_Tick(object sender, EventArgs e)
        {
            if (Count < 1)
            {
                this.timer.Enabled = false;
                this.timertxt.ReadOnly = false;
                this.timertxt.Text = "";
                MessageBox.Show("알람 시간", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Count--;
                this.txtCountDown.Text = Convert.ToString(Count);
            }
        }

        // 타이머 취소
        private void Canbtn_Click(object sender, EventArgs e)
        {
            timer.Stop();

            this.timertxt.ReadOnly = false;
            this.txtCountDown.Text = Convert.ToString(Count = 0);
            timertxt.Text = "";
        }
    }
}
