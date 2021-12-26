
namespace kwonjuho
{
    partial class Loading
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
            this.upbar = new System.Windows.Forms.ProgressBar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblup = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.ccbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upbar
            // 
            this.upbar.Location = new System.Drawing.Point(26, 124);
            this.upbar.Name = "upbar";
            this.upbar.Size = new System.Drawing.Size(378, 27);
            this.upbar.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(378, 106);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // timer
            // 
            this.timer.Interval = 50;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblup
            // 
            this.lblup.AutoSize = true;
            this.lblup.BackColor = System.Drawing.Color.White;
            this.lblup.Location = new System.Drawing.Point(24, 159);
            this.lblup.Name = "lblup";
            this.lblup.Size = new System.Drawing.Size(49, 12);
            this.lblup.TabIndex = 2;
            this.lblup.Text = "진행률 :";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl1.Location = new System.Drawing.Point(34, 22);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(161, 12);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "서버에 업로드를 진행합니다.";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl2.Location = new System.Drawing.Point(35, 43);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(36, 12);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Text2";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl3.Location = new System.Drawing.Point(35, 64);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(36, 12);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Text3";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl4.Location = new System.Drawing.Point(24, 181);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(36, 12);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "Text4";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ccbtn
            // 
            this.ccbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ccbtn.Location = new System.Drawing.Point(314, 159);
            this.ccbtn.Name = "ccbtn";
            this.ccbtn.Size = new System.Drawing.Size(90, 34);
            this.ccbtn.TabIndex = 7;
            this.ccbtn.Text = "업로드 취소";
            this.ccbtn.UseVisualStyleBackColor = true;
            this.ccbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 212);
            this.Controls.Add(this.ccbtn);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblup);
            this.Controls.Add(this.upbar);
            this.Controls.Add(this.listView1);
            this.Name = "Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "정보를 업로드 합니다.";
            this.Load += new System.EventHandler(this.Loading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar upbar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblup;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Button ccbtn;
    }
}