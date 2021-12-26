
namespace kwonjuho
{
    partial class Login
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Logoimage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Logbtn = new System.Windows.Forms.Button();
            this.Pwtxt = new System.Windows.Forms.TextBox();
            this.Idtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logoimage)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "종합검진 예약 : (043)222-7800";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "진료예약 : (043)227-7000";
            // 
            // Logoimage
            // 
            this.Logoimage.Image = ((System.Drawing.Image)(resources.GetObject("Logoimage.Image")));
            this.Logoimage.Location = new System.Drawing.Point(12, 12);
            this.Logoimage.Name = "Logoimage";
            this.Logoimage.Size = new System.Drawing.Size(347, 107);
            this.Logoimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logoimage.TabIndex = 26;
            this.Logoimage.TabStop = false;
            this.Logoimage.Click += new System.EventHandler(this.Logoimage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 12);
            this.label4.TabIndex = 25;
            this.label4.Text = "PW:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "ID :";
            // 
            // Logbtn
            // 
            this.Logbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Logbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logbtn.Location = new System.Drawing.Point(230, 146);
            this.Logbtn.Name = "Logbtn";
            this.Logbtn.Size = new System.Drawing.Size(87, 55);
            this.Logbtn.TabIndex = 23;
            this.Logbtn.Text = "로그인";
            this.Logbtn.UseVisualStyleBackColor = true;
            this.Logbtn.Click += new System.EventHandler(this.logbtn_Click);
            // 
            // Pwtxt
            // 
            this.Pwtxt.Location = new System.Drawing.Point(79, 180);
            this.Pwtxt.Multiline = true;
            this.Pwtxt.Name = "Pwtxt";
            this.Pwtxt.PasswordChar = '*';
            this.Pwtxt.Size = new System.Drawing.Size(145, 21);
            this.Pwtxt.TabIndex = 22;
            this.Pwtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pwtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwtxt_KeyDown);
            // 
            // Idtxt
            // 
            this.Idtxt.BackColor = System.Drawing.SystemColors.Window;
            this.Idtxt.Location = new System.Drawing.Point(79, 146);
            this.Idtxt.Name = "Idtxt";
            this.Idtxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Idtxt.Size = new System.Drawing.Size(145, 21);
            this.Idtxt.TabIndex = 21;
            this.Idtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Idtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.idtxt_KeyDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logoimage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Logbtn);
            this.Controls.Add(this.Pwtxt);
            this.Controls.Add(this.Idtxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logoimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Logoimage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Logbtn;
        private System.Windows.Forms.TextBox Pwtxt;
        private System.Windows.Forms.TextBox Idtxt;
    }
}

