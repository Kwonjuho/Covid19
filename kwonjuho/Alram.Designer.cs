
namespace kwonjuho
{
    partial class Alram
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Canbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountDown = new System.Windows.Forms.TextBox();
            this.timertxt = new System.Windows.Forms.TextBox();
            this.Timerbtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Canbtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCountDown);
            this.groupBox1.Controls.Add(this.timertxt);
            this.groupBox1.Controls.Add(this.Timerbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 85);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "초 단위";
            // 
            // Canbtn
            // 
            this.Canbtn.Location = new System.Drawing.Point(263, 22);
            this.Canbtn.Name = "Canbtn";
            this.Canbtn.Size = new System.Drawing.Size(60, 45);
            this.Canbtn.TabIndex = 34;
            this.Canbtn.Text = "취소";
            this.Canbtn.UseVisualStyleBackColor = true;
            this.Canbtn.Click += new System.EventHandler(this.Canbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 33;
            this.label3.Text = "초 입력 :";
            // 
            // txtCountDown
            // 
            this.txtCountDown.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCountDown.Location = new System.Drawing.Point(86, 48);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.ReadOnly = true;
            this.txtCountDown.Size = new System.Drawing.Size(107, 21);
            this.txtCountDown.TabIndex = 31;
            // 
            // timertxt
            // 
            this.timertxt.Location = new System.Drawing.Point(85, 20);
            this.timertxt.Name = "timertxt";
            this.timertxt.Size = new System.Drawing.Size(108, 21);
            this.timertxt.TabIndex = 30;
            this.timertxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timertxt_KeyDown);
            // 
            // Timerbtn
            // 
            this.Timerbtn.Location = new System.Drawing.Point(199, 20);
            this.Timerbtn.Name = "Timerbtn";
            this.Timerbtn.Size = new System.Drawing.Size(60, 49);
            this.Timerbtn.TabIndex = 29;
            this.Timerbtn.Text = "시작";
            this.Timerbtn.UseVisualStyleBackColor = true;
            this.Timerbtn.Click += new System.EventHandler(this.Timerbtn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Alram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 107);
            this.Controls.Add(this.groupBox1);
            this.Name = "Alram";
            this.Text = "알람";
            this.Load += new System.EventHandler(this.Alram_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCountDown;
        private System.Windows.Forms.TextBox timertxt;
        private System.Windows.Forms.Button Timerbtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button Canbtn;
    }
}