﻿namespace AutoTradDH
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.loginButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.logoutBt = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NAMElb = new System.Windows.Forms.Label();
            this.IDlb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemCodeText = new System.Windows.Forms.TextBox();
            this.ItemSerchbt = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.list_realtime = new System.Windows.Forms.ListBox();
            this.dailybt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(12, 12);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI1.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(37, 68);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "로그인";
            this.loginButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(679, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(230, 148);
            this.listBox1.TabIndex = 2;
            // 
            // logoutBt
            // 
            this.logoutBt.Location = new System.Drawing.Point(37, 98);
            this.logoutBt.Name = "logoutBt";
            this.logoutBt.Size = new System.Drawing.Size(75, 23);
            this.logoutBt.TabIndex = 3;
            this.logoutBt.Text = "로그아웃";
            this.logoutBt.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(407, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // NAMElb
            // 
            this.NAMElb.AutoSize = true;
            this.NAMElb.Location = new System.Drawing.Point(691, 40);
            this.NAMElb.Name = "NAMElb";
            this.NAMElb.Size = new System.Drawing.Size(29, 12);
            this.NAMElb.TabIndex = 5;
            this.NAMElb.Text = "이름";
            // 
            // IDlb
            // 
            this.IDlb.AutoSize = true;
            this.IDlb.Location = new System.Drawing.Point(800, 40);
            this.IDlb.Name = "IDlb";
            this.IDlb.Size = new System.Drawing.Size(41, 12);
            this.IDlb.TabIndex = 6;
            this.IDlb.Text = "아이디";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(917, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "종목코드";
            // 
            // itemCodeText
            // 
            this.itemCodeText.Location = new System.Drawing.Point(972, 37);
            this.itemCodeText.Name = "itemCodeText";
            this.itemCodeText.Size = new System.Drawing.Size(100, 21);
            this.itemCodeText.TabIndex = 8;
            // 
            // ItemSerchbt
            // 
            this.ItemSerchbt.Location = new System.Drawing.Point(1078, 35);
            this.ItemSerchbt.Name = "ItemSerchbt";
            this.ItemSerchbt.Size = new System.Drawing.Size(75, 23);
            this.ItemSerchbt.TabIndex = 9;
            this.ItemSerchbt.Text = "조회";
            this.ItemSerchbt.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(919, 59);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(234, 400);
            this.listBox2.TabIndex = 10;
            // 
            // list_realtime
            // 
            this.list_realtime.FormattingEnabled = true;
            this.list_realtime.ItemHeight = 12;
            this.list_realtime.Location = new System.Drawing.Point(679, 239);
            this.list_realtime.Name = "list_realtime";
            this.list_realtime.Size = new System.Drawing.Size(229, 280);
            this.list_realtime.TabIndex = 11;
            // 
            // dailybt
            // 
            this.dailybt.Location = new System.Drawing.Point(26, 288);
            this.dailybt.Name = "dailybt";
            this.dailybt.Size = new System.Drawing.Size(85, 28);
            this.dailybt.TabIndex = 12;
            this.dailybt.Text = "일봉조회";
            this.dailybt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "기준일자(ex 20180709)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 263);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 21);
            this.textBox1.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 322);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "연속조회";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(407, 59);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(266, 448);
            this.listBox3.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "계좌번호";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 582);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dailybt);
            this.Controls.Add(this.list_realtime);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.ItemSerchbt);
            this.Controls.Add(this.itemCodeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDlb);
            this.Controls.Add(this.NAMElb);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.logoutBt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button logoutBt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label NAMElb;
        private System.Windows.Forms.Label IDlb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemCodeText;
        private System.Windows.Forms.Button ItemSerchbt;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox list_realtime;
        private System.Windows.Forms.Button dailybt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label3;
    }
}

