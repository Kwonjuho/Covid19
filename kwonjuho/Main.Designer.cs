
namespace kwonjuho
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.exitbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Roombtn = new System.Windows.Forms.Button();
            this.Oderbtn = new System.Windows.Forms.Button();
            this.Logoimage = new System.Windows.Forms.PictureBox();
            this.Callbtn = new System.Windows.Forms.Button();
            this.Mainimage = new System.Windows.Forms.PictureBox();
            this.Tttableimage = new System.Windows.Forms.PictureBox();
            this.Imgnextbtn = new System.Windows.Forms.CheckBox();
            this.MainimgList = new System.Windows.Forms.ImageList(this.components);
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Schedulebtn = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Albtn = new System.Windows.Forms.Button();
            this.timelbl = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Logoimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tttableimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbtn
            // 
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.Location = new System.Drawing.Point(1167, 704);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 36);
            this.exitbtn.TabIndex = 19;
            this.exitbtn.Text = "종료";
            this.exitbtn.UseVisualStyleBackColor = true;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 725);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "종합검진 예약 : (043)222-7800";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 704);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "진료예약 : (043)227-7000";
            // 
            // Roombtn
            // 
            this.Roombtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Roombtn.Location = new System.Drawing.Point(838, 504);
            this.Roombtn.Name = "Roombtn";
            this.Roombtn.Size = new System.Drawing.Size(117, 117);
            this.Roombtn.TabIndex = 16;
            this.Roombtn.Text = "입 / 퇴실 관리";
            this.Roombtn.UseVisualStyleBackColor = true;
            this.Roombtn.Click += new System.EventHandler(this.roombtn_Click);
            // 
            // Oderbtn
            // 
            this.Oderbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Oderbtn.Location = new System.Drawing.Point(715, 505);
            this.Oderbtn.Name = "Oderbtn";
            this.Oderbtn.Size = new System.Drawing.Size(117, 117);
            this.Oderbtn.TabIndex = 15;
            this.Oderbtn.Text = "백신 재고 / 주문";
            this.Oderbtn.UseVisualStyleBackColor = true;
            this.Oderbtn.Click += new System.EventHandler(this.oderbtn_Click);
            // 
            // Logoimage
            // 
            this.Logoimage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logoimage.Image = ((System.Drawing.Image)(resources.GetObject("Logoimage.Image")));
            this.Logoimage.Location = new System.Drawing.Point(1001, 12);
            this.Logoimage.Name = "Logoimage";
            this.Logoimage.Size = new System.Drawing.Size(251, 85);
            this.Logoimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logoimage.TabIndex = 20;
            this.Logoimage.TabStop = false;
            this.Logoimage.Click += new System.EventHandler(this.Logoimage_Click);
            // 
            // Callbtn
            // 
            this.Callbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Callbtn.Location = new System.Drawing.Point(961, 505);
            this.Callbtn.Name = "Callbtn";
            this.Callbtn.Size = new System.Drawing.Size(117, 117);
            this.Callbtn.TabIndex = 21;
            this.Callbtn.Text = "긴급 호출";
            this.Callbtn.UseVisualStyleBackColor = true;
            this.Callbtn.Click += new System.EventHandler(this.callbtn_Click);
            // 
            // Mainimage
            // 
            this.Mainimage.Image = ((System.Drawing.Image)(resources.GetObject("Mainimage.Image")));
            this.Mainimage.Location = new System.Drawing.Point(0, 113);
            this.Mainimage.Name = "Mainimage";
            this.Mainimage.Size = new System.Drawing.Size(1264, 238);
            this.Mainimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Mainimage.TabIndex = 23;
            this.Mainimage.TabStop = false;
            // 
            // Tttableimage
            // 
            this.Tttableimage.Location = new System.Drawing.Point(453, 381);
            this.Tttableimage.Name = "Tttableimage";
            this.Tttableimage.Size = new System.Drawing.Size(256, 241);
            this.Tttableimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Tttableimage.TabIndex = 22;
            this.Tttableimage.TabStop = false;
            // 
            // Imgnextbtn
            // 
            this.Imgnextbtn.AutoSize = true;
            this.Imgnextbtn.BackColor = System.Drawing.Color.White;
            this.Imgnextbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Imgnextbtn.Location = new System.Drawing.Point(694, 628);
            this.Imgnextbtn.Name = "Imgnextbtn";
            this.Imgnextbtn.Size = new System.Drawing.Size(15, 14);
            this.Imgnextbtn.TabIndex = 24;
            this.Imgnextbtn.UseVisualStyleBackColor = false;
            this.Imgnextbtn.CheckedChanged += new System.EventHandler(this.Imgnextbtn_CheckedChanged);
            // 
            // MainimgList
            // 
            this.MainimgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MainimgList.ImageStream")));
            this.MainimgList.TransparentColor = System.Drawing.Color.Transparent;
            this.MainimgList.Images.SetKeyName(0, "1.png");
            this.MainimgList.Images.SetKeyName(1, "2.png");
            this.MainimgList.Images.SetKeyName(2, "3.png");
            this.MainimgList.Images.SetKeyName(3, "4.png");
            this.MainimgList.Images.SetKeyName(4, "5.png");
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(191, 381);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(256, 241);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBox1.TabIndex = 25;
            this.PictureBox1.TabStop = false;
            // 
            // Schedulebtn
            // 
            this.Schedulebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Schedulebtn.Location = new System.Drawing.Point(715, 381);
            this.Schedulebtn.Name = "Schedulebtn";
            this.Schedulebtn.Size = new System.Drawing.Size(117, 117);
            this.Schedulebtn.TabIndex = 26;
            this.Schedulebtn.Text = "예방접종\r\n \n사전안내";
            this.Schedulebtn.UseVisualStyleBackColor = true;
            this.Schedulebtn.Click += new System.EventHandler(this.Schedulebtn_Click);
            // 
            // Button1
            // 
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.Location = new System.Drawing.Point(961, 382);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(117, 117);
            this.Button1.TabIndex = 27;
            this.Button1.Text = "질병관리청\r\n\r\n홈페이지";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button2
            // 
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.Location = new System.Drawing.Point(838, 381);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(117, 117);
            this.Button2.TabIndex = 28;
            this.Button2.Text = "코로나\r\n\r\n라이브";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Albtn
            // 
            this.Albtn.Location = new System.Drawing.Point(12, 41);
            this.Albtn.Name = "Albtn";
            this.Albtn.Size = new System.Drawing.Size(66, 37);
            this.Albtn.TabIndex = 33;
            this.Albtn.Text = "알람";
            this.Albtn.UseVisualStyleBackColor = true;
            this.Albtn.Click += new System.EventHandler(this.Albtn_Click);
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Location = new System.Drawing.Point(13, 12);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(65, 12);
            this.timelbl.TabIndex = 37;
            this.timelbl.Text = "현재 시간 :";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.Albtn);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Schedulebtn);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.Imgnextbtn);
            this.Controls.Add(this.Tttableimage);
            this.Controls.Add(this.Callbtn);
            this.Controls.Add(this.Logoimage);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Roombtn);
            this.Controls.Add(this.Oderbtn);
            this.Controls.Add(this.Mainimage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covid-19 전산 프로그램";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logoimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mainimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tttableimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Roombtn;
        private System.Windows.Forms.Button Oderbtn;
        private System.Windows.Forms.PictureBox Logoimage;
        private System.Windows.Forms.Button Callbtn;
        private System.Windows.Forms.PictureBox Mainimage;
        private System.Windows.Forms.PictureBox Tttableimage;
        private System.Windows.Forms.CheckBox Imgnextbtn;
        private System.Windows.Forms.ImageList MainimgList;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button Schedulebtn;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Albtn;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Timer timer;
    }
}